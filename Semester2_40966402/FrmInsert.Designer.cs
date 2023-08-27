namespace Semester2_40966402
{
    partial class FrmInsert
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIDInsert = new System.Windows.Forms.TextBox();
            this.txtNameInsert = new System.Windows.Forms.TextBox();
            this.txtSurnameInsert = new System.Windows.Forms.TextBox();
            this.txtYearInsert = new System.Windows.Forms.TextBox();
            this.rtxtQuoteInsert = new System.Windows.Forms.RichTextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.nameErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.IdErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.yearSaidErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.surnameErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.quoteErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nameErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IdErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yearSaidErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.surnameErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quoteErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(128, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Surname:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(128, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Year said:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(128, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Quote:";
            // 
            // txtIDInsert
            // 
            this.txtIDInsert.Location = new System.Drawing.Point(233, 26);
            this.txtIDInsert.Name = "txtIDInsert";
            this.txtIDInsert.Size = new System.Drawing.Size(151, 22);
            this.txtIDInsert.TabIndex = 5;
            // 
            // txtNameInsert
            // 
            this.txtNameInsert.Location = new System.Drawing.Point(233, 65);
            this.txtNameInsert.Name = "txtNameInsert";
            this.txtNameInsert.Size = new System.Drawing.Size(151, 22);
            this.txtNameInsert.TabIndex = 6;
            // 
            // txtSurnameInsert
            // 
            this.txtSurnameInsert.Location = new System.Drawing.Point(233, 101);
            this.txtSurnameInsert.Name = "txtSurnameInsert";
            this.txtSurnameInsert.Size = new System.Drawing.Size(151, 22);
            this.txtSurnameInsert.TabIndex = 7;
            // 
            // txtYearInsert
            // 
            this.txtYearInsert.Location = new System.Drawing.Point(233, 141);
            this.txtYearInsert.Name = "txtYearInsert";
            this.txtYearInsert.Size = new System.Drawing.Size(151, 22);
            this.txtYearInsert.TabIndex = 8;
            // 
            // rtxtQuoteInsert
            // 
            this.rtxtQuoteInsert.Location = new System.Drawing.Point(233, 191);
            this.rtxtQuoteInsert.Name = "rtxtQuoteInsert";
            this.rtxtQuoteInsert.Size = new System.Drawing.Size(151, 119);
            this.rtxtQuoteInsert.TabIndex = 9;
            this.rtxtQuoteInsert.Text = "";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(188, 348);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 39);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // nameErrorProvider
            // 
            this.nameErrorProvider.ContainerControl = this;
            // 
            // IdErrorProvider
            // 
            this.IdErrorProvider.ContainerControl = this;
            // 
            // yearSaidErrorProvider
            // 
            this.yearSaidErrorProvider.ContainerControl = this;
            // 
            // surnameErrorProvider
            // 
            this.surnameErrorProvider.ContainerControl = this;
            // 
            // quoteErrorProvider
            // 
            this.quoteErrorProvider.ContainerControl = this;
            // 
            // FrmInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 450);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.rtxtQuoteInsert);
            this.Controls.Add(this.txtYearInsert);
            this.Controls.Add(this.txtSurnameInsert);
            this.Controls.Add(this.txtNameInsert);
            this.Controls.Add(this.txtIDInsert);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmInsert";
            this.Text = "FrmInsert";
            ((System.ComponentModel.ISupportInitialize)(this.nameErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IdErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yearSaidErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.surnameErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quoteErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIDInsert;
        private System.Windows.Forms.TextBox txtNameInsert;
        private System.Windows.Forms.TextBox txtSurnameInsert;
        private System.Windows.Forms.TextBox txtYearInsert;
        private System.Windows.Forms.RichTextBox rtxtQuoteInsert;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ErrorProvider nameErrorProvider;
        private System.Windows.Forms.ErrorProvider IdErrorProvider;
        private System.Windows.Forms.ErrorProvider yearSaidErrorProvider;
        private System.Windows.Forms.ErrorProvider surnameErrorProvider;
        private System.Windows.Forms.ErrorProvider quoteErrorProvider;
    }
}