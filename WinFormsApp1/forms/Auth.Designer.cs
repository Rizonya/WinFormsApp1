
namespace WinFormsApp1
{
    partial class Auth
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
            button1 = new Button();
            passwordtb = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            label4 = new Label();
            label5 = new Label();
            usernametb = new MaskedTextBox();
            button2 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(243, 253);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Войти";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // passwordtb
            // 
            passwordtb.BackColor = Color.Plum;
            passwordtb.ForeColor = SystemColors.Control;
            passwordtb.Location = new Point(12, 192);
            passwordtb.Name = "passwordtb";
            passwordtb.Size = new Size(306, 23);
            passwordtb.TabIndex = 2;
            passwordtb.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Plum;
            label1.Location = new Point(12, 107);
            label1.Name = "label1";
            label1.Size = new Size(101, 15);
            label1.TabIndex = 3;
            label1.Text = "Номер телефона";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 174);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 4;
            label2.Text = "Пароль";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(123, 39);
            label3.Name = "label3";
            label3.Size = new Size(95, 15);
            label3.TabIndex = 5;
            label3.Text = "Клининг сервис";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 192, 255);
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(348, 100);
            panel1.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 308);
            label4.Name = "label4";
            label4.Size = new Size(83, 15);
            label4.TabIndex = 7;
            label4.Text = "Нет аккаунта?";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.ForeColor = Color.White;
            label5.Location = new Point(118, 308);
            label5.Name = "label5";
            label5.Size = new Size(125, 15);
            label5.TabIndex = 8;
            label5.Text = "Зарегистрироваться";
            label5.Click += label5_Click;
            // 
            // usernametb
            // 
            usernametb.BackColor = Color.Plum;
            usernametb.Location = new Point(13, 125);
            usernametb.Mask = "+7 (900) 000-00-00";
            usernametb.Name = "usernametb";
            usernametb.Size = new Size(305, 23);
            usernametb.TabIndex = 9;
            // 
            // button2
            // 
            button2.Location = new Point(13, 253);
            button2.Name = "button2";
            button2.Size = new Size(113, 23);
            button2.TabIndex = 10;
            button2.Text = "Показать пароль";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Auth
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Plum;
            ClientSize = new Size(348, 345);
            Controls.Add(button2);
            Controls.Add(usernametb);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(passwordtb);
            Controls.Add(button1);
            Controls.Add(panel1);
            Name = "Auth";
            Text = "Авторизация";
            FormClosed += Auth_FormClosed;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox passwordtb;
        private Label label1;
        private Label label2;
        private Label label3;
        private Panel panel1;
        private Label label4;
        private Label label5;
        private MaskedTextBox usernametb;
        private Button button2;
    }
}
