namespace Cliente
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTittle = new System.Windows.Forms.Label();
            this.txtStart = new System.Windows.Forms.TextBox();
            this.lblStart = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTittle
            // 
            this.lblTittle.AutoSize = true;
            this.lblTittle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTittle.Location = new System.Drawing.Point(12, 9);
            this.lblTittle.Name = "lblTittle";
            this.lblTittle.Size = new System.Drawing.Size(212, 32);
            this.lblTittle.TabIndex = 0;
            this.lblTittle.Text = "Rocket countdown";
            // 
            // txtStart
            // 
            this.txtStart.Location = new System.Drawing.Point(117, 53);
            this.txtStart.Name = "txtStart";
            this.txtStart.Size = new System.Drawing.Size(37, 23);
            this.txtStart.TabIndex = 1;
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStart.Location = new System.Drawing.Point(65, 51);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(46, 21);
            this.lblStart.TabIndex = 2;
            this.lblStart.Text = "Start ";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(65, 118);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(125, 50);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Launch countdown";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(106, 88);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(22, 15);
            this.lblCount.TabIndex = 4;
            this.lblCount.Text = "     ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 191);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.txtStart);
            this.Controls.Add(this.lblTittle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTittle;
        private System.Windows.Forms.TextBox txtStart;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblCount;
    }
}

