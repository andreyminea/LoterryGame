
namespace Lottery
{
    partial class PlayForm
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
            this.numbersBox = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.winnerText = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.moneyText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // numbersBox
            // 
            this.numbersBox.AutoSize = true;
            this.numbersBox.Font = new System.Drawing.Font("Verdana", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.numbersBox.ForeColor = System.Drawing.Color.IndianRed;
            this.numbersBox.Location = new System.Drawing.Point(332, 54);
            this.numbersBox.Name = "numbersBox";
            this.numbersBox.Size = new System.Drawing.Size(140, 36);
            this.numbersBox.TabIndex = 0;
            this.numbersBox.Text = "24 18 3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(45, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lucky numbers are :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(45, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 50);
            this.label1.TabIndex = 2;
            this.label1.Text = "Winner: ";
            // 
            // winnerText
            // 
            this.winnerText.AutoSize = true;
            this.winnerText.Font = new System.Drawing.Font("Verdana", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.winnerText.ForeColor = System.Drawing.Color.Gold;
            this.winnerText.Location = new System.Drawing.Point(214, 152);
            this.winnerText.Name = "winnerText";
            this.winnerText.Size = new System.Drawing.Size(285, 45);
            this.winnerText.TabIndex = 3;
            this.winnerText.Text = "Player Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(45, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 37);
            this.label3.TabIndex = 4;
            this.label3.Text = "Money: ";
            // 
            // moneyText
            // 
            this.moneyText.AutoSize = true;
            this.moneyText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.moneyText.ForeColor = System.Drawing.Color.YellowGreen;
            this.moneyText.Location = new System.Drawing.Point(197, 251);
            this.moneyText.Name = "moneyText";
            this.moneyText.Size = new System.Drawing.Size(77, 38);
            this.moneyText.TabIndex = 5;
            this.moneyText.Text = "200";
            // 
            // PlayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(620, 328);
            this.Controls.Add(this.moneyText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.winnerText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numbersBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PlayForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PlayForm";
            this.Load += new System.EventHandler(this.PlayForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label numbersBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label winnerText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label moneyText;
    }
}