namespace EOPDTiPKP
{
    partial class QuaSendForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuaSendForm));
            this.NameCompany = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.IdQuaField = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.SendQua_Button = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // NameCompany
            // 
            this.NameCompany.AutoSize = true;
            this.NameCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameCompany.Location = new System.Drawing.Point(30, 9);
            this.NameCompany.Name = "NameCompany";
            this.NameCompany.Size = new System.Drawing.Size(279, 50);
            this.NameCompany.TabIndex = 5;
            this.NameCompany.Text = "Отправка заявки на\r\nповышение квалификации";
            this.NameCompany.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLogin.Location = new System.Drawing.Point(3, 7);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(121, 16);
            this.labelLogin.TabIndex = 7;
            this.labelLogin.Text = "ID спецификации";
            this.labelLogin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // IdQuaField
            // 
            this.IdQuaField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IdQuaField.Location = new System.Drawing.Point(3, 26);
            this.IdQuaField.Name = "IdQuaField";
            this.IdQuaField.Size = new System.Drawing.Size(178, 26);
            this.IdQuaField.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.SendQua_Button);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.IdQuaField);
            this.panel2.Controls.Add(this.labelLogin);
            this.panel2.Location = new System.Drawing.Point(12, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(309, 149);
            this.panel2.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(1, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 72);
            this.label1.TabIndex = 8;
            this.label1.Text = "Для ознакомления со списком доступных \r\nспецификаций, нажмите на клавишу\r\n\"Просмо" +
    "треть доступные квалификации\"\r\nв главном меню данного ПО.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // SendQua_Button
            // 
            this.SendQua_Button.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.SendQua_Button.Location = new System.Drawing.Point(187, 26);
            this.SendQua_Button.Name = "SendQua_Button";
            this.SendQua_Button.Size = new System.Drawing.Size(108, 23);
            this.SendQua_Button.TabIndex = 14;
            this.SendQua_Button.Text = "Подать заявку";
            this.SendQua_Button.UseVisualStyleBackColor = true;
            this.SendQua_Button.Click += new System.EventHandler(this.SendQua_Button_Click);
            // 
            // QuaSendForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 223);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.NameCompany);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "QuaSendForm";
            this.Text = "Повышение квалификации";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameCompany;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.TextBox IdQuaField;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SendQua_Button;
    }
}