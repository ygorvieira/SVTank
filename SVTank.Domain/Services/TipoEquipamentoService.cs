using Dapper;
using SVTank.Domain.Entities;
using SVTank.Domain.Repository;

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace SVTank.Domain.Services
{
    public class TipoEquipamentoService : IEquipamentoRepository
    {
        private readonly string connectionString = "Data Source=den1.mssql7.gear.host; Initial Catalog=svtank; User Id=svtank; Password=Sx8H!3Su4At?";

        public int AtualizarTipoEquipamento(int idEquipamento)
        {
            throw new NotImplementedException();
        }

        public int InserirEquipamento(TipoEquipamento equipamento)
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    var query = "INSERT INTO TipoEquipamento(Nome) VALUES(@Nome)";
                    connection.Execute(query, equipamento);
                }

                return 1;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public TipoEquipamento ObterTipoEquipamento(int idEquipamento)
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    var query = "SELECT * FROM TipoEquipamento WHERE IdTipoEquipamento = " + idEquipamento;
                    var equiapamento = connection.Query<TipoEquipamento>(query).FirstOrDefault();

                    return equiapamento;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<TipoEquipamento> ObterTiposEquipamentos()
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    var query = "SELECT * FROM TipoEquipamento";
                    var lstEquipamentos = connection.Query<TipoEquipamento>(query).ToList();

                    return lstEquipamentos;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int RemoverTipoEquipamento(int idEquipamento)
        {
            throw new NotImplementedException();
        }
    }
}
