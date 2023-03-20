
namespace QLSV
{
  partial class FormMonCTDT
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
            this.txtKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDS = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDS)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.DarkCyan;
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Location = new System.Drawing.Point(1042, 53);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(105, 46);
            this.btnHuy.TabIndex = 3;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.DarkCyan;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(914, 54);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(105, 46);
            this.btnLuu.TabIndex = 2;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // txtKey
            // 
            this.txtKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtKey.Location = new System.Drawing.Point(513, 60);
            this.txtKey.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtKey.Multiline = true;
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(367, 34);
            this.txtKey.TabIndex = 1;
            this.txtKey.TextChanged += new System.EventHandler(this.txtKey_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(378, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "Tìm kiếm";
            // 
            // dgvDS
            // 
            this.dgvDS.AllowUserToAddRows = false;
            this.dgvDS.AllowUserToDeleteRows = false;
            this.dgvDS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDS.Location = new System.Drawing.Point(0, 141);
            this.dgvDS.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvDS.MultiSelect = false;
            this.dgvDS.Name = "dgvDS";
            this.dgvDS.ReadOnly = true;
            this.dgvDS.RowHeadersWidth = 51;
            this.dgvDS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDS.Size = new System.Drawing.Size(1275, 605);
            this.dgvDS.TabIndex = 4;
            // 
            // FormMonCTDT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 741);
            this.Controls.Add(this.dgvDS);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormMonCTDT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMonCTDT";
            this.Load += new System.EventHandler(this.FormMonCTDT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.Button btnHuy;
    private System.Windows.Forms.Button btnLuu;
    private System.Windows.Forms.TextBox txtKey;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.DataGridView dgvDS;
  }
}