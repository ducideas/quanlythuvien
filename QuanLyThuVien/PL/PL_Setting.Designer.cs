
namespace PL
{
    partial class PL_Setting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PL_Setting));
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.dataGridViewSetting = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameSetting = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueSetting = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThemSach = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSetting)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(98, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(351, 46);
            this.label4.TabIndex = 96;
            this.label4.Text = "Thay đổi quy định";
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(0, 1);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(92, 123);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 95;
            this.pictureBox8.TabStop = false;
            // 
            // dataGridViewSetting
            // 
            this.dataGridViewSetting.AllowUserToOrderColumns = true;
            this.dataGridViewSetting.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSetting.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.nameSetting,
            this.valueSetting});
            this.dataGridViewSetting.Location = new System.Drawing.Point(106, 119);
            this.dataGridViewSetting.Name = "dataGridViewSetting";
            this.dataGridViewSetting.RowHeadersWidth = 51;
            this.dataGridViewSetting.RowTemplate.Height = 24;
            this.dataGridViewSetting.Size = new System.Drawing.Size(576, 317);
            this.dataGridViewSetting.TabIndex = 99;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 125;
            // 
            // nameSetting
            // 
            this.nameSetting.DataPropertyName = "nameSetting";
            this.nameSetting.HeaderText = "Tên Quy Định";
            this.nameSetting.MinimumWidth = 6;
            this.nameSetting.Name = "nameSetting";
            this.nameSetting.ReadOnly = true;
            this.nameSetting.Width = 128;
            // 
            // valueSetting
            // 
            this.valueSetting.DataPropertyName = "valueSetting";
            this.valueSetting.HeaderText = "Giá Trị";
            this.valueSetting.MinimumWidth = 6;
            this.valueSetting.Name = "valueSetting";
            this.valueSetting.ReadOnly = true;
            this.valueSetting.Width = 125;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnXoa.Location = new System.Drawing.Point(397, 459);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(140, 39);
            this.btnXoa.TabIndex = 103;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSua.Location = new System.Drawing.Point(252, 458);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(140, 39);
            this.btnSua.TabIndex = 102;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThemSach
            // 
            this.btnThemSach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnThemSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnThemSach.Location = new System.Drawing.Point(106, 457);
            this.btnThemSach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemSach.Name = "btnThemSach";
            this.btnThemSach.Size = new System.Drawing.Size(140, 39);
            this.btnThemSach.TabIndex = 101;
            this.btnThemSach.Text = "Thêm Mới";
            this.btnThemSach.UseVisualStyleBackColor = false;
            this.btnThemSach.Click += new System.EventHandler(this.btnThemSach_Click);
            // 
            // btnDong
            // 
            this.btnDong.BackColor = System.Drawing.Color.Silver;
            this.btnDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDong.Location = new System.Drawing.Point(542, 459);
            this.btnDong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(140, 39);
            this.btnDong.TabIndex = 100;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = false;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // PL_Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThemSach);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.dataGridViewSetting);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox8);
            this.Name = "PL_Setting";
            this.Text = "PL_Setting";
            this.Load += new System.EventHandler(this.PL_Setting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSetting)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.DataGridView dataGridViewSetting;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThemSach;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameSetting;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueSetting;
    }
}