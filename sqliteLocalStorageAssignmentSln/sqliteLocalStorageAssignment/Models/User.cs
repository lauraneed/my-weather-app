using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
//using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace sqliteLocalStorageAssignment.Models
{
    public class User
    {
        [PrimaryKey, AutoIncrement]

        public int Id { get; set; }

        public string FirstName { get; set; }

        public string Surname { get; set; }
        public string EmailAddress { get; set; }

        public string Bio {  get; set; }


    }
}
