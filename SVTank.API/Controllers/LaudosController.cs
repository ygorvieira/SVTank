using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SVTank.Domain.Entities;
using SVTank.Domain.Services;

namespace SVTank.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LaudosController : ControllerBase
    {
        private readonly LaudoService serviceLaudo = new LaudoService();

        [HttpGet]
        [Route("GetLaudos/")]
        public List<Laudo> Get()
        {
            return serviceLaudo.ObterLaudos();
        }

        [HttpGet]
        [Route("GetLaudo/ID/{idLaudo}/", Name = "Get")]
        public Laudo Get(int idLaudo)
        {
            return serviceLaudo.ObterLaudo(idLaudo);
        }

        [HttpPost]
        [Route("InsertLaudo/")]
        public void Post(Laudo laudo)
        {
            serviceLaudo.InserirLaudo(laudo);
        }
    }
}