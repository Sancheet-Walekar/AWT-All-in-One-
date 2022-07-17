
namespace BankAccountApplication
{
    partial class Frminput
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
            this.lblamt = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtamt = new System.Windows.Forms.TextBox();
            this.btnok = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblamt
            // 
            this.lblamt.AutoSize = true;
            this.lblamt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblamt.Location = new System.Drawing.Point(13, 24);
            this.lblamt.Name = "lblamt";
            this.lblamt.Size = new System.Drawing.Size(138, 24);
            this.lblamt.TabIndex = 0;
            this.lblamt.Text = "Enter amount  :";
            this.lblamt.Click += new System.EventHandler(this.lblamt_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Thistle;
            this.panel1.Controls.Add(this.btncancel);
            this.panel1.Controls.Add(this.btnok);
            this.panel1.Controls.Add(this.txtamt);
            this.panel1.Controls.Add(this.lblamt);
            this.panel1.Location = new System.Drawing.Point(157, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(376, 180);
            this.panel1.TabIndex = 1;
            // 
            // txtamt
            // 
            this.txtamt.Location = new System.Drawing.Point(164, 27);
            this.txtamt.Name = "txtamt";
            this.txtamt.Size = new System.Drawing.Size(184, 20);
            this.txtamt.TabIndex = 1;
            // 
            // btnok
            // 
            this.btnok.BackColor = System.Drawing.Color.Tomato;
            this.btnok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnok.Location = new System.Drawing.Point(54, 95);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(102, 41);
            this.btnok.TabIndex = 2;
            this.btnok.Text = "OK";
            this.btnok.UseVisualStyleBackColor = false;
            // 
            // btncancel
            // 
            this.btncancel.BackColor = System.Drawing.Color.LightSalmon;
            this.btncancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btncancel.Location = new System.Drawing.Point(192, 95);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(102, 41);
            this.btncancel.TabIndex = 3;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = false;
            // 
            // Frminput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 325);
            this.Controls.Add(this.panel1);
            this.Name = "Frminput";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblamt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnok;
        private System.Windows.Forms.TextBox txtamt;
    }
}