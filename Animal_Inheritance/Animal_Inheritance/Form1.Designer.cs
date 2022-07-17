
namespace Animal_Inheritance
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
            this.lblsel = new System.Windows.Forms.Label();
            this.cmvanimal = new System.Windows.Forms.ComboBox();
            this.btnplay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblsel
            // 
            this.lblsel.AutoSize = true;
            this.lblsel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsel.Location = new System.Drawing.Point(64, 40);
            this.lblsel.Name = "lblsel";
            this.lblsel.Size = new System.Drawing.Size(151, 24);
            this.lblsel.TabIndex = 0;
            this.lblsel.Text = "Select an Animal";
            // 
            // cmvanimal
            // 
            this.cmvanimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmvanimal.FormattingEnabled = true;
            this.cmvanimal.Location = new System.Drawing.Point(252, 42);
            this.cmvanimal.Name = "cmvanimal";
            this.cmvanimal.Size = new System.Drawing.Size(307, 32);
            this.cmvanimal.TabIndex = 1;
            // 
            // btnplay
            // 
            this.btnplay.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnplay.Location = new System.Drawing.Point(583, 40);
            this.btnplay.Name = "btnplay";
            this.btnplay.Size = new System.Drawing.Size(131, 40);
            this.btnplay.TabIndex = 2;
            this.btnplay.Text = "Play sound";
            this.btnplay.UseVisualStyleBackColor = false;
            this.btnplay.Click += new System.EventHandler(this.btnplay_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 287);
            this.Controls.Add(this.btnplay);
            this.Controls.Add(this.cmvanimal);
            this.Controls.Add(this.lblsel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblsel;
        private System.Windows.Forms.ComboBox cmvanimal;
        private System.Windows.Forms.Button btnplay;
    }
}

