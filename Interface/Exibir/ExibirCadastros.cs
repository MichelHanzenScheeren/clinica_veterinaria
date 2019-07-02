using Interface.Controle;
using Modelo;
using Modelo.Excessoes;
using Servico.Geral;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Interface
{
    public partial class ExibirCadastros : Form
    {
        private CadastroServico _cadastroServico;
        private bool _associarCadastro = false;
        public ExibirCadastros()
        {
            InitializeComponent();
        }

        private void ExibirCadastros_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            cbTipo.SelectedItem = "Cliente";
        }

        private void BtnNovo_Click_1(object sender, EventArgs e)
        {
            PaginaCadastro paginaCadastro = new PaginaCadastro();
            Controles.ManterTamanho(this, paginaCadastro);
            Hide();
            paginaCadastro.ShowDialog();
            Controles.ManterTamanho(paginaCadastro, this);
            CenterToScreen();
            Show();
        }

        private void BtnExibirTodos_Click(object sender, EventArgs e)
        {
            ExibirTodos();
        }

        private void ExibirTodos()
        {
            _cadastroServico = new CadastroServico();
            if (cbTipo.Text == "Cliente")
                PreencherDataGrid(_cadastroServico.Buscar(x => x.Discriminator == "Cliente", "Endereco"));
            else if (cbTipo.Text == "Veterinario")
                PreencherDataGrid(_cadastroServico.Buscar(x => x.Discriminator == "Veterinario", "Endereco"));
            else
                PreencherDataGrid(_cadastroServico.Buscar(x => x.Discriminator == "Funcionario", "Endereco"));
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbTipo.Text == "" || cbCriterio.Text == "" || cbPesquisa.Text == "")
                    MessageBox.Show("Um ou mais campos da pesquisa estão incompletos!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                    PesquisarAnimal();
            }
            catch (Exception)
            {
                MessageBox.Show("O conteúdo inserido não é válido para a pesquisa!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void PesquisarAnimal()
        {
            _cadastroServico = new CadastroServico();
            if (cbCriterio.Text == "ID")
                PreencherDataGrid(_cadastroServico.Buscar(x => x.ID == Convert.ToInt32(cbPesquisa.Text) && x.Discriminator == cbTipo.Text, "Endereco"));
            else if (cbCriterio.Text == "Nome")
                PreencherDataGrid(_cadastroServico.Buscar(x => x.Nome.Contains(cbPesquisa.Text) && x.Discriminator == cbTipo.Text, "Endereco"));
            else if (cbCriterio.Text == "Endereço")
                PreencherDataGrid(_cadastroServico.Buscar(x => (x.Endereco.Cidade.Contains(cbPesquisa.Text) || x.Endereco.Estado.Contains(cbPesquisa.Text) || x.Endereco.Bairro.Contains(cbPesquisa.Text) || x.Endereco.Rua.Contains(cbPesquisa.Text)) && x.Discriminator == cbTipo.Text, "Endereco"));
            else
                PreencherDataGrid(_cadastroServico.Buscar(x => x.Cpf.Contains(cbPesquisa.Text) && x.Discriminator == cbTipo.Text, "Endereco"));
        }

        private void PreencherDataGrid(List<Cadastro> cadastros)
        {
            dgvCadastros.Rows.Clear();
            int contLinha = 0, numResultados = 0;
            foreach (var item in cadastros)
            {
                contLinha = dgvCadastros.Rows.Add();
                dgvCadastros.Rows[contLinha].Cells[0].Value = item.ID;
                dgvCadastros.Rows[contLinha].Cells[1].Value = item.Nome;
                dgvCadastros.Rows[contLinha].Cells[2].Value = item.Cpf;
                dgvCadastros.Rows[contLinha].Cells[3].Value = item.Endereco.Rua + ", " + item.Endereco.NumeroCasa + ". " + item.Endereco.Cidade + " - " + item.Endereco.Estado;
                dgvCadastros.Rows[contLinha].Cells[4].Value = item.Telefone;
                numResultados++;
            }
            if(numResultados == 0)
                dgvCadastros.Rows[0].Cells[0].Value = "NENHUM REGISTRO ENCONTRADO...";

            dgvCadastros.AutoResizeColumns();
        }

        private Cadastro CadastroSelecionado()
        {
            try
            {
                int id = Convert.ToInt32(dgvCadastros.CurrentRow.Cells[0].Value.ToString());
                _cadastroServico = new CadastroServico();
                return _cadastroServico.Buscar(x => x.ID == Convert.ToInt32(id) && x.Discriminator == cbTipo.Text, "Endereco").FirstOrDefault();
            }
            catch (Exception)
            {
                MessageBox.Show("Selecione um cadastro primeiro!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.None);
                return null;
            }
        }

        ////////////////////////////////////// INFORMAÇÕES /////////////////////////////////////////////
        private void BtnInformacoes_Click(object sender, EventArgs e)
        {
            Cadastro cadastro = CadastroSelecionado();
            if(cadastro != null)
            {
                InformacoesCadastro informacoesCadastro = new InformacoesCadastro(cadastro);
                informacoesCadastro.AtualizarInformacoes();
                Controles.ManterTamanho(this, informacoesCadastro);
                Hide();
                informacoesCadastro.ShowDialog();
                Controles.ManterTamanho(informacoesCadastro, this);
                CenterToScreen();
                Show();
                dgvCadastros.Rows.Clear();
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
            dgvCadastros.AutoResizeColumns();
        }
        //////////////////////////////// MOVER FORM CLICANDO NO CABEÇALHO ///////////////////
        private void Top_MouseDown(object sender, MouseEventArgs e)
        {
            Controles.ReleaseCapture();
            Controles.SendMessage(Handle, 0x112, 0xf012, 0);
        }

    }
}
