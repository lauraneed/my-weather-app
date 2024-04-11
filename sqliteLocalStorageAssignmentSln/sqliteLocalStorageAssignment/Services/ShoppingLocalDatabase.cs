using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sqliteLocalStorageAssignment.Models;
using SQLite;
using SQLiteNetExtensions.Extensions;
using SQLitePCL;
using System.ComponentModel.DataAnnotations;
using System.Net.NetworkInformation;

namespace sqliteLocalStorageAssignment.Services
{
    public class ShoppingLocalDatabase
    {
        private SQLiteConnection _dbConnection;

        

        public string GetDataBasePath()
        {
            string filename = "Shoppingdata.db";
            string pathToDb = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            return Path.Combine(pathToDb, filename);
        }

        public ShoppingLocalDatabase()
        {
            _dbConnection = new SQLiteConnection(GetDataBasePath());

            _dbConnection.CreateTable<User>();

            SeedDataBase();

        }

        public void SeedDataBase()
        {
            var user = new User
            {
                FirstName = "Lauren",
                Surname = "Petrus",
                EmailAddress = "laurenleigh12@gmail.com",
                Bio = "hectic"
            };

            

           

            
        }

        internal User GetUserById(int v)
        {
            throw new NotImplementedException();
        }

        //internal User GetUserById(int v)
        //{
        //throw new NotImplementedException();
        //}
    }
}