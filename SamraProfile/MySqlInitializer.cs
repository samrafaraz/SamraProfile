﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using SamraProfile.Models;


namespace SamraProfile
{
    public class MySqlInitializer :IDatabaseInitializer<ApplicationDbContext>
    {
        public void InitializeDatabase(ApplicationDbContext context)
        {
            if (!context.Database.Exists())
            {
                // if database did not exist before - create it
                context.Database.Create();
            }
            else
            {
                try
                {
                    // query to check if MigrationHistory table is present in the database 
                    var migrationHistoryTableExists = ((IObjectContextAdapter)context).ObjectContext.ExecuteStoreQuery<int>(
                    string.Format(
                      "SELECT COUNT(*) FROM information_schema.tables WHERE table_schema = '{0}' AND table_name = '__MigrationHistory'",
                      "users"));
                
                    // if MigrationHistory table is not there (which is the case first time we run) - create it
                    if (migrationHistoryTableExists.FirstOrDefault() == 0)
                    {
                        context.Database.Delete();
                        context.Database.Create();
                    }
                }
                catch (Exception e) { }
            }
        }
    }
}