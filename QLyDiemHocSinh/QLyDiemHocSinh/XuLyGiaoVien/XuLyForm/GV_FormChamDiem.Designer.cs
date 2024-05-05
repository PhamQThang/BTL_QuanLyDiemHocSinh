
namespace QLyDiemHocSinh.XuLyGiaoVien.XuLyForm
{
    partial class GV_FormChamDiem
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnChamDiem = new System.Windows.Forms.Button();
            this.gvMonHoc = new System.Windows.Forms.DataGridView();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.tbDT = new System.Windows.Forms.TextBox();
            this.tbGK = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbTenHS = new System.Windows.Forms.TextBox();
            this.tbMaHS = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTenMonHoc = new System.Windows.Forms.TextBox();
            this.tbCC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvMonHoc)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoad
            // 
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Location = new System.Drawing.Point(678, 116);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(135, 41);
            this.btnLoad.TabIndex = 55;
            this.btnLoad.Text = "Xem Toàn Bộ";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Location = new System.Drawing.Point(848, 31);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(121, 41);
            this.btnTimKiem.TabIndex = 54;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnChamDiem
            // 
            this.btnChamDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChamDiem.Location = new System.Drawing.Point(678, 31);
            this.btnChamDiem.Margin = new System.Windows.Forms.Padding(4);
            this.btnChamDiem.Name = "btnChamDiem";
            this.btnChamDiem.Size = new System.Drawing.Size(135, 41);
            this.btnChamDiem.TabIndex = 52;
            this.btnChamDiem.Text = "Chấm Điểm";
            this.btnChamDiem.UseVisualStyleBackColor = true;
            this.btnChamDiem.Click += new System.EventHandler(this.btnChamDiem_Click);
            // 
            // gvMonHoc
            // 
            this.gvMonHoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvMonHoc.BackgroundColor = System.Drawing.Color.White;
            this.gvMonHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Aqua;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvMonHoc.DefaultCellStyle = dataGridViewCellStyle1;
            this.gvMonHoc.GridColor = System.Drawing.Color.Black;
            this.gvMonHoc.Location = new System.Drawing.Point(2, 180);
            this.gvMonHoc.Name = "gvMonHoc";
            this.gvMonHoc.ReadOnly = true;
            this.gvMonHoc.RowHeadersWidth = 51;
            this.gvMonHoc.RowTemplate.Height = 24;
            this.gvMonHoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvMonHoc.Size = new System.Drawing.Size(982, 335);
            this.gvMonHoc.TabIndex = 51;
            this.gvMonHoc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvMonHoc_CellContentClick);
            // 
            // btnThongKe
            // 
            this.btnThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.Location = new System.Drawing.Point(848, 116);
            this.btnThongKe.Margin = new System.Windows.Forms.Padding(4);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(125, 41);
            this.btnThongKe.TabIndex = 56;
            this.btnThongKe.Text = "Thống Kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // tbDT
            // 
            this.tbDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDT.Location = new System.Drawing.Point(497, 122);
            this.tbDT.Multiline = true;
            this.tbDT.Name = "tbDT";
            this.tbDT.Size = new System.Drawing.Size(116, 36);
            this.tbDT.TabIndex = 82;
            // 
            // tbGK
            // 
            this.tbGK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGK.Location = new System.Drawing.Point(497, 72);
            this.tbGK.Multiline = true;
            this.tbGK.Name = "tbGK";
            this.tbGK.Size = new System.Drawing.Size(116, 36);
            this.tbGK.TabIndex = 79;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(413, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 18);
            this.label6.TabIndex = 78;
            this.label6.Text = "Điểm Thi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(413, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 18);
            this.label5.TabIndex = 77;
            this.label5.Text = "Điểm GK";
            // 
            // tbTenHS
            // 
            this.tbTenHS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTenHS.Location = new System.Drawing.Point(166, 72);
            this.tbTenHS.Multiline = true;
            this.tbTenHS.Name = "tbTenHS";
            this.tbTenHS.Size = new System.Drawing.Size(175, 36);
            this.tbTenHS.TabIndex = 74;
            // 
            // tbMaHS
            // 
            this.tbMaHS.Enabled = false;
            this.tbMaHS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaHS.Location = new System.Drawing.Point(166, 23);
            this.tbMaHS.Multiline = true;
            this.tbMaHS.Name = "tbMaHS";
            this.tbMaHS.Size = new System.Drawing.Size(175, 36);
            this.tbMaHS.TabIndex = 73;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 18);
            this.label3.TabIndex = 72;
            this.label3.Text = "Tên Môn Học";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 18);
            this.label2.TabIndex = 71;
            this.label2.Text = "Tên Học Sinh";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 18);
            this.label1.TabIndex = 70;
            this.label1.Text = "Mã Học Sinh";
            // 
            // tbTenMonHoc
            // 
            this.tbTenMonHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTenMonHoc.Location = new System.Drawing.Point(166, 122);
            this.tbTenMonHoc.Multiline = true;
            this.tbTenMonHoc.Name = "tbTenMonHoc";
            this.tbTenMonHoc.Size = new System.Drawing.Size(175, 36);
            this.tbTenMonHoc.TabIndex = 83;
            // 
            // tbCC
            // 
            this.tbCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCC.Location = new System.Drawing.Point(497, 23);
            this.tbCC.Multiline = true;
            this.tbCC.Name = "tbCC";
            this.tbCC.Size = new System.Drawing.Size(116, 36);
            this.tbCC.TabIndex = 85;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(413, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 18);
            this.label4.TabIndex = 84;
            this.label4.Text = "Điểm CC";
            // 
            // GV_FormChamDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 515);
            this.Controls.Add(this.tbCC);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbTenMonHoc);
            this.Controls.Add(this.tbDT);
            this.Controls.Add(this.tbGK);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbTenHS);
            this.Controls.Add(this.tbMaHS);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnChamDiem);
            this.Controls.Add(this.gvMonHoc);
            this.Name = "GV_FormChamDiem";
            this.Text = "GV_FormChamDiem";
            this.Load += new System.EventHandler(this.GV_FormChamDiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvMonHoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnChamDiem;
        private System.Windows.Forms.DataGridView gvMonHoc;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.TextBox tbDT;
        private System.Windows.Forms.TextBox tbGK;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbTenHS;
        private System.Windows.Forms.TextBox tbMaHS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTenMonHoc;
        private System.Windows.Forms.TextBox tbCC;
        private System.Windows.Forms.Label label4;
    }
}