namespace array2
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lbl_n3 = new System.Windows.Forms.Label();
            this.lbl_n2 = new System.Windows.Forms.Label();
            this.lbl_n1 = new System.Windows.Forms.Label();
            this.txt_n1 = new System.Windows.Forms.TextBox();
            this.txt_n2 = new System.Windows.Forms.TextBox();
            this.lbl_n4 = new System.Windows.Forms.Label();
            this.lbl_n5 = new System.Windows.Forms.Label();
            this.btn_n1 = new System.Windows.Forms.Button();
            this.btn_n2 = new System.Windows.Forms.Button();
            this.lbl_n6 = new System.Windows.Forms.Label();
            this.lbl_n7 = new System.Windows.Forms.Label();
            this.lbl_n8 = new System.Windows.Forms.Label();
            this.lbl_n9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Items.AddRange(new object[] {
            "11534",
            "-2345",
            "3451",
            "127",
            "45673",
            "-13",
            "3452"});
            this.listBox3.Location = new System.Drawing.Point(395, 50);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(120, 95);
            this.listBox3.TabIndex = 17;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Items.AddRange(new object[] {
            "11264",
            "99780",
            "00342",
            "03419",
            "34562",
            "09887",
            "02341"});
            this.listBox2.Location = new System.Drawing.Point(200, 52);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(120, 95);
            this.listBox2.TabIndex = 16;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Rossi Mario",
            "Bianchi Luigi",
            "Belli Giulia",
            "Dotti Fabio",
            "Merli Gianna",
            "Zeri Giulio",
            "Botti Maria"});
            this.listBox1.Location = new System.Drawing.Point(30, 52);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 15;
            // 
            // lbl_n3
            // 
            this.lbl_n3.AutoSize = true;
            this.lbl_n3.Location = new System.Drawing.Point(392, 35);
            this.lbl_n3.Name = "lbl_n3";
            this.lbl_n3.Size = new System.Drawing.Size(79, 13);
            this.lbl_n3.TabIndex = 14;
            this.lbl_n3.Text = "saldo del conto";
            // 
            // lbl_n2
            // 
            this.lbl_n2.AutoSize = true;
            this.lbl_n2.Location = new System.Drawing.Point(197, 35);
            this.lbl_n2.Name = "lbl_n2";
            this.lbl_n2.Size = new System.Drawing.Size(89, 13);
            this.lbl_n2.TabIndex = 13;
            this.lbl_n2.Text = "numero del conto";
            // 
            // lbl_n1
            // 
            this.lbl_n1.AutoSize = true;
            this.lbl_n1.Location = new System.Drawing.Point(27, 35);
            this.lbl_n1.Name = "lbl_n1";
            this.lbl_n1.Size = new System.Drawing.Size(89, 13);
            this.lbl_n1.TabIndex = 12;
            this.lbl_n1.Text = "nome e cognome";
            // 
            // txt_n1
            // 
            this.txt_n1.Location = new System.Drawing.Point(17, 202);
            this.txt_n1.Name = "txt_n1";
            this.txt_n1.Size = new System.Drawing.Size(106, 20);
            this.txt_n1.TabIndex = 21;
            // 
            // txt_n2
            // 
            this.txt_n2.Location = new System.Drawing.Point(12, 311);
            this.txt_n2.Name = "txt_n2";
            this.txt_n2.Size = new System.Drawing.Size(108, 20);
            this.txt_n2.TabIndex = 22;
            // 
            // lbl_n4
            // 
            this.lbl_n4.AutoSize = true;
            this.lbl_n4.Location = new System.Drawing.Point(12, 177);
            this.lbl_n4.Name = "lbl_n4";
            this.lbl_n4.Size = new System.Drawing.Size(187, 13);
            this.lbl_n4.TabIndex = 23;
            this.lbl_n4.Text = "inserisci il nome e cognome del cliente";
            // 
            // lbl_n5
            // 
            this.lbl_n5.AutoSize = true;
            this.lbl_n5.Location = new System.Drawing.Point(9, 279);
            this.lbl_n5.Name = "lbl_n5";
            this.lbl_n5.Size = new System.Drawing.Size(136, 13);
            this.lbl_n5.TabIndex = 24;
            this.lbl_n5.Text = "inserisci il numero del conto";
            // 
            // btn_n1
            // 
            this.btn_n1.Location = new System.Drawing.Point(211, 177);
            this.btn_n1.Name = "btn_n1";
            this.btn_n1.Size = new System.Drawing.Size(75, 23);
            this.btn_n1.TabIndex = 25;
            this.btn_n1.Text = "cerca";
            this.btn_n1.UseVisualStyleBackColor = true;
            // 
            // btn_n2
            // 
            this.btn_n2.Location = new System.Drawing.Point(179, 279);
            this.btn_n2.Name = "btn_n2";
            this.btn_n2.Size = new System.Drawing.Size(75, 23);
            this.btn_n2.TabIndex = 26;
            this.btn_n2.Text = "cerca";
            this.btn_n2.UseVisualStyleBackColor = true;
            this.btn_n2.Click += new System.EventHandler(this.btn_n2_Click);
            // 
            // lbl_n6
            // 
            this.lbl_n6.AutoSize = true;
            this.lbl_n6.Location = new System.Drawing.Point(17, 229);
            this.lbl_n6.Name = "lbl_n6";
            this.lbl_n6.Size = new System.Drawing.Size(89, 13);
            this.lbl_n6.TabIndex = 27;
            this.lbl_n6.Text = "nome e cognome";
            // 
            // lbl_n7
            // 
            this.lbl_n7.AutoSize = true;
            this.lbl_n7.Location = new System.Drawing.Point(17, 254);
            this.lbl_n7.Name = "lbl_n7";
            this.lbl_n7.Size = new System.Drawing.Size(72, 13);
            this.lbl_n7.TabIndex = 28;
            this.lbl_n7.Text = "numero conto";
            // 
            // lbl_n8
            // 
            this.lbl_n8.AutoSize = true;
            this.lbl_n8.Location = new System.Drawing.Point(17, 349);
            this.lbl_n8.Name = "lbl_n8";
            this.lbl_n8.Size = new System.Drawing.Size(89, 13);
            this.lbl_n8.TabIndex = 29;
            this.lbl_n8.Text = "nome e cognome";
            // 
            // lbl_n9
            // 
            this.lbl_n9.AutoSize = true;
            this.lbl_n9.Location = new System.Drawing.Point(20, 375);
            this.lbl_n9.Name = "lbl_n9";
            this.lbl_n9.Size = new System.Drawing.Size(72, 13);
            this.lbl_n9.TabIndex = 30;
            this.lbl_n9.Text = "numero conto";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(680, 435);
            this.Controls.Add(this.lbl_n9);
            this.Controls.Add(this.lbl_n8);
            this.Controls.Add(this.lbl_n7);
            this.Controls.Add(this.lbl_n6);
            this.Controls.Add(this.btn_n2);
            this.Controls.Add(this.btn_n1);
            this.Controls.Add(this.lbl_n5);
            this.Controls.Add(this.lbl_n4);
            this.Controls.Add(this.txt_n2);
            this.Controls.Add(this.txt_n1);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lbl_n3);
            this.Controls.Add(this.lbl_n2);
            this.Controls.Add(this.lbl_n1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lbl_n3;
        private System.Windows.Forms.Label lbl_n2;
        private System.Windows.Forms.Label lbl_n1;
        private System.Windows.Forms.TextBox txt_n1;
        private System.Windows.Forms.TextBox txt_n2;
        private System.Windows.Forms.Label lbl_n4;
        private System.Windows.Forms.Label lbl_n5;
        private System.Windows.Forms.Button btn_n1;
        private System.Windows.Forms.Button btn_n2;
        private System.Windows.Forms.Label lbl_n6;
        private System.Windows.Forms.Label lbl_n7;
        private System.Windows.Forms.Label lbl_n8;
        private System.Windows.Forms.Label lbl_n9;
    }
}

