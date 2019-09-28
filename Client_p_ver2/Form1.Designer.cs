namespace Client_p_ver2
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxTemat = new System.Windows.Forms.TextBox();
            this.textBoxMsg = new System.Windows.Forms.TextBox();
            this.textBoxDo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonWyslij = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.zalogujToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wylogujToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonPrzegladaj = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxZalacznik = new System.Windows.Forms.TextBox();
            this.button_Ks = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lstatus = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxTemat
            // 
            this.textBoxTemat.Location = new System.Drawing.Point(76, 98);
            this.textBoxTemat.Name = "textBoxTemat";
            this.textBoxTemat.Size = new System.Drawing.Size(404, 20);
            this.textBoxTemat.TabIndex = 0;
            // 
            // textBoxMsg
            // 
            this.textBoxMsg.Location = new System.Drawing.Point(76, 188);
            this.textBoxMsg.Multiline = true;
            this.textBoxMsg.Name = "textBoxMsg";
            this.textBoxMsg.Size = new System.Drawing.Size(404, 197);
            this.textBoxMsg.TabIndex = 1;
            // 
            // textBoxDo
            // 
            this.textBoxDo.Location = new System.Drawing.Point(76, 63);
            this.textBoxDo.Name = "textBoxDo";
            this.textBoxDo.Size = new System.Drawing.Size(404, 20);
            this.textBoxDo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Do";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Temat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Message";
            // 
            // buttonWyslij
            // 
            this.buttonWyslij.Location = new System.Drawing.Point(12, 409);
            this.buttonWyslij.Name = "buttonWyslij";
            this.buttonWyslij.Size = new System.Drawing.Size(192, 23);
            this.buttonWyslij.TabIndex = 6;
            this.buttonWyslij.Text = "Wyslij";
            this.buttonWyslij.UseVisualStyleBackColor = true;
            this.buttonWyslij.Click += new System.EventHandler(this.buttonWyslij_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zalogujToolStripMenuItem,
            this.wylogujToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(508, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // zalogujToolStripMenuItem
            // 
            this.zalogujToolStripMenuItem.Name = "zalogujToolStripMenuItem";
            this.zalogujToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.zalogujToolStripMenuItem.Text = "Zaloguj";
            this.zalogujToolStripMenuItem.Click += new System.EventHandler(this.zalogujToolStripMenuItem_Click);
            // 
            // wylogujToolStripMenuItem
            // 
            this.wylogujToolStripMenuItem.Name = "wylogujToolStripMenuItem";
            this.wylogujToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.wylogujToolStripMenuItem.Text = "Wyloguj";
            this.wylogujToolStripMenuItem.Click += new System.EventHandler(this.wylogujToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(319, 409);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(405, 409);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Analuj";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonPrzegladaj
            // 
            this.buttonPrzegladaj.Location = new System.Drawing.Point(377, 159);
            this.buttonPrzegladaj.Name = "buttonPrzegladaj";
            this.buttonPrzegladaj.Size = new System.Drawing.Size(103, 23);
            this.buttonPrzegladaj.TabIndex = 14;
            this.buttonPrzegladaj.Text = "Przeglądaj";
            this.buttonPrzegladaj.UseVisualStyleBackColor = true;
            this.buttonPrzegladaj.Click += new System.EventHandler(this.buttonPrzegladaj_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Załącznik:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBoxZalacznik
            // 
            this.textBoxZalacznik.Location = new System.Drawing.Point(76, 133);
            this.textBoxZalacznik.Name = "textBoxZalacznik";
            this.textBoxZalacznik.Size = new System.Drawing.Size(404, 20);
            this.textBoxZalacznik.TabIndex = 16;
            // 
            // button_Ks
            // 
            this.button_Ks.Location = new System.Drawing.Point(7, 58);
            this.button_Ks.Name = "button_Ks";
            this.button_Ks.Size = new System.Drawing.Size(23, 23);
            this.button_Ks.TabIndex = 17;
            this.button_Ks.Text = "K";
            this.button_Ks.UseVisualStyleBackColor = true;
            this.button_Ks.Click += new System.EventHandler(this.button_Ks_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(131, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "STATUS:";
            // 
            // lstatus
            // 
            this.lstatus.AutoSize = true;
            this.lstatus.ForeColor = System.Drawing.Color.Red;
            this.lstatus.Location = new System.Drawing.Point(190, 28);
            this.lstatus.Name = "lstatus";
            this.lstatus.Size = new System.Drawing.Size(80, 13);
            this.lstatus.TabIndex = 19;
            this.lstatus.Text = "Niezalogowano";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 456);
            this.Controls.Add(this.lstatus);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button_Ks);
            this.Controls.Add(this.textBoxZalacznik);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonPrzegladaj);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonWyslij);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxDo);
            this.Controls.Add(this.textBoxMsg);
            this.Controls.Add(this.textBoxTemat);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Client mail";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTemat;
        private System.Windows.Forms.TextBox textBoxMsg;
        private System.Windows.Forms.TextBox textBoxDo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonWyslij;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem zalogujToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonPrzegladaj;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxZalacznik;
        private System.Windows.Forms.Button button_Ks;
        private System.Windows.Forms.ToolStripMenuItem wylogujToolStripMenuItem;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label lstatus;
    }
}

