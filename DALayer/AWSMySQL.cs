﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALayer
{
    class AWSMySQL : SQLBase
    {
        public string connString = "Server=rdb-mysql-cinema.ckummbvzo7mk.us-east-1.rds.amazonaws.com;" + "Port=3306;"
                + " Database=mysqlCinema;" + "Uid=hcasim4839;" + "Pwd=Teachflynn12!";
        public override void Delete(string command)
        {
            throw new NotImplementedException();
        }

        public override void Insert(string command)
        {
            throw new NotImplementedException();
        }
    }

}
