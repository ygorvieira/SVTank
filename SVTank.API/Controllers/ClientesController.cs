using Microsoft.AspNetCore.Mvc;

using SVTank.Domain.Entities;
using SVTank.Domain.Services;

using System.Collections.Generic;

namespace SVTank.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        private readonly ClienteService clienteService = new ClienteService();

        [HttpGet]
        [Route("GetClientes/")]
        public List<Cliente> GetClientes()
        {
            return clienteService.ObterClientes();
        }

        [HttpGet]
        [Route("GetCliente/ID/{idCliente}/")]
        public Cliente GetCliente(int idCliente)
        {
            return clienteService.ObterCliente(idCliente);
        }

        [HttpPost]
        [Route("InsertCliente/")]
        public void PostCliente(Cliente cliente)
        {
            clienteService.InserirCliente(cliente);
        }
    }
}