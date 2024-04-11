using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
//using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingLocalMaui.Models
{
    public class Client
    {
        [PrimaryKey,AutoIncrement]

        public int ClientId { get; set; }

        public string FirstName { get; set; }
        public string Surname{ get; set; }

        public string Email{ get; set; }

        public string SaIdnumber { get; set; }
        public DateTime DateOfBirth  { get; set; }

        public string ContactNumber { get; set; }
        public string PhysicalAddress { get; set; }

        [ForeignKey(typeof(ClientType))]
        public int ClientTypeID { get; set; }

        [ForeignKey(typeof(Bank))]
        public int BankID { get; set;}

        [ManyToOne]
        public Bank Bank { get; set;}
    }
    
}
