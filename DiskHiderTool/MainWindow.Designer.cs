namespace DriveHiderTool
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.ShowButton = new System.Windows.Forms.Button();
            this.HideButton = new System.Windows.Forms.Button();
            this.DrivesList = new System.Windows.Forms.ComboBox();
            this.ChooseDriveHint = new System.Windows.Forms.Label();
            this.AboutHint = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ShowButton
            // 
            this.ShowButton.Location = new System.Drawing.Point(174, 60);
            this.ShowButton.Name = "ShowButton";
            this.ShowButton.Size = new System.Drawing.Size(125, 23);
            this.ShowButton.TabIndex = 0;
            this.ShowButton.Text = "RESTORE DRIVE";
            this.ShowButton.UseVisualStyleBackColor = true;
            this.ShowButton.Click += new System.EventHandler(this.ShowButton_Click);
            // 
            // HideButton
            // 
            this.HideButton.Location = new System.Drawing.Point(23, 60);
            this.HideButton.Name = "HideButton";
            this.HideButton.Size = new System.Drawing.Size(125, 23);
            this.HideButton.TabIndex = 1;
            this.HideButton.Text = "HIDE DRIVE";
            this.HideButton.UseVisualStyleBackColor = true;
            this.HideButton.Click += new System.EventHandler(this.HideButton_Click);
            // 
            // DrivesList
            // 
            this.DrivesList.FormattingEnabled = true;
            this.DrivesList.Location = new System.Drawing.Point(219, 23);
            this.DrivesList.Name = "DrivesList";
            this.DrivesList.Size = new System.Drawing.Size(91, 21);
            this.DrivesList.TabIndex = 2;
            // 
            // ChooseDriveHint
            // 
            this.ChooseDriveHint.AutoSize = true;
            this.ChooseDriveHint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ChooseDriveHint.Location = new System.Drawing.Point(12, 23);
            this.ChooseDriveHint.Name = "ChooseDriveHint";
            this.ChooseDriveHint.Size = new System.Drawing.Size(199, 20);
            this.ChooseDriveHint.TabIndex = 3;
            this.ChooseDriveHint.Text = "CHOOSE ACTIVE DRIVE:";
            // 
            // AboutHint
            // 
            this.AboutHint.AutoSize = true;
            this.AboutHint.Location = new System.Drawing.Point(59, 97);
            this.AboutHint.Name = "AboutHint";
            this.AboutHint.Size = new System.Drawing.Size(203, 13);
            this.AboutHint.TabIndex = 4;
            this.AboutHint.Text = "GrakovNe - Пробуя, создавать лучшее!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Blog: http://grakovne.org";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(88, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "E-Mail: grakovne@yandex.ru";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 174);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AboutHint);
            this.Controls.Add(this.ChooseDriveHint);
            this.Controls.Add(this.DrivesList);
            this.Controls.Add(this.HideButton);
            this.Controls.Add(this.ShowButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Drive Hider 1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ShowButton;
        private System.Windows.Forms.Button HideButton;
        private System.Windows.Forms.ComboBox DrivesList;
        private System.Windows.Forms.Label ChooseDriveHint;
        private System.Windows.Forms.Label AboutHint;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

