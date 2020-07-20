using Dapper;
using SVTank.Domain.Entities;
using SVTank.Domain.Repository;

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace SVTank.Domain.Services
{
    public class ClienteService : IClienteRepository
    {
        private readonly string connectionString = "";

        public int AtualizarCliente(int idCliente)
        {
            throw new NotImplementedException();
        }

        public int InserirCliente(Cliente cliente)
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    var query = "INSERT INTO Cliente VALUES(@Nome, @CNPJ, @Logradouro, @NumeroEndereco, @Complemento, @CEP, @Bairro, @Cidade, @UF)";
                    connection.Execute(query);
                }

                return 1;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Cliente ObterCliente(int idCliente)
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    var query = "SELECT * FROM Cliente WHERE IdCliente = " + idCliente;
                    var cliente = connection.Query<Cliente>(query).FirstOrDefault();

                    return cliente;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Cliente> ObterClientes()
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    var query = "SELECT * FROM Cliente";
                    var lstClientes = connection.Query<Cliente>(query).ToList();

                    return lstClientes;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int RemoverCliente(int idCliente)
        {
            throw new NotImplementedException();
        }
    }
}
