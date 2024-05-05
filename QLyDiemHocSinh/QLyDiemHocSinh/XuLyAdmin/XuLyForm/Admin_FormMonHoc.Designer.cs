
namespace QLyDiemHocSinh.XuLyAdmin.XuLyForm
{
    partial class Admin_FormMonHoc
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gvMonHoc = new System.Windows.Forms.DataGridView();
            this.btnSinh = new System.Windows.Forms.Button();
            this.btnHoa = new System.Windows.Forms.Button();
            this.btnLy = new System.Windows.Forms.Button();
            this.btnToan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvMonHoc)).BeginInit();
            this.SuspendLayout();
            // 
            // gvMonHoc
            // 
            this.gvMonHoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvMonHoc.BackgroundColor = System.Drawing.Color.White;
            this.gvMonHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Aqua;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvMonHoc.DefaultCellStyle = dataGridViewCellStyle4;
            this.gvMonHoc.GridColor = System.Drawing.Color.Black;
            this.gvMonHoc.Location = new System.Drawing.Point(0, 12);
            this.gvMonHoc.Name = "gvMonHoc";
            this.gvMonHoc.ReadOnly = true;
            this.gvMonHoc.RowHeadersWidth = 51;
            this.gvMonHoc.RowTemplate.Height = 24;
            this.gvMonHoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvMonHoc.Size = new System.Drawing.Size(1023, 360);
            this.gvMonHoc.TabIndex = 46;
            // 
            // btnSinh
            // 
            this.btnSinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSinh.Location = new System.Drawing.Point(769, 401);
            this.btnSinh.Margin = new System.Windows.Forms.Padding(4);
            this.btnSinh.Name = "btnSinh";
            this.btnSinh.Size = new System.Drawing.Size(100, 41);
            this.btnSinh.TabIndex = 50;
            this.btnSinh.Text = "Sinh";
            this.btnSinh.UseVisualStyleBackColor = true;
            this.btnSinh.Click += new System.EventHandler(this.btnSinh_Click);
            // 
            // btnHoa
            // 
            this.btnHoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoa.Location = new System.Drawing.Point(576, 401);
            this.btnHoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnHoa.Name = "btnHoa";
            this.btnHoa.Size = new System.Drawing.Size(100, 41);
            this.btnHoa.TabIndex = 49;
            this.btnHoa.Text = "Hóa";
            this.btnHoa.UseVisualStyleBackColor = true;
            this.btnHoa.Click += new System.EventHandler(this.btnHoa_Click);
            // 
            // btnLy
            // 
            this.btnLy.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLy.Location = new System.Drawing.Point(389, 401);
            this.btnLy.Margin = new System.Windows.Forms.Padding(4);
            this.btnLy.Name = "btnLy";
            this.btnLy.Size = new System.Drawing.Size(100, 41);
            this.btnLy.TabIndex = 48;
            this.btnLy.Text = "Lý";
            this.btnLy.UseVisualStyleBackColor = true;
            this.btnLy.Click += new System.EventHandler(this.btnLy_Click);
            // 
            // btnToan
            // 
            this.btnToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToan.Location = new System.Drawing.Point(193, 401);
            this.btnToan.Margin = new System.Windows.Forms.Padding(4);
            this.btnToan.Name = "btnToan";
            this.btnToan.Size = new System.Drawing.Size(103, 41);
            this.btnToan.TabIndex = 47;
            this.btnToan.Text = "Toán";
            this.btnToan.UseVisualStyleBackColor = true;
            this.btnToan.Click += new System.EventHandler(this.btnToan_Click);
            // 
            // Admin_FormMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 503);
            this.Controls.Add(this.btnSinh);
            this.Controls.Add(this.btnHoa);
            this.Controls.Add(this.btnLy);
            this.Controls.Add(this.btnToan);
            this.Controls.Add(this.gvMonHoc);
            this.Name = "Admin_FormMonHoc";
            this.Text = "Admin_FormMonHoc";
            this.Load += new System.EventHandler(this.Admin_FormMonHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvMonHoc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gvMonHoc;
        private System.Windows.Forms.Button btnSinh;
        private System.Windows.Forms.Button btnHoa;
        private System.Windows.Forms.Button btnLy;
        private System.Windows.Forms.Button btnToan;
    }
}