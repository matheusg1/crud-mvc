using Microsoft.EntityFrameworkCore;
using TelecallUnisuamCRUD.Models;

namespace TelecallUnisuamCRUD.Repository
{
    public class TelecallApplicationContext : DbContext
    {
        public DbSet<Usuario> Usuarios;
        public DbSet<Tentativa_acesso> Tentativa_acesso;
        public DbSet<Tipo_autenticacao> Tipo_autenticacao;
        public DbSet<Tipo_usuario> Tipo_usuario;
        public DbSet<Autenticou> Autenticou;

        public TelecallApplicationContext(DbContextOptions<TelecallApplicationContext> options) : base(options)
        {
        }
    }
}
