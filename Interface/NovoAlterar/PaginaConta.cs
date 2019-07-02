using Interface.Controle;
using Modelo.Excessoes;
using Modelo.Servicos;
using Servico.Geral;
using System;
using System.Windows.Forms;

namespace Interface
{
    public partial class PaginaConta : Form
    {
        private Conta _conta;
        private ContaServico _contaServico;

        public PaginaConta()
        {
            InitializeComponent();
            _contaServico = new ContaServico();
            numValor.Select();
            numValor.Focus();
        }

        public PaginaConta(Conta conta) : this()
        {
            _conta = conta;
            AtualizarComponentes();
        }

        private void AtualizarComponentes()
        {
            numValor.Value = Convert.ToDecimal(_conta.Total);
            numValor.Minimum = Convert.ToDecimal(_conta.ValorPago);
            cbMetodoPagamento.SelectedItem = _conta.MetodoPagamento;
            numParcelas.Value = Convert.ToDecimal(_conta.Parcelas);
            dtVencimento.Text = _conta.Data_Vencimento.ToShortDateString();
            cbTipo.SelectedItem = _conta.Tipo;
            cbTipo.Enabled = false;
            if (cbCategoria.Items.Contains(_conta.Categoria))
                cbCategoria.SelectedItem = _conta.Categoria;
            else
                cbCategoria.Text = _conta.Categoria;
            cbCadastro.Text = _conta.Cadastro.ToString();
            numValorPago.Value = Convert.ToDecimal(_conta.ValorPago);
            numValorPago.Enabled = false;
        }

        private void CbMetodoPagamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMetodoPagamento.Text.Contains("A Prazo"))
                numParcelas.Visible = numParcelas.Enabled = lblParcelas.Visible = true;
            else
                numParcelas.Visible = numParcelas.Enabled = lblParcelas.Visible = false;
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                VerificarPreenchimento();
                if (_conta != null)
                {
                    if (MessageBox.Show("TEM CERTEZA QUE DESEJA ALTERAR ESSE REGISTRO?\n\nOBS:\nESSA AÇÃO NÃO PODE SER DESFEITA!", "ATENÇÃO!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                    {
                        _conta.Data_Vencimento = Convert.ToDateTime(dtVencimento.Text);
                        _conta.Total = Convert.ToDouble(numValor.Value);
                        _conta.MetodoPagamento = cbMetodoPagamento.Text;
                        _conta.Categoria = cbCategoria.Text;
                        _conta.CadastroID = Convert.ToInt64(cbCadastro.Text.Split(' ')[0]);
                        if (_conta.MetodoPagamento.Contains("À Vista"))
                            _conta.Parcelas = 1;
                        else
                            _conta.Parcelas = Convert.ToInt32(numParcelas.Value);
                        _contaServico.Editar(_conta);

                    }
                }
                else
                {
                    CadastrarNovaConta();
                }
                MessageBox.Show("REGISTRO SALVO!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.None);
                Close();
            }
            catch(NaoPreenchidoException erro)
            {
                MessageBox.Show($"ERRO NA OPERAÇÃO!\n{erro.Message}", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception)
            {
                MessageBox.Show("DADOS INVÁLIDOS INSERIDOS!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void VerificarPreenchimento()
        {
            ValidarPreenchimento.Validacao(errorProvider1, cbMetodoPagamento, cbTipo, cbCategoria, cbCadastro);

            if (numValor.Value == 0)
            {
                errorProvider1.SetError(numValor, "INFORME O VALOR!");
                throw new NaoPreenchidoException("UM OU MAIS CAMPOS OBRIGATÓRIOS NÃO PREENCHIDOS!");
            }
            else
                errorProvider1.SetError(numValor, null);            
        }

        private void CadastrarNovaConta()
        {
            int parcelas;
            if (cbMetodoPagamento.Text.Contains("À Vista"))
                parcelas = 1;
            else
                parcelas = Convert.ToInt32(numParcelas.Value);
            Conta conta = new Conta(cbTipo.Text, cbCategoria.Text, Convert.ToDateTime(dtVencimento.Text), Convert.ToDouble(numValor.Value), cbMetodoPagamento.Text, parcelas, Convert.ToInt64(cbCadastro.Text.Split(' ')[0]));
            conta.ValorPago = Convert.ToDouble(numValorPago.Value);
            _contaServico.Salvar(conta);
            if(conta.ValorPago != 0)
                CadastrarCaixa(_contaServico.Ultimo());
        }

        private void CadastrarCaixa(long contIaID)
        {
            CaixaServico caixaServico = new CaixaServico();
            double saldo = caixaServico.Ultimo();
            double valor = Convert.ToDouble(numValorPago.Value);
            if (cbTipo.Text == "Saída")
                saldo += (valor * -1);
            else
                saldo += valor;
            Caixa caixa = new Caixa(cbTipo.Text, cbCategoria.Text, valor, saldo, contIaID);
            caixaServico.Salvar(caixa);
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnBuscarDono_Click(object sender, EventArgs e)
        {
            CadastroServico cadastoServico = new CadastroServico();
            cbCadastro.Items.Clear();
            int cont = 0;
            try
            {
                foreach (var item in cadastoServico.Buscar(x => x.ID == Convert.ToInt64(cbCadastro.Text), "Endereco"))
                {
                    cbCadastro.Items.Add(item.ToString());
                    cont++;
                }
            }
            catch (Exception)
            {
                foreach (var item in cadastoServico.Buscar(x => x.Nome.Contains(cbCadastro.Text), "Endereco"))
                {
                    cbCadastro.Items.Add(item.ToString());
                    cont++;
                }
            }
            if (cont == 0)
                cbCadastro.Items.Add("Nenhuma correspondência encontrada!");
            cbCadastro.DroppedDown = true;
        }

        private void CbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbCategoria.Items.Clear();
            if (cbTipo.Text == "Saída")
            {
                cbCategoria.Items.Add("Salário");
                cbCategoria.Items.Add("Despesa Hospitalar");
                cbCategoria.Items.Add("Despesa Extra");
            }
            else
            {
                cbCategoria.Items.Add("Consulta");
                cbCategoria.Items.Add("Exame");
                cbCategoria.Items.Add("Vacina");
                cbCategoria.Items.Add("Cirurgia");
                cbCategoria.Items.Add("Internamento");
                cbCategoria.Items.Add("Outro");
            }
        }

        private void NumValor_ValueChanged(object sender, EventArgs e)
        {
            numValorPago.Maximum = numValor.Value;
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

        private void NumValorPago_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ',')
                e.KeyChar = '.';
            if (numValorPago.Text.Contains(".") && ((e.KeyChar == '.') || (e.KeyChar == ',')))
                e.Handled = true;
            if (numValorPago.Text.Length == 0 && e.KeyChar == '.')
                e.Handled = true;
        }
    }
}
