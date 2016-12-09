namespace Merritt_Coil_App
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
            this.label1 = new System.Windows.Forms.Label();
            this.axText = new System.Windows.Forms.TextBox();
            this.ayText = new System.Windows.Forms.TextBox();
            this.azText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Calculate = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.bFieldText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "âx";
            // 
            // axText
            // 
            this.axText.Location = new System.Drawing.Point(12, 39);
            this.axText.Name = "axText";
            this.axText.Size = new System.Drawing.Size(42, 22);
            this.axText.TabIndex = 0;
            // 
            // ayText
            // 
            this.ayText.Location = new System.Drawing.Point(60, 39);
            this.ayText.Name = "ayText";
            this.ayText.Size = new System.Drawing.Size(42, 22);
            this.ayText.TabIndex = 2;
            // 
            // azText
            // 
            this.azText.Location = new System.Drawing.Point(108, 39);
            this.azText.Name = "azText";
            this.azText.Size = new System.Drawing.Size(42, 22);
            this.azText.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "ây";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(117, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "âz";
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(168, 38);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(89, 23);
            this.Calculate.TabIndex = 6;
            this.Calculate.Text = "Calculate!";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Magnetic Field at Point:";
            // 
            // bFieldText
            // 
            this.bFieldText.Location = new System.Drawing.Point(12, 89);
            this.bFieldText.Name = "bFieldText";
            this.bFieldText.Size = new System.Drawing.Size(245, 22);
            this.bFieldText.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 122);
            this.Controls.Add(this.bFieldText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.azText);
            this.Controls.Add(this.ayText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.axText);
            this.Name = "Form1";
            this.Text = "Merritt Coil App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox axText;
        private System.Windows.Forms.TextBox ayText;
        private System.Windows.Forms.TextBox azText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox bFieldText;
    }
}

