using Interface.Controle;
using Modelo.Excessoes;
using Modelo.Servicos;
using Servico.Geral;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Interface
{
    public partial class ExibirCaixa : Form
    {
        private Conta _conta;
        private ContaServico _contaServico;
        private CaixaServico _caixaServico;

        public ExibirCaixa()
        {
            InitializeComponent();
            _contaServico = new ContaServico();
            _caixaServico = new CaixaServico();
        }

        public void PreencherPagamentosConta(Conta conta)
        {
            _conta = conta;
            pnlDatas.Visible = pnlDatas.Enabled = false;
            PreencherDataGrid(_caixaServico.Buscar(x => x.ContaID == _conta.ContaID));
        }

        private void BtnExibirTodos_Click(object sender, EventArgs e)
        {
            PreencherTodos();
        }

        public void PreencherTodos()
        {
            PreencherDataGrid(_caixaServico.ObterTodos());
        }

        private void BtnPesquisarData_Click_1(object sender, EventArgs e)
        {
            PreencherDataGrid(_caixaServico.Buscar(x => x.Data.Date >= dtInicio.Value.Date && x.Data.Date <= dtFim.Value.Date));
           
        }

        private void PreencherDataGrid(List<Caixa> contas)
        {
            dgvCaixa.Rows.Clear();
            int contLinha = 0, numResultados = 0;
            contas = contas.OrderByDescending(x => x.Data).ToList();
            foreach (var item in contas)
            {
                contLinha = dgvCaixa.Rows.Add();
                dgvCaixa.Rows[contLinha].Cells[0].Value = item.CaixaID;
                dgvCaixa.Rows[contLinha].Cells[1].Value = item.Data.ToShortDateString() + " " + item.Data.ToShortTimeString();
                dgvCaixa.Rows[contLinha].Cells[2].Value = item.Tipo;
                dgvCaixa.Rows[contLinha].Cells[3].Value = item.Categoria;
                dgvCaixa.Rows[contLinha].Cells[4].Value = item.Conta.Cadastro.ToString();
                dgvCaixa.Rows[contLinha].Cells[5].Value = item.Valor;
                dgvCaixa.Rows[contLinha].Cells[6].Value = item.Saldo;
                numResultados++;

                if (item.Tipo == "Entrada")
                    dgvCaixa.Rows[contLinha].DefaultCellStyle.BackColor = Color.DarkCyan;
                else
                    dgvCaixa.Rows[contLinha].DefaultCellStyle.BackColor = Color.Firebrick;
            }
            if(numResultados == 0)
                dgvCaixa.Rows[0].Cells[0].Value = "NENHUM REGISTRO ENCONTRADO...";

            dgvCaixa.AutoResizeColumns();
            dgvCaixa.ClearSelection();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            Caixa caixa = CaixaSelecionado();
            if(caixa != null)
            {
                if (MessageBox.Show("TEM CERTEZA QUE DESEJA APAGAR ESSE REGISTRO?\n\nOBS:\nESSA AÇÃO NÃO PODE SER DESFEITA!\nAPAGAR O REGISTRO NÃO MODIFICA O CAIXA!", "ATENÇÃO!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    _caixaServico.Excluir(caixa);
                    MessageBox.Show("Registro APAGADO!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.None);
                    PreencherTodos();
                }
            }
            
        }

        private Caixa CaixaSelecionado()
        {
            try
            {
                long id = Convert.ToInt64(dgvCaixa.CurrentRow.Cells[0].Value.ToString());
                return _caixaServico.Buscar(x => x.CaixaID == id).FirstOrDefault();
                
            }
            catch (Exception)
            {
                MessageBox.Show("Selecione um registro primeiro primeiro!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.None);
                return null;
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            Caixa caixa = CaixaSelecionado();
            if (caixa != null)
            {
                PaginaCaixa paginaCaixa = new PaginaCaixa(caixa);
                paginaCaixa.ShowDialog();
                if (_conta == null)
                    PreencherTodos();
                else
                    PreencherPagamentosConta(_conta);
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
            dgvCaixa.AutoResizeColumns();
        }

        //////////////////////////////// MOVER FORM CLICANDO NO CABEÇALHO ///////////////////
        private void Top_MouseDown(object sender, MouseEventArgs e)
        {
            Controles.ReleaseCapture();
            Controles.SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void ExibirCaixa_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }
    }
}
