using System;
using System.Threading.Tasks;
using KlusterIO.Business.Core.Data;

namespace KlusterIO.Business.Models.Fornecedores
{
    public interface IEnderecoRepository : IRepository<Endereco>
    {
        Task<Endereco> ObterEnderecoPorFornecedor(Guid fornecedorId);
    }
}