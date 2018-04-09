namespace os_project
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtarrival = new System.Windows.Forms.TextBox();
            this.txtburst = new System.Windows.Forms.TextBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnremove = new System.Windows.Forms.Button();
            this.btnshow = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colprocess = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colarrival = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colburst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colstars = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colfinish = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colwating = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rdnon_pre = new System.Windows.Forms.RadioButton();
            this.rd_pre = new System.Windows.Forms.RadioButton();
            this.lblavgta = new System.Windows.Forms.Label();
            this.lblavgwait = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(18, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Process Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(18, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Arrival Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(18, 118);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Burst Time";
            // 
            // txtid
            // 
            this.txtid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.Location = new System.Drawing.Point(156, 16);
            this.txtid.Margin = new System.Windows.Forms.Padding(4);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(148, 23);
            this.txtid.TabIndex = 3;
            // 
            // txtarrival
            // 
            this.txtarrival.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtarrival.Location = new System.Drawing.Point(156, 71);
            this.txtarrival.Margin = new System.Windows.Forms.Padding(4);
            this.txtarrival.Name = "txtarrival";
            this.txtarrival.Size = new System.Drawing.Size(148, 23);
            this.txtarrival.TabIndex = 4;
            // 
            // txtburst
            // 
            this.txtburst.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtburst.Location = new System.Drawing.Point(156, 122);
            this.txtburst.Margin = new System.Windows.Forms.Padding(4);
            this.txtburst.Name = "txtburst";
            this.txtburst.Size = new System.Drawing.Size(148, 23);
            this.txtburst.TabIndex = 5;
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.Silver;
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnadd.Location = new System.Drawing.Point(46, 174);
            this.btnadd.Margin = new System.Windows.Forms.Padding(4);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(112, 28);
            this.btnadd.TabIndex = 6;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnremove
            // 
            this.btnremove.BackColor = System.Drawing.Color.Silver;
            this.btnremove.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnremove.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnremove.Location = new System.Drawing.Point(267, 174);
            this.btnremove.Margin = new System.Windows.Forms.Padding(4);
            this.btnremove.Name = "btnremove";
            this.btnremove.Size = new System.Drawing.Size(112, 28);
            this.btnremove.TabIndex = 7;
            this.btnremove.Text = "Remove";
            this.btnremove.UseVisualStyleBackColor = false;
            this.btnremove.Click += new System.EventHandler(this.btnremove_Click);
            // 
            // btnshow
            // 
            this.btnshow.BackColor = System.Drawing.Color.Silver;
            this.btnshow.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnshow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnshow.Location = new System.Drawing.Point(494, 174);
            this.btnshow.Margin = new System.Windows.Forms.Padding(4);
            this.btnshow.Name = "btnshow";
            this.btnshow.Size = new System.Drawing.Size(112, 28);
            this.btnshow.TabIndex = 8;
            this.btnshow.Text = "Show";
            this.btnshow.UseVisualStyleBackColor = false;
            this.btnshow.Click += new System.EventHandler(this.btnshow_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colprocess,
            this.colarrival,
            this.colburst,
            this.colstars,
            this.colfinish,
            this.colwating,
            this.colta});
            this.dataGridView1.Location = new System.Drawing.Point(22, 227);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(821, 217);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.Visible = false;
            // 
            // colprocess
            // 
            this.colprocess.HeaderText = "process id";
            this.colprocess.Name = "colprocess";
            this.colprocess.ReadOnly = true;
            // 
            // colarrival
            // 
            this.colarrival.HeaderText = "Arrival Time";
            this.colarrival.Name = "colarrival";
            this.colarrival.ReadOnly = true;
            // 
            // colburst
            // 
            this.colburst.HeaderText = "Burst Time";
            this.colburst.Name = "colburst";
            this.colburst.ReadOnly = true;
            // 
            // colstars
            // 
            this.colstars.HeaderText = "Start";
            this.colstars.Name = "colstars";
            this.colstars.ReadOnly = true;
            // 
            // colfinish
            // 
            this.colfinish.HeaderText = "Finish";
            this.colfinish.Name = "colfinish";
            this.colfinish.ReadOnly = true;
            // 
            // colwating
            // 
            this.colwating.HeaderText = "Waiting Time";
            this.colwating.Name = "colwating";
            this.colwating.ReadOnly = true;
            // 
            // colta
            // 
            this.colta.HeaderText = "Time Around";
            this.colta.Name = "colta";
            this.colta.ReadOnly = true;
            // 
            // rdnon_pre
            // 
            this.rdnon_pre.AutoSize = true;
            this.rdnon_pre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdnon_pre.ForeColor = System.Drawing.Color.DarkBlue;
            this.rdnon_pre.Location = new System.Drawing.Point(325, 62);
            this.rdnon_pre.Name = "rdnon_pre";
            this.rdnon_pre.Size = new System.Drawing.Size(157, 24);
            this.rdnon_pre.TabIndex = 10;
            this.rdnon_pre.TabStop = true;
            this.rdnon_pre.Text = "Non-Pre(Dif-Arr)";
            this.rdnon_pre.UseVisualStyleBackColor = true;
            this.rdnon_pre.CheckedChanged += new System.EventHandler(this.rdnon_pre_CheckedChanged);
            // 
            // rd_pre
            // 
            this.rd_pre.AutoSize = true;
            this.rd_pre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_pre.ForeColor = System.Drawing.Color.DarkBlue;
            this.rd_pre.Location = new System.Drawing.Point(325, 110);
            this.rd_pre.Name = "rd_pre";
            this.rd_pre.Size = new System.Drawing.Size(54, 24);
            this.rd_pre.TabIndex = 11;
            this.rd_pre.TabStop = true;
            this.rd_pre.Text = "Pre";
            this.rd_pre.UseVisualStyleBackColor = true;
            this.rd_pre.CheckedChanged += new System.EventHandler(this.rd_pre_CheckedChanged);
            // 
            // lblavgta
            // 
            this.lblavgta.AutoSize = true;
            this.lblavgta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblavgta.Location = new System.Drawing.Point(545, 37);
            this.lblavgta.Name = "lblavgta";
            this.lblavgta.Size = new System.Drawing.Size(0, 17);
            this.lblavgta.TabIndex = 12;
            // 
            // lblavgwait
            // 
            this.lblavgwait.AutoSize = true;
            this.lblavgwait.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblavgwait.Location = new System.Drawing.Point(545, 100);
            this.lblavgwait.Name = "lblavgwait";
            this.lblavgwait.Size = new System.Drawing.Size(0, 17);
            this.lblavgwait.TabIndex = 13;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.ForeColor = System.Drawing.Color.DarkBlue;
            this.radioButton1.Location = new System.Drawing.Point(325, 21);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(148, 24);
            this.radioButton1.TabIndex = 14;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Non-Pre(Arr=0)";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.dataGridView2.Location = new System.Drawing.Point(86, 227);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(660, 217);
            this.dataGridView2.TabIndex = 15;
            this.dataGridView2.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "process id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Waiting Time";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Time Around";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(271, 464);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 33);
            this.label4.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(891, 521);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.lblavgwait);
            this.Controls.Add(this.lblavgta);
            this.Controls.Add(this.rd_pre);
            this.Controls.Add(this.rdnon_pre);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnshow);
            this.Controls.Add(this.btnremove);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.txtburst);
            this.Controls.Add(this.txtarrival);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtarrival;
        private System.Windows.Forms.TextBox txtburst;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnremove;
        private System.Windows.Forms.Button btnshow;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton rdnon_pre;
        private System.Windows.Forms.RadioButton rd_pre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colprocess;
        private System.Windows.Forms.DataGridViewTextBoxColumn colarrival;
        private System.Windows.Forms.DataGridViewTextBoxColumn colburst;
        private System.Windows.Forms.DataGridViewTextBoxColumn colstars;
        private System.Windows.Forms.DataGridViewTextBoxColumn colfinish;
        private System.Windows.Forms.DataGridViewTextBoxColumn colwating;
        private System.Windows.Forms.DataGridViewTextBoxColumn colta;
        private System.Windows.Forms.Label lblavgta;
        private System.Windows.Forms.Label lblavgwait;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Label label4;
    }
}

