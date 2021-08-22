
namespace DesktopApp.ChildForm
{
    partial class Alarms
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbxDD = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnPreviousDA = new FontAwesome.Sharp.IconButton();
            this.dGVDigitalAlarms = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNextDA = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbxAA = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnPreviousAA = new FontAwesome.Sharp.IconButton();
            this.dGVAnalogAlarms = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNextAA = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVDigitalAlarms)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVAnalogAlarms)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbxDD);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1010, 50);
            this.panel1.TabIndex = 0;
            // 
            // cbxDD
            // 
            this.cbxDD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDD.FormattingEnabled = true;
            this.cbxDD.Items.AddRange(new object[] {
            "All",
            "DI0",
            "DI1",
            "DO0",
            "DO1"});
            this.cbxDD.Location = new System.Drawing.Point(885, 17);
            this.cbxDD.Name = "cbxDD";
            this.cbxDD.Size = new System.Drawing.Size(100, 21);
            this.cbxDD.TabIndex = 1;
            this.cbxDD.SelectedIndexChanged += new System.EventHandler(this.cbxDD_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label1.Location = new System.Drawing.Point(18, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "DIGITAL ALARMS";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnPreviousDA);
            this.panel2.Controls.Add(this.dGVDigitalAlarms);
            this.panel2.Controls.Add(this.btnNextDA);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1010, 250);
            this.panel2.TabIndex = 1;
            // 
            // btnPreviousDA
            // 
            this.btnPreviousDA.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnPreviousDA.IconColor = System.Drawing.Color.Black;
            this.btnPreviousDA.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPreviousDA.Location = new System.Drawing.Point(858, 206);
            this.btnPreviousDA.Name = "btnPreviousDA";
            this.btnPreviousDA.Size = new System.Drawing.Size(56, 32);
            this.btnPreviousDA.TabIndex = 5;
            this.btnPreviousDA.Text = "<<";
            this.btnPreviousDA.UseVisualStyleBackColor = true;
            this.btnPreviousDA.Click += new System.EventHandler(this.btnPreviousDA_Click);
            // 
            // dGVDigitalAlarms
            // 
            this.dGVDigitalAlarms.AllowUserToAddRows = false;
            this.dGVDigitalAlarms.AllowUserToDeleteRows = false;
            this.dGVDigitalAlarms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVDigitalAlarms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dGVDigitalAlarms.Location = new System.Drawing.Point(22, 6);
            this.dGVDigitalAlarms.Name = "dGVDigitalAlarms";
            this.dGVDigitalAlarms.ReadOnly = true;
            this.dGVDigitalAlarms.Size = new System.Drawing.Size(963, 194);
            this.dGVDigitalAlarms.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Ord";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tag Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 270;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Value";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 270;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Time";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 260;
            // 
            // btnNextDA
            // 
            this.btnNextDA.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnNextDA.IconColor = System.Drawing.Color.Black;
            this.btnNextDA.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNextDA.Location = new System.Drawing.Point(929, 206);
            this.btnNextDA.Name = "btnNextDA";
            this.btnNextDA.Size = new System.Drawing.Size(56, 32);
            this.btnNextDA.TabIndex = 6;
            this.btnNextDA.Text = ">>";
            this.btnNextDA.UseVisualStyleBackColor = true;
            this.btnNextDA.Click += new System.EventHandler(this.btnNextDA_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cbxAA);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 300);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1010, 50);
            this.panel3.TabIndex = 1;
            // 
            // cbxAA
            // 
            this.cbxAA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAA.FormattingEnabled = true;
            this.cbxAA.Items.AddRange(new object[] {
            "All",
            "VLN",
            "V1N"});
            this.cbxAA.Location = new System.Drawing.Point(885, 19);
            this.cbxAA.Name = "cbxAA";
            this.cbxAA.Size = new System.Drawing.Size(100, 21);
            this.cbxAA.TabIndex = 1;
            this.cbxAA.SelectedIndexChanged += new System.EventHandler(this.cbxAA_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label2.Location = new System.Drawing.Point(18, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "ANALOG ALARMS";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnPreviousAA);
            this.panel4.Controls.Add(this.dGVAnalogAlarms);
            this.panel4.Controls.Add(this.btnNextAA);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 350);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1010, 250);
            this.panel4.TabIndex = 1;
            // 
            // btnPreviousAA
            // 
            this.btnPreviousAA.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnPreviousAA.IconColor = System.Drawing.Color.Black;
            this.btnPreviousAA.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPreviousAA.Location = new System.Drawing.Point(858, 207);
            this.btnPreviousAA.Name = "btnPreviousAA";
            this.btnPreviousAA.Size = new System.Drawing.Size(56, 32);
            this.btnPreviousAA.TabIndex = 5;
            this.btnPreviousAA.Text = "<<";
            this.btnPreviousAA.UseVisualStyleBackColor = true;
            this.btnPreviousAA.Click += new System.EventHandler(this.btnPreviousAA_Click);
            // 
            // dGVAnalogAlarms
            // 
            this.dGVAnalogAlarms.AllowUserToAddRows = false;
            this.dGVAnalogAlarms.AllowUserToDeleteRows = false;
            this.dGVAnalogAlarms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVAnalogAlarms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.dGVAnalogAlarms.Location = new System.Drawing.Point(22, 7);
            this.dGVAnalogAlarms.Name = "dGVAnalogAlarms";
            this.dGVAnalogAlarms.ReadOnly = true;
            this.dGVAnalogAlarms.Size = new System.Drawing.Size(963, 194);
            this.dGVAnalogAlarms.TabIndex = 0;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Ord";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Tag Name";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 200;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Value";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 200;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "State";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 200;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Time";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 220;
            // 
            // btnNextAA
            // 
            this.btnNextAA.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnNextAA.IconColor = System.Drawing.Color.Black;
            this.btnNextAA.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNextAA.Location = new System.Drawing.Point(929, 207);
            this.btnNextAA.Name = "btnNextAA";
            this.btnNextAA.Size = new System.Drawing.Size(56, 32);
            this.btnNextAA.TabIndex = 6;
            this.btnNextAA.Text = ">>";
            this.btnNextAA.UseVisualStyleBackColor = true;
            this.btnNextAA.Click += new System.EventHandler(this.btnNextAA_Click);
            // 
            // Alarms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1010, 650);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Alarms";
            this.Text = "Alarms";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVDigitalAlarms)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVAnalogAlarms)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dGVDigitalAlarms;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dGVAnalogAlarms;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private FontAwesome.Sharp.IconButton btnPreviousDA;
        private FontAwesome.Sharp.IconButton btnNextDA;
        private FontAwesome.Sharp.IconButton btnPreviousAA;
        private FontAwesome.Sharp.IconButton btnNextAA;
        private System.Windows.Forms.ComboBox cbxDD;
        private System.Windows.Forms.ComboBox cbxAA;
    }
}