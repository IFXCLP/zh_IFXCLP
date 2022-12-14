namespace zh_IFXCLP
{
    partial class Form2
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
            this.textposzt = new System.Windows.Forms.TextBox();
            this.listposzt = new System.Windows.Forms.ListBox();
            this.listjatekos2 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textposzt
            // 
            this.textposzt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textposzt.Location = new System.Drawing.Point(50, 70);
            this.textposzt.Name = "textposzt";
            this.textposzt.Size = new System.Drawing.Size(135, 23);
            this.textposzt.TabIndex = 0;
            this.textposzt.TextChanged += new System.EventHandler(this.textposzt_TextChanged);
            // 
            // listposzt
            // 
            this.listposzt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listposzt.FormattingEnabled = true;
            this.listposzt.ItemHeight = 15;
            this.listposzt.Location = new System.Drawing.Point(50, 136);
            this.listposzt.Name = "listposzt";
            this.listposzt.Size = new System.Drawing.Size(135, 169);
            this.listposzt.TabIndex = 1;
            this.listposzt.SelectedIndexChanged += new System.EventHandler(this.listposzt_SelectedIndexChanged);
            // 
            // listjatekos2
            // 
            this.listjatekos2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listjatekos2.FormattingEnabled = true;
            this.listjatekos2.ItemHeight = 15;
            this.listjatekos2.Location = new System.Drawing.Point(288, 136);
            this.listjatekos2.Name = "listjatekos2";
            this.listjatekos2.Size = new System.Drawing.Size(172, 169);
            this.listjatekos2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(288, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sárga lapok száma játékonként:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listjatekos2);
            this.Controls.Add(this.listposzt);
            this.Controls.Add(this.textposzt);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textposzt;
        private ListBox listposzt;
        private ListBox listjatekos2;
        private Label label1;
    }
}