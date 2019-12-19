namespace ApplicationWinforms
{
    partial class Matiere
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Matiere));
            this.button4 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbnivlist = new System.Windows.Forms.TextBox();
            this.modifier = new System.Windows.Forms.Button();
            this.tbID = new System.Windows.Forms.TextBox();
            this.Ajouter = new System.Windows.Forms.Button();
            this.tbnniv = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbnom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grid_clients = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_clients)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Location = new System.Drawing.Point(12, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(37, 35);
            this.button4.TabIndex = 25;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(306, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "Liste des matieres";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbnivlist);
            this.groupBox1.Controls.Add(this.modifier);
            this.groupBox1.Controls.Add(this.tbID);
            this.groupBox1.Controls.Add(this.Ajouter);
            this.groupBox1.Controls.Add(this.tbnniv);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbnom);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.grid_clients);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Location = new System.Drawing.Point(11, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(581, 281);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Recherche d\'information";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(219, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "ID_Niv";
            // 
            // tbnivlist
            // 
            this.tbnivlist.Location = new System.Drawing.Point(276, 238);
            this.tbnivlist.Name = "tbnivlist";
            this.tbnivlist.Size = new System.Drawing.Size(100, 20);
            this.tbnivlist.TabIndex = 15;
            // 
            // modifier
            // 
            this.modifier.Location = new System.Drawing.Point(12, 236);
            this.modifier.Name = "modifier";
            this.modifier.Size = new System.Drawing.Size(167, 23);
            this.modifier.TabIndex = 14;
            this.modifier.Text = "Modifier";
            this.modifier.UseVisualStyleBackColor = true;
            this.modifier.Click += new System.EventHandler(this.modifier_Click);
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(65, 32);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(100, 20);
            this.tbID.TabIndex = 4;
            // 
            // Ajouter
            // 
            this.Ajouter.Location = new System.Drawing.Point(12, 207);
            this.Ajouter.Name = "Ajouter";
            this.Ajouter.Size = new System.Drawing.Size(167, 23);
            this.Ajouter.TabIndex = 13;
            this.Ajouter.Text = "Ajouter ";
            this.Ajouter.UseVisualStyleBackColor = true;
            this.Ajouter.Click += new System.EventHandler(this.Ajouter_Click);
            // 
            // tbnniv
            // 
            this.tbnniv.Location = new System.Drawing.Point(65, 115);
            this.tbnniv.Name = "tbnniv";
            this.tbnniv.Size = new System.Drawing.Size(100, 20);
            this.tbnniv.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Num_Niv";
            // 
            // tbnom
            // 
            this.tbnom.Location = new System.Drawing.Point(65, 75);
            this.tbnom.Name = "tbnom";
            this.tbnom.Size = new System.Drawing.Size(100, 20);
            this.tbnom.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nom";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "ID";
            // 
            // grid_clients
            // 
            this.grid_clients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_clients.Location = new System.Drawing.Point(207, 32);
            this.grid_clients.Name = "grid_clients";
            this.grid_clients.Size = new System.Drawing.Size(358, 198);
            this.grid_clients.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 178);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(167, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Consulter";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(396, 236);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(169, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Tous les matieres";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_ID);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(23, 342);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(537, 85);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Suppression(opération de mise à jour)";
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(100, 37);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(100, 20);
            this.txt_ID.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(41, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "ID";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(279, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Supprimer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Matiere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(620, 436);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Name = "Matiere";
            this.Text = "Matiere";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_clients)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbnivlist;
        private System.Windows.Forms.Button modifier;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Button Ajouter;
        private System.Windows.Forms.TextBox tbnniv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbnom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grid_clients;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
    }
}