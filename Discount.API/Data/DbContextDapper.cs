﻿using System.Data;
using Npgsql;

namespace Discount.API.Data
{
    public class DbContextDapper
    {
        public IDbConnection Connection { get; }

        public DbContextDapper(IConfiguration configuration)
        {
            Connection = new NpgsqlConnection(configuration.GetValue<string>("DatabaseSettings:ConnectionString"));
            Connection.Open();
        }
    }
}
