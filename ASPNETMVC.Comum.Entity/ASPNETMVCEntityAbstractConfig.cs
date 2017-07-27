using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPNETMVC.Comum.Entity
{
    public abstract class ASPNETMVCEntityAbstractConfig<TEntidade> : EntityTypeConfiguration<TEntidade>
        where TEntidade : class
    {
        public ASPNETMVCEntityAbstractConfig()
        {
            ConfigurarNomeTabela();
            ConfigurarCamposTabela();
            ConfigurarChavePrimaria();
            ConfigurarChavesEstrangeiras();
        }

        protected abstract void ConfigurarNomeTabela();

        protected abstract void ConfigurarCamposTabela();

        protected abstract void ConfigurarChavePrimaria();

        protected abstract void ConfigurarChavesEstrangeiras();
    }
}
