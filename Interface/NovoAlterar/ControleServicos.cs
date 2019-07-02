using Interface.Controle;
using Modelo.Cadastros;
using Modelo.Excessoes;
using Servico.Geral;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Interface
{
    public partial class ControleServicos : Form
    {
        private MedicamentoServico _medicamentoServico;
        private ExameServico _exameServico;
        private VacinaServico _vacinaServico;
        private CirurgiaServico _cirurgiaServico;

        public ControleServicos()
        {
            InitializeComponent();
            _exameServico = new ExameServico();
            _vacinaServico = new VacinaServico();
            _cirurgiaServico = new CirurgiaServico();
        }

        private void CbOpcao_SelectedIndexChanged(object sender, EventArgs e)
        {
            Testar();
        }

        private void CbServico_SelectedIndexChanged(object sender, EventArgs e)
        {
            Testar();
        }

        private void Testar()
        {
            if (cbOpcao.Text == "Novo" && cbServico.Text == "Medicamento")
            {
                cbTodos.Items.Clear();
                txtIDMedicamento.Visible = lblIDMedicamento.Visible = false;
                txtIDMedicamento.Text = string.Empty;
                cbTodos.Text = string.Empty;
                txtNomeMedicamento.Text = string.Empty;
                cbTipo.Text = null;
                cbClassificacao.Text = null;
                txtIDMedicamento.Visible = lblIDMedicamento.Visible = false;
                ExibirPanelMedicamento();
            }

            else if ((cbOpcao.Text == "Editar"  || cbOpcao.Text == "Excluir") && cbServico.Text == "Medicamento")
                PreencherCbTodos();

            else if(cbOpcao.Text == "Novo" && cbServico.Text == "Exame")
            {
                cbTodos.Items.Clear();
                txtIDExame.Visible = lblIDExame.Visible = false;
                txtIDExame.Text = string.Empty;
                txtNomeExame.Text = string.Empty;
                cbTipoExame.Text = null;
                txtPrecoExame.Text = string.Empty;
                ExibirPanelExame();
            }

            else if ((cbOpcao.Text == "Editar" || cbOpcao.Text == "Excluir") && cbServico.Text == "Exame")
                PreencherCbTodos();

            else if (cbOpcao.Text == "Novo" && cbServico.Text == "Vacina")
            {
                cbTodos.Items.Clear();
                txtIDVacina.Visible = lblIDVacina.Visible = false;
                txtIDVacina.Text = string.Empty;
                txtNomeVacina.Text = string.Empty;
                txtInformacoesVacina.Text = string.Empty;
                txtPrecoVacina.Text = string.Empty;
                ExibirPanelVacina();
            }

            else if ((cbOpcao.Text == "Editar" || cbOpcao.Text == "Excluir") && cbServico.Text == "Vacina")
                PreencherCbTodos();

            else if (cbOpcao.Text == "Novo" && cbServico.Text == "Cirurgia")
            {
                cbTodos.Items.Clear();
                txtIDCirurgia.Visible = lblIDCirurgia.Visible = false;
                txtIDCirurgia.Text = string.Empty;
                txtNomeCirurgia.Text = string.Empty;
                txtPrecoCirurgia.Text = string.Empty;
                cbClassificacaoCirurgia.Text = null;
                ExibirPanelCirurgia();
            }

            else if ((cbOpcao.Text == "Editar" || cbOpcao.Text == "Excluir") && cbServico.Text == "Cirurgia")
                PreencherCbTodos();
        }

        private void ExibirPanelMedicamento()
        {
            pnlCirurgia.Enabled = false;
            pnlCirurgia.Visible = false;

            pnlVacina.Enabled = false;
            pnlVacina.Visible = false;

            pnlExame.Enabled = false;
            pnlExame.Visible = false;

            pnlMedicamentos.Enabled = true;
            pnlMedicamentos.Visible = true;
        }

        private void ExibirPanelExame()
        {
            pnlCirurgia.Enabled = false;
            pnlCirurgia.Visible = false;

            pnlVacina.Enabled = false;
            pnlVacina.Visible = false;

            pnlMedicamentos.Enabled = false;
            pnlMedicamentos.Visible = false;

            pnlExame.Enabled = true;
            pnlExame.Visible = true;
        }

        private void ExibirPanelVacina()
        {
            pnlCirurgia.Enabled = false;
            pnlCirurgia.Visible = false;

            pnlExame.Enabled = false;
            pnlExame.Visible = false;

            pnlMedicamentos.Enabled = false;
            pnlMedicamentos.Visible = false;

            pnlVacina.Enabled = true;
            pnlVacina.Visible = true;
        }

        private void ExibirPanelCirurgia()
        {
            pnlExame.Enabled = false;
            pnlExame.Visible = false;

            pnlMedicamentos.Enabled = false;
            pnlMedicamentos.Visible = false;

            pnlVacina.Enabled = false ;
            pnlVacina.Visible = false;

            pnlCirurgia.Enabled = true;
            pnlCirurgia.Visible = true;
        }

        private void BtnSalvarMedicamento_Click(object sender, EventArgs e)
        {
            try
            {
                TestarPreenchimentoMedicamento();
                if (cbOpcao.Text == "Novo")
                    CadastrarMedicamento();
                else if (cbOpcao.Text == "Editar")
                    EditarMedicamento();
                else
                    ExluirMedicamento();
                MessageBox.Show("OPERAÇÃO CONCLUÍDA!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.None);
                Close();
            }
            catch (NaoPreenchidoException erro)
            {
                MessageBox.Show($"Erro no Cadastro!\n {erro.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void TestarPreenchimentoMedicamento()
        {
            if (txtNomeMedicamento.Text == string.Empty || cbTipo.Text == string.Empty || cbClassificacao.Text == string.Empty)
                throw new NaoPreenchidoException("UM OU MAIS CAMPOS OBRIGATÓRIOS ESTÃO INCOMPLETOS!");
        }

        private void CadastrarMedicamento()
        {
            Medicamento medicamento = new Medicamento(txtNomeMedicamento.Text, cbTipo.Text, cbClassificacao.Text);
            _medicamentoServico = new MedicamentoServico();
            _medicamentoServico.Salvar(medicamento);
        }

        private void EditarMedicamento()
        {
            _medicamentoServico = new MedicamentoServico();
            Medicamento medicamento = _medicamentoServico.Buscar(x => x.MedicamentoID == Convert.ToInt64(txtIDMedicamento.Text)).FirstOrDefault();
            medicamento.Nome = txtNomeMedicamento.Text;
            medicamento.Tipo = cbTipo.Text;
            medicamento.Classificacao = cbClassificacao.Text;
            _medicamentoServico.Editar(medicamento);
        }

        private void ExluirMedicamento()
        {
            if (MessageBox.Show("TEM CERTEZA QUE DESEJA APAGAR ESSE REGISTRO?\n\nOBS:\nESSA AÇÃO NÃO PODE SER DESFEITA!\nAPAGAR UM MEDICAMENTO IMPLICA NA PERDA DE TODAS AS RECEITAS ASSOCIADAS A ELE!", "ATENÇÃO!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                _medicamentoServico = new MedicamentoServico();
                Medicamento medicamento = _medicamentoServico.Buscar(x => x.MedicamentoID == Convert.ToInt64(txtIDMedicamento.Text)).FirstOrDefault();
                _medicamentoServico.Excluir(medicamento);
            }
        }

        private void BtnSalvarExame_Click(object sender, EventArgs e)
        {
            try
            {
                TestarPreenchimentoExame();
                if (cbOpcao.Text == "Novo")
                    CadastrarExame();
                else if (cbOpcao.Text == "Editar")
                    EditarExame();
                else
                    ExcluirExame();
                MessageBox.Show("OPERAÇÃO CONCLUÍDA!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.None);
                Close();
            }
            catch (NaoPreenchidoException erro)
            {
                MessageBox.Show($"ERRO NO CADASTRO!\n {erro.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TestarPreenchimentoExame()
        {
            if (txtNomeExame.Text == "" || cbTipoExame.Text == "" || txtPrecoExame.Text == "")
                throw new NaoPreenchidoException("UM OU MAIS CAMPOS OBRIGATÓRIOS INCOMPLETOS!");
        }

        private void CadastrarExame()
        {
            Exame exame = new Exame(txtNomeExame.Text, cbTipoExame.Text, Convert.ToDouble(txtPrecoExame.Text));
            _exameServico.Salvar(exame);
        }

        private void EditarExame()
        {
            Exame exame = _exameServico.Buscar(x => x.ExameID == Convert.ToInt64(txtIDExame.Text)).FirstOrDefault();
            exame.Nome = txtNomeExame.Text;
            exame.Tipo = cbTipoExame.Text;
            exame.Preco = Convert.ToDouble(txtPrecoExame.Text);
            _exameServico.Editar(exame);
        }

        private void ExcluirExame()
        {
            if (MessageBox.Show("TEM CERTEZA QUE DESEJA APAGAR ESSE REGISTRO?\n\nOBS:\nESSA AÇÃO NÃO PODE SER DESFEITA!\nAPAGAR UM EXAME IMPLICA NA PERDA DE TODOS OS ATENDIMENTOS ASSOCIADAS A ELE!", "ATENÇÃO!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                AtendimentoServico atendimentoServico = new AtendimentoServico();
                foreach (var item in atendimentoServico.Buscar(x => x.ClassificacaoAtendimento.Split(' ')[0] == txtIDExame.Text && x.Tipo == "Exame"))
                {
                    atendimentoServico.Excluir(item);
                }
                Exame exame = _exameServico.Buscar(x => x.ExameID == Convert.ToInt64(txtIDExame.Text)).FirstOrDefault();
                _exameServico.Excluir(exame);
            }
        }

        private void BtnSalvarVacina_Click(object sender, EventArgs e)
        {
            try
            {
                TestarPreenchimentoVacina();
                if (cbOpcao.Text == "Novo")
                    CadastrarVacina();
                else if (cbOpcao.Text == "Editar")
                    EditarVacina();
                else
                    ExcluirVacina();
                MessageBox.Show("OPERAÇÃO CONCLUÍDA!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.None);
                Close();
            }
            catch (NaoPreenchidoException erro)
            {
                MessageBox.Show($"ERRO NO CADASTRO!\n {erro.Message}", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TestarPreenchimentoVacina()
        {
            if (txtNomeVacina.Text == "" || txtInformacoesVacina.Text == "" || txtPrecoVacina.Text == "")
                throw new NaoPreenchidoException("UM OU MAIS CAMPOS OBRIGATÓRIOS INCOMPLETOS");
        }

        private void CadastrarVacina()
        {
            Vacina vacina = new Vacina(txtNomeVacina.Text, txtInformacoesVacina.Text, Convert.ToDouble(txtPrecoVacina.Text));
            _vacinaServico.Salvar(vacina);
        }

        private void EditarVacina()
        {
            Vacina vacina = _vacinaServico.Buscar(x => x.VacinaID == Convert.ToInt64(txtIDVacina.Text)).FirstOrDefault();
            vacina.Nome = txtNomeVacina.Text;
            vacina.Informacoes = txtInformacoesVacina.Text;
            vacina.Preco = Convert.ToDouble(txtPrecoVacina.Text);
            _vacinaServico.Editar(vacina);
        }

        private void ExcluirVacina()
        {
            if (MessageBox.Show("TEM CERTEZA QUE DESEJA APAGAR ESSE REGISTRO?\n\nOBS:\nESSA AÇÃO NÃO PODE SER DESFEITA!\nAPAGAR UMA VACINA IMPLICA NA PERDA DE TODOS OS ATENDIMENTOS ASSOCIADAS A ELA!", "ATENÇÃO!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                AtendimentoServico atendimentoServico = new AtendimentoServico();
                foreach (var item in atendimentoServico.Buscar(x => x.ClassificacaoAtendimento.Split(' ')[0] == txtIDVacina.Text && x.Tipo == "Vacina"))
                {
                    atendimentoServico.Excluir(item);
                }
                Vacina vacina =_vacinaServico.Buscar(x => x.VacinaID == Convert.ToInt64(txtIDVacina.Text)).FirstOrDefault();
                _vacinaServico.Excluir(vacina);
            }
        }

        private void BtnSalvarCirurgia_Click(object sender, EventArgs e)
        {
            try
            {
                TestarPreenchimentoCirurgia();
                if (cbOpcao.Text == "Novo")
                    CadastrarCirurgia();
                else if (cbOpcao.Text == "Editar")
                    EditarCirurgia();
                else
                    ExluirCirurgia();
                MessageBox.Show("OPERAÇÃO CONCLUÍDA!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.None);
                Close();
            }
            catch (NaoPreenchidoException erro)
            {
                MessageBox.Show($"ERRO NO CADASTRO!\n {erro.Message}", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TestarPreenchimentoCirurgia()
        {
            if (txtNomeCirurgia.Text == "" || cbClassificacaoCirurgia.Text == "" || txtPrecoCirurgia.Text == "")
                throw new NaoPreenchidoException("UM OU MAIS CAMPOS OBRIGATÓRIOS INCOMPLETOS!");
        }

        private void CadastrarCirurgia()
        {
            Cirurgia cirurgia = new Cirurgia(txtNomeCirurgia.Text, cbClassificacaoCirurgia.Text, Convert.ToDouble(txtPrecoCirurgia.Text));
            _cirurgiaServico.Salvar(cirurgia);
        }

        private void EditarCirurgia()
        {
            Cirurgia cirurgia = _cirurgiaServico.Buscar(x => x.CirurgiaID == Convert.ToInt64(txtIDCirurgia.Text)).FirstOrDefault();
            cirurgia.Nome = txtNomeCirurgia.Text;
            cirurgia.Classificacao = cbClassificacaoCirurgia.Text;
            cirurgia.Preco = Convert.ToDouble(txtPrecoCirurgia.Text);
            _cirurgiaServico.Editar(cirurgia);
        }

        private void ExluirCirurgia()
        {
            if (MessageBox.Show("TEM CERTEZA QUE DESEJA APAGAR ESSE REGISTRO?\n\nOBS:\nESSA AÇÃO NÃO PODE SER DESFEITA!\nAPAGAR UMA CIRURGIA IMPLICA NA PERDA DE TODOS OS ATENDIMENTOS ASSOCIADAS A ELA!", "ATENÇÃO!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                AtendimentoServico atendimentoServico = new AtendimentoServico();
                foreach (var item in atendimentoServico.Buscar(x => x.ClassificacaoAtendimento.Split(' ')[0] == txtIDCirurgia.Text && x.Tipo == "Cirurgia"))
                {
                    atendimentoServico.Excluir(item);
                }
                Cirurgia cirurgia = _cirurgiaServico.Buscar(x => x.CirurgiaID == Convert.ToInt64(txtIDCirurgia.Text)).FirstOrDefault();
                _cirurgiaServico.Excluir(cirurgia);
            }
        }

        private void PreencherCbTodos()
        {
            cbTodos.Items.Clear();
            if (cbServico.Text == "Medicamento")
            {
                _medicamentoServico = new MedicamentoServico();
                foreach (var item in _medicamentoServico.ObterTodos())
                {
                    cbTodos.Items.Add(item.ToString());
                }
            }
            else if (cbServico.Text == "Exame")
            {
                foreach (var item in _exameServico.ObterTodos())
                {
                    cbTodos.Items.Add(item.ToString());
                }
            }
            else if (cbServico.Text == "Vacina")
            {
                foreach (var item in _vacinaServico.ObterTodos())
                {
                    cbTodos.Items.Add(item.ToString());
                }
            }
            else
            {
                foreach (var item in _cirurgiaServico.ObterTodos())
                {
                    cbTodos.Items.Add(item.ToString());
                }
            }
        }

        private void CbTodos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbServico.Text == "Medicamento")
            {
                ExibirPanelMedicamento();
                PreencherInfoMedicamento(Convert.ToInt64(cbTodos.Text.Split(' ')[0]));
            }
            else if (cbServico.Text == "Exame")
            {
                ExibirPanelExame();
                PreencherInfoExame(Convert.ToInt64(cbTodos.Text.Split(' ')[0]));
            }
            else if (cbServico.Text == "Vacina")
            {
                ExibirPanelVacina();
                PreencherInfoVacina(Convert.ToInt64(cbTodos.Text.Split(' ')[0]));
            }
            else
            {
                ExibirPanelCirurgia();
                PreencherInfoCirurgia(Convert.ToInt64(cbTodos.Text.Split(' ')[0]));
            }
        }

        private void PreencherInfoMedicamento(long id)
        {
            _medicamentoServico = new MedicamentoServico();
            Medicamento medicamento = _medicamentoServico.Buscar(x => x.MedicamentoID == id).FirstOrDefault();
            txtIDMedicamento.Visible = lblIDMedicamento.Visible = true;
            txtIDMedicamento.Text = Convert.ToString(medicamento.MedicamentoID);
            txtNomeMedicamento.Text = medicamento.Nome;
            cbTipo.SelectedItem = medicamento.Tipo;
            cbClassificacao.SelectedItem = medicamento.Classificacao;
        }

        private void PreencherInfoExame(long id)
        {
            Exame exame = _exameServico.Buscar(x => x.ExameID == id).FirstOrDefault();
            txtIDExame.Visible = lblIDExame.Visible = true;
            txtIDExame.Text = Convert.ToString(exame.ExameID);
            txtNomeExame.Text = exame.Nome;
            cbTipoExame.Text = exame.Tipo;
            txtPrecoExame.Text = Convert.ToString(exame.Preco);
        }

        private void PreencherInfoVacina(long id)
        {
            Vacina vacina = _vacinaServico.Buscar(x => x.VacinaID == id).FirstOrDefault();
            txtIDVacina.Visible = lblIDVacina.Visible = true;
            txtIDVacina.Text = Convert.ToString(vacina.VacinaID);
            txtNomeVacina.Text = vacina.Nome;
            txtInformacoesVacina.Text = vacina.Informacoes;
            txtPrecoVacina.Text = Convert.ToString(vacina.Preco);
        }

        private void PreencherInfoCirurgia(long id)
        {
            Cirurgia cirurgia = _cirurgiaServico.Buscar(x => x.CirurgiaID == id).FirstOrDefault();
            txtIDCirurgia.Visible = lblIDCirurgia.Visible = true;
            txtIDCirurgia.Text = Convert.ToString(cirurgia.CirurgiaID);
            txtNomeCirurgia.Text = cirurgia.Nome;
            cbClassificacaoCirurgia.Text = cirurgia.Classificacao;
            txtPrecoCirurgia.Text = Convert.ToString(cirurgia.Preco);
        }

        private void TxtPreco_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (!char.IsControl(e.KeyChar)) && (e.KeyChar != '.') && (e.KeyChar != ','))
                e.Handled = true;
            if (e.KeyChar == ',')
                e.KeyChar = '.';
            if (txtPrecoVacina.Text.Contains(".") && ((e.KeyChar == '.') || (e.KeyChar == ',')))
                e.Handled = true;
            if (txtPrecoVacina.Text.Length == 0 && e.KeyChar == '.')
                e.Handled = true;
        }

        private void TxtPrecoExame_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (!char.IsControl(e.KeyChar)) && (e.KeyChar != '.') && (e.KeyChar != ','))
                e.Handled = true;
            if (e.KeyChar == ',')
                e.KeyChar = '.';
            if (txtPrecoExame.Text.Contains(".") && ((e.KeyChar == '.') || (e.KeyChar == ',')))
                e.Handled = true;
            if (txtPrecoExame.Text.Length == 0 && e.KeyChar == '.')
                e.Handled = true;
        }

        private void TxtPrecoCirurgia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (!char.IsControl(e.KeyChar)) && (e.KeyChar != '.') && (e.KeyChar != ','))
                e.Handled = true;
            if (e.KeyChar == ',')
                e.KeyChar = '.';
            if (txtPrecoCirurgia.Text.Contains(".") && ((e.KeyChar == '.') || (e.KeyChar == ',')))
                e.Handled = true;
            if (txtPrecoCirurgia.Text.Length == 0 && e.KeyChar == '.')
                e.Handled = true;
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
        }

        //////////////////////////////// MOVER FORM CLICANDO NO CABEÇALHO ///////////////////
        private void Top_MouseDown(object sender, MouseEventArgs e)
        {
            Controles.ReleaseCapture();
            Controles.SendMessage(Handle, 0x112, 0xf012, 0);
        }
    }
}
