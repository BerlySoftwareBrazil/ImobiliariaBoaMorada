using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#region Imports
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Conventions;
#endregion

namespace ImobiliariaBoaMorada.Intraestrutura.ORM.EF
{
    public class ContextImobiliariaBoaMorada : DbContext
    {
        public ContextImobiliariaBoaMorada() : base("ImobiliariaBoaMorada") { }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }
    }
}
