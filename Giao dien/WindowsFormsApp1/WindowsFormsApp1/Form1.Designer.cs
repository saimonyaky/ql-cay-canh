namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tabQLDH = new System.Windows.Forms.TabPage();
            this.dgvThemCay = new System.Windows.Forms.DataGridView();
            this.tabQLCay = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtTimkiemMa = new System.Windows.Forms.TextBox();
            this.txtTimkiemTen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.dgvQLCay = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.cbLoaiCay = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTenCay = new System.Windows.Forms.TextBox();
            this.txtMaDH = new System.Windows.Forms.TextBox();
            this.txtMaCay = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnTK = new System.Windows.Forms.Button();
            this.tabQLDH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThemCay)).BeginInit();
            this.tabQLCay.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLCay)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabQLDH
            // 
            this.tabQLDH.Controls.Add(this.panel1);
            this.tabQLDH.Controls.Add(this.dgvThemCay);
            this.tabQLDH.Location = new System.Drawing.Point(4, 29);
            this.tabQLDH.Name = "tabQLDH";
            this.tabQLDH.Padding = new System.Windows.Forms.Padding(3);
            this.tabQLDH.Size = new System.Drawing.Size(997, 553);
            this.tabQLDH.TabIndex = 1;
            this.tabQLDH.Text = "Quản lí đơn hàng";
            this.tabQLDH.UseVisualStyleBackColor = true;
            // 
            // dgvThemCay
            // 
            this.dgvThemCay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThemCay.Location = new System.Drawing.Point(6, 79);
            this.dgvThemCay.Name = "dgvThemCay";
            this.dgvThemCay.RowHeadersWidth = 51;
            this.dgvThemCay.Size = new System.Drawing.Size(984, 468);
            this.dgvThemCay.TabIndex = 3;
            // 
            // tabQLCay
            // 
            this.tabQLCay.Controls.Add(this.panel2);
            this.tabQLCay.Controls.Add(this.dgvQLCay);
            this.tabQLCay.Location = new System.Drawing.Point(4, 29);
            this.tabQLCay.Name = "tabQLCay";
            this.tabQLCay.Padding = new System.Windows.Forms.Padding(3);
            this.tabQLCay.Size = new System.Drawing.Size(997, 553);
            this.tabQLCay.TabIndex = 0;
            this.tabQLCay.Text = "Quản lí cây";
            this.tabQLCay.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.cbLoaiCay);
            this.panel2.Controls.Add(this.txtTimkiemMa);
            this.panel2.Controls.Add(this.txtTimkiemTen);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnTimkiem);
            this.panel2.Location = new System.Drawing.Point(1, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(993, 120);
            this.panel2.TabIndex = 8;
            // 
            // txtTimkiemMa
            // 
            this.txtTimkiemMa.Location = new System.Drawing.Point(109, 21);
            this.txtTimkiemMa.Name = "txtTimkiemMa";
            this.txtTimkiemMa.Size = new System.Drawing.Size(159, 26);
            this.txtTimkiemMa.TabIndex = 3;
            // 
            // txtTimkiemTen
            // 
            this.txtTimkiemTen.Location = new System.Drawing.Point(396, 21);
            this.txtTimkiemTen.Name = "txtTimkiemTen";
            this.txtTimkiemTen.Size = new System.Drawing.Size(159, 26);
            this.txtTimkiemTen.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã cây:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(584, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Loại cây:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(305, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên cây:";
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.BackColor = System.Drawing.Color.White;
            this.btnTimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTimkiem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnTimkiem.Location = new System.Drawing.Point(883, 22);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(95, 30);
            this.btnTimkiem.TabIndex = 1;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = false;
            // 
            // dgvQLCay
            // 
            this.dgvQLCay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQLCay.Location = new System.Drawing.Point(1, 126);
            this.dgvQLCay.Name = "dgvQLCay";
            this.dgvQLCay.RowHeadersWidth = 51;
            this.dgvQLCay.Size = new System.Drawing.Size(994, 421);
            this.dgvQLCay.TabIndex = 7;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabQLCay);
            this.tabControl1.Controls.Add(this.tabQLDH);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1005, 586);
            this.tabControl1.TabIndex = 0;
            // 
            // cbLoaiCay
            // 
            this.cbLoaiCay.FormattingEnabled = true;
            this.cbLoaiCay.Location = new System.Drawing.Point(667, 21);
            this.cbLoaiCay.Name = "cbLoaiCay";
            this.cbLoaiCay.Size = new System.Drawing.Size(159, 28);
            this.cbLoaiCay.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAdd.Location = new System.Drawing.Point(29, 79);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(131, 30);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Thêm cây mới";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtTenCay);
            this.panel1.Controls.Add(this.txtMaDH);
            this.panel1.Controls.Add(this.txtMaCay);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnTK);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(993, 73);
            this.panel1.TabIndex = 9;
            // 
            // txtTenCay
            // 
            this.txtTenCay.Location = new System.Drawing.Point(663, 22);
            this.txtTenCay.Name = "txtTenCay";
            this.txtTenCay.Size = new System.Drawing.Size(159, 26);
            this.txtTenCay.TabIndex = 4;
            // 
            // txtMaDH
            // 
            this.txtMaDH.Location = new System.Drawing.Point(109, 21);
            this.txtMaDH.Name = "txtMaDH";
            this.txtMaDH.Size = new System.Drawing.Size(159, 26);
            this.txtMaDH.TabIndex = 3;
            // 
            // txtMaCay
            // 
            this.txtMaCay.Location = new System.Drawing.Point(396, 21);
            this.txtMaCay.Name = "txtMaCay";
            this.txtMaCay.Size = new System.Drawing.Size(159, 26);
            this.txtMaCay.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mã đơn:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(584, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Tên cây:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(305, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Mã cây:";
            // 
            // btnTK
            // 
            this.btnTK.BackColor = System.Drawing.Color.White;
            this.btnTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTK.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnTK.Location = new System.Drawing.Point(883, 22);
            this.btnTK.Name = "btnTK";
            this.btnTK.Size = new System.Drawing.Size(95, 30);
            this.btnTK.TabIndex = 1;
            this.btnTK.Text = "Tìm kiếm";
            this.btnTK.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 608);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "QUẢN LÝ BÁN CÂY";
            this.tabQLDH.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThemCay)).EndInit();
            this.tabQLCay.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLCay)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TabPage tabQLDH;
        private System.Windows.Forms.DataGridView dgvThemCay;
        private System.Windows.Forms.TabPage tabQLCay;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtTimkiemMa;
        private System.Windows.Forms.TextBox txtTimkiemTen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.DataGridView dgvQLCay;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTenCay;
        private System.Windows.Forms.TextBox txtMaDH;
        private System.Windows.Forms.TextBox txtMaCay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnTK;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cbLoaiCay;
    }
}

