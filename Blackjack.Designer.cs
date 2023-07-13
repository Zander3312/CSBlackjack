namespace CSharpBlackjack
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
            this.dealHand = new System.Windows.Forms.Button();
            this.yourTotal = new System.Windows.Forms.Label();
            this.hitButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.dealerTotal = new System.Windows.Forms.Label();
            this.wins = new System.Windows.Forms.Label();
            this.losses = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dealHand
            // 
            this.dealHand.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dealHand.Location = new System.Drawing.Point(81, 364);
            this.dealHand.Name = "dealHand";
            this.dealHand.Size = new System.Drawing.Size(167, 42);
            this.dealHand.TabIndex = 0;
            this.dealHand.Text = "Deal New Hand";
            this.dealHand.UseVisualStyleBackColor = true;
            this.dealHand.Click += new System.EventHandler(this.button1_Click);
            // 
            // yourTotal
            // 
            this.yourTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yourTotal.Location = new System.Drawing.Point(12, 307);
            this.yourTotal.Name = "yourTotal";
            this.yourTotal.Size = new System.Drawing.Size(776, 20);
            this.yourTotal.TabIndex = 3;
            this.yourTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hitButton
            // 
            this.hitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.hitButton.Location = new System.Drawing.Point(327, 364);
            this.hitButton.Name = "hitButton";
            this.hitButton.Size = new System.Drawing.Size(142, 42);
            this.hitButton.TabIndex = 4;
            this.hitButton.Text = "Hit";
            this.hitButton.UseVisualStyleBackColor = true;
            this.hitButton.Visible = false;
            this.hitButton.Click += new System.EventHandler(this.hitButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.stopButton.Location = new System.Drawing.Point(570, 364);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(141, 42);
            this.stopButton.TabIndex = 5;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Visible = false;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // title
            // 
            this.title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.title.Location = new System.Drawing.Point(12, 32);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(776, 36);
            this.title.TabIndex = 2;
            this.title.Text = "Welcome to Blackjack!";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dealerTotal
            // 
            this.dealerTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.dealerTotal.Location = new System.Drawing.Point(323, 307);
            this.dealerTotal.Name = "dealerTotal";
            this.dealerTotal.Size = new System.Drawing.Size(493, 20);
            this.dealerTotal.TabIndex = 6;
            this.dealerTotal.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // wins
            // 
            this.wins.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.wins.Location = new System.Drawing.Point(688, 9);
            this.wins.Name = "wins";
            this.wins.Size = new System.Drawing.Size(100, 23);
            this.wins.TabIndex = 7;
            this.wins.Text = "Wins: 0";
            this.wins.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // losses
            // 
            this.losses.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.losses.Location = new System.Drawing.Point(688, 32);
            this.losses.Name = "losses";
            this.losses.Size = new System.Drawing.Size(100, 23);
            this.losses.TabIndex = 8;
            this.losses.Text = "Losses: 0";
            this.losses.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.losses);
            this.Controls.Add(this.wins);
            this.Controls.Add(this.dealerTotal);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.hitButton);
            this.Controls.Add(this.yourTotal);
            this.Controls.Add(this.title);
            this.Controls.Add(this.dealHand);
            this.Name = "Form1";
            this.Text = "Blackjack";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button dealHand;
        private System.Windows.Forms.Label yourTotal;
        private System.Windows.Forms.Button hitButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label dealerTotal;
        private System.Windows.Forms.Label wins;
        private System.Windows.Forms.Label losses;
    }
}

