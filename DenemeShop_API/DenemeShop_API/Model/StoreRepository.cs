using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Dapper;

namespace DenemeShop_API.Model
{
    public class StoreRepository
    {
        private string connectionString;

        public StoreRepository()
        {
            connectionString = "Server=DESKTOP-REC6226;Database=ETicaretDb;Integrated Security=true;Pooling=true;";
        }
        public IDbConnection Connection
        {
            get
            {
                return new SqlConnection(connectionString);
            }
        }
        public IEnumerable<Store> GetAllStore()
        {
            using (IDbConnection dbConnection = Connection)
            {
                string sQuery = @"SELECT * FROM Store";
                dbConnection.Open();
                return dbConnection.Query<Store>(sQuery);
            }
        }
        public void AddStore(Store store)
        {
            using (IDbConnection dbConnection = Connection)
            {
                string sQuery = @"INSERT INTO Store (groupName) VALUES(@groupName)";
                dbConnection.Open();
                dbConnection.Execute(sQuery, store);
            }
        }
        public void UpdateStore(Store store)
        {
            using (IDbConnection dbConnection = Connection)
            {
                string sQuery = @"UPDATE Store SET groupName=@groupName 
                                WHERE groupId=@groupId";
                dbConnection.Open();
                dbConnection.Execute(sQuery, store);
            }
        }
        public void DeleteStore(int groupId)
        {
            using (IDbConnection dbConnection = Connection)
            {
                string sQuery = @"DELETE FROM Store WHERE groupId=@groupId";
                dbConnection.Open();
                dbConnection.Execute(sQuery, new { groupId = groupId });
            }
        }
    }
}
