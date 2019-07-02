using Interface.Controle;
using System;
using System.Threading;
using System.Windows.Forms;
using Servico.Controle;

namespace Interface
{
    public partial class TelaDeCarregamento : Form
    {
        private Thread _abrirPaginaInicial;
        private Thread _criarBanco;

        public TelaDeCarregamento()
        {
            InitializeComponent();
        }

        private void TimerInicio_Tick(object sender, EventArgs e)
        {
            timerInicio.Stop();
            lblPrincipal.Text = "INICIANDO DATABASE...";
            CriarBanco();
            TimerFim.Enabled = true;
        }

        private void CriarBanco()
        {
            _criarBanco = new Thread(BancoDados);
            _criarBanco.SetApartmentState(ApartmentState.STA);
            _criarBanco.Start();
        }

        private void BancoDados(object obj)
        {
            CriarBancoDados.CreateDataBase();
        }



        private void TimerFim_Tick(object sender, EventArgs e)
        {
            TimerFim.Stop();
            lblPrincipal.Text = "ABRINDO APLICAÇÃO...";
            ExecutarThread();
            
        }

        private void ExecutarThread()
        {
            _abrirPaginaInicial = new Thread(AbrirAplicacao);
            _abrirPaginaInicial.SetApartmentState(ApartmentState.STA);
            if(_criarBanco.ThreadState == ThreadState.Stopped)
            {
                Finalizar();
            }
            else
            {
                timerSeguranca.Enabled = true;
            }
        }

        private void AbrirAplicacao(object obj)
        {
            Application.Run(new PaginaInicial());
        }

        private void TimerSeguranca_Tick(object sender, EventArgs e)
        {
            if (_criarBanco.ThreadState == ThreadState.Stopped)
            {
                timerSeguranca.Stop();
                Finalizar();
            }
        }

        private void Finalizar()
        {
            _abrirPaginaInicial.Start();
            Thread.Sleep(1000);
            Close();
        }

        //////////////////////////////// MOVER FORM ///////////////////
        private void TelaDeCarregamento_MouseDown(object sender, MouseEventArgs e)
        {
            Controles.ReleaseCapture();
            Controles.SendMessage(Handle, 0x112, 0xf012, 0);
        }


    }
}
