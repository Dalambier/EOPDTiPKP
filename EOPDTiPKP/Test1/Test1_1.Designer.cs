﻿
namespace EOPDTiPKP.Test1
{
    partial class Test1_1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Test1_1));
            this.NameCompany = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.StartTesting = new System.Windows.Forms.Button();
            this.DateTestingButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TimerLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // NameCompany
            // 
            this.NameCompany.AutoSize = true;
            this.NameCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameCompany.Location = new System.Drawing.Point(185, 23);
            this.NameCompany.Name = "NameCompany";
            this.NameCompany.Size = new System.Drawing.Size(133, 25);
            this.NameCompany.TabIndex = 5;
            this.NameCompany.Text = "Вопрос 1/10";
            this.NameCompany.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(36, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(413, 100);
            this.label1.TabIndex = 6;
            this.label1.Text = resources.GetString("label1.Text");
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.StartTesting);
            this.panel2.Controls.Add(this.DateTestingButton);
            this.panel2.Location = new System.Drawing.Point(10, 167);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(486, 123);
            this.panel2.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button2.Location = new System.Drawing.Point(248, 71);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(231, 36);
            this.button2.TabIndex = 16;
            this.button2.Text = "Послание Президента Федеральному Собранию";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Location = new System.Drawing.Point(3, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(232, 36);
            this.button1.TabIndex = 15;
            this.button1.Text = "Концепция долгосрочного социально-экономического развития РФ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // StartTesting
            // 
            this.StartTesting.Cursor = System.Windows.Forms.Cursors.Default;
            this.StartTesting.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.StartTesting.Location = new System.Drawing.Point(248, 15);
            this.StartTesting.Name = "StartTesting";
            this.StartTesting.Size = new System.Drawing.Size(231, 50);
            this.StartTesting.TabIndex = 14;
            this.StartTesting.Text = "Фундаментальное ядро содержания общего образования";
            this.StartTesting.UseVisualStyleBackColor = true;
            this.StartTesting.Click += new System.EventHandler(this.StartTesting_Click);
            // 
            // DateTestingButton
            // 
            this.DateTestingButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.DateTestingButton.Location = new System.Drawing.Point(3, 15);
            this.DateTestingButton.Name = "DateTestingButton";
            this.DateTestingButton.Size = new System.Drawing.Size(232, 50);
            this.DateTestingButton.TabIndex = 13;
            this.DateTestingButton.Text = "Концепция духовно-нравственного развития и воспитания личности гражданина";
            this.DateTestingButton.UseVisualStyleBackColor = true;
            this.DateTestingButton.Click += new System.EventHandler(this.DateTestingButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(158, 297);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "Осталось времени";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TimerLabel
            // 
            this.TimerLabel.AutoSize = true;
            this.TimerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TimerLabel.Location = new System.Drawing.Point(229, 327);
            this.TimerLabel.Name = "TimerLabel";
            this.TimerLabel.Size = new System.Drawing.Size(36, 25);
            this.TimerLabel.TabIndex = 11;
            this.TimerLabel.Text = "60";
            this.TimerLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Test1_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 354);
            this.Controls.Add(this.TimerLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameCompany);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Test1_1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Знание государственных образовательных стандартов";
            this.Load += new System.EventHandler(this.Test1_1_Load);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameCompany;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button StartTesting;
        private System.Windows.Forms.Button DateTestingButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label TimerLabel;
        private System.Windows.Forms.Timer timer1;
    }
}