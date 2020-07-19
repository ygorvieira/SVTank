using SVTank.Domain.Entities;
using SVTank.Domain.Repository;

using System;
using System.Collections.Generic;

namespace SVTank.Domain.Services
{
    public class LaudoService : ILaudoRepository
    {
        public int AtualizarLaudo(int idLaudo)
        {
            throw new NotImplementedException();
        }

        public int InserirLaudo(Laudo laudo)
        {
            throw new NotImplementedException();
        }

        public List<Laudo> ListaLaudosReprovados()
        {
            throw new NotImplementedException();
        }

        public Laudo ObterLaudo(int idLaudo)
        {
            throw new NotImplementedException();
        }

        public List<Laudo> ObterLaudos()
        {
            throw new NotImplementedException();
        }

        public List<Laudo> ObterLaudosVencidos(DateTime dataVencimento)
        {
            throw new NotImplementedException();
        }

        public int RemoverLaudo(int idLaudo)
        {
            throw new NotImplementedException();
        }
    }
}
