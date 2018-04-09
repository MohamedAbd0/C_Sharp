namespace increptionVSdecreption
{
    partial class Form1
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
            this.rtxtsourse = new System.Windows.Forms.RichTextBox();
            this.txtshcount = new System.Windows.Forms.TextBox();
            this.lblres = new System.Windows.Forms.Label();
            this.btnOperation = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbInc_Dec = new System.Windows.Forms.ComboBox();
            this.CmbOper = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rtxtsourse
            // 
            this.rtxtsourse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtxtsourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtsourse.Location = new System.Drawing.Point(30, 58);
            this.rtxtsourse.Name = "rtxtsourse";
            this.rtxtsourse.Size = new System.Drawing.Size(235, 66);
            this.rtxtsourse.TabIndex = 0;
            this.rtxtsourse.Text = "";
            // 
            // txtshcount
            // 
            this.txtshcount.Location = new System.Drawing.Point(30, 230);
            this.txtshcount.Name = "txtshcount";
            this.txtshcount.Size = new System.Drawing.Size(100, 20);
            this.txtshcount.TabIndex = 1;
            this.txtshcount.Visible = false;
            this.txtshcount.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblres
            // 
            this.lblres.AutoSize = true;
            this.lblres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblres.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblres.Location = new System.Drawing.Point(278, 58);
            this.lblres.Name = "lblres";
            this.lblres.Size = new System.Drawing.Size(0, 20);
            this.lblres.TabIndex = 2;
            // 
            // btnOperation
            // 
            this.btnOperation.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOperation.ForeColor = System.Drawing.Color.Blue;
            this.btnOperation.Location = new System.Drawing.Point(159, 265);
            this.btnOperation.Name = "btnOperation";
            this.btnOperation.Size = new System.Drawing.Size(184, 37);
            this.btnOperation.TabIndex = 3;
            this.btnOperation.Text = "Operation";
            this.btnOperation.UseVisualStyleBackColor = true;
            this.btnOperation.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(27, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Source";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(277, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Target";
            // 
            // cmbInc_Dec
            // 
            this.cmbInc_Dec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbInc_Dec.FormattingEnabled = true;
            this.cmbInc_Dec.Items.AddRange(new object[] {
            "increption",
            "decreption"});
            this.cmbInc_Dec.Location = new System.Drawing.Point(31, 174);
            this.cmbInc_Dec.Name = "cmbInc_Dec";
            this.cmbInc_Dec.Size = new System.Drawing.Size(170, 28);
            this.cmbInc_Dec.TabIndex = 6;
            this.cmbInc_Dec.SelectedIndexChanged += new System.EventHandler(this.cmbInc_Dec_SelectedIndexChanged);
            // 
            // CmbOper
            // 
            this.CmbOper.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbOper.FormattingEnabled = true;
            this.CmbOper.Items.AddRange(new object[] {
            "Traditional",
            "shifting"});
            this.CmbOper.Location = new System.Drawing.Point(281, 174);
            this.CmbOper.Name = "CmbOper";
            this.CmbOper.Size = new System.Drawing.Size(170, 28);
            this.CmbOper.TabIndex = 7;
            this.CmbOper.SelectedIndexChanged += new System.EventHandler(this.CmbOper_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(277, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Operation";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(27, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(28, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Shift Count";
            this.label5.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 337);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CmbOper);
            this.Controls.Add(this.cmbInc_Dec);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOperation);
            this.Controls.Add(this.lblres);
            this.Controls.Add(this.txtshcount);
            this.Controls.Add(this.rtxtsourse);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxtsourse;
        private System.Windows.Forms.TextBox txtshcount;
        private System.Windows.Forms.Label lblres;
        private System.Windows.Forms.Button btnOperation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbInc_Dec;
        private System.Windows.Forms.ComboBox CmbOper;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

