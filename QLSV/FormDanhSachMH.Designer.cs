
namespace QLSV
{
  partial class FormDanhSachMH
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
      this.dgvDSMH = new System.Windows.Forms.DataGridView();
      this.btnThemMH = new System.Windows.Forms.Button();
      this.btnRefresh = new System.Windows.Forms.Button();
      this.txtKey = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.dgvDSMH)).BeginInit();
      this.SuspendLayout();
      // 
      // dgvDSMH
      // 
      this.dgvDSMH.AllowUserToAddRows = false;
      this.dgvDSMH.AllowUserToDeleteRows = false;
      this.dgvDSMH.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.dgvDSMH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.dgvDSMH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvDSMH.Location = new System.Drawing.Point(0, 113);
      this.dgvDSMH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.dgvDSMH.MultiSelect = false;
      this.dgvDSMH.Name = "dgvDSMH";
      this.dgvDSMH.ReadOnly = true;
      this.dgvDSMH.RowHeadersWidth = 51;
      this.dgvDSMH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dgvDSMH.Size = new System.Drawing.Size(1272, 439);
      this.dgvDSMH.TabIndex = 4;
      this.dgvDSMH.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSMH_CellDoubleClick);
      // 
      // btnThemMH
      // 
      this.btnThemMH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnThemMH.BackColor = System.Drawing.Color.DarkCyan;
      this.btnThemMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.btnThemMH.ForeColor = System.Drawing.Color.White;
      this.btnThemMH.Location = new System.Drawing.Point(936, 44);
      this.btnThemMH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.btnThemMH.Name = "btnThemMH";
      this.btnThemMH.Size = new System.Drawing.Size(101, 45);
      this.btnThemMH.TabIndex = 13;
      this.btnThemMH.Text = "Thêm";
      this.btnThemMH.UseVisualStyleBackColor = false;
      this.btnThemMH.Click += new System.EventHandler(this.btnThemMH_Click);
      // 
      // btnRefresh
      // 
      this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnRefresh.BackColor = System.Drawing.Color.DarkCyan;
      this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.btnRefresh.ForeColor = System.Drawing.Color.White;
      this.btnRefresh.Location = new System.Drawing.Point(1057, 44);
      this.btnRefresh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.btnRefresh.Name = "btnRefresh";
      this.btnRefresh.Size = new System.Drawing.Size(101, 45);
      this.btnRefresh.TabIndex = 12;
      this.btnRefresh.Text = "Làm mới";
      this.btnRefresh.UseVisualStyleBackColor = false;
      this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
      // 
      // txtKey
      // 
      this.txtKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.txtKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.txtKey.Location = new System.Drawing.Point(642, 53);
      this.txtKey.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.txtKey.Multiline = true;
      this.txtKey.Name = "txtKey";
      this.txtKey.Size = new System.Drawing.Size(245, 28);
      this.txtKey.TabIndex = 11;
      this.txtKey.TextChanged += new System.EventHandler(this.txtKey_TextChanged);
      // 
      // label1
      // 
      this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.label1.Location = new System.Drawing.Point(566, 57);
      this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(68, 20);
      this.label1.TabIndex = 10;
      this.label1.Text = "Từ khóa";
      // 
      // FormDanhSachMH
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1272, 553);
      this.Controls.Add(this.btnThemMH);
      this.Controls.Add(this.btnRefresh);
      this.Controls.Add(this.txtKey);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.dgvDSMH);
      this.Name = "FormDanhSachMH";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Danh sách môn học";
      this.Load += new System.EventHandler(this.FormDanhSachMH_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dgvDSMH)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.DataGridView dgvDSMH;
    private System.Windows.Forms.Button btnThemMH;
    private System.Windows.Forms.Button btnRefresh;
    private System.Windows.Forms.TextBox txtKey;
    private System.Windows.Forms.Label label1;
  }
}