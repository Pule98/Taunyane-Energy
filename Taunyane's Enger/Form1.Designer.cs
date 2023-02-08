
namespace Taunyane_s_Enger
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.meterNumbertxt = new System.Windows.Forms.TextBox();
            this.amounttxt = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.vatlb = new System.Windows.Forms.Label();
            this.unitlb = new System.Windows.Forms.Label();
            this.tokenlb = new System.Windows.Forms.Label();
            this.purchasebtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(146, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 178);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Meter Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Amount";
            // 
            // meterNumbertxt
            // 
            this.meterNumbertxt.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meterNumbertxt.Location = new System.Drawing.Point(176, 210);
            this.meterNumbertxt.MaxLength = 11;
            this.meterNumbertxt.Name = "meterNumbertxt";
            this.meterNumbertxt.Size = new System.Drawing.Size(207, 29);
            this.meterNumbertxt.TabIndex = 3;
            this.meterNumbertxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // amounttxt
            // 
            this.amounttxt.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amounttxt.Location = new System.Drawing.Point(176, 257);
            this.amounttxt.Name = "amounttxt";
            this.amounttxt.Size = new System.Drawing.Size(207, 29);
            this.amounttxt.TabIndex = 4;
            this.amounttxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.vatlb);
            this.groupBox1.Controls.Add(this.unitlb);
            this.groupBox1.Controls.Add(this.tokenlb);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(30, 363);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(423, 137);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Details";
            // 
            // vatlb
            // 
            this.vatlb.AutoSize = true;
            this.vatlb.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vatlb.Location = new System.Drawing.Point(79, 98);
            this.vatlb.Name = "vatlb";
            this.vatlb.Size = new System.Drawing.Size(40, 23);
            this.vatlb.TabIndex = 7;
            this.vatlb.Text = "VAT";
            this.vatlb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // unitlb
            // 
            this.unitlb.AutoSize = true;
            this.unitlb.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitlb.Location = new System.Drawing.Point(79, 63);
            this.unitlb.Name = "unitlb";
            this.unitlb.Size = new System.Drawing.Size(36, 23);
            this.unitlb.TabIndex = 7;
            this.unitlb.Text = "Unit";
            this.unitlb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tokenlb
            // 
            this.tokenlb.AutoSize = true;
            this.tokenlb.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tokenlb.Location = new System.Drawing.Point(79, 25);
            this.tokenlb.Name = "tokenlb";
            this.tokenlb.Size = new System.Drawing.Size(54, 23);
            this.tokenlb.TabIndex = 7;
            this.tokenlb.Text = "Token";
            this.tokenlb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // purchasebtn
            // 
            this.purchasebtn.BackColor = System.Drawing.Color.White;
            this.purchasebtn.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchasebtn.ForeColor = System.Drawing.Color.Black;
            this.purchasebtn.Location = new System.Drawing.Point(73, 304);
            this.purchasebtn.Name = "purchasebtn";
            this.purchasebtn.Size = new System.Drawing.Size(349, 37);
            this.purchasebtn.TabIndex = 7;
            this.purchasebtn.Text = "Purcahse";
            this.purchasebtn.UseVisualStyleBackColor = false;
            this.purchasebtn.Click += new System.EventHandler(this.purchasebtn_Click);
            // 
            // Form1
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(467, 549);
            this.Controls.Add(this.purchasebtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.amounttxt);
            this.Controls.Add(this.meterNumbertxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Taunyane\'s Energy";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox meterNumbertxt;
        private System.Windows.Forms.TextBox amounttxt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label vatlb;
        private System.Windows.Forms.Label unitlb;
        private System.Windows.Forms.Label tokenlb;
        private System.Windows.Forms.Button purchasebtn;
    }
}

