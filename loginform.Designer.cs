namespace STUDENT_MANAGEMENT_SYSTEM
{
    partial class loginform
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
            label1 = new Label();
            lblusername = new Label();
            lblpassword = new Label();
            usertxt = new TextBox();
            passtext = new TextBox();
            btnlogin2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(296, 44);
            label1.Name = "label1";
            label1.Size = new Size(175, 23);
            label1.TabIndex = 0;
            label1.Text = "LOGIN DASHBOARD";
            // 
            // lblusername
            // 
            lblusername.AutoSize = true;
            lblusername.Location = new Point(168, 124);
            lblusername.Name = "lblusername";
            lblusername.Size = new Size(78, 20);
            lblusername.TabIndex = 1;
            lblusername.Text = "Username:";
            // 
            // lblpassword
            // 
            lblpassword.AutoSize = true;
            lblpassword.Location = new Point(168, 202);
            lblpassword.Name = "lblpassword";
            lblpassword.Size = new Size(73, 20);
            lblpassword.TabIndex = 2;
            lblpassword.Text = "Password:";
            // 
            // usertxt
            // 
            usertxt.Location = new Point(310, 124);
            usertxt.Name = "usertxt";
            usertxt.Size = new Size(197, 27);
            usertxt.TabIndex = 3;
            // 
            // passtext
            // 
            passtext.Location = new Point(310, 195);
            passtext.Name = "passtext";
            passtext.Size = new Size(197, 27);
            passtext.TabIndex = 4;
            // 
            // btnlogin2
            // 
            btnlogin2.Location = new Point(331, 271);
            btnlogin2.Name = "btnlogin2";
            btnlogin2.Size = new Size(104, 33);
            btnlogin2.TabIndex = 5;
            btnlogin2.Text = "Login";
            btnlogin2.UseVisualStyleBackColor = true;
            btnlogin2.Click += btnlogin2_Click;
            // 
            // loginform
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnlogin2);
            Controls.Add(passtext);
            Controls.Add(usertxt);
            Controls.Add(lblpassword);
            Controls.Add(lblusername);
            Controls.Add(label1);
            Name = "loginform";
            Text = "loginform";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblusername;
        private Label lblpassword;
        private TextBox usertxt;
        private TextBox passtext;
        private Button btnlogin2;
    }
}