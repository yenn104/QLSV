
namespace QLSV
{
  partial class FormDiem
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
            this.btnLưu = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDS = new System.Windows.Forms.DataGridView();
            this.txtTenMH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNienKhoa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbLop = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDS)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLưu
            // 
            this.btnLưu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLưu.BackColor = System.Drawing.Color.DarkCyan;
            this.btnLưu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLưu.ForeColor = System.Drawing.Color.White;
            this.btnLưu.Location = new System.Drawing.Point(861, 146);
            this.btnLưu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLưu.Name = "btnLưu";
            this.btnLưu.Size = new System.Drawing.Size(107, 51);
            this.btnLưu.TabIndex = 14;
            this.btnLưu.Text = "Lưu";
            this.btnLưu.UseVisualStyleBackColor = false;
            this.btnLưu.Click += new System.EventHandler(this.btnLưu_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.BackColor = System.Drawing.Color.DarkCyan;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(1029, 146);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(107, 51);
            this.btnRefresh.TabIndex = 13;
            this.btnRefresh.Text = "Đặt lại";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // txtKey
            // 
            this.txtKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtKey.Location = new System.Drawing.Point(861, 65);
            this.txtKey.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtKey.Multiline = true;
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(275, 34);
            this.txtKey.TabIndex = 12;
            this.txtKey.TextChanged += new System.EventHandler(this.txtKey_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(775, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 22);
            this.label1.TabIndex = 11;
            this.label1.Text = "Từ khóa";
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
            this.dgvDS.Location = new System.Drawing.Point(0, 244);
            this.dgvDS.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvDS.MultiSelect = false;
            this.dgvDS.Name = "dgvDS";
            this.dgvDS.ReadOnly = true;
            this.dgvDS.RowHeadersWidth = 51;
            this.dgvDS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDS.Size = new System.Drawing.Size(1192, 586);
            this.dgvDS.TabIndex = 10;
            // 
            // txtTenMH
            // 
            this.txtTenMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenMH.Location = new System.Drawing.Point(159, 135);
            this.txtTenMH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTenMH.Multiline = true;
            this.txtTenMH.Name = "txtTenMH";
            this.txtTenMH.Size = new System.Drawing.Size(493, 34);
            this.txtTenMH.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(64, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 22);
            this.label2.TabIndex = 15;
            this.label2.Text = "Lớp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(64, 139);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 22);
            this.label3.TabIndex = 17;
            this.label3.Text = "Môn học";
            // 
            // txtNienKhoa
            // 
            this.txtNienKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtNienKhoa.Location = new System.Drawing.Point(493, 69);
            this.txtNienKhoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNienKhoa.Multiline = true;
            this.txtNienKhoa.Name = "txtNienKhoa";
            this.txtNienKhoa.Size = new System.Drawing.Size(160, 34);
            this.txtNienKhoa.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(398, 75);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 22);
            this.label4.TabIndex = 19;
            this.label4.Text = "Niên khóa";
            // 
            // cbbLop
            // 
            this.cbbLop.FormattingEnabled = true;
            this.cbbLop.Location = new System.Drawing.Point(159, 68);
            this.cbbLop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbbLop.Name = "cbbLop";
            this.cbbLop.Size = new System.Drawing.Size(181, 28);
            this.cbbLop.TabIndex = 21;
            this.cbbLop.SelectedIndexChanged += new System.EventHandler(this.cbbLop_SelectedIndexChanged);
            // 
            // FormDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 828);
            this.Controls.Add(this.cbbLop);
            this.Controls.Add(this.txtNienKhoa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTenMH);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLưu);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDS);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormDiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập điểm";
            this.Load += new System.EventHandler(this.FormDiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnLưu;
    private System.Windows.Forms.Button btnRefresh;
    private System.Windows.Forms.TextBox txtKey;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.DataGridView dgvDS;
    private System.Windows.Forms.TextBox txtTenMH;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txtNienKhoa;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.ComboBox cbbLop;
  }
}