
namespace QLSV
{
  partial class FormChuyenTien
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
      this.btnRefresh = new System.Windows.Forms.Button();
      this.cbbNganHang = new System.Windows.Forms.ComboBox();
      this.btnThoat = new System.Windows.Forms.Button();
      this.txtSoTien = new System.Windows.Forms.TextBox();
      this.txtSTK = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.btnChuyen = new System.Windows.Forms.Button();
      this.txtNoiDung = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // btnRefresh
      // 
      this.btnRefresh.BackColor = System.Drawing.Color.DarkCyan;
      this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.btnRefresh.ForeColor = System.Drawing.Color.White;
      this.btnRefresh.Location = new System.Drawing.Point(99, 343);
      this.btnRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.btnRefresh.Name = "btnRefresh";
      this.btnRefresh.Size = new System.Drawing.Size(173, 40);
      this.btnRefresh.TabIndex = 17;
      this.btnRefresh.Text = "Làm mới";
      this.btnRefresh.UseVisualStyleBackColor = false;
      this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
      // 
      // cbbNganHang
      // 
      this.cbbNganHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.cbbNganHang.FormattingEnabled = true;
      this.cbbNganHang.Items.AddRange(new object[] {
            "VietcomBank",
            "AngriBank"});
      this.cbbNganHang.Location = new System.Drawing.Point(350, 81);
      this.cbbNganHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.cbbNganHang.Name = "cbbNganHang";
      this.cbbNganHang.Size = new System.Drawing.Size(262, 26);
      this.cbbNganHang.TabIndex = 16;
      // 
      // btnThoat
      // 
      this.btnThoat.BackColor = System.Drawing.Color.DarkCyan;
      this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.btnThoat.ForeColor = System.Drawing.Color.White;
      this.btnThoat.Location = new System.Drawing.Point(526, 343);
      this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.btnThoat.Name = "btnThoat";
      this.btnThoat.Size = new System.Drawing.Size(173, 40);
      this.btnThoat.TabIndex = 15;
      this.btnThoat.Text = "Thoát";
      this.btnThoat.UseVisualStyleBackColor = false;
      this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
      // 
      // txtSoTien
      // 
      this.txtSoTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.txtSoTien.Location = new System.Drawing.Point(350, 184);
      this.txtSoTien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.txtSoTien.Name = "txtSoTien";
      this.txtSoTien.Size = new System.Drawing.Size(262, 24);
      this.txtSoTien.TabIndex = 14;
      // 
      // txtSTK
      // 
      this.txtSTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.txtSTK.Location = new System.Drawing.Point(350, 134);
      this.txtSTK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.txtSTK.Name = "txtSTK";
      this.txtSTK.Size = new System.Drawing.Size(262, 24);
      this.txtSTK.TabIndex = 13;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.label3.Location = new System.Drawing.Point(133, 188);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(137, 18);
      this.label3.TabIndex = 12;
      this.label3.Text = "Số tiền cần chuyển:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.label2.Location = new System.Drawing.Point(133, 139);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(164, 18);
      this.label2.TabIndex = 11;
      this.label2.Text = "Số tài khoản thụ hưởng:";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.label1.Location = new System.Drawing.Point(133, 80);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(152, 18);
      this.label1.TabIndex = 10;
      this.label1.Text = "Ngân hàng thụ hưởng:";
      // 
      // btnChuyen
      // 
      this.btnChuyen.BackColor = System.Drawing.Color.DarkCyan;
      this.btnChuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.btnChuyen.ForeColor = System.Drawing.Color.White;
      this.btnChuyen.Location = new System.Drawing.Point(310, 343);
      this.btnChuyen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.btnChuyen.Name = "btnChuyen";
      this.btnChuyen.Size = new System.Drawing.Size(173, 40);
      this.btnChuyen.TabIndex = 9;
      this.btnChuyen.Text = "Chuyển tiền";
      this.btnChuyen.UseVisualStyleBackColor = false;
      this.btnChuyen.Click += new System.EventHandler(this.btnChuyen_Click);
      // 
      // txtNoiDung
      // 
      this.txtNoiDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.txtNoiDung.Location = new System.Drawing.Point(350, 235);
      this.txtNoiDung.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.txtNoiDung.Name = "txtNoiDung";
      this.txtNoiDung.Size = new System.Drawing.Size(262, 24);
      this.txtNoiDung.TabIndex = 19;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.label4.Location = new System.Drawing.Point(133, 236);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(149, 18);
      this.label4.TabIndex = 18;
      this.label4.Text = "Nội dung chuyển tiền:";
      // 
      // FormChuyenTien
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(791, 455);
      this.Controls.Add(this.txtNoiDung);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.btnRefresh);
      this.Controls.Add(this.cbbNganHang);
      this.Controls.Add(this.btnThoat);
      this.Controls.Add(this.txtSoTien);
      this.Controls.Add(this.txtSTK);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.btnChuyen);
      this.Name = "FormChuyenTien";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Chuyển tiền học bổng";
      this.Load += new System.EventHandler(this.FormChuyenTien_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnRefresh;
    private System.Windows.Forms.ComboBox cbbNganHang;
    private System.Windows.Forms.Button btnThoat;
    private System.Windows.Forms.TextBox txtSoTien;
    private System.Windows.Forms.TextBox txtSTK;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button btnChuyen;
    private System.Windows.Forms.TextBox txtNoiDung;
    private System.Windows.Forms.Label label4;
  }
}