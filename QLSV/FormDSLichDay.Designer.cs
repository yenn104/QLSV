
namespace QLSV
{
  partial class FormDSLichDay
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
      this.dgvDS = new System.Windows.Forms.DataGridView();
      this.txtKey = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.dgvDS)).BeginInit();
      this.SuspendLayout();
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
      this.dgvDS.Location = new System.Drawing.Point(0, 114);
      this.dgvDS.Margin = new System.Windows.Forms.Padding(4);
      this.dgvDS.MultiSelect = false;
      this.dgvDS.Name = "dgvDS";
      this.dgvDS.ReadOnly = true;
      this.dgvDS.RowHeadersWidth = 51;
      this.dgvDS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dgvDS.Size = new System.Drawing.Size(1199, 491);
      this.dgvDS.TabIndex = 22;
      // 
      // txtKey
      // 
      this.txtKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.txtKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.txtKey.Location = new System.Drawing.Point(778, 52);
      this.txtKey.Margin = new System.Windows.Forms.Padding(4);
      this.txtKey.Multiline = true;
      this.txtKey.Name = "txtKey";
      this.txtKey.Size = new System.Drawing.Size(327, 28);
      this.txtKey.TabIndex = 19;
      this.txtKey.TextChanged += new System.EventHandler(this.txtKey_TextChanged);
      // 
      // label1
      // 
      this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.label1.Location = new System.Drawing.Point(658, 55);
      this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(77, 20);
      this.label1.TabIndex = 23;
      this.label1.Text = "Tìm kiếm";
      // 
      // FormDSLichDay
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1197, 600);
      this.Controls.Add(this.dgvDS);
      this.Controls.Add(this.txtKey);
      this.Controls.Add(this.label1);
      this.Name = "FormDSLichDay";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Lịch Giảng Dạy";
      this.Load += new System.EventHandler(this.FormDSLichDay_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dgvDS)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.DataGridView dgvDS;
    private System.Windows.Forms.TextBox txtKey;
    private System.Windows.Forms.Label label1;
  }
}