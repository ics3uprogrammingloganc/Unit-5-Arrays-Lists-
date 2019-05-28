namespace _2dArraysLoganC
{
    partial class frm2darr
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
            this.nudX = new System.Windows.Forms.NumericUpDown();
            this.nudY = new System.Windows.Forms.NumericUpDown();
            this.lblx = new System.Windows.Forms.Label();
            this.lbly = new System.Windows.Forms.Label();
            this.tbxDisplay = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.lblavg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudY)).BeginInit();
            this.SuspendLayout();
            // 
            // nudX
            // 
            this.nudX.Location = new System.Drawing.Point(205, 55);
            this.nudX.Name = "nudX";
            this.nudX.Size = new System.Drawing.Size(120, 20);
            this.nudX.TabIndex = 0;
            // 
            // nudY
            // 
            this.nudY.Location = new System.Drawing.Point(249, 91);
            this.nudY.Name = "nudY";
            this.nudY.Size = new System.Drawing.Size(120, 20);
            this.nudY.TabIndex = 1;
            // 
            // lblx
            // 
            this.lblx.AutoSize = true;
            this.lblx.Location = new System.Drawing.Point(124, 55);
            this.lblx.Name = "lblx";
            this.lblx.Size = new System.Drawing.Size(33, 13);
            this.lblx.TabIndex = 2;
            this.lblx.Text = "x size";
            // 
            // lbly
            // 
            this.lbly.AutoSize = true;
            this.lbly.Location = new System.Drawing.Point(127, 91);
            this.lbly.Name = "lbly";
            this.lbly.Size = new System.Drawing.Size(33, 13);
            this.lbly.TabIndex = 3;
            this.lbly.Text = "y size";
            // 
            // tbxDisplay
            // 
            this.tbxDisplay.Location = new System.Drawing.Point(104, 138);
            this.tbxDisplay.Multiline = true;
            this.tbxDisplay.Name = "tbxDisplay";
            this.tbxDisplay.Size = new System.Drawing.Size(386, 180);
            this.tbxDisplay.TabIndex = 4;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(409, 51);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(147, 60);
            this.btnGenerate.TabIndex = 5;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // lblavg
            // 
            this.lblavg.AutoSize = true;
            this.lblavg.Location = new System.Drawing.Point(205, 337);
            this.lblavg.Name = "lblavg";
            this.lblavg.Size = new System.Drawing.Size(35, 13);
            this.lblavg.TabIndex = 6;
            this.lblavg.Text = "label1";
            // 
            // frm2darr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 362);
            this.Controls.Add(this.lblavg);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.tbxDisplay);
            this.Controls.Add(this.lbly);
            this.Controls.Add(this.lblx);
            this.Controls.Add(this.nudY);
            this.Controls.Add(this.nudX);
            this.Name = "frm2darr";
            this.Text = "2D Array Logan C";
            ((System.ComponentModel.ISupportInitialize)(this.nudX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudX;
        private System.Windows.Forms.NumericUpDown nudY;
        private System.Windows.Forms.Label lblx;
        private System.Windows.Forms.Label lbly;
        private System.Windows.Forms.TextBox tbxDisplay;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label lblavg;
    }
}

