namespace AsyncFileReader
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnGenerateFile = new System.Windows.Forms.Button();
            this.BtnNewFile = new System.Windows.Forms.Button();
            this.lblProcessing = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblElapsedT = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblFileProc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnGenerateFile
            // 
            this.BtnGenerateFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnGenerateFile.Location = new System.Drawing.Point(302, 176);
            this.BtnGenerateFile.Name = "BtnGenerateFile";
            this.BtnGenerateFile.Size = new System.Drawing.Size(176, 35);
            this.BtnGenerateFile.TabIndex = 0;
            this.BtnGenerateFile.Text = "Create files";
            this.BtnGenerateFile.UseVisualStyleBackColor = true;
            this.BtnGenerateFile.Click += new System.EventHandler(this.BtnGenerateFile_Click);
            // 
            // BtnNewFile
            // 
            this.BtnNewFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnNewFile.Location = new System.Drawing.Point(302, 217);
            this.BtnNewFile.Name = "BtnNewFile";
            this.BtnNewFile.Size = new System.Drawing.Size(176, 35);
            this.BtnNewFile.TabIndex = 5;
            this.BtnNewFile.Text = "Create file based on all files";
            this.BtnNewFile.UseVisualStyleBackColor = true;
            this.BtnNewFile.Click += new System.EventHandler(this.BtnNewFile_Click);
            // 
            // lblProcessing
            // 
            this.lblProcessing.AutoSize = true;
            this.lblProcessing.Location = new System.Drawing.Point(98, 9);
            this.lblProcessing.Name = "lblProcessing";
            this.lblProcessing.Size = new System.Drawing.Size(69, 13);
            this.lblProcessing.TabIndex = 7;
            this.lblProcessing.Text = "lblProcessing";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Processing files";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Elapsed time:";
            // 
            // lblElapsedT
            // 
            this.lblElapsedT.AutoSize = true;
            this.lblElapsedT.Location = new System.Drawing.Point(98, 22);
            this.lblElapsedT.Name = "lblElapsedT";
            this.lblElapsedT.Size = new System.Drawing.Size(62, 13);
            this.lblElapsedT.TabIndex = 9;
            this.lblElapsedT.Text = "lblElapsedT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Files processed:";
            // 
            // lblFileProc
            // 
            this.lblFileProc.AutoSize = true;
            this.lblFileProc.Location = new System.Drawing.Point(98, 35);
            this.lblFileProc.Name = "lblFileProc";
            this.lblFileProc.Size = new System.Drawing.Size(55, 13);
            this.lblFileProc.TabIndex = 11;
            this.lblFileProc.Text = "lblFileProc";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 264);
            this.Controls.Add(this.lblFileProc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblElapsedT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblProcessing);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnNewFile);
            this.Controls.Add(this.BtnGenerateFile);
            this.MinimumSize = new System.Drawing.Size(250, 200);
            this.Name = "Form1";
            this.Text = "Asynchronous reading and writing of files";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnGenerateFile;
        private System.Windows.Forms.Button BtnNewFile;
        private System.Windows.Forms.Label lblProcessing;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblElapsedT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblFileProc;
    }
}

