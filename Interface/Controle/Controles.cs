using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Interface.Controle
{
    public class Controles
    {
        public static void Redimensionar(Form form)
        {
            if (form.Height == 730)
            {
                form.Height = 620;
                form.Width = 1100;
            }
            else
            {
                form.Height = 730;
                form.Width = 1370;
            }
        }

        public static void ManterTamanho(Form form1, Form form2)
        {
            if (form1.Height == 730)
            {
                form2.Height = 730;
                form2.Width = 1370;
            }
            else
            {
                form2.Height = 620;
                form2.Width = 1100;
            }
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        public extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        public extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

    }
}
