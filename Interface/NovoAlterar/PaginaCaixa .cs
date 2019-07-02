using Interface.Controle;
using Modelo.Excessoes;
using Modelo.Servicos;
using Servico.Geral;
using System;
using System.Windows.Forms;

namespace Interface
{
    public partial class PaginaCaixa : Form
    {
        private Conta _conta;
        private Caixa _caixa;
        private CaixaServico _caixaServico;
        private ContaServico _contaServico;

        public PaginaCaixa()
        {
            InitializeComponent();
            _caixaServico = new CaixaServico();
            _contaServico = new ContaServico();
            numValor.Select();
            numValor.Focus();
        }

        public PaginaCaixa(Conta conta) : this()
        {
            _conta = conta;
            ModificacoesIniciais();
        }

        public PaginaCaixa(Caixa caixa) : this()
        {
            _caixa = caixa;
            ModificacoesEdicao();
        }

        private void ModificacoesEdicao()
        {
            cbTipo.SelectedItem = _caixa.Tipo;
            numValor.Maximum = Convert.ToDecimal(_caixa.Valor + (_caixa.Conta.Total - _caixa.Conta.ValorPago));
            txtConta.Text = _caixa.Conta.ToString();
            numValor.Value = Convert.ToDecimal(_caixa.Valor);
            lblID.Visible = txtID.Visible = true;
            txtID.Text = Convert.ToString(_caixa.CaixaID);
        }

        private void ModificacoesIniciais()
        {
            cbTipo.SelectedItem = _conta.Tipo;
            numValor.Maximum = Convert.ToDecimal(_conta.Total - _conta.ValorPago);
            txtConta.Text = _conta.ToString();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                VerificarPreenchimento();
                if (_caixa == null)
                    CadastrarFluxoCaixa();
                else
                    EditarFluxoCaixa();
            }
            catch (NaoPreenchidoException erro)
            {
                MessageBox.Show($"Erro no Cadastro!\n {erro.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show($"Erro no Cadastro!\nA conta inserido não é válida!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void VerificarPreenchimento()
        {
            ValidarPreenchimento.Validacao(errorProvider1, txtConta, cbTipo);
            if (numValor.Value == 0)
            {
                errorProvider1.SetError(numValor, "INFORME O VALOR!");
                throw new NaoPreenchidoException("UM OU MAIS CAMPOS OBRIGATÓRIOS NÃO PREENCHIDOS!");
            }
            else
                errorProvider1.SetError(numValor, null);
        }

        private void CadastrarFluxoCaixa()
        {
            double saldo = _caixaServico.Ultimo();
            double total = Convert.ToDouble(numValor.Value);
            double novoSaldo;
            if (cbTipo.Text == "Saída")
                novoSaldo = saldo - total;
            else
                novoSaldo = saldo + total;
            Caixa caixa = new Caixa(cbTipo.Text, _conta.Categoria, Convert.ToDouble(numValor.Value), novoSaldo, _conta.ContaID);
            _caixaServico.Salvar(caixa);
            AtualizarConta(total);
            MessageBox.Show($"PAGAMENTO REGISTRADO!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void AtualizarConta(double total)
        {
            _conta.ValorPago += total;
            _contaServico.Editar(_conta);
        }

        private void EditarFluxoCaixa()
        {
            double diferenca;
            if (cbTipo.Text == "Entrada")
            {
                diferenca = Convert.ToDouble(numValor.Value) - _caixa.Valor;
                _caixa.Valor += diferenca;
            }

            else
            {
                diferenca = _caixa.Valor - Convert.ToDouble(numValor.Value);
                _caixa.Valor -= diferenca;
            }
            _caixa.Saldo += diferenca;
            _caixaServico.Editar(_caixa);
            EditarValorConta(diferenca);
            MessageBox.Show($"PAGAMENTO ATUALIZADO!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void EditarValorConta(double diferenca)
        {
            if(cbTipo.Text == "Entrada")
                _caixa.Conta.ValorPago += diferenca;
            else
                _caixa.Conta.ValorPago -= diferenca;
            _contaServico.Editar(_caixa.Conta);
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        //////////////////////////////// Botões de Controle ///////////////////////////////////////////
        private void BtnFechar_Click(object sender, EventArgs e)
        { this.Close(); }


        //////////////////////////////// MOVER FORM CLICANDO NO CABEÇALHO ///////////////////
        private void Top_MouseDown(object sender, MouseEventArgs e)
        {
            Controles.ReleaseCapture();
            Controles.SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void NumValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ',')
                e.KeyChar = '.';
            if (numValor.Text.Contains(".") && ((e.KeyChar == '.') || (e.KeyChar == ',')))
                e.Handled = true;
            if (numValor.Text.Length == 0 && e.KeyChar == '.')
                e.Handled = true;
        }
    }
}
