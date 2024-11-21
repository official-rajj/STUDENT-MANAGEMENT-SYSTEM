namespace STUDENT_MANAGEMENT_SYSTEM
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            lblname = new Label();
            lblbranch = new Label();
            lblsemester = new Label();
            txtname = new TextBox();
            txtbranch = new TextBox();
            txtsemester = new TextBox();
            btnregister = new Button();
            label2 = new Label();
            btnlogin = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(316, 58);
            label1.Name = "label1";
            label1.Size = new Size(175, 23);
            label1.TabIndex = 0;
            label1.Text = "REGISTRATION FORM";
            // 
            // lblname
            // 
            lblname.AutoSize = true;
            lblname.Location = new Point(174, 121);
            lblname.Name = "lblname";
            lblname.Size = new Size(51, 20);
            lblname.TabIndex = 1;
            lblname.Text = "NAME";
            // 
            // lblbranch
            // 
            lblbranch.AutoSize = true;
            lblbranch.Location = new Point(174, 187);
            lblbranch.Name = "lblbranch";
            lblbranch.Size = new Size(68, 20);
            lblbranch.TabIndex = 2;
            lblbranch.Text = "BRANCH";
            // 
            // lblsemester
            // 
            lblsemester.AutoSize = true;
            lblsemester.Location = new Point(174, 257);
            lblsemester.Name = "lblsemester";
            lblsemester.Size = new Size(79, 20);
            lblsemester.TabIndex = 3;
            lblsemester.Text = "SEMESTER";
            // 
            // txtname
            // 
            txtname.Location = new Point(316, 114);
            txtname.Name = "txtname";
            txtname.Size = new Size(202, 27);
            txtname.TabIndex = 4;
            // 
            // txtbranch
            // 
            txtbranch.Location = new Point(316, 180);
            txtbranch.Name = "txtbranch";
            txtbranch.Size = new Size(202, 27);
            txtbranch.TabIndex = 5;
            // 
            // txtsemester
            // 
            txtsemester.Location = new Point(316, 250);
            txtsemester.Name = "txtsemester";
            txtsemester.Size = new Size(202, 27);
            txtsemester.TabIndex = 6;
            // 
            // btnregister
            // 
            btnregister.Location = new Point(366, 328);
            btnregister.Name = "btnregister";
            btnregister.Size = new Size(94, 29);
            btnregister.TabIndex = 7;
            btnregister.Text = "Register !";
            btnregister.UseVisualStyleBackColor = true;
            btnregister.Click += btnregister_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(218, 404);
            label2.Name = "label2";
            label2.Size = new Size(116, 23);
            label2.TabIndex = 8;
            label2.Text = "Already User !";
            // 
            // btnlogin
            // 
            btnlogin.Location = new Point(366, 398);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(94, 29);
            btnlogin.TabIndex = 9;
            btnlogin.Text = "Login";
            btnlogin.UseVisualStyleBackColor = true;
            btnlogin.Click += btnlogin_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(795, 577);
            Controls.Add(btnlogin);
            Controls.Add(label2);
            Controls.Add(btnregister);
            Controls.Add(txtsemester);
            Controls.Add(txtbranch);
            Controls.Add(txtname);
            Controls.Add(lblsemester);
            Controls.Add(lblbranch);
            Controls.Add(lblname);
            Controls.Add(label1);
            Name = "Form1";
            Text = "STUDENT REGISTRATION FORM";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblname;
        private Label lblbranch;
        private Label lblsemester;
        private TextBox txtname;
        private TextBox txtbranch;
        private TextBox txtsemester;
        private Button btnregister;
        private Label label2;
        private Button btnlogin;
    }
}
