
namespace QLSV
{
  partial class FormMonHoc
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
            this.btnThemMH = new System.Windows.Forms.Button();
            this.txtSoTC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenMH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXoaMH = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.DarkCyan;
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Location = new System.Drawing.Point(1086, 26);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(105, 46);
            this.btnHuy.TabIndex = 7;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnThemMH
            // 
            this.btnThemMH.BackColor = System.Drawing.Color.DarkCyan;
            this.btnThemMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThemMH.ForeColor = System.Drawing.Color.White;
            this.btnThemMH.Location = new System.Drawing.Point(824, 28);
            this.btnThemMH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThemMH.Name = "btnThemMH";
            this.btnThemMH.Size = new System.Drawing.Size(105, 46);
            this.btnThemMH.TabIndex = 8;
            this.btnThemMH.Text = "Lưu";
            this.btnThemMH.UseVisualStyleBackColor = false;
            this.btnThemMH.Click += new System.EventHandler(this.btnThemMH_Click);
            // 
            // txtSoTC
            // 
            this.txtSoTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSoTC.Location = new System.Drawing.Point(714, 35);
            this.txtSoTC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSoTC.Name = "txtSoTC";
            this.txtSoTC.Size = new System.Drawing.Size(64, 31);
            this.txtSoTC.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(650, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Số TC";
            // 
            // txtTenMH
            // 
            this.txtTenMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenMH.Location = new System.Drawing.Point(200, 35);
            this.txtTenMH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTenMH.Name = "txtTenMH";
            this.txtTenMH.Size = new System.Drawing.Size(432, 31);
            this.txtTenMH.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(72, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tên môn học";
            // 
            // btnXoaMH
            // 
            this.btnXoaMH.BackColor = System.Drawing.Color.DarkCyan;
            this.btnXoaMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoaMH.ForeColor = System.Drawing.Color.White;
            this.btnXoaMH.Location = new System.Drawing.Point(955, 28);
            this.btnXoaMH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXoaMH.Name = "btnXoaMH";
            this.btnXoaMH.Size = new System.Drawing.Size(105, 46);
            this.btnXoaMH.TabIndex = 9;
            this.btnXoaMH.Text = "Xóa";
            this.btnXoaMH.UseVisualStyleBackColor = false;
            this.btnXoaMH.Click += new System.EventHandler(this.btnXoaMH_Click);
            // 
            // FormMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 106);
            this.Controls.Add(this.btnXoaMH);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnThemMH);
            this.Controls.Add(this.txtSoTC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTenMH);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormMonHoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Môn Học";
            this.Load += new System.EventHandler(this.FormMonHoc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnHuy;
    private System.Windows.Forms.Button btnThemMH;
    private System.Windows.Forms.TextBox txtSoTC;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtTenMH;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button btnXoaMH;
  }
}