﻿using Microsoft.EntityFrameworkCore;
using RESTAPI.Controllers.Model;

namespace RESTAPI.Model.Context
{
    public class MySQLContext :  DbContext
    {
        public MySQLContext()
        {

        }

        public MySQLContext(DbContextOptions<MySQLContext>options) : base(options)
        {

        }

        public DbSet<Person> Persons { get; set;  }


    }
}
