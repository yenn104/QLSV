namespace QLSV
{
    partial class FormThongKeDiem
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rpvThongKeDiem = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(98, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1241, 122);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(25, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nhập MSSV";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkCyan;
            this.button2.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(863, 46);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(161, 45);
            this.button2.TabIndex = 9;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(182, 56);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(303, 35);
            this.textBox1.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkCyan;
            this.button1.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(601, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 45);
            this.button1.TabIndex = 8;
            this.button1.Text = "Xem điểm";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rpvThongKeDiem);
            this.groupBox2.Location = new System.Drawing.Point(98, 174);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1245, 488);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DANH SÁCH ĐIỂM";
            // 
            // rpvThongKeDiem
            // 
            this.rpvThongKeDiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpvThongKeDiem.Location = new System.Drawing.Point(3, 22);
            this.rpvThongKeDiem.Name = "rpvThongKeDiem";
            this.rpvThongKeDiem.ServerReport.BearerToken = null;
            this.rpvThongKeDiem.Size = new System.Drawing.Size(1239, 463);
            this.rpvThongKeDiem.TabIndex = 0;
            // 
            // FormThongKeDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1351, 664);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormThongKeDiem";
            this.Text = "FormThongKeDiem";
            this.Load += new System.EventHandler(this.FormThongKeDiem_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private Microsoft.Reporting.WinForms.ReportViewer rpvThongKeDiem;
    }
}