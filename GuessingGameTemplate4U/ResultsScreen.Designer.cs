
namespace GuessingGameTemplate4U
{
    partial class ResultsScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gotItLabel = new System.Windows.Forms.Label();
            this.resultsTitleLabel = new System.Windows.Forms.Label();
            this.resultsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gotItLabel
            // 
            this.gotItLabel.AutoSize = true;
            this.gotItLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gotItLabel.ForeColor = System.Drawing.Color.White;
            this.gotItLabel.Location = new System.Drawing.Point(262, 75);
            this.gotItLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.gotItLabel.Name = "gotItLabel";
            this.gotItLabel.Size = new System.Drawing.Size(262, 67);
            this.gotItLabel.TabIndex = 7;
            this.gotItLabel.Text = "You Got It!";
            // 
            // resultsTitleLabel
            // 
            this.resultsTitleLabel.AutoSize = true;
            this.resultsTitleLabel.Font = new System.Drawing.Font("Segoe UI", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultsTitleLabel.ForeColor = System.Drawing.Color.White;
            this.resultsTitleLabel.Location = new System.Drawing.Point(98, 180);
            this.resultsTitleLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.resultsTitleLabel.Name = "resultsTitleLabel";
            this.resultsTitleLabel.Size = new System.Drawing.Size(176, 65);
            this.resultsTitleLabel.TabIndex = 8;
            this.resultsTitleLabel.Text = "Results";
            // 
            // resultsLabel
            // 
            this.resultsLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.resultsLabel.Font = new System.Drawing.Font("Segoe UI", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultsLabel.ForeColor = System.Drawing.Color.White;
            this.resultsLabel.Location = new System.Drawing.Point(52, 217);
            this.resultsLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.resultsLabel.Name = "resultsLabel";
            this.resultsLabel.Size = new System.Drawing.Size(694, 455);
            this.resultsLabel.TabIndex = 9;
            // 
            // ResultsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.resultsTitleLabel);
            this.Controls.Add(this.resultsLabel);
            this.Controls.Add(this.gotItLabel);
            this.Name = "ResultsScreen";
            this.Size = new System.Drawing.Size(800, 715);
            this.Load += new System.EventHandler(this.ResultsScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label gotItLabel;
        private System.Windows.Forms.Label resultsTitleLabel;
        private System.Windows.Forms.Label resultsLabel;
    }
}
