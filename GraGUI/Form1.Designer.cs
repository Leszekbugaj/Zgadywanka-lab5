namespace GraGUI
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
            this.btnNowaGra = new System.Windows.Forms.Button();
            this.grpBoxLosowanie = new System.Windows.Forms.GroupBox();
            this.btnLosuj = new System.Windows.Forms.Button();
            this.textBoxDo = new System.Windows.Forms.TextBox();
            this.textBoxOd = new System.Windows.Forms.TextBox();
            this.lblZakresDo = new System.Windows.Forms.Label();
            this.lblZakresOd = new System.Windows.Forms.Label();
            this.groupBox_Gra = new System.Windows.Forms.GroupBox();
            this.label_ocena = new System.Windows.Forms.Label();
            this.label_wynik0 = new System.Windows.Forms.Label();
            this.label_wynik = new System.Windows.Forms.Label();
            this.button_poddaj = new System.Windows.Forms.Button();
            this.button_sprawdz = new System.Windows.Forms.Button();
            this.label_podajliczbe = new System.Windows.Forms.Label();
            this.textBox_podajliczbe = new System.Windows.Forms.TextBox();
            this.button_historia = new System.Windows.Forms.Button();
            this.grpBoxLosowanie.SuspendLayout();
            this.groupBox_Gra.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNowaGra
            // 
            this.btnNowaGra.Location = new System.Drawing.Point(13, 13);
            this.btnNowaGra.Name = "btnNowaGra";
            this.btnNowaGra.Size = new System.Drawing.Size(75, 23);
            this.btnNowaGra.TabIndex = 0;
            this.btnNowaGra.Text = "Nowa gra";
            this.btnNowaGra.UseVisualStyleBackColor = true;
            this.btnNowaGra.Click += new System.EventHandler(this.btnNowaGra_Click);
            // 
            // grpBoxLosowanie
            // 
            this.grpBoxLosowanie.BackColor = System.Drawing.SystemColors.Control;
            this.grpBoxLosowanie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.grpBoxLosowanie.Controls.Add(this.btnLosuj);
            this.grpBoxLosowanie.Controls.Add(this.textBoxDo);
            this.grpBoxLosowanie.Controls.Add(this.textBoxOd);
            this.grpBoxLosowanie.Controls.Add(this.lblZakresDo);
            this.grpBoxLosowanie.Controls.Add(this.lblZakresOd);
            this.grpBoxLosowanie.Location = new System.Drawing.Point(13, 52);
            this.grpBoxLosowanie.Name = "grpBoxLosowanie";
            this.grpBoxLosowanie.Size = new System.Drawing.Size(287, 121);
            this.grpBoxLosowanie.TabIndex = 1;
            this.grpBoxLosowanie.TabStop = false;
            this.grpBoxLosowanie.Text = "Losowanie";
            this.grpBoxLosowanie.Visible = false;
            this.grpBoxLosowanie.Enter += new System.EventHandler(this.grpBoxLosowanie_Enter);
            // 
            // btnLosuj
            // 
            this.btnLosuj.Location = new System.Drawing.Point(206, 46);
            this.btnLosuj.Name = "btnLosuj";
            this.btnLosuj.Size = new System.Drawing.Size(75, 23);
            this.btnLosuj.TabIndex = 2;
            this.btnLosuj.Text = "Wylosuj";
            this.btnLosuj.UseVisualStyleBackColor = true;
            this.btnLosuj.Click += new System.EventHandler(this.btnLosuj_Click);
            // 
            // textBoxDo
            // 
            this.textBoxDo.Location = new System.Drawing.Point(87, 74);
            this.textBoxDo.Name = "textBoxDo";
            this.textBoxDo.Size = new System.Drawing.Size(100, 20);
            this.textBoxDo.TabIndex = 3;
            // 
            // textBoxOd
            // 
            this.textBoxOd.Location = new System.Drawing.Point(87, 25);
            this.textBoxOd.Name = "textBoxOd";
            this.textBoxOd.Size = new System.Drawing.Size(100, 20);
            this.textBoxOd.TabIndex = 2;
            // 
            // lblZakresDo
            // 
            this.lblZakresDo.AutoSize = true;
            this.lblZakresDo.Location = new System.Drawing.Point(23, 77);
            this.lblZakresDo.Name = "lblZakresDo";
            this.lblZakresDo.Size = new System.Drawing.Size(58, 13);
            this.lblZakresDo.TabIndex = 1;
            this.lblZakresDo.Text = "Zakres do:";
            // 
            // lblZakresOd
            // 
            this.lblZakresOd.AutoSize = true;
            this.lblZakresOd.Location = new System.Drawing.Point(23, 28);
            this.lblZakresOd.Name = "lblZakresOd";
            this.lblZakresOd.Size = new System.Drawing.Size(58, 13);
            this.lblZakresOd.TabIndex = 0;
            this.lblZakresOd.Text = "Zakres od:";
            // 
            // groupBox_Gra
            // 
            this.groupBox_Gra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox_Gra.Controls.Add(this.label_ocena);
            this.groupBox_Gra.Controls.Add(this.label_wynik0);
            this.groupBox_Gra.Controls.Add(this.label_wynik);
            this.groupBox_Gra.Controls.Add(this.button_poddaj);
            this.groupBox_Gra.Controls.Add(this.button_sprawdz);
            this.groupBox_Gra.Controls.Add(this.label_podajliczbe);
            this.groupBox_Gra.Controls.Add(this.textBox_podajliczbe);
            this.groupBox_Gra.Location = new System.Drawing.Point(13, 178);
            this.groupBox_Gra.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox_Gra.Name = "groupBox_Gra";
            this.groupBox_Gra.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox_Gra.Size = new System.Drawing.Size(287, 146);
            this.groupBox_Gra.TabIndex = 2;
            this.groupBox_Gra.TabStop = false;
            this.groupBox_Gra.Text = "Gra";
            this.groupBox_Gra.Visible = false;
            // 
            // label_ocena
            // 
            this.label_ocena.AutoSize = true;
            this.label_ocena.Location = new System.Drawing.Point(186, 34);
            this.label_ocena.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_ocena.Name = "label_ocena";
            this.label_ocena.Size = new System.Drawing.Size(0, 13);
            this.label_ocena.TabIndex = 3;
            this.label_ocena.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_wynik0
            // 
            this.label_wynik0.AutoSize = true;
            this.label_wynik0.Location = new System.Drawing.Point(58, 126);
            this.label_wynik0.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_wynik0.Name = "label_wynik0";
            this.label_wynik0.Size = new System.Drawing.Size(13, 13);
            this.label_wynik0.TabIndex = 8;
            this.label_wynik0.Text = "0";
            // 
            // label_wynik
            // 
            this.label_wynik.AutoSize = true;
            this.label_wynik.Location = new System.Drawing.Point(23, 126);
            this.label_wynik.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_wynik.Name = "label_wynik";
            this.label_wynik.Size = new System.Drawing.Size(40, 13);
            this.label_wynik.TabIndex = 7;
            this.label_wynik.Text = "Wynik:";
            // 
            // button_poddaj
            // 
            this.button_poddaj.Location = new System.Drawing.Point(102, 71);
            this.button_poddaj.Margin = new System.Windows.Forms.Padding(2);
            this.button_poddaj.Name = "button_poddaj";
            this.button_poddaj.Size = new System.Drawing.Size(76, 30);
            this.button_poddaj.TabIndex = 6;
            this.button_poddaj.Text = "Poddaj się";
            this.button_poddaj.UseVisualStyleBackColor = true;
            this.button_poddaj.Click += new System.EventHandler(this.button_poddaj_Click);
            // 
            // button_sprawdz
            // 
            this.button_sprawdz.Location = new System.Drawing.Point(26, 72);
            this.button_sprawdz.Margin = new System.Windows.Forms.Padding(2);
            this.button_sprawdz.Name = "button_sprawdz";
            this.button_sprawdz.Size = new System.Drawing.Size(74, 29);
            this.button_sprawdz.TabIndex = 5;
            this.button_sprawdz.Text = "Sprawdź";
            this.button_sprawdz.UseVisualStyleBackColor = true;
            this.button_sprawdz.Click += new System.EventHandler(this.button_sprawdz_Click);
            // 
            // label_podajliczbe
            // 
            this.label_podajliczbe.AutoSize = true;
            this.label_podajliczbe.Location = new System.Drawing.Point(23, 36);
            this.label_podajliczbe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_podajliczbe.Name = "label_podajliczbe";
            this.label_podajliczbe.Size = new System.Drawing.Size(68, 13);
            this.label_podajliczbe.TabIndex = 4;
            this.label_podajliczbe.Text = "Podaj Liczbe";
            // 
            // textBox_podajliczbe
            // 
            this.textBox_podajliczbe.Location = new System.Drawing.Point(94, 34);
            this.textBox_podajliczbe.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_podajliczbe.Name = "textBox_podajliczbe";
            this.textBox_podajliczbe.Size = new System.Drawing.Size(84, 20);
            this.textBox_podajliczbe.TabIndex = 3;
            // 
            // button_historia
            // 
            this.button_historia.Enabled = false;
            this.button_historia.Location = new System.Drawing.Point(239, 13);
            this.button_historia.Margin = new System.Windows.Forms.Padding(2);
            this.button_historia.Name = "button_historia";
            this.button_historia.Size = new System.Drawing.Size(61, 23);
            this.button_historia.TabIndex = 3;
            this.button_historia.Text = "Historia";
            this.button_historia.UseVisualStyleBackColor = true;
            this.button_historia.Click += new System.EventHandler(this.button_historia_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(322, 362);
            this.Controls.Add(this.button_historia);
            this.Controls.Add(this.groupBox_Gra);
            this.Controls.Add(this.grpBoxLosowanie);
            this.Controls.Add(this.btnNowaGra);
            this.Name = "Form1";
            this.Text = "Gra";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grpBoxLosowanie.ResumeLayout(false);
            this.grpBoxLosowanie.PerformLayout();
            this.groupBox_Gra.ResumeLayout(false);
            this.groupBox_Gra.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNowaGra;
        private System.Windows.Forms.GroupBox grpBoxLosowanie;
        private System.Windows.Forms.Button btnLosuj;
        private System.Windows.Forms.TextBox textBoxDo;
        private System.Windows.Forms.TextBox textBoxOd;
        private System.Windows.Forms.Label lblZakresDo;
        private System.Windows.Forms.Label lblZakresOd;
        private System.Windows.Forms.GroupBox groupBox_Gra;
        private System.Windows.Forms.Label label_ocena;
        private System.Windows.Forms.Label label_wynik0;
        private System.Windows.Forms.Label label_wynik;
        private System.Windows.Forms.Button button_poddaj;
        private System.Windows.Forms.Button button_sprawdz;
        private System.Windows.Forms.Label label_podajliczbe;
        private System.Windows.Forms.TextBox textBox_podajliczbe;
        private System.Windows.Forms.Button button_historia;
    }
}

