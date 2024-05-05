
namespace QLyDiemHocSinh.XuLyGiaoVien.XLForm
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
            ((System.ComponentModel.ISupportInitialize)(this.gvMonHoc)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(568, 376);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(110, 41);
            this.btnLoad.TabIndex = 54;
            this.btnLoad.Text = "Xem Toàn Bộ";
            this.btnLoad.UseVisualStyleBackColor = true;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(352, 376);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(100, 41);
            this.btnTimKiem.TabIndex = 53;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // btnChamDiem
            // 
            this.btnChamDiem.Location = new System.Drawing.Point(126, 376);
            this.btnChamDiem.Margin = new System.Windows.Forms.Padding(4);
            this.btnChamDiem.Name = "btnChamDiem";
            this.btnChamDiem.Size = new System.Drawing.Size(103, 41);
            this.btnChamDiem.TabIndex = 52;
            this.btnChamDiem.Text = "Chấm Điểm";
            this.btnChamDiem.UseVisualStyleBackColor = true;
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
            this.gvMonHoc.Location = new System.Drawing.Point(-1, -2);
            this.gvMonHoc.Name = "gvMonHoc";
            this.gvMonHoc.ReadOnly = true;
            this.gvMonHoc.RowHeadersWidth = 51;
            this.gvMonHoc.RowTemplate.Height = 24;
            this.gvMonHoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvMonHoc.Size = new System.Drawing.Size(799, 358);
            this.gvMonHoc.TabIndex = 51;
            // 
            // GV_FormChamDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnChamDiem);
            this.Controls.Add(this.gvMonHoc);
            this.Name = "GV_FormChamDiem";
            this.Text = "GV_FormChamDiem";
            ((System.ComponentModel.ISupportInitialize)(this.gvMonHoc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnChamDiem;
        private System.Windows.Forms.DataGridView gvMonHoc;
    }
}