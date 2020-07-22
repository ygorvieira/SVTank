using Microsoft.AspNetCore.Mvc;

using SVTank.Domain.Entities;
using SVTank.Domain.Services;

using System.Collections.Generic;

namespace SVTank.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EquipamentosController : ControllerBase
    {
        private readonly TipoEquipamentoService serviceEquipamento = new TipoEquipamentoService();

        [HttpGet]
        [Route("GetEquipamentos/")]
        public List<TipoEquipamento> GetEquipamentos()
        {
            return serviceEquipamento.ObterTiposEquipamentos();
        }

        [HttpGet]
        [Route("GetEquipamento/ID/{idEquipamento}/")]
        public TipoEquipamento GetEquipamento(int idEquipamento)
        {
            return serviceEquipamento.ObterTipoEquipamento(idEquipamento);
        }

        [HttpPost]
        [Route("InsertEquipamento/")]
        public void PostEquipamento(TipoEquipamento equipamento)
        {
            serviceEquipamento.InserirEquipamento(equipamento);
        }
    }
}