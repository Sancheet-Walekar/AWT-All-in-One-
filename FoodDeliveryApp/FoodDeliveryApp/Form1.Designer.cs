
namespace FoodDeliveryApp
{
    partial class frmmain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmmain));
            this.picheader = new System.Windows.Forms.PictureBox();
            this.lstdisplay = new System.Windows.Forms.ListView();
            this.imgbig = new System.Windows.Forms.ImageList(this.components);
            this.imgsmall = new System.Windows.Forms.ImageList(this.components);
            this.ctxdisplay = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.btnsearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picheader)).BeginInit();
            this.ctxdisplay.SuspendLayout();
            this.SuspendLayout();
            // 
            // picheader
            // 
            this.picheader.Image = ((System.Drawing.Image)(resources.GetObject("picheader.Image")));
            this.picheader.Location = new System.Drawing.Point(12, 12);
            this.picheader.Name = "picheader";
            this.picheader.Size = new System.Drawing.Size(776, 135);
            this.picheader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picheader.TabIndex = 0;
            this.picheader.TabStop = false;
            // 
            // lstdisplay
            // 
            this.lstdisplay.ContextMenuStrip = this.ctxdisplay;
            this.lstdisplay.HideSelection = false;
            this.lstdisplay.LargeImageList = this.imgbig;
            this.lstdisplay.Location = new System.Drawing.Point(12, 198);
            this.lstdisplay.Name = "lstdisplay";
            this.lstdisplay.Size = new System.Drawing.Size(776, 279);
            this.lstdisplay.SmallImageList = this.imgsmall;
            this.lstdisplay.TabIndex = 1;
            this.lstdisplay.UseCompatibleStateImageBehavior = false;
            this.lstdisplay.View = System.Windows.Forms.View.Tile;
            // 
            // imgbig
            // 
            this.imgbig.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imgbig.ImageSize = new System.Drawing.Size(230, 230);
            this.imgbig.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imgsmall
            // 
            this.imgsmall.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imgsmall.ImageSize = new System.Drawing.Size(30, 30);
            this.imgsmall.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // ctxdisplay
            // 
            this.ctxdisplay.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripSeparator1,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5});
            this.ctxdisplay.Name = "ctxdisplay";
            this.ctxdisplay.Size = new System.Drawing.Size(130, 120);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(129, 22);
            this.toolStripMenuItem1.Text = "Large Icon";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(129, 22);
            this.toolStripMenuItem2.Text = "Small Icon";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(129, 22);
            this.toolStripMenuItem3.Text = "List";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(129, 22);
            this.toolStripMenuItem4.Text = "Tile";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(129, 22);
            this.toolStripMenuItem5.Text = "Details";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(126, 6);
            // 
            // txtsearch
            // 
            this.txtsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsearch.Location = new System.Drawing.Point(12, 163);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(630, 29);
            this.txtsearch.TabIndex = 3;
            // 
            // btnsearch
            // 
            this.btnsearch.Font = new System.Drawing.Font("OpenSymbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.Location = new System.Drawing.Point(659, 163);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(129, 29);
            this.btnsearch.TabIndex = 4;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // frmmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 489);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.lstdisplay);
            this.Controls.Add(this.picheader);
            this.Name = "frmmain";
            this.Text = "Zomato Application";
            this.Load += new System.EventHandler(this.frmmain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picheader)).EndInit();
            this.ctxdisplay.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picheader;
        private System.Windows.Forms.ListView lstdisplay;
        private System.Windows.Forms.ImageList imgsmall;
        private System.Windows.Forms.ImageList imgbig;
        private System.Windows.Forms.ContextMenuStrip ctxdisplay;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Button btnsearch;
    }
}

