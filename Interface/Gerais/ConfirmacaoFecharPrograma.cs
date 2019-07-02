using System;
using System.Windows.Forms;

namespace Interface
{
    public partial class ConfirmacaoFecharPrograma : Form
    {
        public ConfirmacaoFecharPrograma()
        {
            InitializeComponent();
        }

        public string Resultado = "Cancelar";

        private void BtnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnOK_Click_1(object sender, EventArgs e)
        {
            Resultado = "OK";
            this.Close();
        }
    }
}
