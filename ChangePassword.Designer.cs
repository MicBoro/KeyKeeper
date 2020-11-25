namespace KeyKeeper
{
    partial class ChangePassword
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.OldPassTxtbox = new System.Windows.Forms.TextBox();
            this.NewPassTxtbox = new System.Windows.Forms.TextBox();
            this.ConfirmPassTxtbox = new System.Windows.Forms.TextBox();
            this.ChangeBtn = new System.Windows.Forms.Button();
            this.CanceleBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(53, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Old Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(45, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "New Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(12, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Confirm Password: ";
            // 
            // OldPassTxtbox
            // 
            this.OldPassTxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.OldPassTxtbox.Location = new System.Drawing.Point(200, 15);
            this.OldPassTxtbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OldPassTxtbox.Name = "OldPassTxtbox";
            this.OldPassTxtbox.PasswordChar = '*';
            this.OldPassTxtbox.Size = new System.Drawing.Size(273, 30);
            this.OldPassTxtbox.TabIndex = 3;
            // 
            // NewPassTxtbox
            // 
            this.NewPassTxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NewPassTxtbox.Location = new System.Drawing.Point(200, 50);
            this.NewPassTxtbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NewPassTxtbox.Name = "NewPassTxtbox";
            this.NewPassTxtbox.PasswordChar = '*';
            this.NewPassTxtbox.Size = new System.Drawing.Size(273, 30);
            this.NewPassTxtbox.TabIndex = 4;
            // 
            // ConfirmPassTxtbox
            // 
            this.ConfirmPassTxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ConfirmPassTxtbox.Location = new System.Drawing.Point(200, 89);
            this.ConfirmPassTxtbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ConfirmPassTxtbox.Name = "ConfirmPassTxtbox";
            this.ConfirmPassTxtbox.PasswordChar = '*';
            this.ConfirmPassTxtbox.Size = new System.Drawing.Size(273, 30);
            this.ConfirmPassTxtbox.TabIndex = 5;
            // 
            // ChangeBtn
            // 
            this.ChangeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ChangeBtn.Location = new System.Drawing.Point(17, 146);
            this.ChangeBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ChangeBtn.Name = "ChangeBtn";
            this.ChangeBtn.Size = new System.Drawing.Size(149, 34);
            this.ChangeBtn.TabIndex = 6;
            this.ChangeBtn.Text = "Change";
            this.ChangeBtn.UseVisualStyleBackColor = true;
            this.ChangeBtn.Click += new System.EventHandler(this.ChangeBtn_Click);
            // 
            // CanceleBtn
            // 
            this.CanceleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CanceleBtn.Location = new System.Drawing.Point(323, 146);
            this.CanceleBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CanceleBtn.Name = "CanceleBtn";
            this.CanceleBtn.Size = new System.Drawing.Size(149, 34);
            this.CanceleBtn.TabIndex = 7;
            this.CanceleBtn.Text = "Cancel";
            this.CanceleBtn.UseVisualStyleBackColor = true;
            this.CanceleBtn.Click += new System.EventHandler(this.CanceleBtn_Click);
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 193);
            this.Controls.Add(this.CanceleBtn);
            this.Controls.Add(this.ChangeBtn);
            this.Controls.Add(this.ConfirmPassTxtbox);
            this.Controls.Add(this.NewPassTxtbox);
            this.Controls.Add(this.OldPassTxtbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ChangePassword";
            this.Text = "ChangePassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox OldPassTxtbox;
        private System.Windows.Forms.TextBox NewPassTxtbox;
        private System.Windows.Forms.TextBox ConfirmPassTxtbox;
        private System.Windows.Forms.Button ChangeBtn;
        private System.Windows.Forms.Button CanceleBtn;
    }
}