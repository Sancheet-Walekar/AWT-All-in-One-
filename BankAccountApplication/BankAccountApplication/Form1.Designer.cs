
namespace BankAccountApplication
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
            this.lblheading = new System.Windows.Forms.Label();
            this.pnlinput = new System.Windows.Forms.Panel();
            this.txtbalance = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtacno = new System.Windows.Forms.TextBox();
            this.lblacbalance = new System.Windows.Forms.Label();
            this.lblacname = new System.Windows.Forms.Label();
            this.lblacno = new System.Windows.Forms.Label();
            this.pnlbutton = new System.Windows.Forms.Panel();
            this.btnexi = new System.Windows.Forms.Button();
            this.btnche = new System.Windows.Forms.Button();
            this.btndep = new System.Windows.Forms.Button();
            this.btnwid = new System.Windows.Forms.Button();
            this.btnopen = new System.Windows.Forms.Button();
            this.pnlresult = new System.Windows.Forms.Panel();
            this.txtmsg = new System.Windows.Forms.TextBox();
            this.pnlinput.SuspendLayout();
            this.pnlbutton.SuspendLayout();
            this.pnlresult.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblheading
            // 
            this.lblheading.BackColor = System.Drawing.Color.Gold;
            this.lblheading.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblheading.ForeColor = System.Drawing.Color.Red;
            this.lblheading.Location = new System.Drawing.Point(99, 9);
            this.lblheading.Name = "lblheading";
            this.lblheading.Size = new System.Drawing.Size(620, 53);
            this.lblheading.TabIndex = 0;
            this.lblheading.Text = "DENA BANK";
            this.lblheading.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlinput
            // 
            this.pnlinput.BackColor = System.Drawing.Color.LemonChiffon;
            this.pnlinput.Controls.Add(this.txtbalance);
            this.pnlinput.Controls.Add(this.txtname);
            this.pnlinput.Controls.Add(this.txtacno);
            this.pnlinput.Controls.Add(this.lblacbalance);
            this.pnlinput.Controls.Add(this.lblacname);
            this.pnlinput.Controls.Add(this.lblacno);
            this.pnlinput.Location = new System.Drawing.Point(99, 90);
            this.pnlinput.Name = "pnlinput";
            this.pnlinput.Size = new System.Drawing.Size(620, 141);
            this.pnlinput.TabIndex = 1;
            // 
            // txtbalance
            // 
            this.txtbalance.Location = new System.Drawing.Point(211, 95);
            this.txtbalance.Name = "txtbalance";
            this.txtbalance.Size = new System.Drawing.Size(258, 20);
            this.txtbalance.TabIndex = 5;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(211, 61);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(258, 20);
            this.txtname.TabIndex = 4;
            this.txtname.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtacno
            // 
            this.txtacno.Location = new System.Drawing.Point(211, 20);
            this.txtacno.Name = "txtacno";
            this.txtacno.Size = new System.Drawing.Size(258, 20);
            this.txtacno.TabIndex = 3;
            // 
            // lblacbalance
            // 
            this.lblacbalance.AutoSize = true;
            this.lblacbalance.Location = new System.Drawing.Point(90, 95);
            this.lblacbalance.Name = "lblacbalance";
            this.lblacbalance.Size = new System.Drawing.Size(104, 13);
            this.lblacbalance.TabIndex = 2;
            this.lblacbalance.Text = "Account Balance    :";
            // 
            // lblacname
            // 
            this.lblacname.AutoSize = true;
            this.lblacname.Location = new System.Drawing.Point(90, 61);
            this.lblacname.Name = "lblacname";
            this.lblacname.Size = new System.Drawing.Size(105, 13);
            this.lblacname.TabIndex = 1;
            this.lblacname.Text = "Account Name        :";
            this.lblacname.Click += new System.EventHandler(this.lblacname_Click);
            // 
            // lblacno
            // 
            this.lblacno.AutoSize = true;
            this.lblacno.Location = new System.Drawing.Point(90, 23);
            this.lblacno.Name = "lblacno";
            this.lblacno.Size = new System.Drawing.Size(105, 13);
            this.lblacno.TabIndex = 0;
            this.lblacno.Text = "Account Number     :";
            this.lblacno.Click += new System.EventHandler(this.lblacno_Click);
            // 
            // pnlbutton
            // 
            this.pnlbutton.BackColor = System.Drawing.Color.LemonChiffon;
            this.pnlbutton.Controls.Add(this.btnexi);
            this.pnlbutton.Controls.Add(this.btnche);
            this.pnlbutton.Controls.Add(this.btndep);
            this.pnlbutton.Controls.Add(this.btnwid);
            this.pnlbutton.Controls.Add(this.btnopen);
            this.pnlbutton.Location = new System.Drawing.Point(99, 253);
            this.pnlbutton.Name = "pnlbutton";
            this.pnlbutton.Size = new System.Drawing.Size(620, 62);
            this.pnlbutton.TabIndex = 2;
            // 
            // btnexi
            // 
            this.btnexi.BackColor = System.Drawing.Color.Orange;
            this.btnexi.Location = new System.Drawing.Point(510, 18);
            this.btnexi.Name = "btnexi";
            this.btnexi.Size = new System.Drawing.Size(99, 31);
            this.btnexi.TabIndex = 4;
            this.btnexi.Text = "Exit";
            this.btnexi.UseVisualStyleBackColor = false;
            this.btnexi.Click += new System.EventHandler(this.btnexi_Click);
            // 
            // btnche
            // 
            this.btnche.BackColor = System.Drawing.Color.YellowGreen;
            this.btnche.Enabled = false;
            this.btnche.Location = new System.Drawing.Point(382, 18);
            this.btnche.Name = "btnche";
            this.btnche.Size = new System.Drawing.Size(107, 31);
            this.btnche.TabIndex = 3;
            this.btnche.Text = "Check";
            this.btnche.UseVisualStyleBackColor = false;
            this.btnche.Click += new System.EventHandler(this.btnche_Click);
            // 
            // btndep
            // 
            this.btndep.BackColor = System.Drawing.Color.YellowGreen;
            this.btndep.Enabled = false;
            this.btndep.Location = new System.Drawing.Point(258, 18);
            this.btndep.Name = "btndep";
            this.btndep.Size = new System.Drawing.Size(107, 31);
            this.btndep.TabIndex = 2;
            this.btndep.Text = "Deposite";
            this.btndep.UseVisualStyleBackColor = false;
            this.btndep.Click += new System.EventHandler(this.btndep_Click);
            // 
            // btnwid
            // 
            this.btnwid.BackColor = System.Drawing.Color.YellowGreen;
            this.btnwid.Enabled = false;
            this.btnwid.Location = new System.Drawing.Point(134, 18);
            this.btnwid.Name = "btnwid";
            this.btnwid.Size = new System.Drawing.Size(107, 31);
            this.btnwid.TabIndex = 1;
            this.btnwid.Text = "Withdraw";
            this.btnwid.UseVisualStyleBackColor = false;
            this.btnwid.Click += new System.EventHandler(this.btnwid_Click);
            // 
            // btnopen
            // 
            this.btnopen.BackColor = System.Drawing.Color.Orange;
            this.btnopen.Location = new System.Drawing.Point(7, 18);
            this.btnopen.Name = "btnopen";
            this.btnopen.Size = new System.Drawing.Size(107, 31);
            this.btnopen.TabIndex = 0;
            this.btnopen.Text = "Open";
            this.btnopen.UseVisualStyleBackColor = false;
            this.btnopen.Click += new System.EventHandler(this.btnopen_Click);
            // 
            // pnlresult
            // 
            this.pnlresult.Controls.Add(this.txtmsg);
            this.pnlresult.Location = new System.Drawing.Point(99, 335);
            this.pnlresult.Name = "pnlresult";
            this.pnlresult.Size = new System.Drawing.Size(620, 63);
            this.pnlresult.TabIndex = 3;
            // 
            // txtmsg
            // 
            this.txtmsg.BackColor = System.Drawing.Color.PowderBlue;
            this.txtmsg.Location = new System.Drawing.Point(7, 3);
            this.txtmsg.Multiline = true;
            this.txtmsg.Name = "txtmsg";
            this.txtmsg.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtmsg.Size = new System.Drawing.Size(602, 57);
            this.txtmsg.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlresult);
            this.Controls.Add(this.pnlbutton);
            this.Controls.Add(this.pnlinput);
            this.Controls.Add(this.lblheading);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlinput.ResumeLayout(false);
            this.pnlinput.PerformLayout();
            this.pnlbutton.ResumeLayout(false);
            this.pnlresult.ResumeLayout(false);
            this.pnlresult.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblheading;
        private System.Windows.Forms.Panel pnlinput;
        private System.Windows.Forms.Label lblacbalance;
        private System.Windows.Forms.Label lblacname;
        private System.Windows.Forms.Label lblacno;
        private System.Windows.Forms.TextBox txtacno;
        private System.Windows.Forms.TextBox txtbalance;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Panel pnlbutton;
        private System.Windows.Forms.Button btnexi;
        private System.Windows.Forms.Button btnche;
        private System.Windows.Forms.Button btndep;
        private System.Windows.Forms.Button btnwid;
        private System.Windows.Forms.Button btnopen;
        private System.Windows.Forms.Panel pnlresult;
        private System.Windows.Forms.TextBox txtmsg;
    }
}

