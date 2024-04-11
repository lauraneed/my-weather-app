﻿using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingLocalMaui.Models
{
    public class TransactionType
    {
        [PrimaryKey, AutoIncrement]
      public int TransactionTypeID { get; set; }

        public string TransactionTypeDescription { get; set; }
    }
}
