
namespace StateTrafficInspectorateApp.Pages
{
    partial class TransitionPage
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
            this.DriverButton = new System.Windows.Forms.Button();
            this.LicenseButton = new System.Windows.Forms.Button();
            this.CarButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.GoBackButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // DriverButton
            // 
            this.DriverButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(213)))), ((int)(((byte)(202)))));
            this.DriverButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DriverButton.ForeColor = System.Drawing.Color.Black;
            this.DriverButton.Location = new System.Drawing.Point(167, 186);
            this.DriverButton.Name = "DriverButton";
            this.DriverButton.Size = new System.Drawing.Size(250, 90);
            this.DriverButton.TabIndex = 0;
            this.DriverButton.Text = "Водитель";
            this.DriverButton.UseVisualStyleBackColor = false;
            this.DriverButton.Click += new System.EventHandler(this.DriverButton_Click);
            // 
            // LicenseButton
            // 
            this.LicenseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(213)))), ((int)(((byte)(202)))));
            this.LicenseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LicenseButton.ForeColor = System.Drawing.Color.Black;
            this.LicenseButton.Location = new System.Drawing.Point(167, 311);
            this.LicenseButton.Name = "LicenseButton";
            this.LicenseButton.Size = new System.Drawing.Size(250, 90);
            this.LicenseButton.TabIndex = 1;
            this.LicenseButton.Text = "Лицензия";
            this.LicenseButton.UseVisualStyleBackColor = false;
            // 
            // CarButton
            // 
            this.CarButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(213)))), ((int)(((byte)(202)))));
            this.CarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CarButton.ForeColor = System.Drawing.Color.Black;
            this.CarButton.Location = new System.Drawing.Point(167, 441);
            this.CarButton.Name = "CarButton";
            this.CarButton.Size = new System.Drawing.Size(250, 90);
            this.CarButton.TabIndex = 2;
            this.CarButton.Text = "Машина";
            this.CarButton.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(48, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(504, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "Выберете таблицу для работы";
            // 
            // GoBackButton
            // 
            this.GoBackButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.GoBackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GoBackButton.Location = new System.Drawing.Point(506, 12);
            this.GoBackButton.Name = "GoBackButton";
            this.GoBackButton.Size = new System.Drawing.Size(96, 35);
            this.GoBackButton.TabIndex = 4;
            this.GoBackButton.Text = "Назад";
            this.GoBackButton.UseVisualStyleBackColor = false;
            this.GoBackButton.Click += new System.EventHandler(this.GoBackButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.panel1.Location = new System.Drawing.Point(-21, 126);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 510);
            this.panel1.TabIndex = 5;
            // 
            // TransitionPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(213)))), ((int)(((byte)(202)))));
            this.ClientSize = new System.Drawing.Size(614, 590);
            this.Controls.Add(this.GoBackButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CarButton);
            this.Controls.Add(this.LicenseButton);
            this.Controls.Add(this.DriverButton);
            this.Controls.Add(this.panel1);
            this.Name = "TransitionPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TransitionPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DriverButton;
        private System.Windows.Forms.Button LicenseButton;
        private System.Windows.Forms.Button CarButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button GoBackButton;
        private System.Windows.Forms.Panel panel1;
    }
}