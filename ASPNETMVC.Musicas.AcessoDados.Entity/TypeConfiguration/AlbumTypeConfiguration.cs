using ASPNETMVC.Comum.Entity;
using ASPNETMVC.Musicas.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPNETMVC.Musicas.AcessoDados.Entity.TypeConfiguration
{
    public class AlbumTypeConfiguration : ASPNETMVCEntityAbstractConfig<Album>
    {
        protected override void ConfigurarCamposTabela()
        {
            Property( p => p.Id )
                .IsRequired()
                .HasDatabaseGeneratedOption( System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity )
                .HasColumnName( "ALB_ID" );

            Property( p => p.Nome )
                .IsRequired()
                .HasColumnName( "ALB_NOME" )
                .HasMaxLength( 100 );

            Property( p => p.Ano )
                .IsRequired()
                .HasColumnName( "ALB_ANO" );

            Property( p => p.Observacoes )
                .IsOptional()
                .HasColumnName( "ALB_OBSERVACOES" )
                .HasMaxLength( 100 );
            Property( p => p.Email )
                .IsRequired()
                .HasColumnName( "ALB_EMAIL" )
                .HasMaxLength( 100 );
        }

        protected override void ConfigurarChavePrimaria()
        {
            HasKey( k => k.Id );
        }

        protected override void ConfigurarChavesEstrangeiras()
        {
            
        }

        protected override void ConfigurarNomeTabela()
        {
            ToTable( "ALB_ALBUNS" );
        }
    }
}
