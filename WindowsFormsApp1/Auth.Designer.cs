namespace WindowsFormsApp1
{
    partial class Auth
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
            this.textBoxLog = new System.Windows.Forms.TextBox();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.labelLog = new System.Windows.Forms.Label();
            this.labelPass = new System.Windows.Forms.Label();
            this.buttonEnt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxLog
            // 
            this.textBoxLog.Location = new System.Drawing.Point(175, 86);
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.Size = new System.Drawing.Size(158, 20);
            this.textBoxLog.TabIndex = 0;
            // 
            // textBoxPass
            // 
            this.textBoxPass.Location = new System.Drawing.Point(175, 156);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.Size = new System.Drawing.Size(158, 20);
            this.textBoxPass.TabIndex = 1;
            // 
            // labelLog
            // 
            this.labelLog.AutoSize = true;
            this.labelLog.Location = new System.Drawing.Point(231, 70);
            this.labelLog.Name = "labelLog";
            this.labelLog.Size = new System.Drawing.Size(38, 13);
            this.labelLog.TabIndex = 2;
            this.labelLog.Text = "Логин";
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.Location = new System.Drawing.Point(231, 140);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(45, 13);
            this.labelPass.TabIndex = 3;
            this.labelPass.Text = "Пароль";
            // 
            // buttonEnt
            // 
            this.buttonEnt.Location = new System.Drawing.Point(187, 212);
            this.buttonEnt.Name = "buttonEnt";
            this.buttonEnt.Size = new System.Drawing.Size(125, 38);
            this.buttonEnt.TabIndex = 4;
            this.buttonEnt.Text = "Войти";
            this.buttonEnt.UseVisualStyleBackColor = true;
            this.buttonEnt.Click += new System.EventHandler(this.buttonEnt_Click);
            // 
            // Auth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 373);
            this.Controls.Add(this.buttonEnt);
            this.Controls.Add(this.labelPass);
            this.Controls.Add(this.labelLog);
            this.Controls.Add(this.textBoxPass);
            this.Controls.Add(this.textBoxLog);
            this.Name = "Auth";
            this.Text = "Auth";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxLog;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.Label labelLog;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.Button buttonEnt;
    }
}