namespace ApplicationWinforms
{
    partial class Eleve
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Eleve));
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.tbgrlist = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.tbgr = new System.Windows.Forms.TextBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.modifier = new System.Windows.Forms.Button();
            this.Ajouter = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tbadresse = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbprenom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbnom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grid_clients = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_clients)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button1.Location = new System.Drawing.Point(279, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Supprimer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(307, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Liste des eleves";
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(100, 37);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(100, 20);
            this.txt_ID.TabIndex = 12;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_ID);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox2.Location = new System.Drawing.Point(40, 336);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(537, 85);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Suppression";
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
            // button4
            // 
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.SystemColors.Control;
            this.button4.Location = new System.Drawing.Point(12, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(49, 41);
            this.button4.TabIndex = 32;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // tbgrlist
            // 
            this.tbgrlist.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbgrlist.Location = new System.Drawing.Point(272, 296);
            this.tbgrlist.Name = "tbgrlist";
            this.tbgrlist.Size = new System.Drawing.Size(100, 20);
            this.tbgrlist.TabIndex = 48;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(222, 298);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 47;
            this.label7.Text = "Num_gr";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(21, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 46;
            this.label6.Text = "Num_gr";
            // 
            // button3
            // 
            this.button3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button3.Location = new System.Drawing.Point(40, 234);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(167, 23);
            this.button3.TabIndex = 34;
            this.button3.Text = "Consulter";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // tbgr
            // 
            this.tbgr.Location = new System.Drawing.Point(77, 187);
            this.tbgr.Name = "tbgr";
            this.tbgr.Size = new System.Drawing.Size(100, 20);
            this.tbgr.TabIndex = 45;
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(76, 77);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(100, 20);
            this.tbID.TabIndex = 35;
            // 
            // modifier
            // 
            this.modifier.ForeColor = System.Drawing.SystemColors.Desktop;
            this.modifier.Location = new System.Drawing.Point(40, 292);
            this.modifier.Name = "modifier";
            this.modifier.Size = new System.Drawing.Size(167, 23);
            this.modifier.TabIndex = 44;
            this.modifier.Text = "Modifier";
            this.modifier.UseVisualStyleBackColor = true;
            this.modifier.Click += new System.EventHandler(this.modifier_Click_1);
            // 
            // Ajouter
            // 
            this.Ajouter.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Ajouter.Location = new System.Drawing.Point(40, 263);
            this.Ajouter.Name = "Ajouter";
            this.Ajouter.Size = new System.Drawing.Size(167, 23);
            this.Ajouter.TabIndex = 43;
            this.Ajouter.Text = "Ajouter ";
            this.Ajouter.UseVisualStyleBackColor = true;
            this.Ajouter.Click += new System.EventHandler(this.Ajouter_Click_1);
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button2.Location = new System.Drawing.Point(378, 293);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(199, 23);
            this.button2.TabIndex = 33;
            this.button2.Text = "Tous les eleves";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // tbadresse
            // 
            this.tbadresse.Location = new System.Drawing.Point(76, 161);
            this.tbadresse.Name = "tbadresse";
            this.tbadresse.Size = new System.Drawing.Size(100, 20);
            this.tbadresse.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(18, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "Adresse";
            // 
            // tbprenom
            // 
            this.tbprenom.Location = new System.Drawing.Point(76, 134);
            this.tbprenom.Name = "tbprenom";
            this.tbprenom.Size = new System.Drawing.Size(100, 20);
            this.tbprenom.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(18, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Prenom";
            // 
            // tbnom
            // 
            this.tbnom.Location = new System.Drawing.Point(76, 108);
            this.tbnom.Name = "tbnom";
            this.tbnom.Size = new System.Drawing.Size(100, 20);
            this.tbnom.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(21, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "Nom";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(21, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "ID";
            // 
            // grid_clients
            // 
            this.grid_clients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_clients.Location = new System.Drawing.Point(225, 68);
            this.grid_clients.Name = "grid_clients";
            this.grid_clients.Size = new System.Drawing.Size(358, 198);
            this.grid_clients.TabIndex = 49;
            this.grid_clients.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_clients_CellContentClick);
            // 
            // Eleve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 433);
            this.Controls.Add(this.grid_clients);
            this.Controls.Add(this.tbgrlist);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.tbgr);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.modifier);
            this.Controls.Add(this.Ajouter);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tbadresse);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbprenom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbnom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox2);
            this.Name = "Eleve";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_clients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox tbgrlist;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox tbgr;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Button modifier;
        private System.Windows.Forms.Button Ajouter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tbadresse;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbprenom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbnom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grid_clients;
    }
}

