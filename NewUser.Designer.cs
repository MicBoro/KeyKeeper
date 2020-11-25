namespace KeyKeeper
{
    partial class NewUser
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
            this.CanceleBtn = new System.Windows.Forms.Button();
            this.CreateBtn = new System.Windows.Forms.Button();
            this.ConfirmPassTxtbox = new System.Windows.Forms.TextBox();
            this.PasswordTxtbox = new System.Windows.Forms.TextBox();
            this.UsernameTxtbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CanceleBtn
            // 
            this.CanceleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CanceleBtn.Location = new System.Drawing.Point(320, 114);
            this.CanceleBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CanceleBtn.Name = "CanceleBtn";
            this.CanceleBtn.Size = new System.Drawing.Size(149, 34);
            this.CanceleBtn.TabIndex = 15;
            this.CanceleBtn.Text = "Cancel";
            this.CanceleBtn.UseVisualStyleBackColor = true;
            this.CanceleBtn.Click += new System.EventHandler(this.CanceleBtn_Click);
            // 
            // CreateBtn
            // 
            this.CreateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CreateBtn.Location = new System.Drawing.Point(13, 114);
            this.CreateBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CreateBtn.Name = "CreateBtn";
            this.CreateBtn.Size = new System.Drawing.Size(149, 34);
            this.CreateBtn.TabIndex = 14;
            this.CreateBtn.Text = "Create";
            this.CreateBtn.UseVisualStyleBackColor = true;
            this.CreateBtn.Click += new System.EventHandler(this.CreateBtn_Click);
            // 
            // ConfirmPassTxtbox
            // 
            this.ConfirmPassTxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ConfirmPassTxtbox.Location = new System.Drawing.Point(197, 78);
            this.ConfirmPassTxtbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ConfirmPassTxtbox.Name = "ConfirmPassTxtbox";
            this.ConfirmPassTxtbox.PasswordChar = '*';
            this.ConfirmPassTxtbox.Size = new System.Drawing.Size(273, 30);
            this.ConfirmPassTxtbox.TabIndex = 13;
            // 
            // PasswordTxtbox
            // 
            this.PasswordTxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PasswordTxtbox.Location = new System.Drawing.Point(197, 39);
            this.PasswordTxtbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PasswordTxtbox.Name = "PasswordTxtbox";
            this.PasswordTxtbox.PasswordChar = '*';
            this.PasswordTxtbox.Size = new System.Drawing.Size(273, 30);
            this.PasswordTxtbox.TabIndex = 12;
            // 
            // UsernameTxtbox
            // 
            this.UsernameTxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.UsernameTxtbox.Location = new System.Drawing.Point(197, 4);
            this.UsernameTxtbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UsernameTxtbox.Name = "UsernameTxtbox";
            this.UsernameTxtbox.Size = new System.Drawing.Size(273, 30);
            this.UsernameTxtbox.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(9, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Confirm Password: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(71, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(61, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Username: ";
            // 
            // NewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 164);
            this.Controls.Add(this.CanceleBtn);
            this.Controls.Add(this.CreateBtn);
            this.Controls.Add(this.ConfirmPassTxtbox);
            this.Controls.Add(this.PasswordTxtbox);
            this.Controls.Add(this.UsernameTxtbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewUser";
            this.Text = "NewUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CanceleBtn;
        private System.Windows.Forms.Button CreateBtn;
        private System.Windows.Forms.TextBox ConfirmPassTxtbox;
        private System.Windows.Forms.TextBox PasswordTxtbox;
        private System.Windows.Forms.TextBox UsernameTxtbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}