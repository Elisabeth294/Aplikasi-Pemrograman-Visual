using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace KasirWarkopApp
{
    public class MenuCrud
    {
        private DatabaseConnection _dbConnection;

        public MenuCrud()
        {
            _dbConnection = new DatabaseConnection();
        }

        // Load Data Menu
        public List<Menu> LoadMenu()
        {
            var menuList = new List<Menu>();
            string query = "SELECT * FROM Menu";

            DataTable dataTable = _dbConnection.ExecuteQuery(query);

            foreach (DataRow row in dataTable.Rows)
            {
                menuList.Add(new Menu
                {
                    Id = Convert.ToInt32(row["Id"]),
                    Nama = row["Nama"].ToString(),
                    Harga = Convert.ToDecimal(row["Harga"])
                });
            }

            return menuList;
        }

        // Tambah Menu
        public void AddMenu(string namaMenu, decimal hargaMenu)
        {
            string query = "INSERT INTO Menu (Nama, Harga) VALUES (@Nama, @Harga)";
            var parameters = new MySqlParameter[]
            {
                new MySqlParameter("@Nama", namaMenu),
                new MySqlParameter("@Harga", hargaMenu)
            };
            _dbConnection.ExecuteNonQuery(query, parameters);
        }

        // Edit Menu
        public void EditMenu(int id, string namaMenu, decimal hargaMenu)
        {
            string query = "UPDATE Menu SET Nama = @Nama, Harga = @Harga WHERE Id = @Id";
            var parameters = new MySqlParameter[]
            {
                new MySqlParameter("@Nama", namaMenu),
                new MySqlParameter("@Harga", hargaMenu),
                new MySqlParameter("@Id", id)
            };
            _dbConnection.ExecuteNonQuery(query, parameters);
        }

        // Hapus Menu
        public void DeleteMenu(int id)
        {
            string query = "DELETE FROM Menu WHERE Id = @Id";
            var parameters = new MySqlParameter[]
            {
                new MySqlParameter("@Id", id)
            };
            _dbConnection.ExecuteNonQuery(query, parameters);
        }
    }
}
