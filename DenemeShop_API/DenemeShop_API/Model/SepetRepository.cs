using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Dapper;

namespace DenemeShop_API.Model
{
    public class SepetRepository
    {
        private readonly string _connectionString;

        public SepetRepository()
        {
            _connectionString = "Server=DESKTOP-REC6226;Database=ETicaretDb;Integrated Security=true;Pooling=true;";
        }
        public IDbConnection Connection
        {
            get
            {
                return new SqlConnection(_connectionString);
            }
        }

        public IEnumerable<SepetModel> GetAll()
        {
            using (IDbConnection dbConnection = Connection)
            {
                string sQuery = @"SELECT * FROM Sepet ";
                dbConnection.Open();
                return dbConnection.Query<SepetModel>(sQuery);
            }
        }

        public IEnumerable<SepetModel> GetAllUser(int userId)
        {
            using (IDbConnection dbConnection = Connection)
            {
                string sQuery = @"SELECT * FROM Sepet where userId=@userId ";
                dbConnection.Open();
                return dbConnection.Query<SepetModel>(sQuery, new { userId = userId });
            }
        }
        public SepetModel GetById(int id)
        {
            using (IDbConnection dbConnection = Connection)
            {
                string sQuery = @"SELECT * FROM Sepet WHERE Id=@Id";
                dbConnection.Open();
                return dbConnection.Query<SepetModel>(sQuery, new { Id = id }).FirstOrDefault();
            }
        }
        public SepetModel GetByIdUser(int id, int userId)
        {
            using (IDbConnection dbConnection = Connection)
            {
                string sQuery = @"SELECT * FROM Sepet WHERE Id=@Id AND userId=@userId";
                dbConnection.Open();
                return dbConnection.Query<SepetModel>(sQuery, new { Id = id, userId = userId }).FirstOrDefault();
            }
        }
        public void Add(SepetModel prod)
        {
            using (IDbConnection dbConnection = Connection)
            {
                string sQuery = @"INSERT INTO Sepet (Id,SepetName,SepetQuantity,SepetPrice,SepetImgUrl,SepetDescription,userId) VALUES(@Id,@SepetName,@SepetQuantity,@SepetPrice,@SepetImgUrl,@SepetDescription,@userId)";
                dbConnection.Open();
                dbConnection.Execute(sQuery, prod);
            }
        }

        public void Update(SepetModel prod)
        {
            using (IDbConnection dbConnection = Connection)
            {
                string sQuery = @"UPDATE Sepet SET Id=@Id,SepetName=@SepetName,SepetQuantity=@SepetQuantity, SepetPrice=@SepetPrice,SepetImgUrl=@SepetImgUrl,SepetDescription=@SepetDescription,userId=@userId
                                WHERE Id=@Id AND userId=@userId";
                dbConnection.Open();
                dbConnection.Execute(sQuery, prod);
            }
        }
        public void Delete(int Id)
        {
            using (IDbConnection dbConnection = Connection)
            {
                string sQuery = @"DELETE FROM Sepet WHERE Id=@Id";
                dbConnection.Open();
                dbConnection.Execute(sQuery, new { Id = Id });
            }
        }
        public void DeleteUser(int Id, int userId)
        {
            using (IDbConnection dbConnection = Connection)
            {
                string sQuery = @"DELETE FROM Sepet WHERE Id=@Id AND userId=@userId";
                dbConnection.Open();
                dbConnection.Execute(sQuery, new { Id = Id, userId = userId });
            }
        }
    }
}
