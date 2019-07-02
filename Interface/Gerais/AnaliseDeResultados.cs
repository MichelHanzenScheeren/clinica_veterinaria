using Interface.Controle;
using Modelo.Excessoes;
using Modelo.Servicos;
using Servico.Geral;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace Interface
{
    public partial class AnaliseDeResultados : Form
    {
        private CadastroServico _cadastroServico;
        private AnimalServico _animalServico;

        private AtendimentoServico _atendimentoServico;
        private ReceitaServico _receitaServico;
        private InternamentoServico _internamentoServico;

        private CaixaServico _caixaServico;

        public AnaliseDeResultados()
        {
            InitializeComponent();
            _atendimentoServico = new AtendimentoServico();
            _internamentoServico = new InternamentoServico();
            _receitaServico = new ReceitaServico();
            _cadastroServico = new CadastroServico();
            _animalServico = new AnimalServico();

            cbTipo.SelectedItem = "Geral";
            dtInicio.Value = DateTime.Now.AddDays(-7);
            AtualizarGraficosGeral();
            AtualizarGraficosFinanceiroTodos();
        }

        private void BtnTodos_Click(object sender, EventArgs e)
        {
            if (cbTipo.Text == "Geral")
            {
                AtualizarGraficosGeral();
            }
            else
            {
                AtualizarGraficosFinanceiroTodos();
            }
        }

        private void BtnPesquisarData_Click(object sender, EventArgs e)
        {
            if (cbTipo.Text == "Geral")
            {
                AtualizarGraficosGeralData();
            }
            else
            {
                AtualizarGraficosFinanceiroData();
            }
        }

        private void CbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTipo.Text == "Geral")
            {
                pnlFinanceiro.Enabled = pnlFinanceiro.Visible = false;
            }
            else
            {
                pnlFinanceiro.Enabled = pnlFinanceiro.Visible = true;
            }
        }

        private void AtualizarGraficosGeral()
        {
            graficoCadastros.Titles[0].Text = "CADASTROS POR CATEGORIA - TODO O PERÍODO";
            graficoServicos.Titles[0].Text = "SERVIÇOS POR CATEGORIA - TODO O PERÍODO";
            int cadastroAnimal = _animalServico.Contagem();
            int cadastrosCliente = _cadastroServico.Contagem(x => x.Discriminator == "Cliente");
            int cadastroVeterinario = _cadastroServico.Contagem(x => x.Discriminator == "Veterinario");
            int cadastroFuncionario = _cadastroServico.Contagem(x => x.Discriminator == "Funcionario");

            PreencherGraficoCadastros(cadastroAnimal, cadastrosCliente, cadastroVeterinario, cadastroFuncionario);

            int cadastroConsulta = _atendimentoServico.Contagem(x => x.Tipo == "Consulta");
            int cadastroExame = _atendimentoServico.Contagem(x => x.Tipo == "Exame");
            int cadastroVacina = _atendimentoServico.Contagem(x => x.Tipo == "Vacina");
            int cadastroCirurgia = _atendimentoServico.Contagem(x => x.Tipo == "Cirurgia");
            int cadastroInternamentos = _internamentoServico.Contagem();
            int cadastroReceitas = _receitaServico.Contagem();

            PreencherGraficoServicos(cadastroConsulta, cadastroExame, cadastroVacina, cadastroCirurgia, cadastroInternamentos, cadastroReceitas);
        }

        private void AtualizarGraficosGeralData()
        {
            graficoCadastros.Titles[0].Text = "CADASTROS POR CATEGORIA - " + dtInicio.Text + " ATÉ " + dtFim.Text;
            graficoServicos.Titles[0].Text = "SERVIÇOS POR CATEGORIA  - " + dtInicio.Text + " ATÉ " + dtFim.Text;
            DateTime inicio = Convert.ToDateTime(dtInicio.Text);
            DateTime fim = Convert.ToDateTime(dtFim.Text);
            int cadastroAnimal = _animalServico.Contagem(x => x.DataCadastro.Date >= inicio.Date && x.DataCadastro.Date <= fim.Date);
            int cadastrosCliente = _cadastroServico.Contagem(x => x.Discriminator == "Cliente" && x.DataCadastro.Date >= inicio.Date && x.DataCadastro.Date <= fim.Date);
            int cadastroVeterinario = _cadastroServico.Contagem(x => x.Discriminator == "Veterinario" && x.DataCadastro.Date >= inicio.Date && x.DataCadastro.Date <= fim.Date);
            int cadastroFuncionario = _cadastroServico.Contagem(x => x.Discriminator == "Funcionario" && x.DataCadastro.Date >= inicio.Date && x.DataCadastro.Date <= fim.Date);

            PreencherGraficoCadastros(cadastroAnimal, cadastrosCliente, cadastroVeterinario, cadastroFuncionario);

            int cadastroConsulta = _atendimentoServico.Contagem(x => x.Tipo == "Consulta" && x.Data.Date >= inicio.Date && x.Data.Date <= fim.Date);
            int cadastroExame = _atendimentoServico.Contagem(x => x.Tipo == "Exame" && x.Data.Date >= inicio.Date && x.Data.Date <= fim.Date);
            int cadastroVacina = _atendimentoServico.Contagem(x => x.Tipo == "Vacina" && x.Data.Date >= inicio.Date && x.Data.Date <= fim.Date);
            int cadastroCirurgia = _atendimentoServico.Contagem(x => x.Tipo == "Cirurgia" && x.Data.Date >= inicio.Date && x.Data.Date <= fim.Date);
            int cadastroInternamentos = _internamentoServico.Contagem(x => x.DataEntrada.Date >= inicio.Date && x.DataEntrada.Date <= fim.Date);
            int cadastroReceitas = _receitaServico.Contagem(x => x.Data.Date >= inicio.Date && x.Data.Date <= fim.Date);

            PreencherGraficoServicos(cadastroConsulta, cadastroExame, cadastroVacina, cadastroCirurgia, cadastroInternamentos, cadastroReceitas);
        }

        private void PreencherGraficoCadastros(int cadastroAnimal, int cadastrosCliente, int cadastroVeterinario, int cadastroFuncionario)
        {
            graficoCadastros.Series[0].Points.Clear();
            graficoCadastros.Series[0].Points.AddXY("Funcionarios", cadastroFuncionario);
            graficoCadastros.Series[0].Points.AddXY("Veterinarios", cadastroVeterinario);
            graficoCadastros.Series[0].Points.AddXY("Clientes", cadastrosCliente);
            graficoCadastros.Series[0].Points.AddXY("Animais", cadastroAnimal);
 
        }

        private void PreencherGraficoServicos(int cadastroConsulta, int cadastroExame, int cadastroVacina, int cadastroCirurgia, int cadastroInternamentos, int cadastroReceitas)
        {
            graficoServicos.Series[0].Points.Clear();
            this.graficoServicos.Series[0].Points.AddXY("Cirurgias", cadastroCirurgia);
            this.graficoServicos.Series[0].Points.AddXY("Internamentos", cadastroInternamentos);
            this.graficoServicos.Series[0].Points.AddXY("Vacinas", cadastroVacina);
            this.graficoServicos.Series[0].Points.AddXY("Receitas", cadastroReceitas);
            this.graficoServicos.Series[0].Points.AddXY("Exames", cadastroExame);
            this.graficoServicos.Series[0].Points.AddXY("Consultas", cadastroConsulta);
        }

        private void AtualizarGraficosFinanceiroTodos()
        {
            graficoFluxoCaixa.Titles[0].Text = "FLUXO DE CAIXA (R$) - TODO O PERÍODO";
            graficoEntradas.Titles[0].Text = "RECEITAS DO CAIXA (R$) - TODO O PERÍODO";
            _caixaServico = new CaixaServico();

            PreencherGraficoFluxoCaixa(_caixaServico.ObterTodos().OrderBy(x => x.Data).ToList());

            PreencherGraficoEntradas(_caixaServico.Buscar(x => x.Tipo == "Entrada"));

        }

        private void AtualizarGraficosFinanceiroData()
        {
            graficoFluxoCaixa.Titles[0].Text = "FLUXO DE CAIXA (R$) - " + dtInicio.Text + " ATÉ " + dtFim.Text;
            graficoEntradas.Titles[0].Text = "RECEITAS DO CAIXA (R$) - " + dtInicio.Text + " ATÉ " + dtFim.Text;
            _caixaServico = new CaixaServico();
            DateTime inicio = Convert.ToDateTime(dtInicio.Text);
            DateTime fim = Convert.ToDateTime(dtFim.Text);

            PreencherGraficoFluxoCaixa(_caixaServico.Buscar(x => x.Data.Date >= inicio.Date && x.Data.Date <= fim.Date).OrderBy(x => x.Data).ToList());

            PreencherGraficoEntradas(_caixaServico.Buscar(x => x.Tipo == "Entrada" && x.Data.Date >= inicio.Date && x.Data.Date <= fim.Date));
        }

        private void PreencherGraficoFluxoCaixa(List<Caixa> caixas)
        {
            graficoFluxoCaixa.Series[0].Points.Clear();
            foreach (var item in caixas)
            {
                graficoFluxoCaixa.Series[0].Points.AddXY(item.Data.Day +"/" + item.Data.Month, item.Saldo);
            }
        }

        private void PreencherGraficoEntradas(List<Caixa> caixas)
        {
            double valorConsultas = 0, valorExames = 0, valorVacinas = 0, valorCirurgia = 0, valorInternamento = 0, outros = 0, total = 0;
            foreach (var item in caixas)
            {
                total += item.Valor;
                if (item.Categoria == "Exame")
                    valorExames += item.Valor;
                else if (item.Categoria == "Vacina")
                    valorVacinas += item.Valor;
                else if (item.Categoria == "Consulta")
                    valorConsultas += item.Valor;
                else if (item.Categoria == "Cirurgia")
                    valorCirurgia += item.Valor;
                else if (item.Categoria == "Internamento")
                    valorInternamento += item.Valor;
                else
                    outros += item.Valor;
            }
            graficoEntradas.Series[0].Points.Clear();
            graficoEntradas.Series[0].Points.AddXY("Exames", valorExames.ToString("C", CultureInfo.CurrentCulture));
            graficoEntradas.Series[0].Points.AddXY("Vacinas", valorVacinas.ToString("C", CultureInfo.CurrentCulture));
            graficoEntradas.Series[0].Points.AddXY("Consultas", valorConsultas.ToString("C", CultureInfo.CurrentCulture));
            graficoEntradas.Series[0].Points.AddXY("Cirurgias", valorCirurgia.ToString("C", CultureInfo.CurrentCulture));
            graficoEntradas.Series[0].Points.AddXY("Internamento", valorInternamento.ToString("C", CultureInfo.CurrentCulture));
            graficoEntradas.Series[0].Points.AddXY("Outros", outros.ToString("C", CultureInfo.CurrentCulture));
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

        //////////////////////////////// MOVER FORM CLICANDO NO CABEÇALHO ///////////////////
        private void Top_MouseDown(object sender, MouseEventArgs e)
        {
            Controles.ReleaseCapture();
            Controles.SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void AnaliseDeResultados_Load(object sender, EventArgs e)
        {
            Height = 730;
            Width = 1370;
            CenterToScreen();
        }
    }
}
