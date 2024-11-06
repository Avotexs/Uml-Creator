namespace Uml_Creator
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
            this.button1 = new System.Windows.Forms.Button();
            this.buttonHide1 = new System.Windows.Forms.Button();
            this.buttonloubna = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(72, 168);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "diagramme";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonHide1
            // 
            this.buttonHide1.Location = new System.Drawing.Point(424, 215);
            this.buttonHide1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonHide1.Name = "buttonHide1";
            this.buttonHide1.Size = new System.Drawing.Size(112, 35);
            this.buttonHide1.TabIndex = 1;
            this.buttonHide1.Text = "buttonHide1";
            this.buttonHide1.UseVisualStyleBackColor = true;
            this.buttonHide1.Click += new System.EventHandler(this.buttonHide1_Click);
            // 
            // buttonloubna
            // 
            this.buttonloubna.Location = new System.Drawing.Point(604, 123);
            this.buttonloubna.Name = "buttonloubna";
            this.buttonloubna.Size = new System.Drawing.Size(75, 23);
            this.buttonloubna.TabIndex = 2;
            this.buttonloubna.Text = "buttonloubna";
            this.buttonloubna.UseVisualStyleBackColor = true;
            this.buttonloubna.Click += new System.EventHandler(this.buttonloubna_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.buttonloubna);
            this.Controls.Add(this.buttonHide1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonHide1;
        private System.Windows.Forms.Button buttonloubna;
    }
}

