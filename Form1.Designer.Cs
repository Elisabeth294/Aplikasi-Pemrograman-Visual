namespace KasirWarkopApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.DataGridView dgvMenu;
        private System.Windows.Forms.DataGridView dgvKeranjang;
        private System.Windows.Forms.Button btnTambahKeKeranjang;
        private System.Windows.Forms.Button btnBayar;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnTambahMenu;
        private System.Windows.Forms.Button btnEditMenu;
        private System.Windows.Forms.Button btnHapusMenu;
        private System.Windows.Forms.TextBox txtNamaMenu;
        private System.Windows.Forms.TextBox txtHargaMenu;
        private System.Windows.Forms.Label labelNamaMenu;
        private System.Windows.Forms.Label labelHargaMenu;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dgvMenu = new System.Windows.Forms.DataGridView();
            this.dgvKeranjang = new System.Windows.Forms.DataGridView();
            this.btnTambahKeKeranjang = new System.Windows.Forms.Button();
            this.btnBayar = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnTambahMenu = new System.Windows.Forms.Button();
            this.btnEditMenu = new System.Windows.Forms.Button();
            this.btnHapusMenu = new System.Windows.Forms.Button();
            this.txtNamaMenu = new System.Windows.Forms.TextBox();
            this.txtHargaMenu = new System.Windows.Forms.TextBox();
            this.labelNamaMenu = new System.Windows.Forms.Label();
            this.labelHargaMenu = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKeranjang)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMenu
            // 
            this.dgvMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMenu.Location = new System.Drawing.Point(30, 50);
            this.dgvMenu.Name = "dgvMenu";
            this.dgvMenu.Size = new System.Drawing.Size(300, 200);
            this.dgvMenu.TabIndex = 0;
            // 
            // dgvKeranjang
            // 
            this.dgvKeranjang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKeranjang.Location = new System.Drawing.Point(370, 50);
            this.dgvKeranjang.Name = "dgvKeranjang";
            this.dgvKeranjang.Size = new System.Drawing.Size(300, 200);
            this.dgvKeranjang.TabIndex = 1;
            // 
            // btnTambahKeKeranjang
            // 
            this.btnTambahKeKeranjang.Location = new System.Drawing.Point(150, 270);
            this.btnTambahKeKeranjang.Name = "btnTambahKeKeranjang";
            this.btnTambahKeKeranjang.Size = new System.Drawing.Size(120, 30);
            this.btnTambahKeKeranjang.TabIndex = 2;
            this.btnTambahKeKeranjang.Text = "Tambah ke Keranjang";
            this.btnTambahKeKeranjang.UseVisualStyleBackColor = true;
            this.btnTambahKeKeranjang.Click += new System.EventHandler(this.btnTambahKeKeranjang_Click);
            // 
            // btnBayar
            // 
            this.btnBayar.Location = new System.Drawing.Point(500, 270);
            this.btnBayar.Name = "btnBayar";
            this.btnBayar.Size = new System.Drawing.Size(75, 30);
            this.btnBayar.TabIndex = 3;
            this.btnBayar.Text = "Bayar";
            this.btnBayar.UseVisualStyleBackColor = true;
            this.btnBayar.Click += new System.EventHandler(this.btnBayar_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotal.Location = new System.Drawing.Point(370, 20);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(78, 19);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "Total: Rp 0";
            // 
            // btnTambahMenu
            // 
            this.btnTambahMenu.Location = new System.Drawing.Point(30, 380);
            this.btnTambahMenu.Name = "btnTambahMenu";
            this.btnTambahMenu.Size = new System.Drawing.Size(75, 30);
            this.btnTambahMenu.TabIndex = 5;
            this.btnTambahMenu.Text = "Tambah Menu";
            this.btnTambahMenu.UseVisualStyleBackColor = true;
            this.btnTambahMenu.Click += new System.EventHandler(this.btnTambahMenu_Click);
            // 
            // btnEditMenu
            // 
            this.btnEditMenu.Location = new System.Drawing.Point(110, 380);
            this.btnEditMenu.Name = "btnEditMenu";
            this.btnEditMenu.Size = new System.Drawing.Size(75, 30);
            this.btnEditMenu.TabIndex = 6;
            this.btnEditMenu.Text = "Edit Menu";
            this.btnEditMenu.UseVisualStyleBackColor = true;
            this.btnEditMenu.Click += new System.EventHandler(this.btnEditMenu_Click);
            // 
            // btnHapusMenu
            // 
            this.btnHapusMenu.Location = new System.Drawing.Point(190, 380);
            this.btnHapusMenu.Name = "btnHapusMenu";
            this.btnHapusMenu.Size = new System.Drawing.Size(75, 30);
            this.btnHapusMenu.TabIndex = 7;
            this.btnHapusMenu.Text = "Hapus Menu";
            this.btnHapusMenu.UseVisualStyleBackColor = true;
            this.btnHapusMenu.Click += new System.EventHandler(this.btnHapusMenu_Click);
            // 
            // txtNamaMenu
            // 
            this.txtNamaMenu.Location = new System.Drawing.Point(30, 330);
            this.txtNamaMenu.Name = "txtNamaMenu";
            this.txtNamaMenu.Size = new System.Drawing.Size(150, 20);
            this.txtNamaMenu.TabIndex = 8;
            // 
            // txtHargaMenu
            // 
            this.txtHargaMenu.Location = new System.Drawing.Point(190, 330);
            this.txtHargaMenu.Name = "txtHargaMenu";
            this.txtHargaMenu.Size = new System.Drawing.Size(100, 20);
            this.txtHargaMenu.TabIndex = 9;
            // 
            // labelNamaMenu
            // 
            this.labelNamaMenu.AutoSize = true;
            this.labelNamaMenu.Location = new System.Drawing.Point(30, 310);
            this.labelNamaMenu.Name = "labelNamaMenu";
            this.labelNamaMenu.Size = new System.Drawing.Size(75, 13);
            this.labelNamaMenu.TabIndex = 10;
            this.labelNamaMenu.Text = "Nama Menu:";
            // 
            // labelHargaMenu
            // 
            this.labelHargaMenu.AutoSize = true;
            this.labelHargaMenu.Location = new System.Drawing.Point(190, 310);
            this.labelHargaMenu.Name = "labelHargaMenu";
            this.labelHargaMenu.Size = new System.Drawing.Size(74, 13);
            this.labelHargaMenu.TabIndex = 11;
            this.labelHargaMenu.Text = "Harga Menu:";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(700, 450);
            this.Controls.Add(this.labelHargaMenu);
            this.Controls.Add(this.labelNamaMenu);
            this.Controls.Add(this.txtHargaMenu);
            this.Controls.Add(this.txtNamaMenu);
            this.Controls.Add(this.btnHapusMenu);
            this.Controls.Add(this.btnEditMenu);
            this.Controls.Add(this.btnTambahMenu);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnBayar);
            this.Controls.Add(this.btnTambahKeKeranjang);
            this.Controls.Add(this.dgvKeranjang);
            this.Controls.Add(this.dgvMenu);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKeranjang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
