using Interface.Controle;
using Modelo.Cadastros;
using Modelo.Excessoes;
using Modelo.Servicos;
using Servico.Geral;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Interface
{
    public partial class ExibirReceita : Form
    {
        private ReceitaServico _receitaServico;

        public ExibirReceita()
        {
            InitializeComponent();
            _receitaServico = new ReceitaServico();
            PesquisarData();
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            PaginaReceita paginaReceita = new PaginaReceita();
            Controles.ManterTamanho(this, paginaReceita);
            Hide();
            paginaReceita.ShowDialog();
            Controles.ManterTamanho(paginaReceita, this);
            CenterToScreen();
            Show();
            PesquisarData();
        }

        private void BtnExibirTodos_Click_1(object sender, EventArgs e)
        {
            PreencherDataGrid(_receitaServico.ObterTodos());
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbCriterio.Text == "" || cbPesquisa.Text == "")
                    MessageBox.Show("UM OU MAIS CAMPOS DA PESQUISA ESTÃO INCOMPLETOS!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else if (cbCriterio.Text == "ID")
                    PreencherDataGrid(_receitaServico.Buscar(x => x.ReceitaID == Convert.ToInt32(cbPesquisa.Text)));
                else if (cbCriterio.Text == "Paciente")
                    PreencherDataGrid(_receitaServico.Buscar(x => (x.Animal.Nome.Contains(cbPesquisa.Text) || x.Animal.Raca.Contains(cbPesquisa.Text) || x.Animal.Especie.Contains(cbPesquisa.Text) || x.Animal.Pedigree.Contains(cbPesquisa.Text))));
                else if(cbCriterio.Text == "Veterinário")
                    PreencherDataGrid(_receitaServico.Buscar(x => (x.Veterinario.Nome.Contains(cbPesquisa.Text) || x.Veterinario.Cpf.Contains(cbPesquisa.Text) || x.Veterinario.Crmv.Contains(cbPesquisa.Text))));
                else
                    PreencherDataGrid(_receitaServico.Buscar(x => (x.Medicamento.Nome.Contains(cbPesquisa.Text) || x.Medicamento.Classificacao.Contains(cbPesquisa.Text) || x.Medicamento.Tipo.Contains(cbPesquisa.Text))));
            }
            catch (Exception)
            {
                MessageBox.Show("O CONTEÚDO INSERIDO NÃO É VÁLIDO PARA A PESQUISA!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void BtnPesquisarData_Click(object sender, EventArgs e)
        {
            PesquisarData();
        }

        private void PesquisarData()
        {
            PreencherDataGrid(_receitaServico.Buscar(x => x.Data.Date == dtPesquisa.Value.Date));
        }

        private void PreencherDataGrid(List<Receita> receitas)
        {
            dgvRegistros.Rows.Clear();
            int contLinha = 0, numResultados = 0;
            foreach (var item in receitas)
            {
                Veterinario veterinario = (Veterinario)item.Veterinario;
                contLinha = dgvRegistros.Rows.Add();
                dgvRegistros.Rows[contLinha].Cells[0].Value = item.ReceitaID;
                dgvRegistros.Rows[contLinha].Cells[1].Value = item.Data.ToShortDateString() + " " + item.Data.ToShortTimeString();
                dgvRegistros.Rows[contLinha].Cells[2].Value = item.Animal.ToString();
                dgvRegistros.Rows[contLinha].Cells[3].Value = item.Veterinario.ID + "  -  " + item.Veterinario.Nome +  ",  CRMV:  " + veterinario.Crmv;
                dgvRegistros.Rows[contLinha].Cells[4].Value =  item.Medicamento.Nome;
                dgvRegistros.Rows[contLinha].Cells[5].Value = item.Dose + " de " + item.IntervaloDose + " em " + item.IntervaloDose + " hora(s) durante " + item.TempoTratamento + " dia(s).";
                numResultados++;
            }
            if(numResultados == 0)
                dgvRegistros.Rows[0].Cells[0].Value = "NENHUM REGISTRO ENCONTRADO... VERIFIQUE OS FILTROS APLICADOS OU A PESQUISA FEITA";

            dgvRegistros.AutoResizeColumns();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            Receita receita = ReceitaSelecionada();
            if (receita != null)
            {
                if (MessageBox.Show("TEM CERTEZA QUE DESEJA APAGAR ESSE REGISTRO?\n\nOBS:\nESSA AÇÃO NÃO PODE SER DESFEITA!\nDADOS ASSOCIADOS TAMBÉM SERÃO APAGADOS!", "ATENÇÃO!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    _receitaServico.Excluir(receita);
                    PesquisarData();
                }
            }
        }

        private Receita ReceitaSelecionada()
        {
            try
            {
                int id = Convert.ToInt32(dgvRegistros.CurrentRow.Cells[0].Value.ToString());
                return _receitaServico.Buscar(x => x.ReceitaID == Convert.ToInt32(id)).FirstOrDefault();
            }
            catch (Exception)
            {
                MessageBox.Show("SELECIONE UM REGISTRO PRIMEIRO!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.None);
                return null;
            }
        }


        private void BtnEditar_Click(object sender, EventArgs e)
        {
            Receita receita = ReceitaSelecionada();
            if (receita != null)
            {
                PaginaReceita paginaReceita = new PaginaReceita(receita);
                Controles.ManterTamanho(this, paginaReceita);
                Hide();
                paginaReceita.ShowDialog();
                Controles.ManterTamanho(paginaReceita, this);
                CenterToScreen();
                Show();
                PesquisarData();
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
            dgvRegistros.AutoResizeColumns();
        }

        //////////////////////////////// MOVER FORM CLICANDO NO CABEÇALHO ///////////////////
        private void Top_MouseDown(object sender, MouseEventArgs e)
        {
            Controles.ReleaseCapture();
            Controles.SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void ExibirReceita_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }
    }
}
