
namespace WindowsFormsTesting
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Panel1OK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel2Back = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ShowPanLoc = new System.Windows.Forms.Button();
            this.PanLocation = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.Panel1OK);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(187, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 429);
            this.panel1.TabIndex = 0;
            // 
            // Panel1OK
            // 
            this.Panel1OK.Location = new System.Drawing.Point(122, 241);
            this.Panel1OK.Name = "Panel1OK";
            this.Panel1OK.Size = new System.Drawing.Size(75, 23);
            this.Panel1OK.TabIndex = 2;
            this.Panel1OK.Text = "OK";
            this.Panel1OK.UseVisualStyleBackColor = true;
            this.Panel1OK.Click += new System.EventHandler(this.Panel1OK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(69, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Panel 1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.Controls.Add(this.panel2Back);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(536, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 429);
            this.panel2.TabIndex = 1;
            this.panel2.Visible = false;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel2Back
            // 
            this.panel2Back.Location = new System.Drawing.Point(3, 241);
            this.panel2Back.Name = "panel2Back";
            this.panel2Back.Size = new System.Drawing.Size(75, 23);
            this.panel2Back.TabIndex = 2;
            this.panel2Back.Text = "Back";
            this.panel2Back.UseVisualStyleBackColor = true;
            this.panel2Back.Click += new System.EventHandler(this.panel2Back_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(78, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Panel 2";
            // 
            // ShowPanLoc
            // 
            this.ShowPanLoc.Location = new System.Drawing.Point(12, 389);
            this.ShowPanLoc.Name = "ShowPanLoc";
            this.ShowPanLoc.Size = new System.Drawing.Size(90, 23);
            this.ShowPanLoc.TabIndex = 2;
            this.ShowPanLoc.Text = "ShowPanLoc";
            this.ShowPanLoc.UseVisualStyleBackColor = true;
            this.ShowPanLoc.Click += new System.EventHandler(this.button2_Click);
            // 
            // PanLocation
            // 
            this.PanLocation.AutoSize = true;
            this.PanLocation.Location = new System.Drawing.Point(70, 30);
            this.PanLocation.Name = "PanLocation";
            this.PanLocation.Size = new System.Drawing.Size(0, 13);
            this.PanLocation.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 424);
            this.Controls.Add(this.PanLocation);
            this.Controls.Add(this.ShowPanLoc);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Panel1OK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button panel2Back;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ShowPanLoc;
        private System.Windows.Forms.Label PanLocation;
    }
}

