
namespace Ekonometria
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelZmienne = new System.Windows.Forms.Label();
            this.labelOdchylenie = new System.Windows.Forms.Label();
            this.labelD = new System.Windows.Forms.Label();
            this.labelRownanie = new System.Windows.Forms.Label();
            this.labelDet = new System.Windows.Forms.Label();
            this.labelLos = new System.Windows.Forms.Label();
            this.btFile = new System.Windows.Forms.Button();
            this.btResult = new System.Windows.Forms.Button();
            this.textBoxDane = new System.Windows.Forms.TextBox();
            this.groupBoxR0 = new System.Windows.Forms.GroupBox();
            this.labelR0 = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.labelEDa = new System.Windows.Forms.Label();
            this.groupBoxR = new System.Windows.Forms.GroupBox();
            this.labelR = new System.Windows.Forms.Label();
            this.label_dane_check = new System.Windows.Forms.Label();
            this.labelVal = new System.Windows.Forms.Label();
            this.groupBoxR0.SuspendLayout();
            this.panel.SuspendLayout();
            this.groupBoxR.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dane:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(645, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Wyniki:";
            // 
            // labelZmienne
            // 
            this.labelZmienne.AutoSize = true;
            this.labelZmienne.Location = new System.Drawing.Point(14, 171);
            this.labelZmienne.Name = "labelZmienne";
            this.labelZmienne.Size = new System.Drawing.Size(70, 20);
            this.labelZmienne.TabIndex = 2;
            this.labelZmienne.Text = "Zmienne:";
            // 
            // labelOdchylenie
            // 
            this.labelOdchylenie.AutoSize = true;
            this.labelOdchylenie.Location = new System.Drawing.Point(14, 205);
            this.labelOdchylenie.Name = "labelOdchylenie";
            this.labelOdchylenie.Size = new System.Drawing.Size(342, 20);
            this.labelOdchylenie.TabIndex = 3;
            this.labelOdchylenie.Text = "Odchylenie standardowe składnika resztowego Su:";
            // 
            // labelD
            // 
            this.labelD.AutoSize = true;
            this.labelD.Location = new System.Drawing.Point(14, 239);
            this.labelD.Name = "labelD";
            this.labelD.Size = new System.Drawing.Size(41, 20);
            this.labelD.TabIndex = 4;
            this.labelD.Text = "D(a):";
            // 
            // labelRownanie
            // 
            this.labelRownanie.AutoSize = true;
            this.labelRownanie.Location = new System.Drawing.Point(14, 323);
            this.labelRownanie.Name = "labelRownanie";
            this.labelRownanie.Size = new System.Drawing.Size(162, 20);
            this.labelRownanie.TabIndex = 5;
            this.labelRownanie.Text = "Równanie modelu:  Y= ";
            // 
            // labelDet
            // 
            this.labelDet.AutoSize = true;
            this.labelDet.Location = new System.Drawing.Point(14, 385);
            this.labelDet.Name = "labelDet";
            this.labelDet.Size = new System.Drawing.Size(189, 20);
            this.labelDet.TabIndex = 6;
            this.labelDet.Text = "Współczynnik determinacji:";
            // 
            // labelLos
            // 
            this.labelLos.AutoSize = true;
            this.labelLos.Location = new System.Drawing.Point(14, 418);
            this.labelLos.Name = "labelLos";
            this.labelLos.Size = new System.Drawing.Size(246, 20);
            this.labelLos.TabIndex = 7;
            this.labelLos.Text = "Współczynnik zmienności losowej v:";
            // 
            // btFile
            // 
            this.btFile.Location = new System.Drawing.Point(83, 22);
            this.btFile.Name = "btFile";
            this.btFile.Size = new System.Drawing.Size(158, 60);
            this.btFile.TabIndex = 8;
            this.btFile.Text = "Otwórz plik";
            this.btFile.UseVisualStyleBackColor = true;
            this.btFile.Click += new System.EventHandler(this.btFile_Click);
            // 
            // btResult
            // 
            this.btResult.Location = new System.Drawing.Point(589, 22);
            this.btResult.Name = "btResult";
            this.btResult.Size = new System.Drawing.Size(163, 60);
            this.btResult.TabIndex = 9;
            this.btResult.Text = "Oblicz";
            this.btResult.UseVisualStyleBackColor = true;
            this.btResult.Click += new System.EventHandler(this.btResult_Click);
            // 
            // textBoxDane
            // 
            this.textBoxDane.Location = new System.Drawing.Point(2, 153);
            this.textBoxDane.Multiline = true;
            this.textBoxDane.Name = "textBoxDane";
            this.textBoxDane.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxDane.Size = new System.Drawing.Size(376, 300);
            this.textBoxDane.TabIndex = 10;
            this.textBoxDane.TextChanged += new System.EventHandler(this.textBoxDane_TextChanged);
            // 
            // groupBoxR0
            // 
            this.groupBoxR0.Controls.Add(this.labelR0);
            this.groupBoxR0.Location = new System.Drawing.Point(43, 13);
            this.groupBoxR0.Name = "groupBoxR0";
            this.groupBoxR0.Size = new System.Drawing.Size(160, 145);
            this.groupBoxR0.TabIndex = 11;
            this.groupBoxR0.TabStop = false;
            this.groupBoxR0.Text = "R0";
            // 
            // labelR0
            // 
            this.labelR0.AutoSize = true;
            this.labelR0.Location = new System.Drawing.Point(6, 23);
            this.labelR0.Name = "labelR0";
            this.labelR0.Size = new System.Drawing.Size(0, 20);
            this.labelR0.TabIndex = 16;
            // 
            // panel
            // 
            this.panel.Controls.Add(this.labelEDa);
            this.panel.Controls.Add(this.groupBoxR0);
            this.panel.Controls.Add(this.groupBoxR);
            this.panel.Controls.Add(this.labelLos);
            this.panel.Controls.Add(this.labelDet);
            this.panel.Controls.Add(this.labelZmienne);
            this.panel.Controls.Add(this.labelOdchylenie);
            this.panel.Controls.Add(this.labelD);
            this.panel.Controls.Add(this.labelRownanie);
            this.panel.Location = new System.Drawing.Point(384, 153);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(657, 455);
            this.panel.TabIndex = 13;
            // 
            // labelEDa
            // 
            this.labelEDa.AutoSize = true;
            this.labelEDa.Location = new System.Drawing.Point(14, 355);
            this.labelEDa.Name = "labelEDa";
            this.labelEDa.Size = new System.Drawing.Size(136, 20);
            this.labelEDa.TabIndex = 16;
            this.labelEDa.Text = "Oszacowane błędy:";
            // 
            // groupBoxR
            // 
            this.groupBoxR.Controls.Add(this.labelR);
            this.groupBoxR.Location = new System.Drawing.Point(221, 13);
            this.groupBoxR.Name = "groupBoxR";
            this.groupBoxR.Size = new System.Drawing.Size(420, 145);
            this.groupBoxR.TabIndex = 12;
            this.groupBoxR.TabStop = false;
            this.groupBoxR.Text = "R";
            // 
            // labelR
            // 
            this.labelR.AutoSize = true;
            this.labelR.Location = new System.Drawing.Point(20, 23);
            this.labelR.Name = "labelR";
            this.labelR.Size = new System.Drawing.Size(0, 20);
            this.labelR.TabIndex = 17;
            // 
            // label_dane_check
            // 
            this.label_dane_check.AutoSize = true;
            this.label_dane_check.Location = new System.Drawing.Point(12, 476);
            this.label_dane_check.Name = "label_dane_check";
            this.label_dane_check.Size = new System.Drawing.Size(193, 20);
            this.label_dane_check.TabIndex = 14;
            this.label_dane_check.Text = "Poprawność danych w pliku:";
            // 
            // labelVal
            // 
            this.labelVal.AutoSize = true;
            this.labelVal.Location = new System.Drawing.Point(48, 508);
            this.labelVal.Name = "labelVal";
            this.labelVal.Size = new System.Drawing.Size(0, 20);
            this.labelVal.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 638);
            this.Controls.Add(this.labelVal);
            this.Controls.Add(this.btFile);
            this.Controls.Add(this.label_dane_check);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.textBoxDane);
            this.Controls.Add(this.btResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Program_ekonometria";
            this.groupBoxR0.ResumeLayout(false);
            this.groupBoxR0.PerformLayout();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.groupBoxR.ResumeLayout(false);
            this.groupBoxR.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelZmienne;
        private System.Windows.Forms.Label labelOdchylenie;
        private System.Windows.Forms.Label labelD;
        private System.Windows.Forms.Label labelRownanie;
        private System.Windows.Forms.Label labelDet;
        private System.Windows.Forms.Label labelLos;
        private System.Windows.Forms.Button btFile;
        private System.Windows.Forms.Button btResult;
        private System.Windows.Forms.TextBox textBoxDane;
        private System.Windows.Forms.GroupBox groupBoxR0;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.GroupBox groupBoxR;
        private System.Windows.Forms.Label label_dane_check;
        private System.Windows.Forms.Label labelR0;
        private System.Windows.Forms.Label labelR;
        private System.Windows.Forms.Label labelEDa;
        private System.Windows.Forms.Label labelVal;
    }
}

