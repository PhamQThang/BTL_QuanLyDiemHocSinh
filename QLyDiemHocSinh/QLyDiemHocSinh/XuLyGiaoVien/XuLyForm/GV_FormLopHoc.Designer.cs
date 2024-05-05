
namespace QLyDiemHocSinh.XuLyGiaoVien.XuLyForm
{
    partial class GV_FormLopHoc
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
            this.gvLopHoc = new System.Windows.Forms.DataGridView();
            this.sMaLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTenLopHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTenMonHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.slsv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gvLopHoc)).BeginInit();
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
            this.sTenMonHoc,
            this.slsv});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Aqua;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvLopHoc.DefaultCellStyle = dataGridViewCellStyle1;
            this.gvLopHoc.GridColor = System.Drawing.Color.Black;
            this.gvLopHoc.Location = new System.Drawing.Point(1, 1);
            this.gvLopHoc.Name = "gvLopHoc";
            this.gvLopHoc.ReadOnly = true;
            this.gvLopHoc.RowHeadersWidth = 51;
            this.gvLopHoc.RowTemplate.Height = 24;
            this.gvLopHoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvLopHoc.Size = new System.Drawing.Size(984, 511);
            this.gvLopHoc.TabIndex = 53;
            this.gvLopHoc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvLopHoc_CellContentClick);
            this.gvLopHoc.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvLopHoc_CellContentDoubleClick);
            // 
            // sMaLop
            // 
            this.sMaLop.DataPropertyName = "sMaLop";
            this.sMaLop.HeaderText = "Mã Lớp";
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
            // sTenMonHoc
            // 
            this.sTenMonHoc.DataPropertyName = "sTenMonHoc";
            this.sTenMonHoc.HeaderText = "Tên Môn Học";
            this.sTenMonHoc.MinimumWidth = 6;
            this.sTenMonHoc.Name = "sTenMonHoc";
            this.sTenMonHoc.ReadOnly = true;
            // 
            // slsv
            // 
            this.slsv.DataPropertyName = "slsv";
            this.slsv.HeaderText = "Sĩ Số";
            this.slsv.MinimumWidth = 6;
            this.slsv.Name = "slsv";
            this.slsv.ReadOnly = true;
            // 
            // GV_FormLopHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 515);
            this.Controls.Add(this.gvLopHoc);
            this.Name = "GV_FormLopHoc";
            this.Text = "GV_FormLopHoc";
            this.Load += new System.EventHandler(this.GV_FormLopHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvLopHoc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gvLopHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMaLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTenLopHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTenMonHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn slsv;
    }
}