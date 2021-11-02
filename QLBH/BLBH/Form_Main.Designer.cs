namespace BLBH
{
    partial class Form_Main
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
            this.dTP_ngaylap_HD = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBox_tongtien_HD = new System.Windows.Forms.TextBox();
            this.txtBox_makh_HD = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtBox_mahd_HD = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.btn_them_HD = new System.Windows.Forms.Button();
            this.btn_xemchitiet_HD = new System.Windows.Forms.Button();
            this.btn_huy_HD = new System.Windows.Forms.Button();
            this.dgv_HD = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabHoaDon = new System.Windows.Forms.TabPage();
            this.panel7 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HD)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabHoaDon.SuspendLayout();
            this.panel7.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dTP_ngaylap_HD
            // 
            this.dTP_ngaylap_HD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTP_ngaylap_HD.Location = new System.Drawing.Point(370, 159);
            this.dTP_ngaylap_HD.MinimumSize = new System.Drawing.Size(4, 33);
            this.dTP_ngaylap_HD.Name = "dTP_ngaylap_HD";
            this.dTP_ngaylap_HD.Size = new System.Drawing.Size(247, 34);
            this.dTP_ngaylap_HD.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(247, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Ngày Lập";
            // 
            // txtBox_tongtien_HD
            // 
            this.txtBox_tongtien_HD.Location = new System.Drawing.Point(370, 205);
            this.txtBox_tongtien_HD.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.txtBox_tongtien_HD.Multiline = true;
            this.txtBox_tongtien_HD.Name = "txtBox_tongtien_HD";
            this.txtBox_tongtien_HD.Size = new System.Drawing.Size(247, 33);
            this.txtBox_tongtien_HD.TabIndex = 13;
            // 
            // txtBox_makh_HD
            // 
            this.txtBox_makh_HD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBox_makh_HD.Location = new System.Drawing.Point(370, 114);
            this.txtBox_makh_HD.Multiline = true;
            this.txtBox_makh_HD.Name = "txtBox_makh_HD";
            this.txtBox_makh_HD.Size = new System.Drawing.Size(247, 33);
            this.txtBox_makh_HD.TabIndex = 10;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.label21.ForeColor = System.Drawing.Color.Blue;
            this.label21.Location = new System.Drawing.Point(243, 208);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(102, 25);
            this.label21.TabIndex = 7;
            this.label21.Text = "Tổng Tiền";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.label19.ForeColor = System.Drawing.Color.Blue;
            this.label19.Location = new System.Drawing.Point(196, 116);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(149, 25);
            this.label19.TabIndex = 5;
            this.label19.Text = "Mã khách Hàng";
            // 
            // txtBox_mahd_HD
            // 
            this.txtBox_mahd_HD.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtBox_mahd_HD.Location = new System.Drawing.Point(370, 69);
            this.txtBox_mahd_HD.Multiline = true;
            this.txtBox_mahd_HD.Name = "txtBox_mahd_HD";
            this.txtBox_mahd_HD.Size = new System.Drawing.Size(247, 33);
            this.txtBox_mahd_HD.TabIndex = 2;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.label17.ForeColor = System.Drawing.Color.Blue;
            this.label17.Location = new System.Drawing.Point(218, 72);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(127, 25);
            this.label17.TabIndex = 1;
            this.label17.Text = "Mã Hoá Đơn";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label16.Location = new System.Drawing.Point(364, 10);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(307, 33);
            this.label16.TabIndex = 0;
            this.label16.Text = "DANH SÁCH HOÁ ĐƠN";
            // 
            // btn_them_HD
            // 
            this.btn_them_HD.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_them_HD.Location = new System.Drawing.Point(402, 18);
            this.btn_them_HD.Name = "btn_them_HD";
            this.btn_them_HD.Size = new System.Drawing.Size(130, 40);
            this.btn_them_HD.TabIndex = 24;
            this.btn_them_HD.Text = "Thêm";
            this.btn_them_HD.UseVisualStyleBackColor = true;
            // 
            // btn_xemchitiet_HD
            // 
            this.btn_xemchitiet_HD.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_xemchitiet_HD.Location = new System.Drawing.Point(94, 18);
            this.btn_xemchitiet_HD.Name = "btn_xemchitiet_HD";
            this.btn_xemchitiet_HD.Size = new System.Drawing.Size(130, 40);
            this.btn_xemchitiet_HD.TabIndex = 22;
            this.btn_xemchitiet_HD.Text = "Xem Chi Tiết";
            this.btn_xemchitiet_HD.UseVisualStyleBackColor = true;
            // 
            // btn_huy_HD
            // 
            this.btn_huy_HD.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_huy_HD.Location = new System.Drawing.Point(710, 18);
            this.btn_huy_HD.Name = "btn_huy_HD";
            this.btn_huy_HD.Size = new System.Drawing.Size(130, 40);
            this.btn_huy_HD.TabIndex = 21;
            this.btn_huy_HD.Text = "Hủy";
            this.btn_huy_HD.UseVisualStyleBackColor = true;
            // 
            // dgv_HD
            // 
            this.dgv_HD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_HD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_HD.Location = new System.Drawing.Point(5, 284);
            this.dgv_HD.Name = "dgv_HD";
            this.dgv_HD.RowHeadersWidth = 51;
            this.dgv_HD.RowTemplate.Height = 24;
            this.dgv_HD.Size = new System.Drawing.Size(1005, 522);
            this.dgv_HD.TabIndex = 21;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_them_HD);
            this.panel1.Controls.Add(this.btn_xemchitiet_HD);
            this.panel1.Controls.Add(this.btn_huy_HD);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(5, 806);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1005, 68);
            this.panel1.TabIndex = 2;
            // 
            // tabHoaDon
            // 
            this.tabHoaDon.Controls.Add(this.dgv_HD);
            this.tabHoaDon.Controls.Add(this.panel1);
            this.tabHoaDon.Controls.Add(this.panel7);
            this.tabHoaDon.Location = new System.Drawing.Point(4, 35);
            this.tabHoaDon.Margin = new System.Windows.Forms.Padding(5);
            this.tabHoaDon.Name = "tabHoaDon";
            this.tabHoaDon.Padding = new System.Windows.Forms.Padding(5);
            this.tabHoaDon.Size = new System.Drawing.Size(1015, 879);
            this.tabHoaDon.TabIndex = 0;
            this.tabHoaDon.Text = "   Hoá Đơn      ";
            this.tabHoaDon.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel7.Controls.Add(this.dTP_ngaylap_HD);
            this.panel7.Controls.Add(this.label1);
            this.panel7.Controls.Add(this.txtBox_tongtien_HD);
            this.panel7.Controls.Add(this.txtBox_makh_HD);
            this.panel7.Controls.Add(this.label21);
            this.panel7.Controls.Add(this.label19);
            this.panel7.Controls.Add(this.txtBox_mahd_HD);
            this.panel7.Controls.Add(this.label17);
            this.panel7.Controls.Add(this.label16);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(5, 5);
            this.panel7.MinimumSize = new System.Drawing.Size(4, 39);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1005, 279);
            this.panel7.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabHoaDon);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1023, 918);
            this.tabControl1.TabIndex = 1;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 918);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HD)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tabHoaDon.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dTP_ngaylap_HD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBox_tongtien_HD;
        private System.Windows.Forms.TextBox txtBox_makh_HD;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtBox_mahd_HD;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btn_them_HD;
        private System.Windows.Forms.Button btn_xemchitiet_HD;
        private System.Windows.Forms.Button btn_huy_HD;
        private System.Windows.Forms.DataGridView dgv_HD;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabPage tabHoaDon;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TabControl tabControl1;
    }
}

