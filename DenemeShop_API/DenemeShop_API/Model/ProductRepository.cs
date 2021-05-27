using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Dapper;

namespace DenemeShop_API.Model
{
    public class ProductRepository
    {
        private readonly string _connectionString;

        public ProductRepository()
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

        public IEnumerable<ProductWithStore> GetAll()
        {
            using (IDbConnection dbConnection = Connection)
            {
                string sQuery = @"SELECT * FROM Products p INNER JOIN Store s ON p.groupId=s.groupId ";
                dbConnection.Open();
                return dbConnection.Query<ProductWithStore>(sQuery);
            }
        }
        public ProductWithStore GetById(int id)
        {
            using (IDbConnection dbConnection = Connection)
            {
                string sQuery = @"SELECT * FROM Products p INNER JOIN Store s ON p.groupId=s.groupId WHERE Id=@Id";
                dbConnection.Open();
                return dbConnection.Query<ProductWithStore>(sQuery, new { Id = id }).FirstOrDefault();
            }
        }

        public IEnumerable<Kategori> KategoriGetAll()
        {
            using (IDbConnection dbConnection = Connection)
            {
                string sQuery = @"SELECT * FROM Kategori";
                dbConnection.Open();
                return dbConnection.Query<Kategori>(sQuery);
            }
        }

        public IEnumerable<ProductWithKategori> GetByKategori(int KategoriID)
        {
            using (IDbConnection dbConnection = Connection)
            {
                string sQuery = @"select * from Products INNER JOIN Kategori on Kategori.KategoriID=Products.KategoriID WHERE Products.KategoriID=@KategoriID";
                dbConnection.Open();
                return dbConnection.Query<ProductWithKategori>(sQuery, new { KategoriID = KategoriID });
            }
        }
        public IEnumerable<ProductWithStore> Search(string ara)
        {
            using (IDbConnection dbConnection = Connection)
            {
                string sQuery = @"SELECT * FROM Products p INNER JOIN Store s ON p.groupId=s.groupId Where Name like @SEARCH ";
                dbConnection.Open();
                IEnumerable<ProductWithStore> lst = dbConnection.Query<ProductWithStore>(sQuery, new { SEARCH = "%" + ara + "%" });
                return lst;
            }
        }
        public void Add(Product prod)
        {
            using (IDbConnection dbConnection = Connection)
            {
                string sQuery = @"INSERT INTO Products (Name,Quantity,Price,ImageUrl,Description,groupId,KategoriID) VALUES(@Name,@Quantity,@Price,@ImageUrl,@Description,@groupId,@KategoriID)";
                dbConnection.Open();
                dbConnection.Execute(sQuery, prod);
            }
        }
        public void Update(int Id,Product prod)
        {
            using (IDbConnection dbConnection = Connection)
            {
                string sQuery = @"UPDATE Products SET Name=@Name,Quantity=@Quantity, Price=@Price,ImageUrl=@ImageUrl,Description=@Description, groupId=@groupId, KategoriID=@KategoriID
                               WHERE Id=@Id";
                dbConnection.Open();
                dbConnection.Execute(sQuery, prod);
            }
        }
        public void ProductUpdate(Product prod)
        {
            using (IDbConnection dbConnection = Connection)
            {
                string sQuery = @"UPDATE Products SET Quantity=Quantity-@Quantity
                                WHERE Id=@Id";
                dbConnection.Open();
                dbConnection.Execute(sQuery, prod);
            }
        }
        public void UpdateBuy(int id, int quantity)
        {
            using (IDbConnection dbConnection = Connection)
            {
                string sQuery = @"UPDATE Products SET Quantity=@Quantity
                                WHERE Id=@Id";
                dbConnection.Open();
                dbConnection.Execute(sQuery, new { Id = id, Quantity = quantity });
            }
        }
        public void Delete(int id)
        {
            using (IDbConnection dbConnection = Connection)
            {
                string sQuery = @"DELETE FROM Products WHERE Id=@Id";
                dbConnection.Open();
                dbConnection.Execute(sQuery, new { Id = id });
            }
        }
    }
}

