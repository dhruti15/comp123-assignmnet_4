namespace Movie_Bonanza
{
    partial class StreamForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StreamForm));
            this.label1 = new System.Windows.Forms.Label();
            this.GrandTotalText = new System.Windows.Forms.Label();
            this.ChosenMovieLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mistral", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(120, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thank You for visting";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // GrandTotalText
            // 
            this.GrandTotalText.AutoSize = true;
            this.GrandTotalText.Font = new System.Drawing.Font("Mistral", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrandTotalText.Location = new System.Drawing.Point(40, 84);
            this.GrandTotalText.Name = "GrandTotalText";
            this.GrandTotalText.Size = new System.Drawing.Size(381, 22);
            this.GrandTotalText.TabIndex = 1;
            this.GrandTotalText.Text = "The amount deducted from your credit  Account [X dollars]";
            // 
            // ChosenMovieLabel
            // 
            this.ChosenMovieLabel.AutoSize = true;
            this.ChosenMovieLabel.Font = new System.Drawing.Font("Mistral", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChosenMovieLabel.Location = new System.Drawing.Point(79, 138);
            this.ChosenMovieLabel.Name = "ChosenMovieLabel";
            this.ChosenMovieLabel.Size = new System.Drawing.Size(273, 22);
            this.ChosenMovieLabel.TabIndex = 2;
            this.ChosenMovieLabel.Text = "[Your Movie] will begin streaming shortly.";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(392, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // StreamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(470, 216);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ChosenMovieLabel);
            this.Controls.Add(this.GrandTotalText);
            this.Controls.Add(this.label1);
            this.Name = "StreamForm";
            this.Text = "Your Movie is about to start!";
            this.Load += new System.EventHandler(this.StreamForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label GrandTotalText;
        private System.Windows.Forms.Label ChosenMovieLabel;
        private System.Windows.Forms.Button button1;
    }
}