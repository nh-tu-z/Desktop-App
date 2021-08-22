
namespace DesktopApp.ChildForm
{
    partial class DataTables
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSum = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlNavTable = new System.Windows.Forms.Panel();
            this.btnPhase3 = new System.Windows.Forms.Label();
            this.btnPhase2 = new System.Windows.Forms.Label();
            this.btnPhase1 = new System.Windows.Forms.Label();
            this.btnNext = new FontAwesome.Sharp.IconButton();
            this.btnPrevious = new FontAwesome.Sharp.IconButton();
            this.lblShowPage = new System.Windows.Forms.Label();
            this.lblExportExcel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(990, 471);
            this.dataGridView1.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Ord";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "VLN";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "VLL";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "I";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "KW";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "KVAR";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "KVA";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "PF";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Time";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 197;
            // 
            // btnSum
            // 
            this.btnSum.AutoSize = true;
            this.btnSum.BackColor = System.Drawing.Color.Transparent;
            this.btnSum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSum.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnSum.Location = new System.Drawing.Point(12, 9);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(73, 17);
            this.btnSum.TabIndex = 2;
            this.btnSum.Text = "SUMMARY";
            this.btnSum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnlNavTable);
            this.panel1.Controls.Add(this.btnPhase3);
            this.panel1.Controls.Add(this.btnPhase2);
            this.panel1.Controls.Add(this.btnPhase1);
            this.panel1.Controls.Add(this.btnSum);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1010, 39);
            this.panel1.TabIndex = 3;
            // 
            // pnlNavTable
            // 
            this.pnlNavTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.pnlNavTable.Location = new System.Drawing.Point(15, 29);
            this.pnlNavTable.Name = "pnlNavTable";
            this.pnlNavTable.Size = new System.Drawing.Size(70, 3);
            this.pnlNavTable.TabIndex = 4;
            // 
            // btnPhase3
            // 
            this.btnPhase3.AutoSize = true;
            this.btnPhase3.BackColor = System.Drawing.Color.Transparent;
            this.btnPhase3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPhase3.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnPhase3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnPhase3.Location = new System.Drawing.Point(275, 9);
            this.btnPhase3.Name = "btnPhase3";
            this.btnPhase3.Size = new System.Drawing.Size(60, 17);
            this.btnPhase3.TabIndex = 2;
            this.btnPhase3.Text = "PHASE 3";
            this.btnPhase3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPhase3.Click += new System.EventHandler(this.btnPhase3_Click);
            // 
            // btnPhase2
            // 
            this.btnPhase2.AutoSize = true;
            this.btnPhase2.BackColor = System.Drawing.Color.Transparent;
            this.btnPhase2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPhase2.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnPhase2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnPhase2.Location = new System.Drawing.Point(189, 9);
            this.btnPhase2.Name = "btnPhase2";
            this.btnPhase2.Size = new System.Drawing.Size(60, 17);
            this.btnPhase2.TabIndex = 2;
            this.btnPhase2.Text = "PHASE 2";
            this.btnPhase2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPhase2.Click += new System.EventHandler(this.btnPhase2_Click);
            // 
            // btnPhase1
            // 
            this.btnPhase1.AutoSize = true;
            this.btnPhase1.BackColor = System.Drawing.Color.Transparent;
            this.btnPhase1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPhase1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnPhase1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnPhase1.Location = new System.Drawing.Point(104, 9);
            this.btnPhase1.Name = "btnPhase1";
            this.btnPhase1.Size = new System.Drawing.Size(60, 17);
            this.btnPhase1.TabIndex = 2;
            this.btnPhase1.Text = "PHASE 1";
            this.btnPhase1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPhase1.Click += new System.EventHandler(this.btnPhase1_Click);
            // 
            // btnNext
            // 
            this.btnNext.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnNext.IconColor = System.Drawing.Color.Black;
            this.btnNext.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNext.Location = new System.Drawing.Point(946, 527);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(56, 32);
            this.btnNext.TabIndex = 4;
            this.btnNext.Text = ">>";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnPrevious.IconColor = System.Drawing.Color.Black;
            this.btnPrevious.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPrevious.Location = new System.Drawing.Point(875, 527);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(56, 32);
            this.btnPrevious.TabIndex = 4;
            this.btnPrevious.Text = "<<";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // lblShowPage
            // 
            this.lblShowPage.AutoSize = true;
            this.lblShowPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowPage.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblShowPage.Location = new System.Drawing.Point(16, 529);
            this.lblShowPage.Name = "lblShowPage";
            this.lblShowPage.Size = new System.Drawing.Size(20, 24);
            this.lblShowPage.TabIndex = 5;
            this.lblShowPage.Text = "  ";
            // 
            // lblExportExcel
            // 
            this.lblExportExcel.AutoSize = true;
            this.lblExportExcel.BackColor = System.Drawing.Color.Transparent;
            this.lblExportExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblExportExcel.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblExportExcel.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblExportExcel.Location = new System.Drawing.Point(12, 534);
            this.lblExportExcel.Name = "lblExportExcel";
            this.lblExportExcel.Size = new System.Drawing.Size(100, 17);
            this.lblExportExcel.TabIndex = 2;
            this.lblExportExcel.Text = "Export to Excel";
            this.lblExportExcel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LimeGreen;
            this.panel2.Location = new System.Drawing.Point(17, 552);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(90, 3);
            this.panel2.TabIndex = 4;
            // 
            // DataTables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1010, 650);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblExportExcel);
            this.Controls.Add(this.lblShowPage);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DataTables";
            this.Text = "DataTable";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label btnSum;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label btnPhase3;
        private System.Windows.Forms.Label btnPhase2;
        private System.Windows.Forms.Label btnPhase1;
        private System.Windows.Forms.Panel pnlNavTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private FontAwesome.Sharp.IconButton btnNext;
        private FontAwesome.Sharp.IconButton btnPrevious;
        private System.Windows.Forms.Label lblShowPage;
        private System.Windows.Forms.Label lblExportExcel;
        private System.Windows.Forms.Panel panel2;
    }
}