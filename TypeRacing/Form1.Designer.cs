namespace TypeRacing
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.TextToType = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.typingText = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.status = new System.Windows.Forms.Label();
            this.testbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Yi Baiti", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Type the text below";
            // 
            // TextToType
            // 
            this.TextToType.AccessibleName = "typeThis";
            this.TextToType.AutoSize = true;
            this.TextToType.Location = new System.Drawing.Point(33, 62);
            this.TextToType.MaximumSize = new System.Drawing.Size(720, 0);
            this.TextToType.Name = "TextToType";
            this.TextToType.Size = new System.Drawing.Size(35, 13);
            this.TextToType.TabIndex = 1;
            this.TextToType.Text = "label2";
            // 
            // progressBar
            // 
            this.progressBar.AccessibleName = "imay";
            this.progressBar.Location = new System.Drawing.Point(36, 286);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(100, 23);
            this.progressBar.TabIndex = 2;
            // 
            // typingText
            // 
            this.typingText.Location = new System.Drawing.Point(32, 137);
            this.typingText.Multiline = true;
            this.typingText.Name = "typingText";
            this.typingText.Size = new System.Drawing.Size(665, 92);
            this.typingText.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Location = new System.Drawing.Point(256, 286);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(35, 13);
            this.status.TabIndex = 4;
            this.status.Text = "label2";
            // 
            // testbox
            // 
            this.testbox.Location = new System.Drawing.Point(36, 346);
            this.testbox.Multiline = true;
            this.testbox.Name = "testbox";
            this.testbox.Size = new System.Drawing.Size(665, 92);
            this.testbox.TabIndex = 5;
            // 
            // Form1
            // 
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.testbox);
            this.Controls.Add(this.status);
            this.Controls.Add(this.typingText);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.TextToType);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TextToType;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.TextBox typingText;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.TextBox testbox;
    }
}

