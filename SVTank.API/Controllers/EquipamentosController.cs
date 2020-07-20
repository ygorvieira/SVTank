﻿using System;
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
    public class EquipamentosController : ControllerBase
    {
        private readonly TipoEquipamentoService serviceEquipamento = new TipoEquipamentoService();

        [HttpGet]
        [Route("GetEquipamentos/")]
        public List<TipoEquipamento> Get()
        {
            return serviceEquipamento.ObterTiposEquipamentos();
        }

        [HttpGet]
        [Route("GetEquipamento/ID/{idEquipamento}/", Name = "Get")]
        public TipoEquipamento Get(int idEquipamento)
        {
            return serviceEquipamento.ObterTipoEquipamento(idEquipamento);
        }

        [HttpPost]
        [Route("InsertEquipamento/")]
        public void Post(TipoEquipamento equipamento)
        {
            serviceEquipamento.InserirEquipamento(equipamento);
        }
    }
}