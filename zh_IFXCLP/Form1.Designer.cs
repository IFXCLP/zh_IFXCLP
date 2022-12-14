namespace zh_IFXCLP
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
            this.textnemzetiseg = new System.Windows.Forms.TextBox();
            this.listnemzetiseg = new System.Windows.Forms.ListBox();
            this.listjatekos = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonadd = new System.Windows.Forms.Button();
            this.buttonremove = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textnemzetiseg
            // 
            this.textnemzetiseg.Location = new System.Drawing.Point(75, 124);
            this.textnemzetiseg.Name = "textnemzetiseg";
            this.textnemzetiseg.Size = new System.Drawing.Size(136, 23);
            this.textnemzetiseg.TabIndex = 0;
            this.textnemzetiseg.TextChanged += new System.EventHandler(this.textnemzetiseg_TextChanged);
            // 
            // listnemzetiseg
            // 
            this.listnemzetiseg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listnemzetiseg.FormattingEnabled = true;
            this.listnemzetiseg.ItemHeight = 15;
            this.listnemzetiseg.Location = new System.Drawing.Point(75, 169);
            this.listnemzetiseg.Name = "listnemzetiseg";
            this.listnemzetiseg.Size = new System.Drawing.Size(136, 214);
            this.listnemzetiseg.TabIndex = 1;
            this.listnemzetiseg.SelectedIndexChanged += new System.EventHandler(this.listnemzetiseg_SelectedIndexChanged);
            // 
            // listjatekos
            // 
            this.listjatekos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listjatekos.FormattingEnabled = true;
            this.listjatekos.ItemHeight = 15;
            this.listjatekos.Location = new System.Drawing.Point(386, 169);
            this.listjatekos.Name = "listjatekos";
            this.listjatekos.Size = new System.Drawing.Size(144, 214);
            this.listjatekos.TabIndex = 2;
            // 
            // listBox3
            // 
            this.listBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 15;
            this.listBox3.Location = new System.Drawing.Point(617, 169);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(124, 214);
            this.listBox3.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(617, 124);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(124, 23);
            this.textBox1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(261, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Poszt";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonadd
            // 
            this.buttonadd.Location = new System.Drawing.Point(261, 264);
            this.buttonadd.Name = "buttonadd";
            this.buttonadd.Size = new System.Drawing.Size(75, 23);
            this.buttonadd.TabIndex = 6;
            this.buttonadd.Text = "Add";
            this.buttonadd.UseVisualStyleBackColor = true;
            // 
            // buttonremove
            // 
            this.buttonremove.Location = new System.Drawing.Point(261, 313);
            this.buttonremove.Name = "buttonremove";
            this.buttonremove.Size = new System.Drawing.Size(75, 23);
            this.buttonremove.TabIndex = 7;
            this.buttonremove.Text = "Remove";
            this.buttonremove.UseVisualStyleBackColor = true;
            this.buttonremove.Click += new System.EventHandler(this.buttonremove_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Szűrés nemzetiség szerint:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(368, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Sárga lapok száma játékosonként:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonremove);
            this.Controls.Add(this.buttonadd);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listjatekos);
            this.Controls.Add(this.listnemzetiseg);
            this.Controls.Add(this.textnemzetiseg);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textnemzetiseg;
        private ListBox listnemzetiseg;
        private ListBox listjatekos;
        private ListBox listBox3;
        private TextBox textBox1;
        private Button button1;
        private Button buttonadd;
        private Button buttonremove;
        private Label label1;
        private Label label2;
    }
}