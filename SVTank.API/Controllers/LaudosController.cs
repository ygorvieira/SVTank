using Microsoft.AspNetCore.Mvc;

using SVTank.Domain.Entities;
using SVTank.Domain.Services;

using System.Collections.Generic;

namespace SVTank.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LaudosController : ControllerBase
    {
        private readonly LaudoService serviceLaudo = new LaudoService();

        [HttpGet]
        [Route("GetLaudos/")]
        public List<Laudo> GetLaudos()
        {
            return serviceLaudo.ObterLaudos();
        }

        [HttpGet]
        [Route("GetLaudo/ID/{idLaudo}/")]
        public Laudo GetLaudo(int idLaudo)
        {
            return serviceLaudo.ObterLaudo(idLaudo);
        }

        [HttpGet]
        [Route("GetLaudosVencidos/DataVencimento/{data}/")]
        public List<Laudo> GetLaudosVencidos(string data)
        {
            //var dataVencimento = Convert.ToDateTime(data);
            return serviceLaudo.ObterLaudosVencidos(data);
        }

        [HttpPost]
        [Route("InsertLaudo/")]
        public void PostLaudo(Laudo laudo)
        {
            serviceLaudo.InserirLaudo(laudo);
        }
    }
}