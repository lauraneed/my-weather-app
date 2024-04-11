using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankingLocalMaui.Models;
using SQLite;
using SQLiteNetExtensions.Extensions;
using SQLitePCL;

namespace BankingLocalMaui.Services
{
    public class BankingLocalDatabase
    {
        private SQLiteConnection _dbConnection;
        public string GetDataBasePath()
        {

            string filename = "bankingdata.db";
            string pathToDb = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);

            return Path.Combine(pathToDb, filename);


        }
        public BankingLocalDatabase()
        {

            _dbConnection = new SQLiteConnection(GetDataBasePath());
            _dbConnection.CreateTable<ClientType>();
            _dbConnection.CreateTable<BankAccountType>();
            _dbConnection.CreateTable<TransactionType>();
            _dbConnection.CreateTable<Bank>();
            _dbConnection.CreateTable<Client>();
            SeedDatabase();

        }

        public void SeedDatabase()
        {
            if (_dbConnection.Table<ClientType>().Count() == 0)
            {


                ClientType clientType = new ClientType()
                {
                    ClientTypeDescription = "Private"
                };
                _dbConnection.Insert(clientType); //ROW 1

                clientType = new ClientType()
                {
                    ClientTypeDescription = "MVP"


                };
                _dbConnection.Insert(clientType);   //TWO ROWS IN THE DATA BASE / INSERT ADDS ROWS

                clientType = new ClientType()
                {

                    ClientTypeDescription = "Standard"
                };
                _dbConnection.Insert(clientType);
            }

            if (_dbConnection.Table<BankAccountType>().Count() == 0)
            {
                BankAccountType BankAccountType = new BankAccountType()
                {
                    BankAccountDescription = "Credit"



                };

                _dbConnection.Insert(BankAccountType);


                BankAccountType = new BankAccountType()
                {
                    BankAccountDescription = "Saving"



                };
                _dbConnection.Insert(BankAccountType);

                BankAccountType = new BankAccountType()
                {
                    BankAccountDescription = "Cheque"

                };


            }
            TransactionType transactionType = new TransactionType()
            {

                TransactionTypeDescription = "Deposit"
            };
            _dbConnection.Insert(transactionType);

            transactionType = new TransactionType()

            {

                TransactionTypeDescription = "Withdraw"
            };
            _dbConnection.Insert(transactionType);

            Client client = new Client() 
            { 
              FirstName = "Brandy",
              Surname = "Makky",
              SaIdnumber = "1843877687",
              ContactNumber = "082551234",
              Email = "me@Computer",
              PhysicalAddress = "Swellendamm"
            
            };

            Bank bank = new Bank()
            {

                BankName = "Nedbank",
                BranchCode = "12345",
            };
            _dbConnection.Insert(bank);
            _dbConnection.Insert(client);
            bank.Clients.Add(client);


            _dbConnection.UpdateWithChildren(bank);//basically says youve addes the client list and if you say update the children it will sort out the realtions for you
        }


        public List<ClientType> GetAllClientTypes()
        {
            var clientTypes = _dbConnection.Table<ClientType>().ToList();
            return clientTypes;
        }



    }   
      
    
}
