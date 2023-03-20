
namespace QLSV
{
  partial class FormDanhSachCN
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
            this.btnThemCN = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDSCN = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSCN)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThemCN
            // 
            this.btnThemCN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemCN.BackColor = System.Drawing.Color.DarkCyan;
            this.btnThemCN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThemCN.ForeColor = System.Drawing.Color.White;
            this.btnThemCN.Location = new System.Drawing.Point(1033, 50);
            this.btnThemCN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThemCN.Name = "btnThemCN";
            this.btnThemCN.Size = new System.Drawing.Size(112, 51);
            this.btnThemCN.TabIndex = 23;
            this.btnThemCN.Text = "Thêm";
            this.btnThemCN.UseVisualStyleBackColor = false;
            this.btnThemCN.Click += new System.EventHandler(this.btnThemCN_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.BackColor = System.Drawing.Color.DarkCyan;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(1172, 50);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(112, 51);
            this.btnRefresh.TabIndex = 22;
            this.btnRefresh.Text = "Làm mới";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // txtKey
            // 
            this.txtKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtKey.Location = new System.Drawing.Point(722, 59);
            this.txtKey.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtKey.Multiline = true;
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(275, 34);
            this.txtKey.TabIndex = 21;
            this.txtKey.TextChanged += new System.EventHandler(this.txtKey_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(636, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "Từ khóa";
            // 
            // dgvDSCN
            // 
            this.dgvDSCN.AllowUserToAddRows = false;
            this.dgvDSCN.AllowUserToDeleteRows = false;
            this.dgvDSCN.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDSCN.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSCN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSCN.Location = new System.Drawing.Point(0, 128);
            this.dgvDSCN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvDSCN.MultiSelect = false;
            this.dgvDSCN.Name = "dgvDSCN";
            this.dgvDSCN.ReadOnly = true;
            this.dgvDSCN.RowHeadersWidth = 51;
            this.dgvDSCN.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSCN.Size = new System.Drawing.Size(1431, 564);
            this.dgvDSCN.TabIndex = 19;
            this.dgvDSCN.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSCN_CellContentClick);
            this.dgvDSCN.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSCN_CellDoubleClick);
            // 
            // FormDanhSachCN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1431, 691);
            this.Controls.Add(this.btnThemCN);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDSCN);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormDanhSachCN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDanhSachCN";
            this.Load += new System.EventHandler(this.FormDanhSachCN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSCN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnThemCN;
    private System.Windows.Forms.Button btnRefresh;
    private System.Windows.Forms.TextBox txtKey;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.DataGridView dgvDSCN;
  }
}