namespace Async1
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
            this.btnCallAsync = new System.Windows.Forms.Button();
            this.btnCallAsync2 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnCallAsync
            // 
            this.btnCallAsync.Location = new System.Drawing.Point(79, 37);
            this.btnCallAsync.Name = "btnCallAsync";
            this.btnCallAsync.Size = new System.Drawing.Size(114, 62);
            this.btnCallAsync.TabIndex = 0;
            this.btnCallAsync.Text = "Call Async";
            this.btnCallAsync.UseVisualStyleBackColor = true;
            this.btnCallAsync.Click += new System.EventHandler(this.btnCallAsync_Click);
            // 
            // btnCallAsync2
            // 
            this.btnCallAsync2.Location = new System.Drawing.Point(79, 118);
            this.btnCallAsync2.Name = "btnCallAsync2";
            this.btnCallAsync2.Size = new System.Drawing.Size(114, 62);
            this.btnCallAsync2.TabIndex = 0;
            this.btnCallAsync2.Text = "Call Async 2";
            this.btnCallAsync2.UseVisualStyleBackColor = true;
            this.btnCallAsync2.Click += new System.EventHandler(this.btnCallAsync2_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(290, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(365, 251);
            this.listBox1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 681);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnCallAsync2);
            this.Controls.Add(this.btnCallAsync);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCallAsync;
        private System.Windows.Forms.Button btnCallAsync2;
        private System.Windows.Forms.ListBox listBox1;
    }
}

