namespace FINAL_PROJECT
{
    partial class MainMenu
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
            this.btnstrt = new System.Windows.Forms.Button();
            this.btnhtp = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnstrt
            // 
            this.btnstrt.Location = new System.Drawing.Point(603, 247);
            this.btnstrt.Name = "btnstrt";
            this.btnstrt.Size = new System.Drawing.Size(114, 23);
            this.btnstrt.TabIndex = 0;
            this.btnstrt.Text = "Start Game";
            this.btnstrt.UseVisualStyleBackColor = true;
            this.btnstrt.Click += new System.EventHandler(this.btnstrt_Click);
            // 
            // btnhtp
            // 
            this.btnhtp.Location = new System.Drawing.Point(603, 277);
            this.btnhtp.Name = "btnhtp";
            this.btnhtp.Size = new System.Drawing.Size(114, 23);
            this.btnhtp.TabIndex = 1;
            this.btnhtp.Text = "How to Play";
            this.btnhtp.UseVisualStyleBackColor = true;
            this.btnhtp.Click += new System.EventHandler(this.btnhtp_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(603, 307);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(114, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Settings";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FINAL_PROJECT.Properties.Resources.d5ba59e608e6f1db1e0d5de47e30af79;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1350, 615);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnhtp);
            this.Controls.Add(this.btnstrt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnstrt;
        private System.Windows.Forms.Button btnhtp;
        private System.Windows.Forms.Button button3;
    }
}

