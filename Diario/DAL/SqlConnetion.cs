﻿using System;
using System.Data.SqlClient;

namespace DAL
{
    internal class SqlConnetion
    {
        public string ConnectionString { get; internal set; }

        public static implicit operator SqlConnetion(SqlConnection v)
        {
            throw new NotImplementedException();
        }

        public static implicit operator SqlConnection(SqlConnetion v)
        {
            throw new NotImplementedException();
        }
    }
}