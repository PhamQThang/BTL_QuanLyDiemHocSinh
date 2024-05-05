
namespace QLyDiemHocSinh.XuLySinhVien
{
    partial class HS_FormDiem
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
            this.gvMonHoc = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gvMonHoc)).BeginInit();
            this.SuspendLayout();
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
            this.gvMonHoc.Location = new System.Drawing.Point(0, -4);
            this.gvMonHoc.Name = "gvMonHoc";
            this.gvMonHoc.ReadOnly = true;
            this.gvMonHoc.RowHeadersWidth = 51;
            this.gvMonHoc.RowTemplate.Height = 24;
            this.gvMonHoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvMonHoc.Size = new System.Drawing.Size(799, 343);
            this.gvMonHoc.TabIndex = 52;
            this.gvMonHoc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvMonHoc_CellContentClick);
            // 
            // HS_FormDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 337);
            this.Controls.Add(this.gvMonHoc);
            this.Name = "HS_FormDiem";
            this.Text = "SV_FormDiem";
            this.Load += new System.EventHandler(this.HS_FormDiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvMonHoc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gvMonHoc;
    }
}