namespace EOPDTiPKP
{
    partial class MenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.Help_Button = new System.Windows.Forms.Button();
            this.NameLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.IDLabel = new System.Windows.Forms.Label();
            this.IDLabelText = new System.Windows.Forms.Label();
            this.Fio = new System.Windows.Forms.Label();
            this.Info1 = new System.Windows.Forms.Label();
            this.Info2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.StartTesting = new System.Windows.Forms.Button();
            this.DateTestingButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.Test_Results = new System.Windows.Forms.Button();
            this.Test2_button = new System.Windows.Forms.Button();
            this.Test1_button = new System.Windows.Forms.Button();
            this.Info3 = new System.Windows.Forms.Label();
            this.Exit_Button = new System.Windows.Forms.Button();
            this.NameCompany = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Help_Button
            // 
            this.Help_Button.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Help_Button.Location = new System.Drawing.Point(17, 429);
            this.Help_Button.Name = "Help_Button";
            this.Help_Button.Size = new System.Drawing.Size(142, 23);
            this.Help_Button.TabIndex = 1;
            this.Help_Button.Text = "Техническая поддержка";
            this.Help_Button.UseVisualStyleBackColor = true;
            this.Help_Button.Click += new System.EventHandler(this.Help_Button_Click);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLabel.Location = new System.Drawing.Point(55, 25);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(225, 24);
            this.NameLabel.TabIndex = 5;
            this.NameLabel.Text = "Фамилия Имя Отчество";
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.IDLabel);
            this.panel1.Controls.Add(this.IDLabelText);
            this.panel1.Controls.Add(this.Fio);
            this.panel1.Controls.Add(this.NameLabel);
            this.panel1.Location = new System.Drawing.Point(12, 128);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(360, 56);
            this.panel1.TabIndex = 6;
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IDLabel.Location = new System.Drawing.Point(26, 1);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(40, 24);
            this.IDLabel.TabIndex = 8;
            this.IDLabel.Text = "000";
            this.IDLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // IDLabelText
            // 
            this.IDLabelText.AutoSize = true;
            this.IDLabelText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IDLabelText.Location = new System.Drawing.Point(1, 0);
            this.IDLabelText.Name = "IDLabelText";
            this.IDLabelText.Size = new System.Drawing.Size(32, 24);
            this.IDLabelText.TabIndex = 7;
            this.IDLabelText.Text = "ID:";
            this.IDLabelText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Fio
            // 
            this.Fio.AutoSize = true;
            this.Fio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Fio.Location = new System.Drawing.Point(0, 25);
            this.Fio.Name = "Fio";
            this.Fio.Size = new System.Drawing.Size(59, 24);
            this.Fio.TabIndex = 6;
            this.Fio.Text = "ФИО:";
            this.Fio.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Info1
            // 
            this.Info1.AutoSize = true;
            this.Info1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Info1.Location = new System.Drawing.Point(12, 105);
            this.Info1.Name = "Info1";
            this.Info1.Size = new System.Drawing.Size(168, 20);
            this.Info1.TabIndex = 6;
            this.Info1.Text = "Личная информация";
            this.Info1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Info2
            // 
            this.Info2.AutoSize = true;
            this.Info2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Info2.Location = new System.Drawing.Point(12, 192);
            this.Info2.Name = "Info2";
            this.Info2.Size = new System.Drawing.Size(245, 20);
            this.Info2.TabIndex = 7;
            this.Info2.Text = "Модуль личного тестирования";
            this.Info2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.StartTesting);
            this.panel2.Controls.Add(this.DateTestingButton);
            this.panel2.Location = new System.Drawing.Point(12, 215);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(360, 57);
            this.panel2.TabIndex = 8;
            // 
            // StartTesting
            // 
            this.StartTesting.Cursor = System.Windows.Forms.Cursors.Default;
            this.StartTesting.Enabled = false;
            this.StartTesting.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.StartTesting.Location = new System.Drawing.Point(207, 15);
            this.StartTesting.Name = "StartTesting";
            this.StartTesting.Size = new System.Drawing.Size(146, 23);
            this.StartTesting.TabIndex = 14;
            this.StartTesting.Text = "Начать тестирование";
            this.StartTesting.UseVisualStyleBackColor = true;
            // 
            // DateTestingButton
            // 
            this.DateTestingButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.DateTestingButton.Location = new System.Drawing.Point(3, 15);
            this.DateTestingButton.Name = "DateTestingButton";
            this.DateTestingButton.Size = new System.Drawing.Size(198, 23);
            this.DateTestingButton.TabIndex = 13;
            this.DateTestingButton.Text = "Просмотреть даты проведения тестирования";
            this.DateTestingButton.UseVisualStyleBackColor = true;
            this.DateTestingButton.Click += new System.EventHandler(this.DateTestingButton_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.Test_Results);
            this.panel3.Controls.Add(this.Test2_button);
            this.panel3.Controls.Add(this.Test1_button);
            this.panel3.Location = new System.Drawing.Point(12, 305);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(360, 118);
            this.panel3.TabIndex = 10;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Location = new System.Drawing.Point(21, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(216, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Рекомендуемые материалы";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Test_Results
            // 
            this.Test_Results.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Test_Results.Location = new System.Drawing.Point(244, 84);
            this.Test_Results.Name = "Test_Results";
            this.Test_Results.Size = new System.Drawing.Size(95, 23);
            this.Test_Results.TabIndex = 16;
            this.Test_Results.Text = "Результаты";
            this.Test_Results.UseVisualStyleBackColor = true;
            this.Test_Results.Click += new System.EventHandler(this.Test_Results_Click);
            // 
            // Test2_button
            // 
            this.Test2_button.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Test2_button.Location = new System.Drawing.Point(21, 40);
            this.Test2_button.Name = "Test2_button";
            this.Test2_button.Size = new System.Drawing.Size(318, 23);
            this.Test2_button.TabIndex = 15;
            this.Test2_button.Text = "Навыки работы с программой ZOOM";
            this.Test2_button.UseVisualStyleBackColor = true;
            this.Test2_button.Click += new System.EventHandler(this.Test2_button_Click);
            // 
            // Test1_button
            // 
            this.Test1_button.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Test1_button.Location = new System.Drawing.Point(21, 9);
            this.Test1_button.Name = "Test1_button";
            this.Test1_button.Size = new System.Drawing.Size(318, 23);
            this.Test1_button.TabIndex = 14;
            this.Test1_button.Text = "Знание государственных образовательных стандартов";
            this.Test1_button.UseVisualStyleBackColor = true;
            this.Test1_button.Click += new System.EventHandler(this.Test1_button_Click);
            // 
            // Info3
            // 
            this.Info3.AutoSize = true;
            this.Info3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Info3.Location = new System.Drawing.Point(12, 282);
            this.Info3.Name = "Info3";
            this.Info3.Size = new System.Drawing.Size(239, 20);
            this.Info3.TabIndex = 9;
            this.Info3.Text = "Модуль общего тестирования";
            this.Info3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Exit_Button
            // 
            this.Exit_Button.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Exit_Button.Location = new System.Drawing.Point(311, 429);
            this.Exit_Button.Name = "Exit_Button";
            this.Exit_Button.Size = new System.Drawing.Size(56, 23);
            this.Exit_Button.TabIndex = 11;
            this.Exit_Button.Text = "Выход";
            this.Exit_Button.UseVisualStyleBackColor = true;
            this.Exit_Button.Click += new System.EventHandler(this.Exit_Button_Click);
            // 
            // NameCompany
            // 
            this.NameCompany.AutoSize = true;
            this.NameCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameCompany.Location = new System.Drawing.Point(30, 9);
            this.NameCompany.Name = "NameCompany";
            this.NameCompany.Size = new System.Drawing.Size(329, 75);
            this.NameCompany.TabIndex = 12;
            this.NameCompany.Text = "Единый онлайн портал для \r\nтестирования и повышения \r\nквалификации преподавателей" +
    "\r\n";
            this.NameCompany.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 464);
            this.Controls.Add(this.NameCompany);
            this.Controls.Add(this.Exit_Button);
            this.Controls.Add(this.Help_Button);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.Info3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Info2);
            this.Controls.Add(this.Info1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MenuForm";
            this.Text = "Главное меню";
            this.Load += new System.EventHandler(this.MenuForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Help_Button;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Info1;
        private System.Windows.Forms.Label Fio;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.Label IDLabelText;
        private System.Windows.Forms.Label Info2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label Info3;
        private System.Windows.Forms.Button Exit_Button;
        private System.Windows.Forms.Button StartTesting;
        private System.Windows.Forms.Button DateTestingButton;
        private System.Windows.Forms.Button Test_Results;
        private System.Windows.Forms.Button Test2_button;
        private System.Windows.Forms.Button Test1_button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label NameCompany;
    }
}