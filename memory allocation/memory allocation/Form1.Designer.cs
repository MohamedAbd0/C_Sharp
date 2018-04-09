namespace memory_allocation
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtb1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtb3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtb4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtb2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rfrist_fit = new System.Windows.Forms.RadioButton();
            this.rn = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.txtpro = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lwait = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(38, 175);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Save Size";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtb1
            // 
            this.txtb1.Location = new System.Drawing.Point(85, 46);
            this.txtb1.Name = "txtb1";
            this.txtb1.Size = new System.Drawing.Size(84, 20);
            this.txtb1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(35, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Block 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(35, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Block 3";
            // 
            // txtb3
            // 
            this.txtb3.Location = new System.Drawing.Point(86, 106);
            this.txtb3.Name = "txtb3";
            this.txtb3.Size = new System.Drawing.Size(84, 20);
            this.txtb3.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(35, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Block 4";
            // 
            // txtb4
            // 
            this.txtb4.Location = new System.Drawing.Point(86, 138);
            this.txtb4.Name = "txtb4";
            this.txtb4.Size = new System.Drawing.Size(84, 20);
            this.txtb4.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(35, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Block 2";
            // 
            // txtb2
            // 
            this.txtb2.Location = new System.Drawing.Point(85, 72);
            this.txtb2.Name = "txtb2";
            this.txtb2.Size = new System.Drawing.Size(84, 20);
            this.txtb2.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(95, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Memory Block";
            // 
            // rfrist_fit
            // 
            this.rfrist_fit.AutoSize = true;
            this.rfrist_fit.ForeColor = System.Drawing.Color.Blue;
            this.rfrist_fit.Location = new System.Drawing.Point(219, 49);
            this.rfrist_fit.Name = "rfrist_fit";
            this.rfrist_fit.Size = new System.Drawing.Size(58, 17);
            this.rfrist_fit.TabIndex = 10;
            this.rfrist_fit.TabStop = true;
            this.rfrist_fit.Text = "Frist Fit";
            this.rfrist_fit.UseVisualStyleBackColor = true;
            this.rfrist_fit.CheckedChanged += new System.EventHandler(this.rfrist_fit_CheckedChanged);
            // 
            // rn
            // 
            this.rn.AutoSize = true;
            this.rn.ForeColor = System.Drawing.Color.Blue;
            this.rn.Location = new System.Drawing.Point(219, 109);
            this.rn.Name = "rn";
            this.rn.Size = new System.Drawing.Size(61, 17);
            this.rn.TabIndex = 11;
            this.rn.TabStop = true;
            this.rn.Text = "Next Fit";
            this.rn.UseVisualStyleBackColor = true;
            this.rn.CheckedChanged += new System.EventHandler(this.rn_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(15, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Enter Your Process";
            // 
            // txtpro
            // 
            this.txtpro.Location = new System.Drawing.Point(133, 225);
            this.txtpro.Name = "txtpro";
            this.txtpro.Size = new System.Drawing.Size(84, 20);
            this.txtpro.TabIndex = 14;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(229, 223);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Add Process";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(64, 261);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(153, 23);
            this.button3.TabIndex = 17;
            this.button3.Text = "Calculation The Operation";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(322, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(345, 138);
            this.dataGridView1.TabIndex = 18;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Block";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Size Block";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Size Process";
            this.Column3.Name = "Column3";
            // 
            // lwait
            // 
            this.lwait.AutoSize = true;
            this.lwait.Font = new System.Drawing.Font("Minion Pro Med", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lwait.ForeColor = System.Drawing.Color.Red;
            this.lwait.Location = new System.Drawing.Point(413, 175);
            this.lwait.Name = "lwait";
            this.lwait.Size = new System.Drawing.Size(0, 22);
            this.lwait.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 307);
            this.Controls.Add(this.lwait);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtpro);
            this.Controls.Add(this.rn);
            this.Controls.Add(this.rfrist_fit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtb2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtb4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtb3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtb1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtb1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtb3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtb4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtb2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rfrist_fit;
        private System.Windows.Forms.RadioButton rn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtpro;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label lwait;
    }
}

