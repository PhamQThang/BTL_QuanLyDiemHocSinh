
namespace QLyDiemHocSinh.XuLyAdmin.XuLyForm
{
    partial class Admin_FormLopHoc
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gvLopHoc = new System.Windows.Forms.DataGridView();
            this.sMaLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTenLopHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iKhoiHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siSo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnXemToanBo = new System.Windows.Forms.Button();
            this.btnKhoi6 = new System.Windows.Forms.Button();
            this.btnKhoi7 = new System.Windows.Forms.Button();
            this.btnKhoi8 = new System.Windows.Forms.Button();
            this.btnKhoi9 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvLopHoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // gvLopHoc
            // 
            this.gvLopHoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvLopHoc.BackgroundColor = System.Drawing.Color.White;
            this.gvLopHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvLopHoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sMaLop,
            this.sTenLopHoc,
            this.iKhoiHoc,
            this.siSo});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Aqua;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvLopHoc.DefaultCellStyle = dataGridViewCellStyle1;
            this.gvLopHoc.GridColor = System.Drawing.Color.Black;
            this.gvLopHoc.Location = new System.Drawing.Point(-6, 0);
            this.gvLopHoc.Name = "gvLopHoc";
            this.gvLopHoc.ReadOnly = true;
            this.gvLopHoc.RowHeadersWidth = 51;
            this.gvLopHoc.RowTemplate.Height = 24;
            this.gvLopHoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvLopHoc.Size = new System.Drawing.Size(1029, 336);
            this.gvLopHoc.TabIndex = 35;
            this.gvLopHoc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvLopHoc_CellContentClick);
            // 
            // sMaLop
            // 
            this.sMaLop.DataPropertyName = "sMaLop";
            this.sMaLop.HeaderText = "Mã Lớp ";
            this.sMaLop.MinimumWidth = 6;
            this.sMaLop.Name = "sMaLop";
            this.sMaLop.ReadOnly = true;
            // 
            // sTenLopHoc
            // 
            this.sTenLopHoc.DataPropertyName = "sTenLopHoc";
            this.sTenLopHoc.HeaderText = "Tên Lớp Học";
            this.sTenLopHoc.MinimumWidth = 6;
            this.sTenLopHoc.Name = "sTenLopHoc";
            this.sTenLopHoc.ReadOnly = true;
            // 
            // iKhoiHoc
            // 
            this.iKhoiHoc.DataPropertyName = "iKhoiHoc";
            this.iKhoiHoc.HeaderText = "Khối Học";
            this.iKhoiHoc.MinimumWidth = 6;
            this.iKhoiHoc.Name = "iKhoiHoc";
            this.iKhoiHoc.ReadOnly = true;
            // 
            // siSo
            // 
            this.siSo.DataPropertyName = "siSo";
            this.siSo.HeaderText = "Sĩ Số";
            this.siSo.MinimumWidth = 6;
            this.siSo.Name = "siSo";
            this.siSo.ReadOnly = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnXemToanBo
            // 
            this.btnXemToanBo.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemToanBo.Location = new System.Drawing.Point(794, 362);
            this.btnXemToanBo.Name = "btnXemToanBo";
            this.btnXemToanBo.Size = new System.Drawing.Size(137, 41);
            this.btnXemToanBo.TabIndex = 41;
            this.btnXemToanBo.Text = "Xem Toàn Bộ";
            this.btnXemToanBo.UseVisualStyleBackColor = true;
            this.btnXemToanBo.Click += new System.EventHandler(this.btnXemToanBo_Click);
            // 
            // btnKhoi6
            // 
            this.btnKhoi6.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhoi6.Location = new System.Drawing.Point(108, 362);
            this.btnKhoi6.Name = "btnKhoi6";
            this.btnKhoi6.Size = new System.Drawing.Size(137, 41);
            this.btnKhoi6.TabIndex = 42;
            this.btnKhoi6.Text = "Khối 6";
            this.btnKhoi6.UseVisualStyleBackColor = true;
            this.btnKhoi6.Click += new System.EventHandler(this.btnKhoi6_Click);
            // 
            // btnKhoi7
            // 
            this.btnKhoi7.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhoi7.Location = new System.Drawing.Point(282, 362);
            this.btnKhoi7.Name = "btnKhoi7";
            this.btnKhoi7.Size = new System.Drawing.Size(137, 41);
            this.btnKhoi7.TabIndex = 43;
            this.btnKhoi7.Text = "Khối 7";
            this.btnKhoi7.UseVisualStyleBackColor = true;
            this.btnKhoi7.Click += new System.EventHandler(this.btnKhoi7_Click);
            // 
            // btnKhoi8
            // 
            this.btnKhoi8.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhoi8.Location = new System.Drawing.Point(457, 362);
            this.btnKhoi8.Name = "btnKhoi8";
            this.btnKhoi8.Size = new System.Drawing.Size(137, 41);
            this.btnKhoi8.TabIndex = 44;
            this.btnKhoi8.Text = "Khối 8";
            this.btnKhoi8.UseVisualStyleBackColor = true;
            this.btnKhoi8.Click += new System.EventHandler(this.btnKhoi8_Click);
            // 
            // btnKhoi9
            // 
            this.btnKhoi9.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhoi9.Location = new System.Drawing.Point(630, 362);
            this.btnKhoi9.Name = "btnKhoi9";
            this.btnKhoi9.Size = new System.Drawing.Size(137, 41);
            this.btnKhoi9.TabIndex = 45;
            this.btnKhoi9.Text = "Khối 9";
            this.btnKhoi9.UseVisualStyleBackColor = true;
            this.btnKhoi9.Click += new System.EventHandler(this.btnKhoi9_Click);
            // 
            // Admin_FormLopHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 503);
            this.Controls.Add(this.btnKhoi9);
            this.Controls.Add(this.btnKhoi8);
            this.Controls.Add(this.btnKhoi7);
            this.Controls.Add(this.btnKhoi6);
            this.Controls.Add(this.btnXemToanBo);
            this.Controls.Add(this.gvLopHoc);
            this.Name = "Admin_FormLopHoc";
            this.Text = "Admin_FormLopHoc";
            this.Load += new System.EventHandler(this.Admin_FormLopHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvLopHoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView gvLopHoc;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnXemToanBo;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMaLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTenLopHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn iKhoiHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn siSo;
        private System.Windows.Forms.Button btnKhoi9;
        private System.Windows.Forms.Button btnKhoi8;
        private System.Windows.Forms.Button btnKhoi7;
        private System.Windows.Forms.Button btnKhoi6;
    }
}