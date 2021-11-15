namespace WFA211115
{
    partial class FrmMain
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
            this.pbJogaBG = new System.Windows.Forms.PictureBox();
            this.btnOktatok = new System.Windows.Forms.Button();
            this.btnProgramok = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbJogaBG)).BeginInit();
            this.SuspendLayout();
            // 
            // pbJogaBG
            // 
            this.pbJogaBG.Image = global::WFA211115.Properties.Resources.joga_BG;
            this.pbJogaBG.Location = new System.Drawing.Point(12, 12);
            this.pbJogaBG.Name = "pbJogaBG";
            this.pbJogaBG.Size = new System.Drawing.Size(420, 235);
            this.pbJogaBG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbJogaBG.TabIndex = 0;
            this.pbJogaBG.TabStop = false;
            // 
            // btnOktatok
            // 
            this.btnOktatok.BackColor = System.Drawing.Color.White;
            this.btnOktatok.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOktatok.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnOktatok.Location = new System.Drawing.Point(12, 254);
            this.btnOktatok.Name = "btnOktatok";
            this.btnOktatok.Size = new System.Drawing.Size(420, 64);
            this.btnOktatok.TabIndex = 1;
            this.btnOktatok.Text = "Oktatók";
            this.btnOktatok.UseVisualStyleBackColor = false;
            this.btnOktatok.Click += new System.EventHandler(this.btnOktatok_Click);
            // 
            // btnProgramok
            // 
            this.btnProgramok.BackColor = System.Drawing.Color.White;
            this.btnProgramok.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnProgramok.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnProgramok.Location = new System.Drawing.Point(12, 324);
            this.btnProgramok.Name = "btnProgramok";
            this.btnProgramok.Size = new System.Drawing.Size(420, 64);
            this.btnProgramok.TabIndex = 1;
            this.btnProgramok.Text = "Programok";
            this.btnProgramok.UseVisualStyleBackColor = false;
            this.btnProgramok.Click += new System.EventHandler(this.btnProgramok_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.ForeColor = System.Drawing.Color.DarkOrange;
            this.button3.Location = new System.Drawing.Point(12, 394);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(420, 64);
            this.button3.TabIndex = 1;
            this.button3.Text = "Jelentkezés";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(12, 464);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(420, 64);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Kilépés";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 546);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnProgramok);
            this.Controls.Add(this.btnOktatok);
            this.Controls.Add(this.pbJogaBG);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMain";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbJogaBG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbJogaBG;
        private System.Windows.Forms.Button btnOktatok;
        private System.Windows.Forms.Button btnProgramok;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnExit;
    }
}

