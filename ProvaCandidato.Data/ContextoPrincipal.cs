using ProvaCandidato.Data.Entidade;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;

using System.Threading.Tasks;

namespace ProvaCandidato.Data
{
  public class ContextoPrincipal : DbContext
  {
    const string CONNECTION_STRING = @"Password=1234;Persist Security Info=True;User ID=herb;Initial Catalog=provacandidato;Data Source=DESKTOP-80IHR46";


    public ContextoPrincipal() : base(CONNECTION_STRING) { }
    
    public DbSet<Cliente> Clientes { get; set; }
    public DbSet<Cidade> Cidades { get; set; }
  }
}
