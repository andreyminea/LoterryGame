
namespace Lottery
{
    partial class LotteryWindow
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.number1 = new System.Windows.Forms.NumericUpDown();
            this.number2 = new System.Windows.Forms.NumericUpDown();
            this.number3 = new System.Windows.Forms.NumericUpDown();
            this.randomGenBtn = new System.Windows.Forms.Button();
            this.registerBtn = new System.Windows.Forms.Button();
            this.date = new System.Windows.Forms.MonthCalendar();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.playBtn = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.number1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.number2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.number3)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.number1);
            this.flowLayoutPanel1.Controls.Add(this.number2);
            this.flowLayoutPanel1.Controls.Add(this.number3);
            this.flowLayoutPanel1.Controls.Add(this.randomGenBtn);
            this.flowLayoutPanel1.Controls.Add(this.registerBtn);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(58, 114);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(564, 34);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // number1
            // 
            this.number1.BackColor = System.Drawing.SystemColors.Window;
            this.number1.Location = new System.Drawing.Point(3, 3);
            this.number1.Name = "number1";
            this.number1.Size = new System.Drawing.Size(60, 27);
            this.number1.TabIndex = 0;
            // 
            // number2
            // 
            this.number2.Location = new System.Drawing.Point(69, 3);
            this.number2.Name = "number2";
            this.number2.Size = new System.Drawing.Size(60, 27);
            this.number2.TabIndex = 1;
            // 
            // number3
            // 
            this.number3.Location = new System.Drawing.Point(135, 3);
            this.number3.Name = "number3";
            this.number3.Size = new System.Drawing.Size(60, 27);
            this.number3.TabIndex = 2;
            // 
            // randomGenBtn
            // 
            this.randomGenBtn.Location = new System.Drawing.Point(248, 3);
            this.randomGenBtn.Margin = new System.Windows.Forms.Padding(50, 3, 3, 3);
            this.randomGenBtn.Name = "randomGenBtn";
            this.randomGenBtn.Size = new System.Drawing.Size(150, 30);
            this.randomGenBtn.TabIndex = 3;
            this.randomGenBtn.Text = "Generate Random";
            this.randomGenBtn.UseVisualStyleBackColor = true;
            this.randomGenBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.randomGenBtn_MouseClick);
            // 
            // registerBtn
            // 
            this.registerBtn.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.registerBtn.ForeColor = System.Drawing.Color.DarkCyan;
            this.registerBtn.Location = new System.Drawing.Point(461, 3);
            this.registerBtn.Margin = new System.Windows.Forms.Padding(60, 3, 3, 3);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(100, 30);
            this.registerBtn.TabIndex = 4;
            this.registerBtn.Text = "Enter";
            this.registerBtn.UseVisualStyleBackColor = true;
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // date
            // 
            this.date.Enabled = false;
            this.date.Location = new System.Drawing.Point(58, 191);
            this.date.Name = "date";
            this.date.ShowToday = false;
            this.date.TabIndex = 1;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label1);
            this.flowLayoutPanel2.Controls.Add(this.nameInput);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(58, 35);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(377, 32);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name: ";
            // 
            // nameInput
            // 
            this.nameInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameInput.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameInput.ForeColor = System.Drawing.Color.Black;
            this.nameInput.Location = new System.Drawing.Point(112, 3);
            this.nameInput.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(239, 32);
            this.nameInput.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(58, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(359, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Choose your lucky numbers (1-11)";
            // 
            // playBtn
            // 
            this.playBtn.Font = new System.Drawing.Font("Segoe UI", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.playBtn.ForeColor = System.Drawing.Color.Firebrick;
            this.playBtn.Location = new System.Drawing.Point(470, 284);
            this.playBtn.Name = "playBtn";
            this.playBtn.Size = new System.Drawing.Size(238, 66);
            this.playBtn.TabIndex = 4;
            this.playBtn.Text = "Play Round";
            this.playBtn.UseVisualStyleBackColor = true;
            this.playBtn.Click += new System.EventHandler(this.playBtn_Click);
            // 
            // LotteryWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.playBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.date);
            this.Controls.Add(this.flowLayoutPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LotteryWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LotteryWindow_FormClosed);
            this.Resize += new System.EventHandler(this.LotteryWindow_Resize);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.number1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.number2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.number3)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.NumericUpDown number1;
        private System.Windows.Forms.NumericUpDown number2;
        private System.Windows.Forms.NumericUpDown number3;
        private System.Windows.Forms.Button randomGenBtn;
        private System.Windows.Forms.Button registerBtn;
        private System.Windows.Forms.MonthCalendar date;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button playBtn;
    }
}