namespace TestHomeWork22
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
            this.buttonStartCalc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonStartCalc
            // 
            this.buttonStartCalc.Location = new System.Drawing.Point(12, 40);
            this.buttonStartCalc.Name = "buttonStartCalc";
            this.buttonStartCalc.Size = new System.Drawing.Size(297, 208);
            this.buttonStartCalc.TabIndex = 0;
            this.buttonStartCalc.Text = "Нажмите для запуска блокнота";
            this.buttonStartCalc.UseVisualStyleBackColor = true;
            this.buttonStartCalc.Click += new System.EventHandler(this.buttonStartCalc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 296);
            this.Controls.Add(this.buttonStartCalc);
            this.Name = "Form1";
            this.Text = "Процесс";
            this.ResumeLayout(false);

            }

        #endregion

        private System.Windows.Forms.Button buttonStartCalc;
    }
}

