﻿namespace WFA211115
{
    partial class FrmOktatok
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
            this.lbOktatok = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rtbIdopontok = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lbOktatok
            // 
            this.lbOktatok.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lbOktatok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbOktatok.FormattingEnabled = true;
            this.lbOktatok.ItemHeight = 20;
            this.lbOktatok.Location = new System.Drawing.Point(12, 62);
            this.lbOktatok.Name = "lbOktatok";
            this.lbOktatok.Size = new System.Drawing.Size(253, 164);
            this.lbOktatok.TabIndex = 0;
            this.lbOktatok.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.LbOktatok_DrawItem);
            this.lbOktatok.SelectedIndexChanged += new System.EventHandler(this.LbOktatok_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Oktatók:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(12, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kijelölt oktató órái:";
            // 
            // rtbIdopontok
            // 
            this.rtbIdopontok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rtbIdopontok.ForeColor = System.Drawing.Color.DarkOrange;
            this.rtbIdopontok.Location = new System.Drawing.Point(12, 288);
            this.rtbIdopontok.Name = "rtbIdopontok";
            this.rtbIdopontok.Size = new System.Drawing.Size(253, 146);
            this.rtbIdopontok.TabIndex = 2;
            this.rtbIdopontok.Text = "";
            // 
            // FrmOktatok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 455);
            this.Controls.Add(this.rtbIdopontok);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbOktatok);
            this.Name = "FrmOktatok";
            this.Text = "FrmOktatok";
            this.Load += new System.EventHandler(this.FrmOktatok_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbOktatok;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtbIdopontok;
    }
}