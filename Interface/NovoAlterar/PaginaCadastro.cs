using Interface.Controle;
using Modelo;
using Modelo.Cadastros;
using Modelo.Excessoes;
using Servico.Geral;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Interface
{
    public partial class PaginaCadastro : Form
    {
        private Cadastro _cadastro;
        private EnderecoServico _enderecoServico;
        private CadastroServico _cadastroServico;

        public PaginaCadastro()
        {
            InitializeComponent();
        }

        public PaginaCadastro(Cadastro cadastro) : this()
        {
            _cadastro = cadastro;
            AtualizarInformacoes();
        }

        private void PaginaCadastro_Load(object sender, EventArgs e)
        {
            _cadastroServico = new CadastroServico();
            txtNome.Focus();
            txtNome.Select();
        }



        private void CbCadastro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCadastro.Text == "Veterinário")
            {
                pnlFuncionario.Enabled = false;
                pnlFuncionario.Visible = false;
                pnlVeterinario.Enabled = true;
                pnlVeterinario.Visible = true;
            }
            else if (cbCadastro.Text == "Funcionário")
            {
                pnlVeterinario.Enabled = false;
                pnlVeterinario.Visible = false;
                pnlFuncionario.Enabled = true;
                pnlFuncionario.Visible = true;
            }
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                VerificarPreenchimento();
                if (_cadastro != null)
                {
                    if (MessageBox.Show("TEM CERTEZA QUE DESEJA FAZER ALTERAÇÕES NESSE REGISTRO?\n\nOBS:\nESSA AÇÃO NÃO PODE SER DESFEITA!", "ATENÇÃO!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                        EditarCadastro();
                    
                }
                else
                {
                    long enderecoID = CadastrarEndereco();
                    if (cbCadastro.Text == "Cliente")
                        CadastrarCliente(enderecoID);
                    else if (cbCadastro.Text == "Veterinário")
                        CadastrarVeterinario(enderecoID);
                    else
                        CadastrarFuncionario(enderecoID);
                }
            }
            catch (NaoPreenchidoException erro)
            {
                MessageBox.Show($"Erro no Cadastro!\n {erro.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void VerificarPreenchimento()
        {
            if (_cadastro == null)
            {
                if (_cadastroServico.Contagem(x => x.Cpf == mbCpf.Text) != 0)
                    throw new NaoPreenchidoException("JÁ EXISTE UM REGISTRO COM ESSE CPF!");
            }

            ValidarPreenchimento.Validacao(errorProvider1, txtBairro, txtCidade, txtEmail, txtNome, txtNumero, txtRua, cbSexo, cbCadastro, mbEstado);

            string telefone = mbTelefone.Text.Replace("+", "").Replace("-", "").Replace("(", "").Replace(")", "").Replace(" ", "");
            string cep = mbCep.Text.Replace("-", "").Replace(" ", "");
            if (string.IsNullOrEmpty(telefone) || telefone.Length != 13)
            {
                errorProvider1.SetError(mbTelefone, "O TELEFONE INSERIDO É INVÁLIDO");
                throw new NaoPreenchidoException("PREENCHIMENTO INVÁLIDO!");
            }
            else
                errorProvider1.SetError(mbTelefone, null);

            if (string.IsNullOrEmpty(cep) || cep.Length != 8)
            {
                errorProvider1.SetError(mbCep, "O TELEFONE INSERIDO É INVÁLIDO");
                throw new NaoPreenchidoException("PREENCHIMENTO INVÁLIDO!");
            }
            else
                errorProvider1.SetError(mbCep, null);

            if (!ValidarCPF.Valida(mbCpf.Text))
            {
                errorProvider1.SetError(mbCpf, "INFORME UM CPF VÁLIDO");
                throw new NaoPreenchidoException("O CPF INSERIDO NÃO É VÁLIDO!");
            }
            else
                errorProvider1.SetError(mbCpf, null);

            if (cbCadastro.Text == "Veterinário")
            {
                ValidarPreenchimento.Validacao(errorProvider1, txtAreasAtuacao, txtCrmv, txtEspecializacao, txtGraduacao, txtInstituicao, mbEstadoCRMV);

            }

            if (cbCadastro.Text == "Funcionário")
            {
                ValidarPreenchimento.Validacao(errorProvider1, txtSalario, txtCargo);
                if (numCargaHoraria.Value == 0)
                {
                    errorProvider1.SetError(numCargaHoraria, "INFORME A CARGA HORÁRIA DO FUNCIONÁRIO!");
                    throw new NaoPreenchidoException("UM OU MAIS CAMPOS OBRIGATÓRIOS NÃO PREENCHIDOS!");
                }
                else
                    errorProvider1.SetError(numCargaHoraria, null);
            }

            if (Convert.ToDateTime(dtNascimento.Text).Date >= DateTime.Now.Date)
            {
                errorProvider1.SetError(dtNascimento, "A DATA INSERIDA É INVÁLIDA!");
                throw new NaoPreenchidoException("PREENCHIMENTO INVÁLIDO!");
            }
            else
                errorProvider1.SetError(dtNascimento, null);
        }

        private long CadastrarEndereco()
        {
            Endereco endereco = new Endereco(mbCep.Text, txtRua.Text, txtNumero.Text, txtBairro.Text, txtCidade.Text, mbEstado.Text);
            _enderecoServico = new EnderecoServico();
            _enderecoServico.Salvar(endereco);
            return _enderecoServico.Ultimo();
        }

        private void CadastrarCliente(long enderecoID)
        {
            Cadastro cliente = new Cliente(txtNome.Text, cbSexo.Text, mbCpf.Text, txtEmail.Text, mbTelefone.Text, Convert.ToDateTime(dtNascimento.Text), enderecoID);
            _cadastroServico.Salvar(cliente);
            MessageBox.Show("Cadastro Concluído!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.None);
            this.Close();
        }

        private void CadastrarVeterinario(long enderecoID)
        {
            Cadastro veterinario = new Veterinario(txtNome.Text, cbSexo.Text, mbCpf.Text, txtEmail.Text, mbTelefone.Text, Convert.ToDateTime(dtNascimento.Text), enderecoID)
            {
                AreaAtuacao = txtAreasAtuacao.Text,
                Crmv = txtCrmv.Text,
                Mestrado = txtMestrado.Text,
                Doutorado = txtDoutorado.Text,
                Especializacao = txtEspecializacao.Text,
                EstadoCrmv = mbEstadoCRMV.Text,
                Faculdade = txtInstituicao.Text,
                Graduacao = txtGraduacao.Text
            };
            _cadastroServico.Salvar(veterinario);
            MessageBox.Show("Cadastro Concluído!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.None);
            this.Close();
        }

        private void CadastrarFuncionario(long enderecoID)
        {
            Cadastro funcionario = new Funcionario(txtNome.Text, cbSexo.Text, mbCpf.Text, txtEmail.Text, mbTelefone.Text, Convert.ToDateTime(dtNascimento.Text), enderecoID)
            {
                JornadaDeTrabalho = Convert.ToInt32(numCargaHoraria.Value),
                Cargo = txtCargo.Text,
                Salario = Convert.ToDouble(txtSalario.Text)
            };
            _cadastroServico.Salvar(funcionario);
            MessageBox.Show("Cadastro Concluído!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.None);
            this.Close();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtSalario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (!char.IsControl(e.KeyChar)) && (e.KeyChar != '.') && (e.KeyChar != ','))
                e.Handled = true;
            if (e.KeyChar == ',')
                e.KeyChar = '.';
            if (txtSalario.Text.Contains(".") && ((e.KeyChar == '.') || (e.KeyChar == ',')))
                e.Handled = true;
            if (txtSalario.Text.Length == 0 && e.KeyChar == '.')
                e.Handled = true;
        }

        //////////////////////////////// EDITAR CADASTRO ///////////////////////////////////////////

        private void AtualizarInformacoes()
        {
            lblID.Enabled = true;
            lblID.Visible = true;
            txtID.Visible = true;
            cbCadastro.Enabled = false;
            btnSalvar.Text = "SALVAR ALTERAÇÕES";
            btnCancelar.Text = "CANCELAR";
            txtID.Text = Convert.ToString(_cadastro.ID);
            txtNome.Text = _cadastro.Nome;
            cbSexo.SelectedItem = _cadastro.Sexo;
            dtNascimento.Text = _cadastro.DataNascimento.ToShortDateString();
            mbCpf.Text = _cadastro.Cpf;
            mbTelefone.Text = _cadastro.Telefone;
            txtEmail.Text = _cadastro.Email;
            mbCep.Text = _cadastro.Endereco.Cep;
            txtNumero.Text = _cadastro.Endereco.NumeroCasa;
            txtRua.Text = _cadastro.Endereco.Rua;
            txtBairro.Text = _cadastro.Endereco.Bairro;
            txtCidade.Text = _cadastro.Endereco.Cidade;
            mbEstado.Text = _cadastro.Endereco.Estado;
            if (_cadastro.GetType() == typeof(Cliente))
                cbCadastro.SelectedItem = "Cliente";
            else if (_cadastro.GetType() == typeof(Veterinario))
            {
                cbCadastro.SelectedItem += "Veterinário";
                AtualizarInfoVeterinario();
            }
            else
            {
                cbCadastro.SelectedItem += "Funcionário";
                AtualizarInfoFuncionario();
            }
        }

        private void AtualizarInfoVeterinario()
        {
            Veterinario veterinario = (Veterinario)_cadastro;
            pnlFuncionario.Enabled = false;
            pnlFuncionario.Visible = false;
            pnlVeterinario.Enabled = true;
            pnlVeterinario.Visible = true;

            txtCrmv.Text = veterinario.Crmv;
            mbEstadoCRMV.Text = veterinario.EstadoCrmv;
            txtAreasAtuacao.Text = veterinario.AreaAtuacao;
            txtEspecializacao.Text = veterinario.Especializacao;
            txtGraduacao.Text = veterinario.Graduacao;
            txtInstituicao.Text = veterinario.Faculdade;
            txtMestrado.Text = veterinario.Mestrado;
            txtDoutorado.Text = veterinario.Doutorado;
        }

        private void AtualizarInfoFuncionario()
        {
            Funcionario funcionario = (Funcionario)_cadastro;
            pnlVeterinario.Enabled = false;
            pnlVeterinario.Visible = false;
            pnlFuncionario.Enabled = true;
            pnlFuncionario.Visible = true;

            txtCargo.Text = funcionario.Cargo;
            txtSalario.Text = Convert.ToString(funcionario.Salario);
            numCargaHoraria.Value = Convert.ToDecimal(funcionario.JornadaDeTrabalho);
        }

        private void EditarCadastro()
        {
            _cadastro.Nome = txtNome.Text;
            _cadastro.Sexo = cbSexo.Text;
            _cadastro.DataNascimento = Convert.ToDateTime(dtNascimento.Text);
            _cadastro.Cpf = mbCpf.Text;
            _cadastro.Telefone = mbTelefone.Text;
            _cadastro.Email = txtEmail.Text;

            EditarEndereco();

            if (_cadastro.GetType() == typeof(Veterinario))
                EditarVeterinario();
            else if(_cadastro.GetType() == typeof(Funcionario))
                EditarFuncionario();

            _cadastroServico.Editar(_cadastro);
            MessageBox.Show("TODAS AS ALTERAÇÕES FORAM SALVAS!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.None);
            Close();
        }

        private void EditarEndereco()
        {
            _enderecoServico = new EnderecoServico();
            Endereco endereco = _enderecoServico.Buscar(x => x.EnderecoID == _cadastro.EnderecoID).FirstOrDefault();
            endereco.Cep = mbCep.Text;
            endereco.NumeroCasa = txtNumero.Text;
            endereco.Rua = txtRua.Text;
            endereco.Bairro = txtBairro.Text;
            endereco.Cidade = txtCidade.Text;
            endereco.Estado = mbEstado.Text;
            _enderecoServico.Editar(endereco);
        }

        private void EditarVeterinario()
        {
            Veterinario veterinario = (Veterinario)_cadastro;
            veterinario.Crmv = txtCrmv.Text;
            veterinario.EstadoCrmv = mbEstadoCRMV.Text;
            veterinario.AreaAtuacao = txtAreasAtuacao.Text;
            veterinario.Especializacao = txtEspecializacao.Text;
            veterinario.Graduacao = txtGraduacao.Text;
            veterinario.Faculdade = txtInstituicao.Text;
            veterinario.Mestrado = txtMestrado.Text;
            veterinario.Doutorado = txtDoutorado.Text;
        }

        private void EditarFuncionario()
        {
            Funcionario funcionario = (Funcionario)_cadastro;
            funcionario.Cargo = txtCargo.Text;
            funcionario.Salario = Convert.ToDouble(txtSalario.Text);
            funcionario.JornadaDeTrabalho = Convert.ToInt32(numCargaHoraria.Value);
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
