﻿
namespace EOPDTiPKP.Test2
{
    partial class Test2_7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Test2_7));
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.StartTesting = new System.Windows.Forms.Button();
            this.DateTestingButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.NameCompany = new System.Windows.Forms.Label();
            this.TimerLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.StartTesting);
            this.panel2.Controls.Add(this.DateTestingButton);
            this.panel2.Location = new System.Drawing.Point(4, 86);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(483, 114);
            this.panel2.TabIndex = 34;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button2.Location = new System.Drawing.Point(2, 78);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(473, 26);
            this.button2.TabIndex = 16;
            this.button2.Text = "Выгнать всех участников из конференции";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Location = new System.Drawing.Point(3, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(472, 28);
            this.button1.TabIndex = 15;
            this.button1.Text = "Подождать, пока конференцию закончится сама";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // StartTesting
            // 
            this.StartTesting.Cursor = System.Windows.Forms.Cursors.Default;
            this.StartTesting.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.StartTesting.Location = new System.Drawing.Point(219, 10);
            this.StartTesting.Name = "StartTesting";
            this.StartTesting.Size = new System.Drawing.Size(256, 28);
            this.StartTesting.TabIndex = 14;
            this.StartTesting.Text = "Нажать \"Завершить конференцию\"";
            this.StartTesting.UseVisualStyleBackColor = true;
            this.StartTesting.Click += new System.EventHandler(this.StartTesting_Click);
            // 
            // DateTestingButton
            // 
            this.DateTestingButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.DateTestingButton.Location = new System.Drawing.Point(3, 10);
            this.DateTestingButton.Name = "DateTestingButton";
            this.DateTestingButton.Size = new System.Drawing.Size(208, 28);
            this.DateTestingButton.TabIndex = 13;
            this.DateTestingButton.Text = "Выйти из конференции";
            this.DateTestingButton.UseVisualStyleBackColor = true;
            this.DateTestingButton.Click += new System.EventHandler(this.DateTestingButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(89, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 20);
            this.label1.TabIndex = 33;
            this.label1.Text = "Как правильно окончить конференцию?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // NameCompany
            // 
            this.NameCompany.AutoSize = true;
            this.NameCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameCompany.Location = new System.Drawing.Point(186, 9);
            this.NameCompany.Name = "NameCompany";
            this.NameCompany.Size = new System.Drawing.Size(133, 25);
            this.NameCompany.TabIndex = 32;
            this.NameCompany.Text = "Вопрос 7/10";
            this.NameCompany.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TimerLabel
            // 
            this.TimerLabel.AutoSize = true;
            this.TimerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TimerLabel.Location = new System.Drawing.Point(226, 233);
            this.TimerLabel.Name = "TimerLabel";
            this.TimerLabel.Size = new System.Drawing.Size(36, 25);
            this.TimerLabel.TabIndex = 36;
            this.TimerLabel.Text = "60";
            this.TimerLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(156, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 24);
            this.label2.TabIndex = 35;
            this.label2.Text = "Осталось времени";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Test2_7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 267);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameCompany);
            this.Controls.Add(this.TimerLabel);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Test2_7";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Навыки работы с программой ZOOM";
            this.Load += new System.EventHandler(this.Test2_7_Load);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button StartTesting;
        private System.Windows.Forms.Button DateTestingButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label NameCompany;
        private System.Windows.Forms.Label TimerLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
    }
}