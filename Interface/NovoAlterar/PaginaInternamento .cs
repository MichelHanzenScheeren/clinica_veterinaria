using Interface.Controle;
using Modelo;
using Modelo.Excessoes;
using Modelo.Servicos;
using Servico.Geral;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Interface
{
    public partial class PaginaInternamento : Form
    {
        private Internamento _internamento;
        private AnimalServico _animalServico;
        private ContaServico _contaServico;
        private InternamentoServico _internamentoServico;
        public PaginaInternamento()
        {
            InitializeComponent();
            AlteracoesBasicas();
        }

        public PaginaInternamento(long animalID) : this()
        {
            cbPaciente.Text = _animalServico.Buscar(x => x.AnimalID == animalID, "Cadastro").FirstOrDefault().ToString();
            
        }

        public PaginaInternamento(Internamento internamento) : this()
        {
            _internamento = internamento;
            FazerAlteracoes();
        }

        private void AlteracoesBasicas()
        {
            _internamentoServico = new InternamentoServico();
            _animalServico = new AnimalServico();
            dtVencimento.Text = DateTime.Now.AddDays(30).ToShortDateString();
            dtHoraEntrada.Text = DateTime.Now.ToShortTimeString();
            dtHoraSaida.Text = DateTime.Now.ToShortTimeString();
            dtEntrada.Select();
            dtEntrada.Focus();
        }

        private void BtnAdicionarAnimal_Click(object sender, EventArgs e)
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
                foreach (var item in _animalServico.Buscar(x => x.Nome.Contains(cbPaciente.Text) || x.Especie.Contains(cbPaciente.Text) || x.Raca.Contains(cbPaciente.Text) || x.Pedigree.Contains(cbPaciente.Text), "Cadastro"))
                {
                    cbPaciente.Items.Add(item.ToString());
                    cont++;
                }
            }
            if (cont == 0)
                cbPaciente.Items.Add("NENHUMA CORRESPONDÊNCIA...");
            cbPaciente.DroppedDown = true;
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                VerificarPreenchimento();
                if(_internamento != null)
                {
                    if (MessageBox.Show("TEM CERTEZA QUE DESEJA FAZER ALTERAÇÕES NESSE REGISTRO?\n\nOBS:\nESSA AÇÃO NÃO PODE SER DESFEITA!", "ATENÇÃO!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                        EditarAgendamento();
                }
                else
                    CadastrarInternamento();
            }
            catch (NaoPreenchidoException erro)
            {
                MessageBox.Show($"ERRO NO CADASTRO!\n {erro.Message}", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show($"O PACIENTE E/OU PREÇO INSERIDOS NÃO SÃO VÁLIDOS!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void VerificarPreenchimento()
        {
            ValidarPreenchimento.Validacao(errorProvider1, cbPaciente, txtResumo);
            if (numQuarto.Value == 0)
            {
                errorProvider1.SetError(numQuarto, "PREENCHA O CAMPO!");
                throw new NaoPreenchidoException("UM OU MAIS CAMPOS OBRIGATÓRIOS NÃO PREENCHIDOS!");
            }
            else
                errorProvider1.SetError(numQuarto, null);

            if (checkSaida.Checked == true) 
            {
                ValidarPreenchimento.Validacao(errorProvider1, txtPreco, cbMetodoPagamento, txtConclusao);
            }

        }

        private void CadastrarInternamento()
        {
            Internamento internamento;
            if (checkEntrada.Checked == true)
            {
                internamento = new Internamento(ArrumarDataHora(dtEntrada.Text, dtHoraEntrada.Text), txtResumo.Text, Convert.ToInt32(numQuarto.Value), Convert.ToInt64(cbPaciente.Text.Split(' ')[0]));
            }
            else
            {
                internamento = new Internamento(ArrumarDataHora(dtEntrada.Text, dtHoraEntrada.Text), txtResumo.Text, Convert.ToInt32(numQuarto.Value), Convert.ToInt64(cbPaciente.Text.Split(' ')[0]))
                {
                    Conclusoes = txtConclusao.Text,
                    DataSaida = ArrumarDataHora(dtSaida.Text, dtHoraSaida.Text),
                    ContaID = CadastrarConta()
                };
            }
            _internamentoServico.Salvar(internamento);
            MessageBox.Show("CADASTRO CONCLUÍDO!", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.None);
            this.Close();
        }

        private long CadastrarConta()
        {
            _contaServico = new ContaServico();
            Animal animal = _animalServico.Buscar(x => x.AnimalID == Convert.ToInt64(cbPaciente.Text.Split(' ')[0]), "Cadastro").FirstOrDefault();
            if (animal != null)
            {
                int parcelas = 1;
                if (cbMetodoPagamento.Text.Contains("A Prazo"))
                {
                    parcelas = Convert.ToInt32(numParcelas.Value);
                }
                Conta conta = new Conta("Entrada", "Internamento", Convert.ToDateTime(dtVencimento.Text), Convert.ToDouble(txtPreco.Text), cbMetodoPagamento.Text, parcelas, animal.Cadastro.ID);
                _contaServico = new ContaServico();
                _contaServico.Salvar(conta);
                return _contaServico.Ultimo();
            }
            else
                throw new Exception();
            
        }

        private DateTime ArrumarDataHora(string auxData, string auxHora)
        {
            string auxiliar = auxData + " " + auxHora;
            DateTime data = DateTime.Parse(auxiliar);
            return data;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //////////////////////////////// EDITAR AGENDAMENTO ///////////////////////////////////////////

        private void FazerAlteracoes()
        {
            lblID.Visible = true;
            lblID.Enabled = true;
            txtID.Visible = true;
            txtID.Text = Convert.ToString(_internamento.InternamentoID);
            dtEntrada.Text = _internamento.DataEntrada.ToLongDateString();
            dtHoraEntrada.Text = _internamento.DataEntrada.ToShortTimeString();
            if (_internamento.DataSaida != null)
            {
                DateTime saida = Convert.ToDateTime(_internamento.DataSaida.ToString());
                dtSaida.Text = saida.ToLongDateString();
                dtHoraSaida.Text = saida.ToShortTimeString();
                checkSaida.Checked = true;
                checkEntrada.Enabled = checkSaida.Enabled = false;
            }
            cbPaciente.Text = _internamento.Animal.ToString();
            txtResumo.Text = _internamento.Resumo;
            txtConclusao.Text = _internamento.Conclusoes;
            numQuarto.Value = _internamento.NumeroQuarto;
            AtualizarConta();
        }

        private void AtualizarConta()
        {
            if(_internamento.ContaID != null)
            {
                _contaServico = new ContaServico();
                Conta conta = _contaServico.Buscar(x => x.ContaID == _internamento.ContaID).FirstOrDefault();
                txtPreco.Text = Convert.ToString(conta.Total);
                cbMetodoPagamento.SelectedItem = conta.MetodoPagamento;
                numParcelas.Value = conta.Parcelas;
                dtVencimento.Text = conta.Data_Vencimento.ToShortDateString();
                txtPreco.Enabled = cbMetodoPagamento.Enabled = dtVencimento.Enabled = numParcelas.Enabled = false;
                lblAviso1.Visible = lblAviso2.Visible = true;
            }
        }

        private void EditarAgendamento()
        {
            if (_internamento.AnimalID != Convert.ToInt64(cbPaciente.Text.Split(' ')[0]))
                EditarConta();
            _internamento.DataEntrada = ArrumarDataHora(dtEntrada.Text, dtHoraEntrada.Text);
            if (checkSaida.Checked == true)
                _internamento.DataSaida = ArrumarDataHora(dtSaida.Text, dtHoraSaida.Text);
            _internamento.AnimalID = Convert.ToInt64(cbPaciente.Text.Split(' ')[0]);
            _internamento.Resumo = txtResumo.Text;
            _internamento.Conclusoes = txtConclusao.Text;
            _internamento.NumeroQuarto = Convert.ToInt32(numQuarto.Value);
            if (_internamento.ContaID == null && checkSaida.Checked == true)
                _internamento.ContaID = CadastrarConta();
            _internamentoServico.Editar(_internamento);
            MessageBox.Show("TODAS AS ALTERAÇÕES FORAM SALVAS!", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.None);
            Close();
        }

        private void EditarConta()
        {
            _contaServico = new ContaServico();
            Conta conta = _contaServico.Buscar(x => x.ContaID == _internamento.ContaID).FirstOrDefault();
            if(conta != null)
            {
                Animal animal = _animalServico.Buscar(x => x.AnimalID == Convert.ToInt64(cbPaciente.Text.Split(' ')[0])).FirstOrDefault();
                if(animal != null)
                {
                    conta.CadastroID = animal.CadastroID;
                    _contaServico.Editar(conta);
                }
            }
        }

        private void CheckSaida_CheckedChanged(object sender, EventArgs e)
        {
            if (checkSaida.Checked == true)
            {
                checkEntrada.Checked = false;
                dtSaida.Enabled = dtHoraSaida.Enabled = true;
                pnlSaida.Enabled = pnlSaida.Visible = true;
            }
            else
                checkEntrada.Checked = true;
        }

        private void CheckEntrada_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEntrada.Checked == true)
            {
                checkSaida.Checked = false;
                dtSaida.Enabled = dtHoraSaida.Enabled = false;
                pnlSaida.Enabled = pnlSaida.Visible = false;
            }
            else
                checkSaida.Checked = true;

        }

        private void TxtPreco_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (!char.IsControl(e.KeyChar)) && (e.KeyChar != '.') && (e.KeyChar != ','))
                e.Handled = true;
            if (e.KeyChar == ',')
                e.KeyChar = '.';
            if (txtPreco.Text.Contains(".") && ((e.KeyChar == '.') || (e.KeyChar == ',')))
                e.Handled = true;
            if (txtPreco.Text.Length == 0 && e.KeyChar == '.')
                e.Handled = true;
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
            btnSalvar.Width = this.Width / 2;
            btnCancelar.Width = this.Width / 2;
        }

        //////////////////////////////// MOVER FORM CLICANDO NO CABEÇALHO ///////////////////
        private void Top_MouseDown(object sender, MouseEventArgs e)
        {
            Controles.ReleaseCapture();
            Controles.SendMessage(Handle, 0x112, 0xf012, 0);
        }
    }
}
