using Interface.Controle;
using Modelo;
using Modelo.Cadastros;
using Modelo.Excessoes;
using Servico.Geral;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Interface
{
    public partial class InformacoesCadastro : Form
    {
        private Cadastro _cadastro;
        private AnimalServico _animalServico;
        private CadastroServico _cadastroServico;
        private ContaServico _contaServico;
        public InformacoesCadastro(Cadastro cadastro)
        {
            this._cadastro = cadastro;
            InitializeComponent();
        }

        public void AtualizarInformacoes()
        {
            lblID.Text = "Nº " +   Convert.ToString(_cadastro.ID);
            lblNome.Text = "NOME: " + _cadastro.Nome;
            lblSexo.Text = "SEXO: " + _cadastro.Sexo;
            lblNascimento.Text = "DATA DE NASCIMENTO: " + _cadastro.DataNascimento.ToShortDateString();
            lblCPF.Text = "CPF: " + _cadastro.Cpf;
            lblTelefone.Text = "TELEFONE: " + _cadastro.Telefone;
            lblEmail.Text = "EMAIL: " + _cadastro.Email;
            lblDataCadastro.Text = "DATA DO CADASTRO: " + _cadastro.DataCadastro.ToShortDateString();
            lblCep.Text = "CEP: " + _cadastro.Endereco.Cep;
            lblNumCasa.Text = "Nº CASA: " + _cadastro.Endereco.NumeroCasa;
            lblRua.Text = "RUA: " + _cadastro.Endereco.Rua;
            lblBairro.Text = "BAIRRO: " + _cadastro.Endereco.Bairro;
            lblCidade.Text = "CIDADE: " + _cadastro.Endereco.Cidade;
            lblEstado.Text = "ESTADO: " + _cadastro.Endereco.Estado;
            if (_cadastro.GetType() == typeof(Cliente))
                lblClassificacao.Text = "CLASSIFICAÇÃO: " + "Cliente";
            else if (_cadastro.GetType() == typeof(Veterinario))
            {
                lblClassificacao.Text = "CLASSIFICAÇÃO: " + "Médico Veterinário";
                AtualizarInfoVeterinario();
            }
            else
            {
                lblClassificacao.Text = "CLASSIFICAÇÃO: " + "Funcionário";
                AtualizarInfoFuncionario();
            }
            AtualizarAnimais();
        }

        private void AtualizarInfoVeterinario()
        {
            Veterinario veterinario = (Veterinario)_cadastro;
            pnlFuncionario.Enabled = false;
            pnlFuncionario.Visible = false;
            pnlVeterinario.Enabled = true;
            pnlVeterinario.Visible = true;

            lblCRMV_Estado.Text = "CRMV: " + veterinario.Crmv + " - " + veterinario.EstadoCrmv;
            lblAreaAtuacao.Text = "ATUAÇÃO: " + veterinario.AreaAtuacao;
            lblEspecializacao.Text = "ESPECIALIZAÇÃO: " + veterinario.Especializacao;
            lblGraduacao.Text = "GRADUAÇÃO: " + veterinario.Graduacao;
            lblInstituicao.Text = "INSTITUIÇÃO: " + veterinario.Faculdade;

            if (veterinario.Mestrado == string.Empty)
                lblMestrado.Text = "MESTRADO: " + "Não informado";
            else
                lblMestrado.Text = "MESTRADO: " + veterinario.Mestrado;

            if (veterinario.Doutorado == string.Empty)
                lblDoutorado.Text = "DOUTORADO: " + "Não informado";
            else
                lblDoutorado.Text = "DOUTORADO: " + veterinario.Doutorado;
        }

        private void AtualizarInfoFuncionario()
        {
            Funcionario funcionario = (Funcionario)_cadastro;
            pnlVeterinario.Enabled = false;
            pnlVeterinario.Visible = false;
            pnlFuncionario.Enabled = true;
            pnlFuncionario.Visible = true;

            lblCargo.Text = "CARGO: " + funcionario.Cargo;
            lblSalario.Text = "SALÁRIO: " + "R$ " + Convert.ToString(funcionario.Salario);
            lblCargaHoraria.Text = "JORNADA: " + Convert.ToString(funcionario.JornadaDeTrabalho) + " horas/semana";
        }

        private void AtualizarAnimais()
        {
            listAnimais.Items.Clear();
            _animalServico = new AnimalServico();
            List<Animal> animais = _animalServico.Buscar(x => x.CadastroID == _cadastro.ID);
            if (animais.Count == 0)
                listAnimais.Items.Add("Nenhum animal cadastrado...");
            else
            {
                foreach (var item in animais)
                {
                    listAnimais.Items.Add(item.Nome + " - " + item.Raca + " - " + item.Especie);
                }
            }
        }

        ////////////////////////////////////// NOVO ANIMAL /////////////////////////////////////////////
        private void BtnNovoAnimal_Click(object sender, EventArgs e)
        {
            PaginaAnimal paginaAnimal = new PaginaAnimal(_cadastro.ID);
            Controles.ManterTamanho(this, paginaAnimal);
            Hide();
            paginaAnimal.ShowDialog();
            Controles.ManterTamanho(paginaAnimal, this);
            CenterToScreen();
            Show();
            AtualizarAnimais();
        }

        ////////////////////////////////////// EDITAR CADASTRO /////////////////////////////////////////////
        private void BtnEditar_Click(object sender, EventArgs e)
        {
            PaginaCadastro paginaCadastro = new PaginaCadastro(_cadastro);
            _cadastroServico = new CadastroServico();
            Controles.ManterTamanho(this, paginaCadastro);
            Hide();
            paginaCadastro.ShowDialog();
            Controles.ManterTamanho(paginaCadastro, this);
            CenterToScreen();
            Show();
            _cadastro = _cadastroServico.Buscar(x => x.ID == _cadastro.ID, "Endereco").FirstOrDefault();
            AtualizarInformacoes();
        }

        ////////////////////////////////////// APAGAR CADASTRO /////////////////////////////////////////////
        private void BtnDeletar_Click(object sender, EventArgs e)
        {
            try
            {
                _contaServico = new ContaServico();
                _animalServico = new AnimalServico();
                if (_contaServico.Buscar(x => x.CadastroID == _cadastro.ID && x.ValorPago < x.Total).Count != 0)
                    throw new AcaoProibidaException("NÃO É POSSÍVEL EXCLUIR UM CADASTRO QUE POSSUI CONTAS PENDENTES!");
                if (_animalServico.Buscar(x => x.CadastroID == _cadastro.ID).Count != 0)
                    throw new AcaoProibidaException("NÃO É POSSÍVEL EXCLUIR UM CADASTRO QUE POSSUI ANIMAIS RELACIONADOS!");
                if (MessageBox.Show("TEM CERTEZA QUE DESEJA APAGAR ESSE REGISTRO?\n\nOBS:\nESSA AÇÃO NÃO PODE SER DESFEITA!", "ATENÇÃO!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    _cadastroServico = new CadastroServico();
                    _cadastroServico.Excluir(_cadastro);
                    MessageBox.Show("CADASTRO APAGADO!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.None);
                    Close();
                }
            }
            catch (AcaoProibidaException erro)
            {
                MessageBox.Show($"ATENÇÃO!\n\n{erro.Message}", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        //////////////////////////////////// FINANCEIRO //////////////////////////////////////////////////////
        ///
        private void BtnFinanceiro_Click(object sender, EventArgs e)
        {
            ExibirFinanceiro exibirFinanceiro = new ExibirFinanceiro();
            exibirFinanceiro.PreencherContasCadastro(_cadastro);
            Controles.ManterTamanho(this, exibirFinanceiro);
            Hide();
            exibirFinanceiro.ShowDialog();
            Controles.ManterTamanho(exibirFinanceiro, this);
            CenterToScreen();
            Show();
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
            this.CenterToScreen();
            AjustarInformacoes();
        }

        //////////////////////////////// MOVER FORM CLICANDO NO CABEÇALHO ///////////////////
        private void Top_MouseDown(object sender, MouseEventArgs e)
        {
            Controles.ReleaseCapture();
            Controles.SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void AjustarInformacoes()
        {
            pnlprincipal.Left = (this.Width - pnlEsquerdo.Width - pnlprincipal.Width) / 2;
            pnlprincipal.Top = (this.Height - Top.Height - pnlprincipal.Height) / 2;
        }
    }
}
