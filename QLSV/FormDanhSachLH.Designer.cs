
namespace QLSV
{
  partial class FormDanhSachLH
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
            this.btnThemLH = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.txtKeyLH = new System.Windows.Forms.TextBox();
            this.lblKey = new System.Windows.Forms.Label();
            this.dgvDSLH = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSLH)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThemLH
            // 
            this.btnThemLH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemLH.BackColor = System.Drawing.Color.DarkCyan;
            this.btnThemLH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThemLH.ForeColor = System.Drawing.Color.White;
            this.btnThemLH.Location = new System.Drawing.Point(1063, 50);
            this.btnThemLH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThemLH.Name = "btnThemLH";
            this.btnThemLH.Size = new System.Drawing.Size(112, 38);
            this.btnThemLH.TabIndex = 18;
            this.btnThemLH.Text = "Thêm";
            this.btnThemLH.UseVisualStyleBackColor = false;
            this.btnThemLH.Click += new System.EventHandler(this.btnThemLH_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.BackColor = System.Drawing.Color.DarkCyan;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(1205, 50);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(112, 38);
            this.btnRefresh.TabIndex = 17;
            this.btnRefresh.Text = "Làm mới";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // txtKeyLH
            // 
            this.txtKeyLH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKeyLH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtKeyLH.Location = new System.Drawing.Point(741, 52);
            this.txtKeyLH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtKeyLH.Multiline = true;
            this.txtKeyLH.Name = "txtKeyLH";
            this.txtKeyLH.Size = new System.Drawing.Size(275, 34);
            this.txtKeyLH.TabIndex = 16;
            this.txtKeyLH.TextChanged += new System.EventHandler(this.txtKeyLH_TextChanged);
            // 
            // lblKey
            // 
            this.lblKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblKey.AutoSize = true;
            this.lblKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblKey.Location = new System.Drawing.Point(655, 57);
            this.lblKey.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(90, 25);
            this.lblKey.TabIndex = 15;
            this.lblKey.Text = "Từ khóa";
            // 
            // dgvDSLH
            // 
            this.dgvDSLH.AllowUserToAddRows = false;
            this.dgvDSLH.AllowUserToDeleteRows = false;
            this.dgvDSLH.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDSLH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSLH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSLH.Location = new System.Drawing.Point(0, 119);
            this.dgvDSLH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvDSLH.MultiSelect = false;
            this.dgvDSLH.Name = "dgvDSLH";
            this.dgvDSLH.ReadOnly = true;
            this.dgvDSLH.RowHeadersWidth = 51;
            this.dgvDSLH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSLH.Size = new System.Drawing.Size(1431, 574);
            this.dgvDSLH.TabIndex = 14;
            this.dgvDSLH.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSLH_CellDoubleClick);
            // 
            // FormDanhSachLH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1431, 691);
            this.Controls.Add(this.btnThemLH);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.txtKeyLH);
            this.Controls.Add(this.lblKey);
            this.Controls.Add(this.dgvDSLH);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormDanhSachLH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách lớp học";
            this.Load += new System.EventHandler(this.FormDanhSachLH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSLH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnThemLH;
    private System.Windows.Forms.Button btnRefresh;
    private System.Windows.Forms.TextBox txtKeyLH;
    private System.Windows.Forms.Label lblKey;
    private System.Windows.Forms.DataGridView dgvDSLH;
  }
}