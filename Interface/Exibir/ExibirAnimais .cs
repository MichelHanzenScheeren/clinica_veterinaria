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
    public partial class ExibirAnimais : Form
    {
        private AnimalServico _animalServico;

        public ExibirAnimais()
        {
            InitializeComponent();
        }
        private void ExibirAnimais_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            PaginaAnimal paginaAnimal = new PaginaAnimal();
            Controles.ManterTamanho(this, paginaAnimal);
            Hide();
            paginaAnimal.ShowDialog();
            Controles.ManterTamanho(paginaAnimal, this);
            CenterToScreen();
            Show();
        }

        private void BtnExibirTodos_Click(object sender, EventArgs e)
        {
            ExibirTodos();
        }

        private void ExibirTodos()
        {
            _animalServico = new AnimalServico();
            PreencherDataGrid(_animalServico.ObterTodos());
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbCriterio.Text == "" || cbPesquisa.Text == "")
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
            _animalServico = new AnimalServico();
            if (cbCriterio.Text == "ID")
                PreencherDataGrid(_animalServico.Buscar(x => x.AnimalID == Convert.ToInt32(cbPesquisa.Text), "Cadastro"));
            else if (cbCriterio.Text == "Nome")
                PreencherDataGrid(_animalServico.Buscar(x => x.Nome.Contains(cbPesquisa.Text), "Cadastro"));
            else if (cbCriterio.Text == "Raça")
                PreencherDataGrid(_animalServico.Buscar(x => x.Raca.Contains(cbPesquisa.Text), "Cadastro"));
            else if (cbCriterio.Text == "Espécie")
                PreencherDataGrid(_animalServico.Buscar(x => x.Especie.Contains(cbPesquisa.Text), "Cadastro"));
            else
                PreencherDataGrid(_animalServico.Buscar(x => x.Cadastro.Nome.Contains(cbPesquisa.Text), "Cadastro"));
        }

        private void PreencherDataGrid(List<Animal> animais)
        {
            dgvCadastros.Rows.Clear();
            int contLinha = 0, numResultados = 0;
            foreach (var item in animais)
            {
                contLinha = dgvCadastros.Rows.Add();
                dgvCadastros.Rows[contLinha].Cells[0].Value = item.AnimalID;
                dgvCadastros.Rows[contLinha].Cells[1].Value = item.Nome;
                dgvCadastros.Rows[contLinha].Cells[2].Value = item.Especie;
                dgvCadastros.Rows[contLinha].Cells[3].Value = item.Raca;
                dgvCadastros.Rows[contLinha].Cells[4].Value = item.CadastroID+ " - " + item.Cadastro.Nome + ". " + item.Cadastro.Cpf ;
                numResultados++;
            }
            if(numResultados == 0)
                dgvCadastros.Rows[0].Cells[0].Value = "NENHUM REGISTRO ENCONTRADO...";

            dgvCadastros.AutoResizeColumns();
        }

        private void BtnInformacoes_Click(object sender, EventArgs e)
        {
            Animal animal = AnimalSelecionado();
            if (animal != null)
            {
                InformacoesAnimal informacoesAnimal = new InformacoesAnimal(animal);
                informacoesAnimal.AtualizarInformacoes();
                Controles.ManterTamanho(this, informacoesAnimal);
                Hide();
                informacoesAnimal.ShowDialog();
                Controles.ManterTamanho(informacoesAnimal, this);
                CenterToScreen();
                Show();
                dgvCadastros.Rows.Clear();
            }
        }

        private Animal AnimalSelecionado()
        {
            try
            {
                int id = Convert.ToInt32(dgvCadastros.CurrentRow.Cells[0].Value.ToString());
                _animalServico = new AnimalServico();
                return _animalServico.Buscar(x => x.AnimalID == Convert.ToInt32(id), "Cadastro").FirstOrDefault();
            }
            catch (Exception)
            {
                MessageBox.Show("Selecione um animal primeiro!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.None);
                return null;
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
