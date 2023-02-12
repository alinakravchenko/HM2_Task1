namespace HM2_2
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
            this.buttonProcessStart = new System.Windows.Forms.Button();
            this.buttonStopProcess = new System.Windows.Forms.Button();
            this.checkBoxChooseWait = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // buttonProcessStart
            // 
            this.buttonProcessStart.Location = new System.Drawing.Point(12, 173);
            this.buttonProcessStart.Name = "buttonProcessStart";
            this.buttonProcessStart.Size = new System.Drawing.Size(203, 56);
            this.buttonProcessStart.TabIndex = 0;
            this.buttonProcessStart.Text = "Запустить процесс";
            this.buttonProcessStart.UseVisualStyleBackColor = true;
            this.buttonProcessStart.Click += new System.EventHandler(this.buttonProcessStart_Click);
            // 
            // buttonStopProcess
            // 
            this.buttonStopProcess.Location = new System.Drawing.Point(12, 12);
            this.buttonStopProcess.Name = "buttonStopProcess";
            this.buttonStopProcess.Size = new System.Drawing.Size(203, 65);
            this.buttonStopProcess.TabIndex = 1;
            this.buttonStopProcess.Text = "Принудительно завершить процесс";
            this.buttonStopProcess.UseVisualStyleBackColor = true;
            this.buttonStopProcess.Click += new System.EventHandler(this.buttonStopProcess_Click);
            // 
            // checkBoxChooseWait
            // 
            this.checkBoxChooseWait.AutoSize = true;
            this.checkBoxChooseWait.Location = new System.Drawing.Point(210, 116);
            this.checkBoxChooseWait.Name = "checkBoxChooseWait";
            this.checkBoxChooseWait.Size = new System.Drawing.Size(258, 17);
            this.checkBoxChooseWait.TabIndex = 2;
            this.checkBoxChooseWait.Text = "Запустить процесс с ожиданием завершения";
            this.checkBoxChooseWait.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 257);
            this.Controls.Add(this.checkBoxChooseWait);
            this.Controls.Add(this.buttonStopProcess);
            this.Controls.Add(this.buttonProcessStart);
            this.Name = "Form1";
            this.Text = "Дочерний Процесс";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonProcessStart;
        private System.Windows.Forms.Button buttonStopProcess;
        private System.Windows.Forms.CheckBox checkBoxChooseWait;
    }
}

