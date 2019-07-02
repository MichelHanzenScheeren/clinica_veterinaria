using Modelo.Excessoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface.Controle
{
    public class ValidarPreenchimento
    {

        public static void Validacao(ErrorProvider ErroPreenchimento, params Control[] controles)
        {
            int cont = 0;
            foreach (var item in controles)
            {
                if (string.IsNullOrEmpty(item.Text))
                {
                    ErroPreenchimento.SetError(item, "CAMPO DE PREENCHIMENTO OBRIGATÓRIO");
                    cont++;
                }
                else
                {
                    ErroPreenchimento.SetError(item, null);
                }

            }
            if(cont != 0)
            {
                throw new NaoPreenchidoException("UM OU MAIS CAMPOS OBRIGATÓRIOS NÃO PREENCHIDOS!");
            }
               
        }
    }
}
