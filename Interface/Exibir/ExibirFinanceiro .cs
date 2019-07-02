using Interface.Controle;
using Modelo;
using Modelo.Excessoes;
using Modelo.Servicos;
using Servico.Geral;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Interface
{
    public partial class ExibirFinanceiro : Form
    {
        private ContaServico _contaServico;
        public ExibirFinanceiro()
        {
            InitializeComponent();
            _contaServico = new ContaServico();
            cbTipo.SelectedItem = "ABERTAS";
            ExibirTodas();
        }

        private void BtnNovoPagamento_Click(object sender, EventArgs e)
        {
            Conta conta = ContaSelecionada();
            if(conta != null)
            {
                PaginaCaixa paginaCaixa = new PaginaCaixa(conta);
                paginaCaixa.ShowDialog();
                ExibirTodas();
            }
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                Conta conta = ContaSelecionada();
                if (conta != null && MessageBox.Show("TEM CERTEZA QUE DESEJA APAGAR ESSE REGISTRO?\n\nOBS:\nESSA AÇÃO NÃO PODE SER DESFEITA!\nOUTROS DADOS, INCLUINDO PAGAMENTOS E REGISTROS SOBRE SERVIÇOS RELACIONADOS A ESSA CONTA TAMBÉM SERÃO PERDIDOS!", "ATENÇÃO!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                   
                    InternamentoServico internamentoServico = new InternamentoServico();
                    foreach (var item in internamentoServico.Buscar(x => x.ContaID == conta.ContaID))
                    {
                        internamentoServico.Excluir(item);
                    }
                    AtendimentoServico atendimentoServico = new AtendimentoServico();
                    foreach( var item in atendimentoServico.Buscar(x => x.ContaID == conta.ContaID))
                    {
                        atendimentoServico.Excluir(item);
                    }
                    _contaServico.Excluir(conta);
                    MessageBox.Show("CONTA APAGADA!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.None);
                    ExibirTodas();
                }
            }
            catch (AcaoProibidaException erro)
            {
                MessageBox.Show($"ATENÇÃO!\n\n{erro.Message}", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }

        private Conta ContaSelecionada()
        {
            try
            {
                long id = Convert.ToInt64(dgvContas.CurrentRow.Cells[0].Value.ToString());
                return _contaServico.Buscar(x => x.ContaID == id).FirstOrDefault();

            }
            catch (Exception)
            {
                MessageBox.Show("Selecione uma conta primeiro!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.None);
                return null;
            }
        }

        private void BtnExibirTodos_Click(object sender, EventArgs e)
        {
            ExibirTodas();
        }
        private void ExibirTodas()
        {
            if (cbTipo.Text == "TODAS")
                PreencherDataGridContas(_contaServico.ObterTodos());
            else if (cbTipo.Text == "ABERTAS")
                PreencherDataGridContas(_contaServico.Buscar(x => x.Total > x.ValorPago));
            else if (cbTipo.Text == "VENCIDAS")
                PreencherDataGridContas(_contaServico.Buscar(x => x.Total > x.ValorPago && x.Data_Vencimento < DateTime.Now));
            else
                PreencherDataGridContas(_contaServico.Buscar(x => x.Total == x.ValorPago));
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbCriterio.Text == "" || cbPesquisa.Text == "")
                    MessageBox.Show("Um ou mais campos da pesquisa estão incompletos!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else if (cbCriterio.Text == "ID")
                    PreencherDataGridContas(_contaServico.Buscar(x => x.ContaID == Convert.ToInt64(cbPesquisa.Text)));
                else if (cbCriterio.Text == "CLIENTE")
                    PreencherDataGridContas(_contaServico.Buscar(x => x.Cadastro.Nome.Contains(cbPesquisa.Text) || x.Cadastro.Cpf.Contains(cbPesquisa.Text)));
            }
            catch (Exception)
            {
                MessageBox.Show("O conteúdo inserido não é válido para a pesquisa!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void BtnPesquisarData_Click(object sender, EventArgs e)
        {
            PreencherDataGridContas(_contaServico.Buscar(x => x.Data_Inicio.Date == dtPesquisa.Value.Date));
        }

        private void PreencherDataGridContas(List<Conta> contas)
        {
            dgvContas.Rows.Clear();
            int contLinha = 0, numResultados = 0;
            contas = contas.OrderByDescending(x => x.Data_Inicio).ToList();
            foreach (var item in contas)
            {
                contLinha = dgvContas.Rows.Add();
                dgvContas.Rows[contLinha].Cells[0].Value = item.ContaID;
                dgvContas.Rows[contLinha].Cells[1].Value = item.Data_Inicio.ToShortDateString() + " " + item.Data_Inicio.ToShortTimeString();
                dgvContas.Rows[contLinha].Cells[2].Value = item.Data_Vencimento.ToShortDateString();
                dgvContas.Rows[contLinha].Cells[3].Value = item.Tipo;
                dgvContas.Rows[contLinha].Cells[4].Value = item.Categoria;
                dgvContas.Rows[contLinha].Cells[5].Value = item.Cadastro.ToString();
                dgvContas.Rows[contLinha].Cells[6].Value = item.Total;
                dgvContas.Rows[contLinha].Cells[7].Value = item.ValorPago;
                numResultados++;

                if (item.Tipo == "Entrada")
                    dgvContas.Rows[contLinha].DefaultCellStyle.BackColor = Color.DarkCyan;
                else
                    dgvContas.Rows[contLinha].DefaultCellStyle.BackColor = Color.Firebrick;
            }
            if(numResultados == 0)
                dgvContas.Rows[0].Cells[0].Value = "NENHUM REGISTRO ENCONTRADO...";

            dgvContas.AutoResizeColumns();
            dgvContas.ClearSelection();
        }



        private void BtnPagamentos_Click(object sender, EventArgs e)
        {
            Conta conta = ContaSelecionada();
            if (conta != null)
            {
                ExibirCaixa exibirCaixa = new ExibirCaixa();
                exibirCaixa.PreencherPagamentosConta(conta);
                Controles.ManterTamanho(this, exibirCaixa);
                Hide();
                exibirCaixa.ShowDialog();
                Controles.ManterTamanho(exibirCaixa, this);
                CenterToScreen();
                Show();
                ExibirTodas();
            }
        }

        private void BtnCaixa_Click(object sender, EventArgs e)
        {
            ExibirCaixa exibirCaixa = new ExibirCaixa();
            exibirCaixa.PreencherTodos();
            Controles.ManterTamanho(this, exibirCaixa);
            Hide();
            exibirCaixa.ShowDialog();
            Controles.ManterTamanho(exibirCaixa, this);
            CenterToScreen();
            Show();
            ExibirTodas();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            Conta conta = ContaSelecionada();
            if(conta != null)
            {
                PaginaConta paginaConta = new PaginaConta(conta);
                paginaConta.ShowDialog();
                ExibirTodas();

            }
        }

        private void BtnNovaConta_Click(object sender, EventArgs e)
        {
            PaginaConta paginaConta = new PaginaConta();
            paginaConta.ShowDialog();
        }

        ////////////////////////////////// FINANCEIRO DO CADASTRO //////////////////////////////////////////

        public void PreencherContasCadastro(Cadastro cadastro)
        {
            PreencherDataGridContas(_contaServico.Buscar(x => x.CadastroID == cadastro.ID));
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
        {  this.WindowState = FormWindowState.Minimized;  }
        private void BtnVoltar_Click(object sender, EventArgs e)
        { this.Close(); }
        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            Controles.Redimensionar(this);
            CenterToScreen();
            dgvContas.AutoResizeColumns();
        }

        //////////////////////////////// MOVER FORM CLICANDO NO CABEÇALHO ///////////////////
        private void Top_MouseDown(object sender, MouseEventArgs e)
        {
            Controles.ReleaseCapture();
            Controles.SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void ExibirFinanceiro_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }
    }
}
