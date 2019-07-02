using Interface.Controle;
using Modelo;
using Modelo.Excessoes;
using Modelo.Servicos;
using Servico.Geral;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace Interface
{
    public partial class ExibirProntuario : Form
    {
        private Animal _animal;
        private AtendimentoServico _atendimentoServico;
        private InternamentoServico _internamentoServico;
        private ReceitaServico _receitaServico;

        public ExibirProntuario(Animal animal)
        {
            InitializeComponent();
            _animal = animal;
            cbTipo.SelectedItem = "Todos";
            _atendimentoServico = new AtendimentoServico();
            _internamentoServico = new InternamentoServico();
            _receitaServico = new ReceitaServico();
            ExibirTodos();
        }

        private void ExibirTodos()
        {
            LimaprDataGrid();
            PreencherDataGridAtendimentos(_atendimentoServico.Buscar(x => x.AnimalID == _animal.AnimalID));
            PreencherDataGridInternamentos(_internamentoServico.Buscar(x => x.AnimalID == _animal.AnimalID));
            PreencherDataGridReceita(_receitaServico.Buscar(x => x.AnimalID == _animal.AnimalID));
            RedimensioarDataGrid();
            OrdenarDataGrid();
        }

        private void BtnExibirTodos_Click(object sender, EventArgs e)
        {
            LimaprDataGrid();
            if (cbTipo.Text == "Todos")
                ExibirTodos();
            else if(cbTipo.Text == "Cirurgias")
                PreencherDataGridAtendimentos(_atendimentoServico.Buscar(x => x.AnimalID == _animal.AnimalID && x.Tipo == "Cirurgia"));
            else if (cbTipo.Text == "Consultas")
                PreencherDataGridAtendimentos(_atendimentoServico.Buscar(x => x.AnimalID == _animal.AnimalID && x.Tipo == "Consulta"));
            else if (cbTipo.Text == "Exames")
                PreencherDataGridAtendimentos(_atendimentoServico.Buscar(x => x.AnimalID == _animal.AnimalID && x.Tipo == "Exame"));
            else if (cbTipo.Text == "Internamentos")
                PreencherDataGridInternamentos(_internamentoServico.Buscar(x => x.AnimalID == _animal.AnimalID));
            else if (cbTipo.Text == "Medicamentos")
                PreencherDataGridReceita(_receitaServico.Buscar(x => x.AnimalID == _animal.AnimalID));
            else
                PreencherDataGridAtendimentos(_atendimentoServico.Buscar(x => x.AnimalID == _animal.AnimalID && x.Tipo == "Vacina"));

            RedimensioarDataGrid();
            OrdenarDataGrid();
        }

        private void BtnPesquisarData_Click(object sender, EventArgs e)
        {

            LimaprDataGrid();
            if (cbTipo.Text == "Todos")
            {
                PreencherDataGridAtendimentos(_atendimentoServico.Buscar(x => x.AnimalID == _animal.AnimalID && x.Data.Date == dtPesquisa.Value.Date));
                PreencherDataGridInternamentos(_internamentoServico.Buscar(x => x.AnimalID == _animal.AnimalID && x.DataEntrada.Date == dtPesquisa.Value.Date));
                PreencherDataGridReceita(_receitaServico.Buscar(x => x.AnimalID == _animal.AnimalID && x.Data.Date == dtPesquisa.Value.Date));
            }
            else if (cbTipo.Text == "Cirurgias")
                PreencherDataGridAtendimentos(_atendimentoServico.Buscar(x => x.AnimalID == _animal.AnimalID && x.Tipo == "Cirurgia" && x.Data.Date == dtPesquisa.Value.Date));
            else if (cbTipo.Text == "Consultas")
                PreencherDataGridAtendimentos(_atendimentoServico.Buscar(x => x.AnimalID == _animal.AnimalID && x.Tipo == "Consulta" && x.Data.Date == dtPesquisa.Value.Date));
            else if (cbTipo.Text == "Exames")
                PreencherDataGridAtendimentos(_atendimentoServico.Buscar(x => x.AnimalID == _animal.AnimalID && x.Tipo == "Exame" && x.Data.Date == dtPesquisa.Value.Date));
            else if (cbTipo.Text == "Internamentos")
                PreencherDataGridInternamentos(_internamentoServico.Buscar(x => x.AnimalID == _animal.AnimalID && x.DataEntrada.Date == dtPesquisa.Value.Date));
            else if (cbTipo.Text == "Medicamentos")
                PreencherDataGridReceita(_receitaServico.Buscar(x => x.AnimalID == _animal.AnimalID && x.Data.Date == dtPesquisa.Value.Date));
            else
                PreencherDataGridAtendimentos(_atendimentoServico.Buscar(x => x.AnimalID == _animal.AnimalID && x.Tipo == "Vacina" && x.Data.Date == dtPesquisa.Value.Date));

            RedimensioarDataGrid();
            OrdenarDataGrid();
        }

        private void LimaprDataGrid()
        {
            dgvRegistros.Rows.Clear();
        }

        private void RedimensioarDataGrid()
        {
            dgvRegistros.AutoResizeColumns();
        }

        private void OrdenarDataGrid()
        {
            dgvRegistros.Sort(dgvRegistros.Columns[1], ListSortDirection.Descending);
        }

        private void PreencherDataGridAtendimentos(List<Atendimento> atendimentos)
        {
            int contLinha = 0;
            foreach (var item in atendimentos)
            {
                contLinha = dgvRegistros.Rows.Add();
                dgvRegistros.Rows[contLinha].Cells[0].Value = item.AtendimentoID;
                dgvRegistros.Rows[contLinha].Cells[1].Value = item.Data.ToShortDateString() + " " + item.Data.ToShortTimeString();
                dgvRegistros.Rows[contLinha].Cells[2].Value = item.Tipo + "  -  " + item.ClassificacaoAtendimento;
                dgvRegistros.Rows[contLinha].Cells[3].Value = item.Resumo;
                dgvRegistros.Rows[contLinha].Cells[4].Value = item.Conclusoes;

            }
        }

        private void PreencherDataGridInternamentos(List<Internamento> internamentos)
        {
            int contLinha = 0;
            foreach (var item in internamentos)
            {
                contLinha = dgvRegistros.Rows.Add();
                dgvRegistros.Rows[contLinha].Cells[0].Value = item.InternamentoID;
                dgvRegistros.Rows[contLinha].Cells[1].Value = item.DataEntrada.ToShortDateString() + " " + item.DataEntrada.ToShortTimeString();
                dgvRegistros.Rows[contLinha].Cells[2].Value = "Internamento";
                dgvRegistros.Rows[contLinha].Cells[3].Value = item.Resumo;
                dgvRegistros.Rows[contLinha].Cells[4].Value = item.Conclusoes;
            }
        }

        private void PreencherDataGridReceita(List<Receita> receitas)
        {
            int contLinha = 0;
            foreach (var item in receitas)
            {
                contLinha = dgvRegistros.Rows.Add();
                dgvRegistros.Rows[contLinha].Cells[0].Value = item.ReceitaID;
                dgvRegistros.Rows[contLinha].Cells[1].Value = item.Data.ToShortDateString() + " " + item.Data.ToShortTimeString();
                dgvRegistros.Rows[contLinha].Cells[2].Value = "Receita de Medicamento";
                dgvRegistros.Rows[contLinha].Cells[3].Value = item.Dose + " de " + item.IntervaloDose + " em " + item.IntervaloDose + " horas durante " + item.TempoTratamento + " dias.";
            }
        }




        private void BtnMaisInformacoes_Click(object sender, EventArgs e)
        {
            string Servico = TipoSelecionado();
            if(Servico == "Internamento")
            {
                Internamento internamento = InternamentoSelecionado();
                if(internamento!= null)
                {
                    PaginaInternamento paginaInternamento = new PaginaInternamento(internamento);
                    Hide();
                    paginaInternamento.ShowDialog();
                    Show();

                }
            }
            else if(Servico == "Receita de Medicamento")
            {
                Receita receita = ReceitaSelecionada();
                if(receita != null)
                {
                    PaginaReceita paginaReceita = new PaginaReceita(receita);
                    Hide();
                    paginaReceita.ShowDialog();
                    Show();
                }
            }
            else
            {
                Atendimento atendimento = AtendimentoSelecionado();
                if(atendimento != null)
                {
                    PaginaAtendimentos paginaAtendimento = new PaginaAtendimentos(atendimento);
                    Hide();
                    paginaAtendimento.ShowDialog();
                    Show();
                    dgvRegistros.Rows.Clear();
                }
            }
            ExibirTodos();
        }

        private string TipoSelecionado()
        {
            try
            {
                string tipo = dgvRegistros.CurrentRow.Cells[2].Value.ToString();
                return tipo;
            }
            catch (Exception)
            {
                MessageBox.Show("Selecione um Registro primeiro!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.None);
                return null;
            }
        }

        private Internamento InternamentoSelecionado()
        {
            try
            {
                int id = Convert.ToInt32(dgvRegistros.CurrentRow.Cells[0].Value.ToString());
                return _internamentoServico.Buscar(x => x.InternamentoID == Convert.ToInt32(id)).FirstOrDefault();
            }
            catch (Exception)
            {
                MessageBox.Show("Selecione um Registro primeiro!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.None);
                return null;
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
                MessageBox.Show("Selecione um Registro primeiro!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.None);
                return null;
            }
        }

        private Atendimento AtendimentoSelecionado()
        {
            try
            {
                int id = Convert.ToInt32(dgvRegistros.CurrentRow.Cells[0].Value.ToString());
                return _atendimentoServico.Buscar(x => x.AtendimentoID == Convert.ToInt32(id)).FirstOrDefault();
            }
            catch (Exception)
            {
                MessageBox.Show("Selecione um Registro primeiro!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.None);
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
            dgvRegistros.AutoResizeColumns();
        }

        //////////////////////////////// MOVER FORM CLICANDO NO CABEÇALHO ///////////////////
        private void Top_MouseDown(object sender, MouseEventArgs e)
        {
            Controles.ReleaseCapture();
            Controles.SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void ExibirAtendimento_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }
    }
}
