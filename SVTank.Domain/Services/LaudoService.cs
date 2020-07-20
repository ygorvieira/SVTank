using Dapper;
using SVTank.Domain.Entities;
using SVTank.Domain.Repository;

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace SVTank.Domain.Services
{
    public class LaudoService : ILaudoRepository
    {
        private readonly string connectionString = "";

        public int AtualizarLaudo(int idLaudo)
        {
            throw new NotImplementedException();
        }

        public int InserirLaudo(Laudo laudo)
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    var query = "INSERT INTO Laudo VALUES(@DataInspecao, @DataValidade, @ClienteId, @TipoEquipamentoId, @TAG, @AnoFabricacao, @TipoLaudo, @Status)";
                    connection.Execute(query);
                }
                return 1;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Laudo> ListaLaudosReprovados()
        {
            throw new NotImplementedException();
        }

        public Laudo ObterLaudo(int idLaudo)
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    var query = "SELECT * FROM Laudo WHERE IdLaudo = " + idLaudo;
                    var laudo = connection.Query<Laudo>(query).FirstOrDefault();

                    return laudo;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Laudo> ObterLaudos()
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    var query = "SELECT * FROM Laudo";
                    var lstLaudos = connection.Query<Laudo>(query).ToList();

                    return lstLaudos;
                }
            }
            catch (Exception)
            {

                throw;
            }
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
