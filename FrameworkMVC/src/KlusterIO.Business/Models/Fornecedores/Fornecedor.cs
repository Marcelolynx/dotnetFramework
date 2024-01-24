using System.Collections.Generic;
using KlusterIO.Business.Core.Models;
using KlusterIO.Business.Models.Produtos;

namespace KlusterIO.Business.Models.Fornecedores
{
    public class Fornecedor : Entity
    {
        public string Nome { get; set; }
        public string Documento { get; set; }
        public TipoFornecedor TipoFornecedor { get; set; }
        public Endereco Endereco { get; set; }
        public bool Ativo { get; set; }

        /* EF Relations */
        
        public ICollection<Produto> Produtos { get; set; }
    }
}