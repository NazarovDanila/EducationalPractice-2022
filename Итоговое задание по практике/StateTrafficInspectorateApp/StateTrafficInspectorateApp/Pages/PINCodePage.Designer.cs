
namespace StateTrafficInspectorateApp.Pages
{
    partial class PINCodePage
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
            this.PINlabel = new System.Windows.Forms.Label();
            this.PINField = new System.Windows.Forms.TextBox();
            this.RemarkLabel = new System.Windows.Forms.Label();
            this.PageNameLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LoginButton = new System.Windows.Forms.Button();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PINlabel
            // 
            this.PINlabel.AutoSize = true;
            this.PINlabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.PINlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PINlabel.ForeColor = System.Drawing.Color.Black;
            this.PINlabel.Location = new System.Drawing.Point(239, 64);
            this.PINlabel.Name = "PINlabel";
            this.PINlabel.Size = new System.Drawing.Size(91, 32);
            this.PINlabel.TabIndex = 0;
            this.PINlabel.Text = "PIN-L";
            this.PINlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PINField
            // 
            this.PINField.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PINField.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.PINField.ForeColor = System.Drawing.Color.Black;
            this.PINField.Location = new System.Drawing.Point(118, 241);
            this.PINField.Margin = new System.Windows.Forms.Padding(4);
            this.PINField.Name = "PINField";
            this.PINField.Size = new System.Drawing.Size(341, 46);
            this.PINField.TabIndex = 6;
            // 
            // RemarkLabel
            // 
            this.RemarkLabel.AutoSize = true;
            this.RemarkLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.RemarkLabel.ForeColor = System.Drawing.Color.Black;
            this.RemarkLabel.Location = new System.Drawing.Point(45, 152);
            this.RemarkLabel.Name = "RemarkLabel";
            this.RemarkLabel.Size = new System.Drawing.Size(524, 34);
            this.RemarkLabel.TabIndex = 8;
            this.RemarkLabel.Text = "(В данной версии программы PIN-код выводится вам на экран. В дальнейших \r\nобновен" +
    "иях код будет отправляться на телефон пользователю.)";
            this.RemarkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PageNameLabel
            // 
            this.PageNameLabel.AutoSize = true;
            this.PageNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PageNameLabel.ForeColor = System.Drawing.Color.Black;
            this.PageNameLabel.Location = new System.Drawing.Point(98, 24);
            this.PageNameLabel.Name = "PageNameLabel";
            this.PageNameLabel.Size = new System.Drawing.Size(349, 46);
            this.PageNameLabel.TabIndex = 9;
            this.PageNameLabel.Text = "Введите PIN-код";
            this.PageNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.panel1.Controls.Add(this.LoginButton);
            this.panel1.Controls.Add(this.PINlabel);
            this.panel1.Controls.Add(this.RemarkLabel);
            this.panel1.Controls.Add(this.PINField);
            this.panel1.Location = new System.Drawing.Point(-12, 97);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(646, 485);
            this.panel1.TabIndex = 10;
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(213)))), ((int)(((byte)(202)))));
            this.LoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginButton.ForeColor = System.Drawing.Color.Black;
            this.LoginButton.Location = new System.Drawing.Point(178, 350);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(218, 64);
            this.LoginButton.TabIndex = 4;
            this.LoginButton.Text = "ВОЙТИ";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click_1);
            // 
            // btnGoBack
            // 
            this.btnGoBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.btnGoBack.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnGoBack.ForeColor = System.Drawing.Color.Black;
            this.btnGoBack.Location = new System.Drawing.Point(490, 12);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(80, 45);
            this.btnGoBack.TabIndex = 9;
            this.btnGoBack.Text = "Назад";
            this.btnGoBack.UseVisualStyleBackColor = false;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // PINCodePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(213)))), ((int)(((byte)(202)))));
            this.ClientSize = new System.Drawing.Size(582, 553);
            this.Controls.Add(this.btnGoBack);
            this.Controls.Add(this.PageNameLabel);
            this.Controls.Add(this.panel1);
            this.Name = "PINCodePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PINCodePage";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PINlabel;
        private System.Windows.Forms.TextBox PINField;
        private System.Windows.Forms.Label RemarkLabel;
        private System.Windows.Forms.Label PageNameLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Button btnGoBack;
    }
}