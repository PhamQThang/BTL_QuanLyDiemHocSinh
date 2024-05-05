
namespace QLyDiemHocSinh.ChucNangTimKiem.XLForm
{
    partial class FormDiemTheoKhoi
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button3 = new System.Windows.Forms.Button();
            this.tb_ten = new System.Windows.Forms.TextBox();
            this.cb_khoi = new System.Windows.Forms.ComboBox();
            this.max = new System.Windows.Forms.NumericUpDown();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cb_danhhieu = new System.Windows.Forms.ComboBox();
            this.min = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gvDiem = new System.Windows.Forms.DataGridView();
            this.sMaHS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTenHS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iKhoiHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Trungbinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.danhhieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDiem)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(595, 137);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(157, 39);
            this.button3.TabIndex = 27;
            this.button3.Text = "Quay lại";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // tb_ten
            // 
            this.tb_ten.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ten.Location = new System.Drawing.Point(188, 5);
            this.tb_ten.Margin = new System.Windows.Forms.Padding(4);
            this.tb_ten.Name = "tb_ten";
            this.tb_ten.Size = new System.Drawing.Size(515, 35);
            this.tb_ten.TabIndex = 26;
            // 
            // cb_khoi
            // 
            this.cb_khoi.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_khoi.FormattingEnabled = true;
            this.cb_khoi.Location = new System.Drawing.Point(188, 47);
            this.cb_khoi.Margin = new System.Windows.Forms.Padding(4);
            this.cb_khoi.Name = "cb_khoi";
            this.cb_khoi.Size = new System.Drawing.Size(145, 35);
            this.cb_khoi.TabIndex = 25;
            // 
            // max
            // 
            this.max.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.max.Location = new System.Drawing.Point(736, 83);
            this.max.Margin = new System.Windows.Forms.Padding(4);
            this.max.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.max.Name = "max";
            this.max.Size = new System.Drawing.Size(65, 35);
            this.max.TabIndex = 24;
            this.max.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(336, 137);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(157, 39);
            this.button2.TabIndex = 23;
            this.button2.Text = "Báo cáo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(36, 137);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 39);
            this.button1.TabIndex = 22;
            this.button1.Text = "Tìm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // cb_danhhieu
            // 
            this.cb_danhhieu.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_danhhieu.FormattingEnabled = true;
            this.cb_danhhieu.Location = new System.Drawing.Point(188, 91);
            this.cb_danhhieu.Margin = new System.Windows.Forms.Padding(4);
            this.cb_danhhieu.Name = "cb_danhhieu";
            this.cb_danhhieu.Size = new System.Drawing.Size(145, 35);
            this.cb_danhhieu.TabIndex = 21;
            // 
            // min
            // 
            this.min.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.min.Location = new System.Drawing.Point(531, 84);
            this.min.Margin = new System.Windows.Forms.Padding(4);
            this.min.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(67, 35);
            this.min.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(28, 93);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 28);
            this.label6.TabIndex = 19;
            this.label6.Text = "Danh hiệu :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(376, 93);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 28);
            this.label5.TabIndex = 18;
            this.label5.Text = "Điểm TB từ ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(93, 49);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 28);
            this.label4.TabIndex = 17;
            this.label4.Text = "Lớp :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(640, 93);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 28);
            this.label3.TabIndex = 16;
            this.label3.Text = "đến";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 28);
            this.label2.TabIndex = 15;
            this.label2.Text = "Tên học sinh :";
            // 
            // gvDiem
            // 
            this.gvDiem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvDiem.BackgroundColor = System.Drawing.Color.White;
            this.gvDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvDiem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sMaHS,
            this.sTenHS,
            this.iKhoiHoc,
            this.Trungbinh,
            this.danhhieu});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Aqua;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvDiem.DefaultCellStyle = dataGridViewCellStyle2;
            this.gvDiem.GridColor = System.Drawing.Color.Black;
            this.gvDiem.Location = new System.Drawing.Point(-2, 183);
            this.gvDiem.Name = "gvDiem";
            this.gvDiem.ReadOnly = true;
            this.gvDiem.RowHeadersWidth = 51;
            this.gvDiem.RowTemplate.Height = 24;
            this.gvDiem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvDiem.Size = new System.Drawing.Size(984, 343);
            this.gvDiem.TabIndex = 53;
            // 
            // sMaHS
            // 
            this.sMaHS.DataPropertyName = "sMaHS";
            this.sMaHS.HeaderText = "Mã Học Sinh";
            this.sMaHS.MinimumWidth = 6;
            this.sMaHS.Name = "sMaHS";
            this.sMaHS.ReadOnly = true;
            // 
            // sTenHS
            // 
            this.sTenHS.DataPropertyName = "sTenHS";
            this.sTenHS.HeaderText = "Tên Học Sinh";
            this.sTenHS.MinimumWidth = 6;
            this.sTenHS.Name = "sTenHS";
            this.sTenHS.ReadOnly = true;
            // 
            // iKhoiHoc
            // 
            this.iKhoiHoc.DataPropertyName = "iKhoiHoc";
            this.iKhoiHoc.HeaderText = "Khối Học";
            this.iKhoiHoc.MinimumWidth = 6;
            this.iKhoiHoc.Name = "iKhoiHoc";
            this.iKhoiHoc.ReadOnly = true;
            // 
            // Trungbinh
            // 
            this.Trungbinh.DataPropertyName = "Trungbinh";
            this.Trungbinh.HeaderText = "Điểm Tổng Kết";
            this.Trungbinh.MinimumWidth = 6;
            this.Trungbinh.Name = "Trungbinh";
            this.Trungbinh.ReadOnly = true;
            // 
            // danhhieu
            // 
            this.danhhieu.DataPropertyName = "danhhieu";
            this.danhhieu.HeaderText = "Danh Hiệu";
            this.danhhieu.MinimumWidth = 6;
            this.danhhieu.Name = "danhhieu";
            this.danhhieu.ReadOnly = true;
            // 
            // FormDiemTheoKhoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 533);
            this.Controls.Add(this.gvDiem);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.tb_ten);
            this.Controls.Add(this.cb_khoi);
            this.Controls.Add(this.max);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cb_danhhieu);
            this.Controls.Add(this.min);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "FormDiemTheoKhoi";
            this.Text = "FormDiemTheoKhoi";
            this.Load += new System.EventHandler(this.FormDiemTheoKhoi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDiem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox tb_ten;
        private System.Windows.Forms.ComboBox cb_khoi;
        private System.Windows.Forms.NumericUpDown max;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cb_danhhieu;
        private System.Windows.Forms.NumericUpDown min;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView gvDiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMaHS;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTenHS;
        private System.Windows.Forms.DataGridViewTextBoxColumn iKhoiHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Trungbinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn danhhieu;
    }
}