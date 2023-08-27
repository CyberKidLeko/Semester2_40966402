namespace Semester2_40966402
{
    partial class ViewForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbNames = new System.Windows.Forms.ComboBox();
            this.hsbYear = new System.Windows.Forms.HScrollBar();
            this.lblYearScrollBar = new System.Windows.Forms.Label();
            this.lblRemoveFilter = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 292);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblRemoveFilter);
            this.groupBox1.Controls.Add(this.lblYearScrollBar);
            this.groupBox1.Controls.Add(this.hsbYear);
            this.groupBox1.Controls.Add(this.cmbNames);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 310);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 128);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter Quotes";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Year:";
            // 
            // cmbNames
            // 
            this.cmbNames.FormattingEnabled = true;
            this.cmbNames.Location = new System.Drawing.Point(83, 18);
            this.cmbNames.Name = "cmbNames";
            this.cmbNames.Size = new System.Drawing.Size(140, 24);
            this.cmbNames.TabIndex = 2;
            // 
            // hsbYear
            // 
            this.hsbYear.Location = new System.Drawing.Point(83, 64);
            this.hsbYear.Name = "hsbYear";
            this.hsbYear.Size = new System.Drawing.Size(140, 21);
            this.hsbYear.TabIndex = 3;
            this.hsbYear.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hsbYear_Scroll);
            // 
            // lblYearScrollBar
            // 
            this.lblYearScrollBar.AutoSize = true;
            this.lblYearScrollBar.Location = new System.Drawing.Point(270, 69);
            this.lblYearScrollBar.Name = "lblYearScrollBar";
            this.lblYearScrollBar.Size = new System.Drawing.Size(0, 16);
            this.lblYearScrollBar.TabIndex = 4;
            // 
            // lblRemoveFilter
            // 
            this.lblRemoveFilter.AutoSize = true;
            this.lblRemoveFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemoveFilter.Location = new System.Drawing.Point(666, 86);
            this.lblRemoveFilter.Name = "lblRemoveFilter";
            this.lblRemoveFilter.Size = new System.Drawing.Size(104, 16);
            this.lblRemoveFilter.TabIndex = 5;
            this.lblRemoveFilter.Text = "Remove Filter";
            this.lblRemoveFilter.Click += new System.EventHandler(this.lblRemoveFilter_Click);
            // 
            // ViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ViewForm";
            this.Text = "ViewForm";
            this.Load += new System.EventHandler(this.ViewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblRemoveFilter;
        private System.Windows.Forms.Label lblYearScrollBar;
        private System.Windows.Forms.HScrollBar hsbYear;
        private System.Windows.Forms.ComboBox cmbNames;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dataGridView1;
    }
}