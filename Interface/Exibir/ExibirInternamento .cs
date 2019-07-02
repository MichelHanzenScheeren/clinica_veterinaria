using Interface.Controle;
using Modelo.Excessoes;
using Modelo.Servicos;
using Servico.Geral;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Interface
{
    public partial class ExibirInternamento : Form
    {
        private InternamentoServico _internamentoServico;
        private PaginaInternamento _paginaInternamento;

        public ExibirInternamento()
        {
            InitializeComponent();
            _internamentoServico = new InternamentoServico();
            cbTipo.SelectedItem = "Internados";
            ExibirTodos();
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            _paginaInternamento = new PaginaInternamento();
            Controles.ManterTamanho(this, _paginaInternamento);
            Hide();
            _paginaInternamento.ShowDialog();
            Controles.ManterTamanho(_paginaInternamento, this);
            CenterToScreen();
            Show();
            ExibirTodos();
        }

        private void BtnExibirTodos_Click(object sender, EventArgs e)
        {
            ExibirTodos();
        }

        private void ExibirTodos()
        {

            if (cbTipo.Text == "Internados")
                PreencherDataGrid(_internamentoServico.Buscar(x => x.DataSaida == null));
            else if(cbTipo.Text == "Liberados")
                PreencherDataGrid(_internamentoServico.Buscar(x => x.DataSaida != null));
            else
                PreencherDataGrid(_internamentoServico.ObterTodos());
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (cbCriterio.Text == "" || cbPesquisa.Text == "")
                    MessageBox.Show("UM OU MAIS CAMPOS DE PESQUISA ESTÃO INCOMPLETOS!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                    PesquisarInternamentos();
            }
            catch (Exception)
            {
                MessageBox.Show("O CONTEÚDO INSERIDO NÃO É VÁLIDO PARA PESQUISA!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void PesquisarInternamentos()
        {
            if (cbTipo.Text == "Todos")
            {
                if (cbCriterio.Text == "ID")
                    PreencherDataGrid(_internamentoServico.Buscar(x => x.InternamentoID == Convert.ToInt32(cbPesquisa.Text)));
                else if (cbCriterio.Text == "Paciente")
                    PreencherDataGrid(_internamentoServico.Buscar(x => x.Animal.Nome.Contains(cbPesquisa.Text)));
                else
                    PreencherDataGrid(_internamentoServico.Buscar(x => x.NumeroQuarto == Convert.ToInt32(cbPesquisa.Text)));
            }  
            else if(cbTipo.Text == "Internados")
            {
                if (cbCriterio.Text == "ID")
                    PreencherDataGrid(_internamentoServico.Buscar(x => x.InternamentoID == Convert.ToInt32(cbPesquisa.Text) && x.DataSaida == null));
                else if (cbCriterio.Text == "Paciente")
                    PreencherDataGrid(_internamentoServico.Buscar(x => x.Animal.Nome.Contains(cbPesquisa.Text) && x.DataSaida == null));
                else
                    PreencherDataGrid(_internamentoServico.Buscar(x => x.NumeroQuarto == Convert.ToInt32(cbPesquisa.Text) && x.DataSaida == null));
            }
            else
            {
                if (cbCriterio.Text == "ID")
                    PreencherDataGrid(_internamentoServico.Buscar(x => x.InternamentoID == Convert.ToInt32(cbPesquisa.Text) && x.DataSaida != null));
                else if (cbCriterio.Text == "Paciente")
                    PreencherDataGrid(_internamentoServico.Buscar(x => x.Animal.Nome.Contains(cbPesquisa.Text) && x.DataSaida != null));
                else
                    PreencherDataGrid(_internamentoServico.Buscar(x => x.NumeroQuarto == Convert.ToInt32(cbPesquisa.Text) && x.DataSaida != null));
            }
        }

        private void BtnPesquisarData_Click(object sender, EventArgs e)
        {
            if(cbTipo.Text == "Todos")
                PreencherDataGrid(_internamentoServico.Buscar(x => x.DataEntrada.Date == dtPesquisa.Value.Date));
            else if(cbTipo.Text == "Internados")
                PreencherDataGrid(_internamentoServico.Buscar(x => x.DataEntrada.Date == dtPesquisa.Value.Date && x.DataSaida == null));
            else
                PreencherDataGrid(_internamentoServico.Buscar(x => x.DataEntrada.Date == dtPesquisa.Value.Date && x.DataSaida != null));
        }

        private void PreencherDataGrid(List<Internamento> internamentos)
        {
            dgvRegistros.Rows.Clear();
            int contLinha = 0, numResultados = 0;
            internamentos = internamentos.OrderByDescending(x => x.DataEntrada).ToList();
            foreach (var item in internamentos)
            {
                contLinha = dgvRegistros.Rows.Add();
                dgvRegistros.Rows[contLinha].Cells[0].Value = item.InternamentoID;
                dgvRegistros.Rows[contLinha].Cells[1].Value = item.DataEntrada.ToShortDateString() + " " + item.DataEntrada.ToShortTimeString();
                if(item.DataSaida != null)
                {
                    DateTime saida = Convert.ToDateTime(item.DataSaida);
                    dgvRegistros.Rows[contLinha].Cells[2].Value = saida.ToShortDateString() + " " + saida.ToShortTimeString();
                }
                else
                {
                    dgvRegistros.Rows[contLinha].Cells[2].Value = "INTERNADO";
                }
                dgvRegistros.Rows[contLinha].Cells[3].Value = item.Animal.AnimalID + " - " + item.Animal.Nome + ". " + item.Animal.Raca + ", " + item.Animal.Especie;
                dgvRegistros.Rows[contLinha].Cells[4].Value = item.NumeroQuarto;
                numResultados++;
            }
            if(numResultados == 0)
                dgvRegistros.Rows[0].Cells[0].Value = "NENHUM REGISTRO ENCONTRADO... VERIFIQUE O FILTRO E/OU A PESQUISA";

            dgvRegistros.AutoResizeColumns();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            Internamento internamento = AgendamentoSelecionado();
            if (internamento != null)
            {
                if (MessageBox.Show("TEM CERTEZA QUE DESEJA APAGAR ESSE REGISTRO?\n\nOBS:\nESSA AÇÃO NÃO PODE SER DESFEITA!\nDADOS ASSOCIADOS TAMBÉM SERÃO APAGADOS!", "ATENÇÃO!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    _internamentoServico.Excluir(internamento);
                    MessageBox.Show("REGISTRO APAGADO!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.None);
                    ExibirTodos();
                }
            }
        }

        private Internamento AgendamentoSelecionado()
        {
            try
            {
                int id = Convert.ToInt32(dgvRegistros.CurrentRow.Cells[0].Value.ToString());
                return _internamentoServico.Buscar(x => x.InternamentoID == Convert.ToInt32(id)).FirstOrDefault();
            }
            catch (Exception)
            {
                MessageBox.Show("SELECIONE UM REGISTRO PRIMEIRO!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.None);
                return null;
            }
        }

        private void BtnInformacoes_Click(object sender, EventArgs e)
        {
            Internamento internamento = AgendamentoSelecionado();
            if(internamento != null)
            {
                PaginaInternamento paginaInternamento = new PaginaInternamento(internamento);
                Controles.ManterTamanho(this, paginaInternamento);
                Hide();
                paginaInternamento.ShowDialog();
                Controles.ManterTamanho(paginaInternamento, this);
                CenterToScreen();
                Show();
                ExibirTodos();
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

        private void ExibirInternamento_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }
    }
}
