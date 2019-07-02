using Interface.Controle;
using Modelo.Excessoes;
using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Interface
{
    public partial class PaginaInicial : Form
    {

        public PaginaInicial()
        {
            InitializeComponent();
        }

        private void PaginaInicial_Load(object sender, EventArgs e)
        {
            MenuLateral();
        }

        private void Abrir(Form form)
        {
            try
            {
                Controles.ManterTamanho(this, form);
                Hide();
                form.ShowDialog();
                Show();
                Controles.ManterTamanho(form, this);
                CenterToScreen();
                
            }
            catch (FecharException)
            {
                this.Close();
            }
            catch (Exception erro)
            {
                Show();
                MessageBox.Show($"UM PROBLEMA DESCONHECIDO IMPEDIU QUE O COMANDO SOLICITADO FOSSE EXECUTADO!\nSENTIMOS PELO INCONVENIENTE E TRABALHAREMOS PARA SOLUCIONÁ-LO ASSIM QUE POSSÍVEL.\n\nERRO:\n '{erro.Message}' \n\n LOCAL:\n {erro.TargetSite}", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void BtnCadastros_Click(object sender, EventArgs e)
        {
            ExibirCadastros exibirCadastros = new ExibirCadastros();
            Abrir(exibirCadastros);
        }

        private void BtnAnimais_Click(object sender, EventArgs e)
        {
            ExibirAnimais exibirAnimais = new ExibirAnimais();
            Abrir(exibirAnimais);
        }

        private void BtnAgendamentos_Click(object sender, EventArgs e)
        {
            ExibirAgendamento exibirAgendamento = new ExibirAgendamento();
            Abrir(exibirAgendamento);
        }

        private void BtnATENDIMENTO_Click(object sender, EventArgs e)
        {
            ExibirAtendimento exibirAtendimento = new ExibirAtendimento();
            Abrir(exibirAtendimento);
        }

        private void BtnControle_Click(object sender, EventArgs e)
        {
            ControleServicos controleServicos = new ControleServicos();
            Abrir(controleServicos);
        }

        private void BtnReceitas_Click(object sender, EventArgs e)
        {
            ExibirReceita exibirReceita = new ExibirReceita();
            Abrir(exibirReceita);
        }

        private void BtnInternacao_Click(object sender, EventArgs e)
        {
            ExibirInternamento exibirInternamento = new ExibirInternamento();
            Abrir(exibirInternamento);
        }

        private void BtnCaixa_Click(object sender, EventArgs e)
        { 
            ExibirFinanceiro exibirFinanceiro = new ExibirFinanceiro();
            Abrir(exibirFinanceiro);

        }

        private void BtnResultados_Click(object sender, EventArgs e)
        {
            AnaliseDeResultados analiseDeResultados = new AnaliseDeResultados();
            Abrir(analiseDeResultados);
        }
        private void BtnMenu_Click(object sender, EventArgs e)
        {
            MenuLateral();
        }

        private void MenuLateral()
        {
            if (pnlLateral.Width == 246)
            {
                pnlLateral.Width = 85;
                btnCadastros.Text = "";
                btnAnimais.Text = "";
                btnAgendamentos.Text = "";
                btnATENDIMENTO.Text = "";
                btnReceitas.Text = "";
                btnInternacao.Text = "";
                btnCaixa.Text = "";
                btnControle.Text = "";
                btnResultados.Text = "";
            }
            else
            {
                pnlLateral.Width = 246;
                btnCadastros.Text = "CADASTROS";
                btnAnimais.Text = "           ANIMAIS";
                btnAgendamentos.Text = "           AGENDA";
                btnATENDIMENTO.Text = "   ATENDIMENTO";
                btnReceitas.Text = "           RECEITA";
                btnInternacao.Text = "       INTERNAMENTO";
                btnCaixa.Text = "FINANÇAS";
                btnControle.Text = "CONTROLE";
                btnResultados.Text = "RESULTADOS";
            }
        }


        //////////////////////////////// Botões de Controle ///////////////////////////////////////////
        private void BtnFechar_Click(object sender, EventArgs e)
        {
            ConfirmacaoFecharPrograma fechar = new ConfirmacaoFecharPrograma();
            fechar.ShowDialog();
            if (fechar.Resultado == "OK")
                this.Close();
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
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

        //////////////////////////////// REDIMENSIONAMENTO //////////////////////////////////
        private void PnlCentral_Resize(object sender, EventArgs e)
        {
            if(WindowState != FormWindowState.Minimized)
                imagemCentral.Image = RedimensionarImagem(imagemCentral.Image, new Size(pnlImagem.Width, pnlImagem.Height));
        }

        private Image RedimensionarImagem(Image imagem, Size newSize)
        {
            Image newImage = new Bitmap(newSize.Width, newSize.Height);
            using(Graphics GFX = Graphics.FromImage((Bitmap)newImage))
            {
                GFX.DrawImage(imagem, new Rectangle(Point.Empty, newSize));
            }
            return newImage;
        }
    }
}
