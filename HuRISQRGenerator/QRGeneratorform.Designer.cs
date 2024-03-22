namespace HuRISQRGenerator
{
    partial class QRGeneratorform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QRGeneratorform));
            this.panFoot = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.picQR = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_itemtype = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtname = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtLink = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtColor = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panFoot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picQR)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panFoot
            // 
            this.panFoot.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panFoot.Controls.Add(this.label5);
            this.panFoot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panFoot.ForeColor = System.Drawing.Color.DarkGray;
            this.panFoot.Location = new System.Drawing.Point(0, 483);
            this.panFoot.Name = "panFoot";
            this.panFoot.Size = new System.Drawing.Size(499, 25);
            this.panFoot.TabIndex = 1082;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Dock = System.Windows.Forms.DockStyle.Left;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.LightGray;
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(288, 25);
            this.label5.TabIndex = 849;
            this.label5.Text = "      Press Esc to close this form";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picQR
            // 
            this.picQR.BackColor = System.Drawing.Color.White;
            this.picQR.Location = new System.Drawing.Point(99, 125);
            this.picQR.Name = "picQR";
            this.picQR.Size = new System.Drawing.Size(301, 297);
            this.picQR.TabIndex = 1083;
            this.picQR.TabStop = false;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(346, 434);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 37);
            this.button1.TabIndex = 1085;
            this.button1.Text = "        Print QR code";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_itemtype
            // 
            this.btn_itemtype.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_itemtype.BackColor = System.Drawing.Color.White;
            this.btn_itemtype.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_itemtype.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_itemtype.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.btn_itemtype.Image = ((System.Drawing.Image)(resources.GetObject("btn_itemtype.Image")));
            this.btn_itemtype.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_itemtype.Location = new System.Drawing.Point(12, 434);
            this.btn_itemtype.Name = "btn_itemtype";
            this.btn_itemtype.Size = new System.Drawing.Size(145, 37);
            this.btn_itemtype.TabIndex = 1084;
            this.btn_itemtype.Text = "           Generate QR code";
            this.btn_itemtype.UseVisualStyleBackColor = false;
            this.btn_itemtype.Click += new System.EventHandler(this.btn_itemtype_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(406, 11);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(77, 23);
            this.button2.TabIndex = 1086;
            this.button2.Text = "Find";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtname);
            this.panel1.Controls.Add(this.Label1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(499, 40);
            this.panel1.TabIndex = 1087;
            // 
            // txtname
            // 
            this.txtname.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtname.Border.Class = "TextBoxBorder";
            this.txtname.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtname.Location = new System.Drawing.Point(75, 12);
            this.txtname.Name = "txtname";
            this.txtname.ReadOnly = true;
            this.txtname.Size = new System.Drawing.Size(325, 21);
            this.txtname.TabIndex = 1088;
            this.txtname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtname_KeyDown);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(12, 16);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(60, 13);
            this.Label1.TabIndex = 1087;
            this.Label1.Text = "Employee :";
            // 
            // txtLink
            // 
            this.txtLink.BackColor = System.Drawing.Color.WhiteSmoke;
            // 
            // 
            // 
            this.txtLink.Border.Class = "TextBoxBorder";
            this.txtLink.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtLink.Location = new System.Drawing.Point(75, 46);
            this.txtLink.Name = "txtLink";
            this.txtLink.Size = new System.Drawing.Size(325, 21);
            this.txtLink.TabIndex = 1089;
            this.txtLink.Text = "http://www.zips.wardhowell.com.ph/Tool/ids?guid=";
            // 
            // txtColor
            // 
            this.txtColor.BackColor = System.Drawing.Color.WhiteSmoke;
            // 
            // 
            // 
            this.txtColor.Border.Class = "TextBoxBorder";
            this.txtColor.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtColor.Location = new System.Drawing.Point(75, 73);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(325, 21);
            this.txtColor.TabIndex = 1090;
            this.txtColor.Text = "#0c4496";
            this.txtColor.TextChanged += new System.EventHandler(this.txtColor_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1091;
            this.label2.Text = "Link :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 1092;
            this.label3.Text = "Color :";
            // 
            // QRGeneratorform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(499, 508);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.txtLink);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_itemtype);
            this.Controls.Add(this.picQR);
            this.Controls.Add(this.panFoot);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "QRGeneratorform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ZMG QR Generator";
            this.panFoot.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picQR)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panFoot;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox picQR;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_itemtype;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtname;
        internal System.Windows.Forms.Label Label1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtLink;
        private DevComponents.DotNetBar.Controls.TextBoxX txtColor;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label label3;
    }
}

