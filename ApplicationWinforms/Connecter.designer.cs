namespace ApplicationWinforms
{
    partial class Connecter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Connecter));
            this.tblogin = new System.Windows.Forms.TextBox();
            this.tbpass = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tblogin
            // 
            this.tblogin.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tblogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tblogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblogin.Location = new System.Drawing.Point(144, 213);
            this.tblogin.Name = "tblogin";
            this.tblogin.Size = new System.Drawing.Size(268, 33);
            this.tblogin.TabIndex = 0;
            this.tblogin.TextChanged += new System.EventHandler(this.tblogin_TextChanged);
            // 
            // tbpass
            // 
            this.tbpass.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tbpass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpass.Location = new System.Drawing.Point(144, 263);
            this.tbpass.Name = "tbpass";
            this.tbpass.PasswordChar = '*';
            this.tbpass.Size = new System.Drawing.Size(268, 33);
            this.tbpass.TabIndex = 1;
            this.tbpass.TextChanged += new System.EventHandler(this.tbpass_TextChanged_1);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(175, 347);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 35);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Connecter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(518, 469);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbpass);
            this.Controls.Add(this.tblogin);
            this.Name = "Connecter";
            this.Text = "Connecter";
            this.Load += new System.EventHandler(this.Connecter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tblogin;
        private System.Windows.Forms.TextBox tbpass;
        private System.Windows.Forms.Button button1;
    }
}