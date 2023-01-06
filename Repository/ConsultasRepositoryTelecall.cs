using System.Linq;
using TelecallUnisuamCRUD.Models;

namespace TelecallUnisuamCRUD.Repository
{
    public class ConsultasRepositoryTelecall
    {
        private readonly TelecallApplicationContext context;

        public ConsultasRepositoryTelecall(TelecallApplicationContext context)
        {
            this.context = context;
        }

        public IQueryable<Usuario> ObterTodosUsuarios()
        {
            try
            {
            return context.Set<Usuario>();
            }
            catch
            {
                return null;
            }
        }

        public IQueryable<Usuario> ObterUsuarioById(int id)
        {
            try
            {
                return context.Set<Usuario>().Where(u => u.usu_id == id);
            }
            catch
            {
                return null;
            }
        }
    }
}