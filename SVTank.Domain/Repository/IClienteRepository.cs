using SVTank.Domain.Entities;

using System.Collections.Generic;

namespace SVTank.Domain.Repository
{
    public interface IClienteRepository
    {
        int InserirCliente(Cliente cliente);
        List<Cliente> ObterClientes();
        Cliente ObterCliente(int idCliente);
        int AtualizarCliente(int idCliente);
        int RemoverCliente(int idCliente);
    }
}
