using Interface.Controle;
using Modelo.Cadastros;
using Modelo.Excessoes;
using Modelo.Servicos;
using Servico.Geral;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Interface
{
    public partial class PaginaReceita : Form
    {
        private Receita _receita;
        private ReceitaServico _receitaServico;
        private AnimalServico _animalServico;
        private CadastroServico _cadastroServico;
        private MedicamentoServico _medicamentoServico;
        public PaginaReceita()
        {
            InitializeComponent();
            _receitaServico = new ReceitaServico();
            _animalServico = new AnimalServico();
            txtDose.Select();
            txtDose.Focus();
            AtualizarCbMedicamentos();
            AtualizarVeterinarios();
        }
        public PaginaReceita(long animalID) : this()
        {
            cbPaciente.Text = _animalServico.Buscar(x => x.AnimalID == animalID, "Cadastro").FirstOrDefault().ToString();
        }

        public PaginaReceita(Receita receita) :this()
        {
            _receita = receita;
            FazerAlteracoes();
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

        private void AtualizarCbMedicamentos()
        {
            _medicamentoServico = new MedicamentoServico();
            foreach (var item in _medicamentoServico.ObterTodos().OrderBy(x => x.Nome).ToList())
            {
                cbMedicamento.Items.Add(item.ToString());
            }
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
                cbPaciente.Items.Add("Nenhuma correspondência encontrada!");
            cbPaciente.DroppedDown = true;
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                VerificarPreenchimento();
                if(_receita != null)
                {
                    if (MessageBox.Show("TEM CERTEZA QUE DESEJA FAZER ALTERAÇÕES NESSE REGISTRO?\n\nOBS:\nESSA AÇÃO NÃO PODE SER DESFEITA!", "ATENÇÃO!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                    EditarReceita();
                }
                else
                    CadastrarReceita();
            }
            catch (NaoPreenchidoException erro)
            {
                MessageBox.Show($"ERRO NO CADASTRO!\n {erro.Message}", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show($"ERRO NO CADASTRO!\n O PACIENTE INSERIDO NÃO É VÁLIDO!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void VerificarPreenchimento()
        {
            ValidarPreenchimento.Validacao(errorProvider1, cbPaciente, cbMedicamento, txtDose, cbVeterinarios);
            if (numIntervaloHoras.Value == 0)
            {
                errorProvider1.SetError(numIntervaloHoras, "PREENCHA O CAMPO!");
                throw new NaoPreenchidoException("UM OU MAIS CAMPOS OBRIGATÓRIOS NÃO PREENCHIDOS!");
            }
            else
                errorProvider1.SetError(numIntervaloHoras, null);

            if (numTotalDias.Value == 0)
            {
                errorProvider1.SetError(numTotalDias, "PREENCHA O CAMPO!");
                throw new NaoPreenchidoException("UM OU MAIS CAMPOS OBRIGATÓRIOS NÃO PREENCHIDOS!");
            }
            else
                errorProvider1.SetError(numTotalDias, null);
        }

        private void CadastrarReceita()
        {
            Receita receita = new Receita(txtDose.Text, Convert.ToInt32(numIntervaloHoras.Value), Convert.ToInt32(numTotalDias.Value), Convert.ToInt64(cbMedicamento.Text.Split(' ')[0]), Convert.ToInt64(cbPaciente.Text.Split(' ')[0]), Convert.ToInt64(cbVeterinarios.Text.Split(' ')[0]));
            _receitaServico.Salvar(receita);
            MessageBox.Show("CADASTRO CONCLUÍDO!", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.None);
            this.Close();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //////////////////////////////// EDITAR Receita ///////////////////////////////////////////
        
        private void FazerAlteracoes()
        {
            lblID.Visible = true;
            lblID.Enabled = true;
            txtID.Visible = true;
            txtID.Text = Convert.ToString(_receita.ReceitaID);
            txtDose.Text = _receita.Dose;
            numIntervaloHoras.Value = _receita.IntervaloDose;
            numTotalDias.Value = _receita.TempoTratamento;
            cbMedicamento.Text = _receita.Medicamento.ToString();
            cbPaciente.Text = _receita.Animal.ToString();
            cbVeterinarios.SelectedItem = _receita.Veterinario.ToString() + " - Crmv: " + _receita.Veterinario.Crmv;
        }

        private void EditarReceita()
        {
            _receita.TempoTratamento = Convert.ToInt32(numTotalDias.Value);
            _receita.MedicamentoID = Convert.ToInt64(cbMedicamento.Text.Split(' ')[0]);
            _receita.IntervaloDose = Convert.ToInt32(numIntervaloHoras.Value);
            _receita.Dose = txtDose.Text;
            _receita.AnimalID = Convert.ToInt64(cbPaciente.Text.Split(' ')[0]);
            _receita.VeterinarioID = Convert.ToInt64(cbVeterinarios.Text.Split(' ')[0]);
            _receitaServico.Editar(_receita);
            MessageBox.Show("TODAS AS ALTERAÇÕES FORAM SALVAS!", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.None);
            Close();
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
