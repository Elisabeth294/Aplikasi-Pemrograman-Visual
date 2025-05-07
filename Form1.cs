using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace KasirWarkopApp
{
    public partial class Form1 : Form
    {
        private MenuCrud _menuCrud;
        private List<Menu> daftarMenu = new List<Menu>();
        private List<Menu> keranjang = new List<Menu>();

        public Form1()
        {
            InitializeComponent();
            _menuCrud = new MenuCrud();

            // Test database connection at startup
            var dbConnection = new DatabaseConnection();
            if (dbConnection.TestConnection())
            {
                MessageBox.Show("Koneksi ke database berhasil!", "Koneksi Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            LoadMenu();
            TampilkanMenu();
        }

        private void LoadMenu()
        {
            daftarMenu = _menuCrud.LoadMenu();
        }

        private void TampilkanMenu()
        {
            dgvMenu.DataSource = null;
            dgvMenu.DataSource = daftarMenu;
        }

        private void btnTambahKeKeranjang_Click(object sender, EventArgs e)
        {
            if (dgvMenu.SelectedRows.Count > 0)
            {
                var row = dgvMenu.SelectedRows[0];
                var id = Convert.ToInt32(row.Cells[0].Value);
                var menu = daftarMenu.FirstOrDefault(m => m.Id == id);
                if (menu != null)
                {
                    keranjang.Add(menu);
                    TampilkanKeranjang();
                }
            }
        }

        private void TampilkanKeranjang()
        {
            dgvKeranjang.DataSource = null;
            dgvKeranjang.DataSource = keranjang.Select(k => new
            {
                k.Nama,
                Harga = $"Rp {k.Harga:N0}"
            }).ToList();

            HitungTotal();
        }

        private void HitungTotal()
        {
            decimal total = keranjang.Sum(k => k.Harga);
            lblTotal.Text = $"Total: Rp {total:N0}";
        }

        private void btnBayar_Click(object sender, EventArgs e)
        {
            if (keranjang.Count == 0)
            {
                MessageBox.Show("Keranjang masih kosong!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal total = keranjang.Sum(k => k.Harga);
            MessageBox.Show($"Total pembayaran: Rp {total:N0}\nTerima kasih!", "Pembayaran", MessageBoxButtons.OK, MessageBoxIcon.Information);
            keranjang.Clear();
            TampilkanKeranjang();
        }

        // ** Fitur CRUD untuk Menu (Database) **

        private void btnTambahMenu_Click(object sender, EventArgs e)
        {
            var namaMenu = txtNamaMenu.Text;
            var hargaMenu = decimal.TryParse(txtHargaMenu.Text, out var harga) ? harga : 0;

            if (!string.IsNullOrEmpty(namaMenu) && hargaMenu > 0)
            {
                _menuCrud.AddMenu(namaMenu, hargaMenu);
                LoadMenu();
                TampilkanMenu();
            }
            else
            {
                MessageBox.Show("Nama menu dan harga harus valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditMenu_Click(object sender, EventArgs e)
        {
            if (dgvMenu.SelectedRows.Count > 0)
            {
                var row = dgvMenu.SelectedRows[0];
                var id = Convert.ToInt32(row.Cells[0].Value);
                var menu = daftarMenu.FirstOrDefault(m => m.Id == id);

                if (menu != null)
                {
                    var namaMenu = txtNamaMenu.Text;
                    var hargaMenu = decimal.TryParse(txtHargaMenu.Text, out var harga) ? harga : 0;

                    if (!string.IsNullOrEmpty(namaMenu) && hargaMenu > 0)
                    {
                        _menuCrud.EditMenu(menu.Id, namaMenu, hargaMenu);
                        LoadMenu();
                        TampilkanMenu();
                    }
                    else
                    {
                        MessageBox.Show("Nama menu dan harga harus valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnHapusMenu_Click(object sender, EventArgs e)
        {
            if (dgvMenu.SelectedRows.Count > 0)
            {
                var row = dgvMenu.SelectedRows[0];
                var id = Convert.ToInt32(row.Cells[0].Value);
                _menuCrud.DeleteMenu(id);
                LoadMenu();
                TampilkanMenu();
            }
        }
    }

    public class Menu
    {
        public int Id { get; set; }
        public string Nama { get; set; }
        public decimal Harga { get; set; }
    }
}
