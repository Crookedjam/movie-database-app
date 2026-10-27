namespace _2200_GardnerA_Participation04
{
    partial class LandingForm
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
            this.BtnLocalPhoneNums = new System.Windows.Forms.Button();
            this.BtnImportedPhoneNums = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnOnlinePhoneNums = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnLocalPhoneNums
            // 
            this.BtnLocalPhoneNums.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLocalPhoneNums.Location = new System.Drawing.Point(154, 56);
            this.BtnLocalPhoneNums.Name = "BtnLocalPhoneNums";
            this.BtnLocalPhoneNums.Size = new System.Drawing.Size(343, 192);
            this.BtnLocalPhoneNums.TabIndex = 0;
            this.BtnLocalPhoneNums.Text = "&Local Phone Numbers";
            this.BtnLocalPhoneNums.UseVisualStyleBackColor = true;
            this.BtnLocalPhoneNums.Click += new System.EventHandler(this.BtnLocalPhoneNums_Click);
            // 
            // BtnImportedPhoneNums
            // 
            this.BtnImportedPhoneNums.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnImportedPhoneNums.Location = new System.Drawing.Point(648, 56);
            this.BtnImportedPhoneNums.Name = "BtnImportedPhoneNums";
            this.BtnImportedPhoneNums.Size = new System.Drawing.Size(343, 192);
            this.BtnImportedPhoneNums.TabIndex = 1;
            this.BtnImportedPhoneNums.Text = "&Imported Phone Numbers";
            this.BtnImportedPhoneNums.UseVisualStyleBackColor = true;
            this.BtnImportedPhoneNums.Click += new System.EventHandler(this.BtnImportedPhoneNums_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.Location = new System.Drawing.Point(648, 316);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(343, 192);
            this.BtnClose.TabIndex = 1;
            this.BtnClose.Text = "&Close";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnOnlinePhoneNums
            // 
            this.BtnOnlinePhoneNums.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOnlinePhoneNums.Location = new System.Drawing.Point(154, 316);
            this.BtnOnlinePhoneNums.Name = "BtnOnlinePhoneNums";
            this.BtnOnlinePhoneNums.Size = new System.Drawing.Size(343, 192);
            this.BtnOnlinePhoneNums.TabIndex = 1;
            this.BtnOnlinePhoneNums.Text = "&Online Phone Numbers";
            this.BtnOnlinePhoneNums.UseVisualStyleBackColor = true;
            this.BtnOnlinePhoneNums.Click += new System.EventHandler(this.BtnOnlinePhoneNums_Click);
            // 
            // LandingForm
            // 
            this.AcceptButton = this.BtnLocalPhoneNums;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnClose;
            this.ClientSize = new System.Drawing.Size(1145, 623);
            this.Controls.Add(this.BtnOnlinePhoneNums);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnImportedPhoneNums);
            this.Controls.Add(this.BtnLocalPhoneNums);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.LandingForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnLocalPhoneNums;
        private System.Windows.Forms.Button BtnImportedPhoneNums;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button BtnOnlinePhoneNums;
    }
}

