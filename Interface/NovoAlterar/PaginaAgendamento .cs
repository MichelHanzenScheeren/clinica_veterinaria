using Interface.Controle;
using Modelo.Excessoes;
using Modelo.Servicos;
using Servico.Geral;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Interface
{
    public partial class PaginaAgendamento : Form
    {
        private Agendamento _agendamento;
        private AgendamentoServico _agendamentoServico;
        private AnimalServico _animalServico;
        public PaginaAgendamento()
        {
            InitializeComponent();
            _agendamentoServico = new AgendamentoServico();
            _animalServico = new AnimalServico();
            cbStatus.SelectedItem = "Pendente";
        }
        public PaginaAgendamento(long animalID) : this()
        {
            cbPaciente.Text = _animalServico.Buscar(x => x.AnimalID == animalID, "Cadastro").FirstOrDefault().ToString();
        }

        public PaginaAgendamento(Agendamento agendamento) :this()
        {
            _agendamento = agendamento;
            FazerAlteracoes();
        }

        private void PaginaAgendamento_Load(object sender, EventArgs e)
        {
            cbTipo.Focus();
            cbTipo.Select();
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
                foreach (var item in _animalServico.Buscar(x => x.Nome.Contains(cbPaciente.Text) || x.Raca.Contains(cbPaciente.Text) || x.Especie.Contains(cbPaciente.Text), "Cadastro"))
                {
                    cbPaciente.Items.Add(item.ToString());
                    cont++;
                }
            }
            if (cont == 0)
                cbPaciente.Items.Add("Nenhuma correspondência encontrada!");
            cbPaciente.DroppedDown = true;
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                VerificarPreenchimento();
                if(_agendamento != null)
                {
                    if (MessageBox.Show("TEM CERTEZA QUE DESEJA FAZER ALTERAÇÕES NESSE REGISTRO?\n\nOBS:\nESSA AÇÃO NÃO PODE SER DESFEITA!", "ATENÇÃO!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                    EditarAgendamento();
                }
                else
                    CadastrarAgendamento();
            }
            catch (NaoPreenchidoException erro)
            {
                MessageBox.Show($"Erro no Cadastro!\n {erro.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("O PACIENTE INSERIDO NÃO É VÁLIDO!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void VerificarPreenchimento()
        {
            ValidarPreenchimento.Validacao(errorProvider1, cbPaciente, cbTipo);
        }

        private void CadastrarAgendamento()
        {
            Agendamento agendamento = new Agendamento(ArrumarDataHora(), cbTipo.Text, cbStatus.Text, txtResumo.Text,Convert.ToInt64(cbPaciente.Text.Split(' ')[0]));
            _agendamentoServico.Salvar(agendamento);
            MessageBox.Show("Cadastro Concluído!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.None);
            this.Close();
        }

        private DateTime ArrumarDataHora()
        {
            string auxiliar = dtData.Text + " " + dtHora.Text;
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
            txtID.Text = Convert.ToString(_agendamento.AgendamentoID);
            cbTipo.SelectedItem = _agendamento.Tipo;
            dtData.Text = _agendamento.DataAtendimento.ToLongDateString();
            dtHora.Text = _agendamento.DataAtendimento.ToShortTimeString();
            cbPaciente.Text = _agendamento.Animal.ToString();
            cbStatus.SelectedItem = _agendamento.Status;
            txtResumo.Text = _agendamento.Resumo;
        }

        private void EditarAgendamento()
        {
            try
            {
                _agendamento.Tipo = cbTipo.Text;
                _agendamento.DataAtendimento = ArrumarDataHora();
                _agendamento.AnimalID = Convert.ToInt64(cbPaciente.Text.Split(' ')[0]);
                _agendamento.Status = cbStatus.Text;
                _agendamento.Resumo = txtResumo.Text;
                _agendamentoServico.Editar(_agendamento);
                MessageBox.Show("TODAS AS ALTERAÇÕES FORAM SALVAS!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.None);
                Close();
            }
            catch (Exception)
            {
                MessageBox.Show("O PACIENTE INSERIDO É INVÁLIDO!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
