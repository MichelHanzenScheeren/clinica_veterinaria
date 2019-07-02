using Interface.Controle;
using Modelo;
using Modelo.Excessoes;
using Servico.Geral;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Interface
{
    public partial class PaginaAnimal : Form
    {
        private Animal _animal;
        private AnimalServico _animalServico;
        private CadastroServico _cadastroServico;
        public PaginaAnimal()
        {
            InitializeComponent();
        }

        public PaginaAnimal(Animal animal) : this()
        {
            _animal = animal;
            AtualizarInformacoes();
        }

        public PaginaAnimal(long cadastroID) : this()
        {
            _cadastroServico = new CadastroServico();
            cbDono.Text = _cadastroServico.Buscar(x => x.ID == cadastroID, "Endereco").FirstOrDefault().ToString();
        }

        private void PaginaAnimal_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            txtNome.Focus();
            txtNome.Select();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                VerificarPreenchimento();
                if (_animal != null)
                {
                    if (MessageBox.Show("TEM CERTEZA QUE DESEJA FAZER ALTERAÇÕES NESSE REGISTRO?\n\nOBS:\nESSA AÇÃO NÃO PODE SER DESFEITA!", "ATENÇÃO!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                        EditarAnimal();
                }
                else
                    CadastrarAnimal();
            }
            catch (NaoPreenchidoException erro)
            {
                MessageBox.Show($"Erro no Cadastro!\n {erro.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void VerificarPreenchimento()
        {
            ValidarPreenchimento.Validacao(errorProvider1, txtCor, txtEspecie, txtNome, txtRaca, txtPeso, txtTamanho, cbSexo, cbEsterilizacao, cbDono);

            if (Convert.ToDateTime(dtNascimento.Text).Date >= DateTime.Now.Date)
            {
                errorProvider1.SetError(dtNascimento, "A DATA INSERIDA É INVÁLIDA!");
                throw new NaoPreenchidoException("PREENCHIMENTO INVÁLIDO!");
            }
            else
                errorProvider1.SetError(dtNascimento, null);
        }

        private void CadastrarAnimal()
        {
            try
            {
                Animal animal = new Animal(txtNome.Text, txtEspecie.Text, txtRaca.Text, cbSexo.Text, Convert.ToDouble(txtPeso.Text), Convert.ToDouble(txtTamanho.Text),txtCor.Text, cbEsterilizacao.Text, txtPedigree.Text, Convert.ToDateTime(dtNascimento.Text), Convert.ToInt64(cbDono.Text.Split(' ')[0]));
                _animalServico = new AnimalServico();
                _animalServico.Salvar(animal);
                MessageBox.Show("Cadastro Concluído!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.None);
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Cliente inválido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void BtnBuscarDono_Click(object sender, EventArgs e)
        {
            cbDono.Items.Clear();
            int cont = 0;
            _cadastroServico = new CadastroServico();
            try
            {
                foreach (var item in _cadastroServico.Buscar(x => x.ID == Convert.ToInt64(cbDono.Text), "Endereco"))
                {
                    cbDono.Items.Add(item.ToString());
                    cont++;
                }
                if (cont == 0)
                    throw new Exception();
            }
            catch (Exception)
            {
                foreach (var item in _cadastroServico.Buscar(x => x.Nome.Contains(cbDono.Text) || x.Cpf.Contains(cbDono.Text), "Endereco"))
                {
                    cbDono.Items.Add(item.ToString());
                    cont++;
                }
            }
            if (cont == 0)
                cbDono.Items.Add("Nenhuma correspondência encontrada!");
            cbDono.DroppedDown = true;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //////////////////////////////// EDITAR ANIMAL ///////////////////////////////////////////
        
        private void AtualizarInformacoes()
        {
            lblID.Enabled = true;
            lblID.Visible = true;
            txtID.Visible = true;
            txtID.Text = Convert.ToString(_animal.AnimalID);
            txtNome.Text = _animal.Nome;
            txtRaca.Text = _animal.Raca;
            txtEspecie.Text = _animal.Especie;
            txtCor.Text = _animal.Cor;
            cbSexo.SelectedItem = _animal.Sexo;
            dtNascimento.Text = _animal.DataNascimento.ToShortDateString();
            txtPeso.Text = Convert.ToString(_animal.Peso);
            txtTamanho.Text = Convert.ToString(_animal.Tamanho);
            cbEsterilizacao.SelectedItem = _animal.Esterilizacao;
            txtPedigree.Text = _animal.Pedigree;
            cbDono.Text = _animal.Cadastro.ToString();
        }

        private void EditarAnimal()
        {
            try
            {
                _animal.Nome = txtNome.Text;
                _animal.Raca = txtRaca.Text;
                _animal.Especie = txtEspecie.Text;
                _animal.Cor = txtCor.Text;
                _animal.Sexo = cbSexo.Text;
                _animal.DataNascimento = Convert.ToDateTime(dtNascimento.Text);
                _animal.Peso = Convert.ToDouble(txtPeso.Text);
                _animal.Tamanho = Convert.ToDouble(txtTamanho.Text);
                _animal.Esterilizacao = cbEsterilizacao.Text;
                _animal.Pedigree = txtPedigree.Text;
                _animal.CadastroID = Convert.ToInt64(cbDono.Text.Split(' ')[0]);
                _animalServico = new AnimalServico();
                _animalServico.Editar(_animal);
                MessageBox.Show("REGISTRO ATUALIZADO!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.None);
                Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Cliente inválido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /////////////////////////// Só permtir numeros para Tamanho e Peso ////////////////////////
        private void TxtPeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtPeso.Text.Contains(".") && ((e.KeyChar == '.') || (e.KeyChar == ',')))
                e.Handled = true;
            if (txtPeso.Text.Length == 0 && e.KeyChar == '.')
                e.Handled = true;
            ValidarDouble(e);
        }
        private void TxtTamanho_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtTamanho.Text.Contains(".") && ((e.KeyChar == '.') || (e.KeyChar == ',')))
                e.Handled = true;
            if (txtTamanho.Text.Length == 0 && e.KeyChar == '.')
                e.Handled = true;
            ValidarDouble(e);
        }
        private void ValidarDouble(KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (!char.IsControl(e.KeyChar)) && (e.KeyChar != '.') && (e.KeyChar != ','))
                e.Handled = true;
            if (e.KeyChar == ',')
                e.KeyChar = '.';
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
