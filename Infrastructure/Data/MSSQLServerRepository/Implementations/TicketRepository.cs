﻿using ApplicationCore.Domain.Core.Models.Cinema;
using Infrastructure.Data.MSSQLServerRepository.Connection;
using System.Data.SqlClient;

namespace Infrastructure.Data.MSSQLServerRepository.Implementations
{
    internal class TicketRepository : MainMSSQLServerRepository<Ticket>
    {
        public TicketRepository(string connectionString, string tableName, string insertQuery, string updateQuery, string getAllQuery, string getByIdQuery) 
            : base(connectionString, 
                  tableName, 
                  insertQuery, 
                  updateQuery, 
                  getAllQuery, 
                  getByIdQuery)
        {
        }

        protected override Ticket GetReader(SqlDataReader sqlDataReader)
        {
            throw new NotImplementedException();
        }

        protected override void InsertCommand(SqlCommand sqlCommand, Ticket entity)
        {
            throw new NotImplementedException();
        }
    }
}
