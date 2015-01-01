namespace Delegate
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
            this.btnApproach1 = new System.Windows.Forms.Button();
            this.btnUsingDelegates = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.LogList = new System.Windows.Forms.ListBox();
            this.Logs = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnApproach1
            // 
            this.btnApproach1.Location = new System.Drawing.Point(58, 75);
            this.btnApproach1.Name = "btnApproach1";
            this.btnApproach1.Size = new System.Drawing.Size(130, 45);
            this.btnApproach1.TabIndex = 0;
            this.btnApproach1.Text = "Approach1";
            this.btnApproach1.UseVisualStyleBackColor = true;
            this.btnApproach1.Click += new System.EventHandler(this.btnApproach1_Click);
            // 
            // btnUsingDelegates
            // 
            this.btnUsingDelegates.Location = new System.Drawing.Point(58, 140);
            this.btnUsingDelegates.Name = "btnUsingDelegates";
            this.btnUsingDelegates.Size = new System.Drawing.Size(130, 36);
            this.btnUsingDelegates.TabIndex = 0;
            this.btnUsingDelegates.Text = "Using Delegates";
            this.btnUsingDelegates.UseVisualStyleBackColor = true;
            this.btnUsingDelegates.Click += new System.EventHandler(this.btnUsingDelegates_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(270, 25);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(396, 264);
            this.listBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(58, 204);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LogList
            // 
            this.LogList.FormattingEnabled = true;
            this.LogList.Location = new System.Drawing.Point(57, 353);
            this.LogList.Name = "LogList";
            this.LogList.Size = new System.Drawing.Size(396, 264);
            this.LogList.TabIndex = 1;
            // 
            // Logs
            // 
            this.Logs.AutoSize = true;
            this.Logs.Location = new System.Drawing.Point(55, 337);
            this.Logs.Name = "Logs";
            this.Logs.Size = new System.Drawing.Size(30, 13);
            this.Logs.TabIndex = 3;
            this.Logs.Text = "Logs";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 675);
            this.Controls.Add(this.Logs);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LogList);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnUsingDelegates);
            this.Controls.Add(this.btnApproach1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnApproach1;
        private System.Windows.Forms.Button btnUsingDelegates;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox LogList;
        private System.Windows.Forms.Label Logs;
    }
}

