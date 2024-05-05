
namespace QLyDiemHocSinh.XuLyGiaoVien.XuLyForm
{
    partial class GV_FormDiemTK
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
            this.gvDiemTK = new System.Windows.Forms.DataGridView();
            this.sMaHS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTenHS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Trungbinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.danhhieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThongKe = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvDiemTK)).BeginInit();
            this.SuspendLayout();
            // 
            // gvDiemTK
            // 
            this.gvDiemTK.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvDiemTK.BackgroundColor = System.Drawing.Color.White;
            this.gvDiemTK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvDiemTK.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sMaHS,
            this.sTenHS,
            this.Trungbinh,
            this.danhhieu});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Aqua;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvDiemTK.DefaultCellStyle = dataGridViewCellStyle1;
            this.gvDiemTK.GridColor = System.Drawing.Color.Black;
            this.gvDiemTK.Location = new System.Drawing.Point(1, -1);
            this.gvDiemTK.Name = "gvDiemTK";
            this.gvDiemTK.ReadOnly = true;
            this.gvDiemTK.RowHeadersWidth = 51;
            this.gvDiemTK.RowTemplate.Height = 24;
            this.gvDiemTK.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvDiemTK.Size = new System.Drawing.Size(801, 281);
            this.gvDiemTK.TabIndex = 46;
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
            // Trungbinh
            // 
            this.Trungbinh.DataPropertyName = "Trungbinh";
            this.Trungbinh.HeaderText = "Trung Bình";
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
            // btnThongKe
            // 
            this.btnThongKe.Location = new System.Drawing.Point(324, 295);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(123, 43);
            this.btnThongKe.TabIndex = 47;
            this.btnThongKe.Text = "Thống Kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // GV_FormDiemTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 365);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.gvDiemTK);
            this.Name = "GV_FormDiemTK";
            this.Text = "GV_FormDiemTK";
            this.Load += new System.EventHandler(this.GV_FormDiemTK_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvDiemTK)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gvDiemTK;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMaHS;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTenHS;
        private System.Windows.Forms.DataGridViewTextBoxColumn Trungbinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn danhhieu;
    }
}