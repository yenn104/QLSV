
namespace QLSV
{
  partial class FormSinhVien
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
      this.btnHuy = new System.Windows.Forms.Button();
      this.btnLuu = new System.Windows.Forms.Button();
      this.rbtNu = new System.Windows.Forms.RadioButton();
      this.rbtNam = new System.Windows.Forms.RadioButton();
      this.mtbNgaySinh = new System.Windows.Forms.MaskedTextBox();
      this.txtSDT = new System.Windows.Forms.TextBox();
      this.txtMail = new System.Windows.Forms.TextBox();
      this.txtQue = new System.Windows.Forms.TextBox();
      this.txtTen = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label9 = new System.Windows.Forms.Label();
      this.label8 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.txtHo = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.btnXoaSV = new System.Windows.Forms.Button();
      this.txtMSSV = new System.Windows.Forms.TextBox();
      this.lblMSSV = new System.Windows.Forms.Label();
      this.cbbLop = new System.Windows.Forms.ComboBox();
      this.label2 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // btnHuy
      // 
      this.btnHuy.BackColor = System.Drawing.Color.DarkCyan;
      this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.btnHuy.ForeColor = System.Drawing.Color.White;
      this.btnHuy.Location = new System.Drawing.Point(481, 431);
      this.btnHuy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.btnHuy.Name = "btnHuy";
      this.btnHuy.Size = new System.Drawing.Size(103, 46);
      this.btnHuy.TabIndex = 25;
      this.btnHuy.Text = "Hủy";
      this.btnHuy.UseVisualStyleBackColor = false;
      this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
      // 
      // btnLuu
      // 
      this.btnLuu.BackColor = System.Drawing.Color.DarkCyan;
      this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.btnLuu.ForeColor = System.Drawing.Color.White;
      this.btnLuu.Location = new System.Drawing.Point(182, 431);
      this.btnLuu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.btnLuu.Name = "btnLuu";
      this.btnLuu.Size = new System.Drawing.Size(103, 46);
      this.btnLuu.TabIndex = 24;
      this.btnLuu.Text = "Lưu";
      this.btnLuu.UseVisualStyleBackColor = false;
      this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
      // 
      // rbtNu
      // 
      this.rbtNu.AutoSize = true;
      this.rbtNu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.rbtNu.Location = new System.Drawing.Point(422, 193);
      this.rbtNu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.rbtNu.Name = "rbtNu";
      this.rbtNu.Size = new System.Drawing.Size(51, 24);
      this.rbtNu.TabIndex = 23;
      this.rbtNu.Text = "Nữ";
      this.rbtNu.UseVisualStyleBackColor = true;
      // 
      // rbtNam
      // 
      this.rbtNam.AutoSize = true;
      this.rbtNam.Checked = true;
      this.rbtNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.rbtNam.Location = new System.Drawing.Point(300, 193);
      this.rbtNam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.rbtNam.Name = "rbtNam";
      this.rbtNam.Size = new System.Drawing.Size(65, 24);
      this.rbtNam.TabIndex = 22;
      this.rbtNam.TabStop = true;
      this.rbtNam.Text = "Nam";
      this.rbtNam.UseVisualStyleBackColor = true;
      // 
      // mtbNgaySinh
      // 
      this.mtbNgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.mtbNgaySinh.Location = new System.Drawing.Point(280, 155);
      this.mtbNgaySinh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.mtbNgaySinh.Mask = "00/00/0000";
      this.mtbNgaySinh.Name = "mtbNgaySinh";
      this.mtbNgaySinh.Size = new System.Drawing.Size(132, 27);
      this.mtbNgaySinh.TabIndex = 21;
      this.mtbNgaySinh.ValidatingType = typeof(System.DateTime);
      // 
      // txtSDT
      // 
      this.txtSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.txtSDT.Location = new System.Drawing.Point(280, 268);
      this.txtSDT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.txtSDT.Name = "txtSDT";
      this.txtSDT.Size = new System.Drawing.Size(304, 27);
      this.txtSDT.TabIndex = 18;
      // 
      // txtMail
      // 
      this.txtMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.txtMail.Location = new System.Drawing.Point(280, 309);
      this.txtMail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.txtMail.Name = "txtMail";
      this.txtMail.Size = new System.Drawing.Size(304, 27);
      this.txtMail.TabIndex = 17;
      // 
      // txtQue
      // 
      this.txtQue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.txtQue.Location = new System.Drawing.Point(280, 230);
      this.txtQue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.txtQue.Name = "txtQue";
      this.txtQue.Size = new System.Drawing.Size(304, 27);
      this.txtQue.TabIndex = 20;
      // 
      // txtTen
      // 
      this.txtTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.txtTen.Location = new System.Drawing.Point(280, 117);
      this.txtTen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.txtTen.Name = "txtTen";
      this.txtTen.Size = new System.Drawing.Size(304, 27);
      this.txtTen.TabIndex = 14;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.label5.Location = new System.Drawing.Point(130, 195);
      this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(71, 20);
      this.label5.TabIndex = 5;
      this.label5.Text = "Giới tính";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.label4.Location = new System.Drawing.Point(130, 158);
      this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(83, 20);
      this.label4.TabIndex = 12;
      this.label4.Text = "Ngày sinh";
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.label9.Location = new System.Drawing.Point(130, 272);
      this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(84, 20);
      this.label9.TabIndex = 11;
      this.label9.Text = "Điện thoại";
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.label8.Location = new System.Drawing.Point(133, 316);
      this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(40, 20);
      this.label8.TabIndex = 10;
      this.label8.Text = "Mail";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.label6.Location = new System.Drawing.Point(130, 232);
      this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(81, 20);
      this.label6.TabIndex = 8;
      this.label6.Text = "Quê quán";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.label3.Location = new System.Drawing.Point(130, 120);
      this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(37, 20);
      this.label3.TabIndex = 7;
      this.label3.Text = "Tên";
      // 
      // txtHo
      // 
      this.txtHo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.txtHo.Location = new System.Drawing.Point(280, 77);
      this.txtHo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.txtHo.Name = "txtHo";
      this.txtHo.Size = new System.Drawing.Size(304, 27);
      this.txtHo.TabIndex = 1;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.label1.Location = new System.Drawing.Point(130, 77);
      this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(31, 20);
      this.label1.TabIndex = 13;
      this.label1.Text = "Họ";
      // 
      // btnXoaSV
      // 
      this.btnXoaSV.BackColor = System.Drawing.Color.DarkCyan;
      this.btnXoaSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.btnXoaSV.ForeColor = System.Drawing.Color.White;
      this.btnXoaSV.Location = new System.Drawing.Point(332, 431);
      this.btnXoaSV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.btnXoaSV.Name = "btnXoaSV";
      this.btnXoaSV.Size = new System.Drawing.Size(103, 46);
      this.btnXoaSV.TabIndex = 26;
      this.btnXoaSV.Text = "Xóa";
      this.btnXoaSV.UseVisualStyleBackColor = false;
      this.btnXoaSV.Click += new System.EventHandler(this.btnXoaSV_Click);
      // 
      // txtMSSV
      // 
      this.txtMSSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.txtMSSV.Location = new System.Drawing.Point(280, 38);
      this.txtMSSV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.txtMSSV.Name = "txtMSSV";
      this.txtMSSV.Size = new System.Drawing.Size(304, 27);
      this.txtMSSV.TabIndex = 27;
      // 
      // lblMSSV
      // 
      this.lblMSSV.AutoSize = true;
      this.lblMSSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.lblMSSV.Location = new System.Drawing.Point(130, 38);
      this.lblMSSV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lblMSSV.Name = "lblMSSV";
      this.lblMSSV.Size = new System.Drawing.Size(56, 20);
      this.lblMSSV.TabIndex = 28;
      this.lblMSSV.Text = "MSSV";
      // 
      // cbbLop
      // 
      this.cbbLop.FormattingEnabled = true;
      this.cbbLop.Location = new System.Drawing.Point(280, 353);
      this.cbbLop.Name = "cbbLop";
      this.cbbLop.Size = new System.Drawing.Size(304, 24);
      this.cbbLop.TabIndex = 30;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.label2.Location = new System.Drawing.Point(135, 354);
      this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(37, 20);
      this.label2.TabIndex = 29;
      this.label2.Text = "Lớp";
      // 
      // FormSinhVien
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(752, 524);
      this.Controls.Add(this.cbbLop);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.txtMSSV);
      this.Controls.Add(this.lblMSSV);
      this.Controls.Add(this.btnXoaSV);
      this.Controls.Add(this.btnHuy);
      this.Controls.Add(this.btnLuu);
      this.Controls.Add(this.rbtNu);
      this.Controls.Add(this.rbtNam);
      this.Controls.Add(this.mtbNgaySinh);
      this.Controls.Add(this.txtSDT);
      this.Controls.Add(this.txtMail);
      this.Controls.Add(this.txtQue);
      this.Controls.Add(this.txtTen);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label9);
      this.Controls.Add(this.label8);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.txtHo);
      this.Controls.Add(this.label1);
      this.Name = "FormSinhVien";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "FormSinhVien";
      this.Load += new System.EventHandler(this.FormSinhVien_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnHuy;
    private System.Windows.Forms.Button btnLuu;
    private System.Windows.Forms.RadioButton rbtNu;
    private System.Windows.Forms.RadioButton rbtNam;
    private System.Windows.Forms.MaskedTextBox mtbNgaySinh;
    private System.Windows.Forms.TextBox txtSDT;
    private System.Windows.Forms.TextBox txtMail;
    private System.Windows.Forms.TextBox txtQue;
    private System.Windows.Forms.TextBox txtTen;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txtHo;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button btnXoaSV;
    private System.Windows.Forms.TextBox txtMSSV;
    private System.Windows.Forms.Label lblMSSV;
    private System.Windows.Forms.ComboBox cbbLop;
    private System.Windows.Forms.Label label2;
  }
}