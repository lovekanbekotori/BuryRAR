namespace BuryRAR
{
    partial class buryRAR
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
            this.rarFileTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rarFileBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.baseFileTxtBox = new System.Windows.Forms.TextBox();
            this.baseFileBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.newFileTxtBox = new System.Windows.Forms.TextBox();
            this.buryRarBtn = new System.Windows.Forms.Button();
            this.rarFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.baseFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // rarFileTxtBox
            // 
            this.rarFileTxtBox.Location = new System.Drawing.Point(70, 6);
            this.rarFileTxtBox.Name = "rarFileTxtBox";
            this.rarFileTxtBox.ReadOnly = true;
            this.rarFileTxtBox.Size = new System.Drawing.Size(202, 20);
            this.rarFileTxtBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "RAR File:";
            // 
            // rarFileBtn
            // 
            this.rarFileBtn.Location = new System.Drawing.Point(278, 6);
            this.rarFileBtn.Name = "rarFileBtn";
            this.rarFileBtn.Size = new System.Drawing.Size(24, 20);
            this.rarFileBtn.TabIndex = 2;
            this.rarFileBtn.Text = "...";
            this.rarFileBtn.UseVisualStyleBackColor = true;
            this.rarFileBtn.Click += new System.EventHandler(this.rarFileBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Base File:";
            // 
            // baseFileTxtBox
            // 
            this.baseFileTxtBox.Location = new System.Drawing.Point(70, 32);
            this.baseFileTxtBox.Name = "baseFileTxtBox";
            this.baseFileTxtBox.ReadOnly = true;
            this.baseFileTxtBox.Size = new System.Drawing.Size(202, 20);
            this.baseFileTxtBox.TabIndex = 4;
            // 
            // baseFileBtn
            // 
            this.baseFileBtn.Location = new System.Drawing.Point(278, 32);
            this.baseFileBtn.Name = "baseFileBtn";
            this.baseFileBtn.Size = new System.Drawing.Size(24, 20);
            this.baseFileBtn.TabIndex = 5;
            this.baseFileBtn.Text = "...";
            this.baseFileBtn.UseVisualStyleBackColor = true;
            this.baseFileBtn.Click += new System.EventHandler(this.baseFileBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "New File:";
            // 
            // newFileTxtBox
            // 
            this.newFileTxtBox.Location = new System.Drawing.Point(70, 58);
            this.newFileTxtBox.Name = "newFileTxtBox";
            this.newFileTxtBox.Size = new System.Drawing.Size(232, 20);
            this.newFileTxtBox.TabIndex = 7;
            // 
            // buryRarBtn
            // 
            this.buryRarBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buryRarBtn.Location = new System.Drawing.Point(15, 84);
            this.buryRarBtn.Name = "buryRarBtn";
            this.buryRarBtn.Size = new System.Drawing.Size(287, 34);
            this.buryRarBtn.TabIndex = 8;
            this.buryRarBtn.Text = "BuryRAR";
            this.buryRarBtn.UseVisualStyleBackColor = false;
            this.buryRarBtn.Click += new System.EventHandler(this.buryRarBtn_Click);
            // 
            // rarFileDialog
            // 
            this.rarFileDialog.FileName = "RAR File";
            // 
            // baseFileDialog
            // 
            this.baseFileDialog.FileName = "Base File";
            // 
            // buryRAR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 126);
            this.Controls.Add(this.buryRarBtn);
            this.Controls.Add(this.newFileTxtBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.baseFileBtn);
            this.Controls.Add(this.baseFileTxtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rarFileBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rarFileTxtBox);
            this.Name = "buryRAR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BuryRAR v1.0";
            this.Load += new System.EventHandler(this.buryRAR_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox rarFileTxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button rarFileBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox baseFileTxtBox;
        private System.Windows.Forms.Button baseFileBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox newFileTxtBox;
        private System.Windows.Forms.Button buryRarBtn;
        private System.Windows.Forms.OpenFileDialog rarFileDialog;
        private System.Windows.Forms.OpenFileDialog baseFileDialog;
    }
}

