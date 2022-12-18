
namespace FCFS
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.process2 = new System.Windows.Forms.TextBox();
            this.process4 = new System.Windows.Forms.TextBox();
            this.process1 = new System.Windows.Forms.TextBox();
            this.cpu = new System.Windows.Forms.TextBox();
            this.process3 = new System.Windows.Forms.TextBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button_FCFS = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.paneltop = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonnext = new System.Windows.Forms.Button();
            this.buttonhome = new System.Windows.Forms.Button();
            this.paneltop.SuspendLayout();
            this.SuspendLayout();
            // 
            // process2
            // 
            this.process2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.process2.Location = new System.Drawing.Point(304, 303);
            this.process2.Name = "process2";
            this.process2.Size = new System.Drawing.Size(131, 27);
            this.process2.TabIndex = 0;
            // 
            // process4
            // 
            this.process4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.process4.Location = new System.Drawing.Point(304, 339);
            this.process4.Name = "process4";
            this.process4.Size = new System.Drawing.Size(131, 27);
            this.process4.TabIndex = 1;
            // 
            // process1
            // 
            this.process1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.process1.Location = new System.Drawing.Point(84, 302);
            this.process1.Name = "process1";
            this.process1.Size = new System.Drawing.Size(131, 27);
            this.process1.TabIndex = 2;
            // 
            // cpu
            // 
            this.cpu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cpu.Location = new System.Drawing.Point(388, 124);
            this.cpu.Multiline = true;
            this.cpu.Name = "cpu";
            this.cpu.ReadOnly = true;
            this.cpu.Size = new System.Drawing.Size(325, 136);
            this.cpu.TabIndex = 4;
            // 
            // process3
            // 
            this.process3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.process3.Location = new System.Drawing.Point(84, 335);
            this.process3.Name = "process3";
            this.process3.Size = new System.Drawing.Size(131, 27);
            this.process3.TabIndex = 5;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(16, 124);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(310, 136);
            this.checkedListBox1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(12, 309);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Process1";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(232, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Process2";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Gold;
            this.label3.Location = new System.Drawing.Point(12, 342);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Process3";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Gold;
            this.label4.Location = new System.Drawing.Point(232, 342);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Process4";
            // 
            // button_FCFS
            // 
            this.button_FCFS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_FCFS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_FCFS.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_FCFS.ForeColor = System.Drawing.Color.Gold;
            this.button_FCFS.Location = new System.Drawing.Point(441, 269);
            this.button_FCFS.Name = "button_FCFS";
            this.button_FCFS.Size = new System.Drawing.Size(272, 120);
            this.button_FCFS.TabIndex = 11;
            this.button_FCFS.Text = "Start FCFS";
            this.button_FCFS.UseVisualStyleBackColor = true;
            this.button_FCFS.Click += new System.EventHandler(this.button_FCFS_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Gold;
            this.label5.Location = new System.Drawing.Point(118, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Ready Queue";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Gold;
            this.label6.Location = new System.Drawing.Point(537, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "CPU";
            // 
            // listView1
            // 
            this.listView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 395);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(701, 196);
            this.listView1.TabIndex = 14;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // paneltop
            // 
            this.paneltop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.paneltop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.paneltop.Controls.Add(this.label7);
            this.paneltop.Controls.Add(this.buttonnext);
            this.paneltop.Controls.Add(this.buttonhome);
            this.paneltop.Location = new System.Drawing.Point(0, 0);
            this.paneltop.Name = "paneltop";
            this.paneltop.Size = new System.Drawing.Size(725, 90);
            this.paneltop.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Myanmar Text", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(250, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(257, 60);
            this.label7.TabIndex = 2;
            this.label7.Text = "FCFS Algorithm";
            // 
            // buttonnext
            // 
            this.buttonnext.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonnext.Location = new System.Drawing.Point(600, 0);
            this.buttonnext.Name = "buttonnext";
            this.buttonnext.Size = new System.Drawing.Size(125, 90);
            this.buttonnext.TabIndex = 1;
            this.buttonnext.Text = "Next";
            this.buttonnext.UseVisualStyleBackColor = true;
            this.buttonnext.Click += new System.EventHandler(this.buttonnext_Click);
            // 
            // buttonhome
            // 
            this.buttonhome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonhome.Location = new System.Drawing.Point(0, 0);
            this.buttonhome.Name = "buttonhome";
            this.buttonhome.Size = new System.Drawing.Size(125, 90);
            this.buttonhome.TabIndex = 0;
            this.buttonhome.Text = "Home";
            this.buttonhome.UseVisualStyleBackColor = true;
            this.buttonhome.Click += new System.EventHandler(this.buttonhome_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(725, 603);
            this.Controls.Add(this.paneltop);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button_FCFS);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.process3);
            this.Controls.Add(this.cpu);
            this.Controls.Add(this.process1);
            this.Controls.Add(this.process4);
            this.Controls.Add(this.process2);
            this.Name = "Form1";
            this.Text = "FCFS 1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.paneltop.ResumeLayout(false);
            this.paneltop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox process2;
        private System.Windows.Forms.TextBox process4;
        private System.Windows.Forms.TextBox process1;
        private System.Windows.Forms.TextBox cpu;
        private System.Windows.Forms.TextBox process3;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_FCFS;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel paneltop;
        private System.Windows.Forms.Button buttonhome;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonnext;
    }
}

