using System.Data.Entity.ModelConfiguration;
using KlusterIO.Business.Models.Fornecedores;

namespace KlusterIO.Infra.Data.Mappings
{
    public class EnderecoMap : EntityTypeConfiguration<Endereco>
    {
        public EnderecoMap()
        {
            HasKey(e => e.Id);

            Property(e => e.Logradouro)
                .IsRequired()
                .HasMaxLength(200);

            Property(e => e.Numero)
                .IsRequired()
                .HasMaxLength(50);

            Property(e => e.Cep)
                .IsRequired()
                .HasMaxLength(8)
                .IsFixedLength();

            Property(e => e.Complemento)
                .HasMaxLength(250);

            Property(e => e.Bairro)
                .IsRequired()
                .HasMaxLength(100);

            Property(e => e.Cidade)
                .IsRequired()
                .HasMaxLength(100);

            Property(e => e.Estado)
                .IsRequired()
                .HasMaxLength(100);

            ToTable("Enderecos");
        }
    }
}