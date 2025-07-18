namespace Rapchieuphim
{
    partial class FormTonKho
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDsMonCon = new System.Windows.Forms.DataGridView();
            this.id_do_an = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sl_con_lai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsMonCon)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(177, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(429, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH SÁCH MÓN CÒN HÀNG";
            // 
            // dgvDsMonCon
            // 
            this.dgvDsMonCon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDsMonCon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDsMonCon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_do_an,
            this.ten,
            this.sl_con_lai,
            this.gia});
            this.dgvDsMonCon.Location = new System.Drawing.Point(32, 86);
            this.dgvDsMonCon.Name = "dgvDsMonCon";
            this.dgvDsMonCon.ReadOnly = true;
            this.dgvDsMonCon.RowHeadersWidth = 72;
            this.dgvDsMonCon.RowTemplate.Height = 31;
            this.dgvDsMonCon.Size = new System.Drawing.Size(734, 313);
            this.dgvDsMonCon.TabIndex = 1;
            // 
            // id_do_an
            // 
            this.id_do_an.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.id_do_an.DataPropertyName = "id_do_an";
            this.id_do_an.HeaderText = "Mã món";
            this.id_do_an.MinimumWidth = 9;
            this.id_do_an.Name = "id_do_an";
            this.id_do_an.ReadOnly = true;
            this.id_do_an.Width = 124;
            // 
            // ten
            // 
            this.ten.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ten.DataPropertyName = "ten";
            this.ten.HeaderText = "Tên món";
            this.ten.MinimumWidth = 9;
            this.ten.Name = "ten";
            this.ten.ReadOnly = true;
            // 
            // sl_con_lai
            // 
            this.sl_con_lai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.sl_con_lai.DataPropertyName = "sl_con_lai";
            this.sl_con_lai.HeaderText = "Còn lại";
            this.sl_con_lai.MinimumWidth = 9;
            this.sl_con_lai.Name = "sl_con_lai";
            this.sl_con_lai.ReadOnly = true;
            this.sl_con_lai.Width = 114;
            // 
            // gia
            // 
            this.gia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gia.DataPropertyName = "gia";
            this.gia.HeaderText = "Đơn giá";
            this.gia.MinimumWidth = 9;
            this.gia.Name = "gia";
            this.gia.ReadOnly = true;
            // 
            // btnThoat
            // 
            this.btnThoat.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnThoat.Location = new System.Drawing.Point(333, 422);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(159, 50);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Đóng";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // FormTonKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(800, 497);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.dgvDsMonCon);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormTonKho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTonKho";
            this.Load += new System.EventHandler(this.FormTonKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsMonCon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDsMonCon;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_do_an;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn sl_con_lai;
        private System.Windows.Forms.DataGridViewTextBoxColumn gia;
    }
}