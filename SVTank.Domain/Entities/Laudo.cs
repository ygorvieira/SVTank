﻿using SVTank.Domain.Entities.Enums;

using System;

namespace SVTank.Domain.Entities
{
    public class Laudo
    {
        public int IdLaudo { get; set; }
        public DateTime DataInspecao { get; set; }
        public DateTime DataValidade { get; set; }
        public int ClienteId { get; set; }
        public int TipoEquipamentoId { get; set; }
        public string TAG { get; set; }
        public int AnoFabricacao { get; set; }
        public TipoLaudoEnum TipoLaudo { get; set; }
        public bool Status { get; set; }
    }
}
