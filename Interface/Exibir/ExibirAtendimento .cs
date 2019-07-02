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
    public partial class ExibirAtendimento : Form
    {
        private AtendimentoServico _atendimentoServico;
        private PaginaAtendimentos _paginaAtendimento;

        public ExibirAtendimento()
        {
            InitializeComponent();
            _atendimentoServico = new AtendimentoServico();
            cbTipo.SelectedItem = "Consulta";
            dtPesquisa.Text = DateTime.Now.ToShortDateString();
            PesquisarData();
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            _paginaAtendimento = new PaginaAtendimentos();
            Controles.ManterTamanho(this, _paginaAtendimento);
            Hide();
            _paginaAtendimento.ShowDialog();
            Controles.ManterTamanho(_paginaAtendimento, this);
            CenterToScreen();
            Show();
            PesquisarData();
        }

        private void BtnExibirTodos_Click(object sender, EventArgs e)
        {
            if(cbTipo.Text == "")
            {
                MessageBox.Show("Informe o tipo de Serviço!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cbTipo.DroppedDown = true;
            }
            else
                PreencherDataGrid(_atendimentoServico.Buscar(x => x.Tipo == cbTipo.Text));
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbTipo.Text == "" || cbCriterio.Text == "" || cbPesquisa.Text == "")
                    MessageBox.Show("UM OU MAIS CAMPOS DA PESQUISA ESTÃO INCOMPLETOS!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else if (cbCriterio.Text == "ID")
                    PreencherDataGrid(_atendimentoServico.Buscar(x => x.AtendimentoID == Convert.ToInt32(cbPesquisa.Text) && x.Tipo == cbTipo.Text));
                else if (cbCriterio.Text == "Paciente")
                    PreencherDataGrid(_atendimentoServico.Buscar(x => (x.Animal.Nome.Contains(cbPesquisa.Text) || x.Animal.Raca.Contains(cbPesquisa.Text) || x.Animal.Especie.Contains(cbPesquisa.Text) || x.Animal.Pedigree.Contains(cbPesquisa.Text)) && x.Tipo == cbTipo.Text));
                else
                    PreencherDataGrid(_atendimentoServico.Buscar(x => (x.Veterinario.Nome.Contains(cbPesquisa.Text) || x.Veterinario.Cpf.Contains(cbPesquisa.Text) || x.Veterinario.Crmv.Contains(cbPesquisa.Text)) && x.Tipo == cbTipo.Text));
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
            PreencherDataGrid(_atendimentoServico.Buscar(x => x.Data.Date == dtPesquisa.Value.Date && x.Tipo == cbTipo.Text));
        }

        private void PreencherDataGrid(List<Atendimento> atendimentos)
        {
            dgvRegistros.Rows.Clear();
            int contLinha = 0, numResultados = 0;
            atendimentos = atendimentos.OrderBy(x => x.Data).ToList();
            foreach (var item in atendimentos)
            {
                Veterinario veterinario = (Veterinario)item.Veterinario;
                contLinha = dgvRegistros.Rows.Add();
                dgvRegistros.Rows[contLinha].Cells[0].Value = item.AtendimentoID;
                dgvRegistros.Rows[contLinha].Cells[1].Value = item.Data.ToShortDateString() + " " + item.Data.ToShortTimeString();
                dgvRegistros.Rows[contLinha].Cells[2].Value = item.Tipo;
                dgvRegistros.Rows[contLinha].Cells[3].Value = item.Animal.ToString();
                dgvRegistros.Rows[contLinha].Cells[4].Value = item.Veterinario.ID + "  -  " + item.Veterinario.Nome +  ",  CRMV:  " + veterinario.Crmv;
                dgvRegistros.Rows[contLinha].Cells[5].Value =  item.ClassificacaoAtendimento;
                numResultados++;
            }
            if(numResultados == 0)
                dgvRegistros.Rows[0].Cells[0].Value = "NENHUM REGISTRO ENCONTRADO... VERIFIQUE OS FILTROS APLICADOS OU A PESQUISA FEITA!";

            dgvRegistros.AutoResizeColumns();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            Atendimento atendimento = AtendimentoSelecionado();
            if (atendimento != null)
            {
                if (MessageBox.Show("TEM CERTEZA QUE DESEJA APAGAR ESSE REGISTRO?\n\nOBS:\nESSA AÇÃO NÃO PODE SER DESFEITA!\nDADOS ASSOCIADOS TAMBÉM SERÃO APAGADOS!", "ATENÇÃO!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    _atendimentoServico.Excluir(atendimento);
                    dgvRegistros.Rows.Clear();
                }
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
                MessageBox.Show("SELECIONE UM CADASTRO PRIMEIRO", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.None);
                return null;
            }
        }


        private void BtnEditar_Click(object sender, EventArgs e)
        {
            Atendimento atendimento = AtendimentoSelecionado();
            if (atendimento != null)
            {
                PaginaAtendimentos paginaAtendimento = new PaginaAtendimentos(atendimento);
                Controles.ManterTamanho(this, paginaAtendimento);
                Hide();
                paginaAtendimento.ShowDialog();
                Controles.ManterTamanho(paginaAtendimento, this);
                CenterToScreen();
                Show();
                dgvRegistros.Rows.Clear();
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
