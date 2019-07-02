using Persistencia.Controle;

namespace Servico.Controle
{
    public class CriarBancoDados
    {
        public static void CreateDataBase()
        {
            using (var context = new EFContext())
            {
                //context.Database.EnsureDeleted();
                context.Database.EnsureCreated();
            }
        }
    }
}
