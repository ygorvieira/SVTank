using Dapper;
using SVTank.Domain.Entities;
using SVTank.Domain.Entities.Enums;
using SVTank.Domain.Repository;

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace SVTank.Domain.Services
{
    public class LaudoService : ILaudoRepository
    {
        private readonly string connectionString = "Data Source=den1.mssql7.gear.host; Initial Catalog=svtank; User Id=svtank; Password=Sx8H!3Su4At?";

        public int AtualizarLaudo(int idLaudo)
        {
            throw new NotImplementedException();
        }

        public int InserirLaudo(Laudo laudo)
        {
            try
            {
                if (laudo.TipoLaudo == TipoLaudoEnum.Anual)
                {
                    laudo.DataValidade = laudo.DataInspecao.AddYears(1);
                }
                else
                {
                    laudo.DataValidade = laudo.DataInspecao.AddMonths(3);
                }

                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    var query = "INSERT INTO Laudo(DataInspecao, DataValidade, ClienteId, TipoEquipamentoId, TAG, AnoFabricacao, TipoLaudo, Status) VALUES(@DataInspecao, @DataValidade, @ClienteId, @TipoEquipamentoId, @TAG, @AnoFabricacao, @TipoLaudo, @Status)";
                    connection.Execute(query, laudo);
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

        public List<Laudo> ObterLaudosVencidos(string dataVencimento)
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    var query = "SELECT * FROM Laudo WHERE DataValidade <= '" + dataVencimento + "'";
                    var lstLaudosVencidos = connection.Query<Laudo>(query).ToList();

                    return lstLaudosVencidos;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int RemoverLaudo(int idLaudo)
        {
            throw new NotImplementedException();
        }
    }
}
