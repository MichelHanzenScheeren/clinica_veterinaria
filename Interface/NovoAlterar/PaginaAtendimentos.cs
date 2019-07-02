using Interface.Controle;
using Modelo;
using Modelo.Cadastros;
using Modelo.Excessoes;
using Modelo.Servicos;
using Servico.Geral;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Interface
{
    public partial class PaginaAtendimentos : Form
    {
        private Atendimento _atendimento;
        private Conta _conta;

        private AgendamentoServico _agendamentoServico;
        private CadastroServico _cadastroServico;
        private AnimalServico _animalServico;
        private AtendimentoServico _atendimentoServico;
        private ContaServico _contaServico;


        public PaginaAtendimentos()
        {
            InitializeComponent();
            ConfigIniciais();
            AtualizarVeterinarios();
        }

        public PaginaAtendimentos(Atendimento atendimento) : this()
        {
            _atendimento = atendimento;
            AtualizarInformacoes();
        }

        public PaginaAtendimentos(long animalID) : this()
        {
            cbPaciente.Text = _animalServico.Buscar(x => x.AnimalID == animalID, "Cadastro").FirstOrDefault().ToString();
        }

        private void ConfigIniciais()
        {
            _animalServico = new AnimalServico();
            _cadastroServico = new CadastroServico();
            _atendimentoServico = new AtendimentoServico();
            CenterToScreen();
            dtVencimento.Text = DateTime.Now.AddDays(30).ToShortDateString();
            dtHora.Text = DateTime.Now.ToShortTimeString();
        }

        private void BtnAdicionarAnimal_Click_1(object sender, EventArgs e)
        {
            cbPaciente.Items.Clear();
            int cont = 0;
            try
            {
                foreach (var item in _animalServico.Buscar(x => x.AnimalID == Convert.ToInt64(cbPaciente.Text), "Cadastro"))
                {
                    cbPaciente.Items.Add(item.ToString());
                    cont++;
                }
            }
            catch (Exception)
            {
                foreach (var item in _animalServico.Buscar(x => x.Nome.Contains(cbPaciente.Text) || x.Especie.Contains(cbPaciente.Text) || x.Raca.Contains(cbPaciente.Text), "Cadastro"))
                {
                    cbPaciente.Items.Add(item.ToString());
                    cont++;
                }
            }
            if (cont == 0)
                cbPaciente.Items.Add("NENHUMA CORRESPONDÊNCIA ENCONTRADA...!");
            cbPaciente.DroppedDown = true;
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                VerificarPreenchimento();
                AtualizarStatusAgendamento();
                if(_atendimento != null)
                {
                    if (MessageBox.Show("TEM CERTEZA QUE DESEJA FAZER ALTERAÇÕES NESSE REGISTRO?\n\nOBS:\nESSA AÇÃO NÃO PODE SER DESFEITA!", "ATENÇÃO!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                        EditarAtendimento();
                }
                else
                {
                    long contaID = CadastrarConta();
                    CadastrarAtendimento(contaID);
                }
            }
            catch (NaoPreenchidoException erro)
            {
                MessageBox.Show($"ERRO NO CADASTRO!\n {erro.Message}", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show($"ERRO NO CADASTRO!\nO PACIENTE E/OU PREÇO INSERIDOS NÃO SÂO VÁLIDOS!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void VerificarPreenchimento()
        {
            ValidarPreenchimento.Validacao(errorProvider1, cbPaciente, cbTipo, cbVeterinarios, cbClassificacao, txtPreco, cbMetodoPagamento, txtResumo, txtConclusao);
        }

        private void AtualizarStatusAgendamento()
        {
            if(cbAgendamento.Text != "")
            {
                try
                {
                    long id = Convert.ToInt64(cbAgendamento.Text.Split(' ')[0]);
                    _agendamentoServico = new AgendamentoServico();
                    Agendamento agendamento = _agendamentoServico.Buscar(x => x.AgendamentoID == id).FirstOrDefault();
                    agendamento.Status = "Concluído";
                    _agendamentoServico.Editar(agendamento);
                }
                catch (Exception)
                {
                }
            }
        }

        private long CadastrarConta()
        {
            Animal animal = _animalServico.Buscar(x => x.AnimalID == Convert.ToInt64(cbPaciente.Text.Split(' ')[0]), "Cadastro").FirstOrDefault();
            if (animal != null)
            {
                int parcelas = 1;
                if (cbMetodoPagamento.Text.Contains("A Prazo"))
                    parcelas = Convert.ToInt32(numParcelas.Value);
                Conta conta = new Conta("Entrada", cbTipo.Text, Convert.ToDateTime(dtVencimento.Text), Convert.ToDouble(txtPreco.Text), cbMetodoPagamento.Text,parcelas, animal.Cadastro.ID);
                _contaServico = new ContaServico();
                _contaServico.Salvar(conta);
                return _contaServico.Ultimo();
            }
            else
                throw new Exception();
        }

        private void CadastrarAtendimento(long contaID)
        {
            Atendimento atendimento = new Atendimento(ArrumarDataHora(), cbTipo.Text, txtResumo.Text, cbClassificacao.Text, txtConclusao.Text, Convert.ToInt64(cbVeterinarios.Text.Split(' ')[0]), Convert.ToInt64(cbPaciente.Text.Split(' ')[0]), contaID);
            _atendimentoServico.Salvar(atendimento);
            MessageBox.Show("REGISTRO CONCLUÍDO!", "INFORNAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.None);
            this.Close();
        }

        private DateTime ArrumarDataHora()
        {
            string auxiliar = dtData.Text + " " + dtHora.Text;
            DateTime data = DateTime.Parse(auxiliar);
            return data;
        }

        private void BtnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CbMetodoPagamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMetodoPagamento.Text.Contains("A Prazo"))
            {
                lblParcelas.Visible = numParcelas.Visible = true;
                lblParcelas.Enabled = numParcelas.Enabled = true;
            }
            else
            {
                lblParcelas.Visible = numParcelas.Visible = false;
                lblParcelas.Enabled = numParcelas.Enabled = false;
            }
        }

        private void CbTipo_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            AtualizarCbAgendamentos();
            AtualizarClassificacao();
        }

        private void AtualizarCbAgendamentos()
        {
            cbAgendamento.Enabled = true;
            cbAgendamento.Items.Clear();
            _agendamentoServico = new AgendamentoServico();
            foreach (var item in _agendamentoServico.Buscar(x => x.DataAtendimento.Date == DateTime.Today.Date && x.Tipo == cbTipo.Text))
            {
                cbAgendamento.Items.Add(item.AgendamentoID + " - " + item.DataAtendimento.ToShortDateString() + " " + item.DataAtendimento.ToShortTimeString() + ". " + item.Animal.Nome);
            }
        }

        private void AtualizarClassificacao()
        {
            cbClassificacao.Items.Clear();
            if (cbTipo.Text == "Consulta")
            {
                cbClassificacao.Items.Add("Rotina");
                cbClassificacao.Items.Add("Geral");
                cbClassificacao.Items.Add("Avaliação Cirúrgica");
                cbClassificacao.Items.Add("Retorno");
                cbClassificacao.Items.Add("Emmergência");
            }
            else if (cbTipo.Text == "Exame")
            {
                ExameServico _exameServico = new ExameServico();
                foreach (var item in _exameServico.ObterTodos())
                {
                    cbClassificacao.Items.Add(item.ToString());
                }
                
            }
            else if(cbTipo.Text == "Vacina")
            {
                VacinaServico _vacinaServico = new VacinaServico();
                foreach (var item in _vacinaServico.ObterTodos())
                {
                    cbClassificacao.Items.Add(item.ToString());
                }
            }
            else
            {
                CirurgiaServico _cirurgiaServico = new CirurgiaServico();
                foreach (var item in _cirurgiaServico.ObterTodos())
                {
                    cbClassificacao.Items.Add(item.ToString());
                }
            }
        }

        private void CbAgendamento_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            _agendamentoServico = new AgendamentoServico();
            Agendamento agendamento = _agendamentoServico.Buscar(x => x.AgendamentoID == Convert.ToInt64(cbAgendamento.Text.Split(' ')[0])).FirstOrDefault();
            if (agendamento != null)
            {
                cbPaciente.Text = agendamento.Animal.AnimalID + " - " + agendamento.Animal.Nome + ". " + agendamento.Animal.Raca;
                dtHora.Text = agendamento.DataAtendimento.ToShortTimeString();
                txtResumo.Text = agendamento.Resumo;
            }
        }

        private void AtualizarVeterinarios()
        {
            _cadastroServico = new CadastroServico();
            foreach (var item in _cadastroServico.Buscar(x => x.Discriminator == "Veterinario", "Endereco"))
            {
                Veterinario aux = (Veterinario)item;
                cbVeterinarios.Items.Add(item.ToString() + " - Crmv: " + aux.Crmv);
            }
        }

        private void CbClassificacao_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbTipo.Text == "Exame")
                {
                    ExameServico _exameServico = new ExameServico();
                    Exame exame = _exameServico.Buscar(x => x.ExameID == Convert.ToInt64(cbClassificacao.Text.Split(' ')[0])).FirstOrDefault();
                    txtPreco.Text = Convert.ToString(exame.Preco);
                }
                else if (cbTipo.Text == "Vacina")
                {
                    VacinaServico _vacinaServico = new VacinaServico();
                    Vacina vacina = _vacinaServico.Buscar(x => x.VacinaID == Convert.ToInt64(cbClassificacao.Text.Split(' ')[0])).FirstOrDefault();
                    txtPreco.Text = Convert.ToString(vacina.Preco);
                }
                else if (cbTipo.Text == "Consulta")
                {
                    txtPreco.Text = "";
                }
                else
                {
                    CirurgiaServico _cirurgiaServico = new CirurgiaServico();
                    Cirurgia cirurgia = _cirurgiaServico.Buscar(x => x.CirurgiaID == Convert.ToInt64(cbClassificacao.Text.Split(' ')[0])).FirstOrDefault();
                    txtPreco.Text = Convert.ToString(cirurgia.Preco);
                }
            }
            catch (Exception)
            { }
        }

        private void TxtPreco_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (!char.IsControl(e.KeyChar)) && (e.KeyChar != '.') && (e.KeyChar != ','))
                e.Handled = true;
            if (e.KeyChar == ',')
                e.KeyChar = '.';
            if (txtPreco.Text.Contains(".") && ((e.KeyChar == '.') || (e.KeyChar == ',')))
                e.Handled = true;
            if(txtPreco.Text.Length == 0 && e.KeyChar == '.')
                e.Handled = true;
        }

        //////////////////////////////// ATUALIZAR CONSULTA ///////////////////////////////////////////

        private void AtualizarInformacoes()
        {
            lblID.Enabled = true;
            lblID.Visible = true;
            txtID.Visible = true;
            btnSalvar.Text = "SALVAR ALTERAÇÕES";
            btnCancelar.Text = "CANCELAR";
            txtID.Text = Convert.ToString(_atendimento.AtendimentoID);
            cbTipo.SelectedItem = _atendimento.Tipo;
            dtData.Text = _atendimento.Data.ToLongDateString();
            dtHora.Text = _atendimento.Data.ToShortTimeString();
            cbPaciente.Text = _atendimento.Animal.ToString();
            cbVeterinarios.SelectedItem = _atendimento.Veterinario.ToString() +" - Crmv: " + _atendimento.Veterinario.Crmv;
            txtResumo.Text = _atendimento.Resumo;
            txtConclusao.Text = _atendimento.Conclusoes;
            cbClassificacao.SelectedItem = _atendimento.ClassificacaoAtendimento;
            cbAgendamento.Enabled = false;
            AtualizarInfoConta();
        }

        private void AtualizarInfoConta()
        {
            _contaServico = new ContaServico();
            _conta = _contaServico.Buscar(x => x.ContaID == _atendimento.ContaID).FirstOrDefault();
            txtPreco.Text = Convert.ToString(_conta.Total);
            cbMetodoPagamento.SelectedItem = _conta.MetodoPagamento;
            dtVencimento.Text = _conta.Data_Vencimento.ToShortDateString();
            numParcelas.Value = _conta.Parcelas;
            txtPreco.Enabled = cbMetodoPagamento.Enabled = dtVencimento.Enabled = numParcelas.Enabled = false;
            lblAviso.Visible = true;
        }

        private void EditarAtendimento()
        {
            try
            {
                if (_atendimento.AnimalID != Convert.ToInt64(cbPaciente.Text.Split(' ')[0]) || cbTipo.Text != _atendimento.ClassificacaoAtendimento)
                    EditarConta();
                _atendimento.Data = ArrumarDataHora();
                _atendimento.Tipo = cbTipo.Text;
                _atendimento.AnimalID = Convert.ToInt64(cbPaciente.Text.Split(' ')[0]);
                _atendimento.VeterinarioID = Convert.ToInt64(cbVeterinarios.Text.Split(' ')[0]);
                _atendimento.Resumo = txtResumo.Text;
                _atendimento.Conclusoes = txtConclusao.Text;
                _atendimento.ClassificacaoAtendimento = cbClassificacao.Text;
                _atendimentoServico.Editar(_atendimento);
                MessageBox.Show("TODAS AS ALTERAÇÕES FORAM SALVAS!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.None);
                Close();
            }
            catch (Exception)
            {
                MessageBox.Show("O PACIENTE E/OU VETERINÁRIO INSERIDOS SÃO INVÁLIDOS!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void EditarConta()
        {
            _contaServico = new ContaServico();
            Conta conta = _contaServico.Buscar(x => x.ContaID == _atendimento.ContaID).FirstOrDefault();
            if (conta != null)
            {
                Animal animal = _animalServico.Buscar(x => x.AnimalID == Convert.ToInt64(cbPaciente.Text.Split(' ')[0])).FirstOrDefault();
                if (animal != null)
                {
                    conta.CadastroID = animal.CadastroID;
                    _contaServico.Editar(conta);
                }
            }
        }

        //////////////////////////////// Botões de Controle ///////////////////////////////////////////
        private void BtnFechar_Click(object sender, EventArgs e)
        {
            ConfirmacaoFecharPrograma fechar = new ConfirmacaoFecharPrograma();
            fechar.ShowDialog();
            if (fechar.Resultado == "OK")
                throw new FecharException();
        }
        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            Controles.Redimensionar(this);
            CenterToScreen();
        }

        //////////////////////////////// MOVER FORM CLICANDO NO CABEÇALHO ///////////////////
        private void Top_MouseDown(object sender, MouseEventArgs e)
        {
            Controles.ReleaseCapture();
            Controles.SendMessage(Handle, 0x112, 0xf012, 0);
        }

        /////////////////////////// Redimensionamento ////////////////////////
        private void PaginaCadastro_Resize(object sender, EventArgs e)
        {
            pnlEsquerdo.Width = this.Width / 2;
            pnlDireito.Width = this.Width / 2;
            btnSalvar.Width = this.Width / 2;
            btnCancelar.Width = this.Width / 2;
        }
    }
}
