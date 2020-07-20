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
        public List<Cliente> Get()
        {
            return clienteService.ObterClientes();
        }

        [HttpGet]
        [Route("GetCliente/ID/{idCliente}/", Name ="Get")]
        public Cliente Get(int idCliente)
        {
            return clienteService.ObterCliente(idCliente);
        }

        [HttpPost]
        [Route("InsertCliente/")]
        public void Post(Cliente cliente)
        {
            clienteService.InserirCliente(cliente);
        }
    }
}