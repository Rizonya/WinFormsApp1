
namespace WinFormsApp1.forms
{
    partial class Application
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
            Nametb = new TextBox();
            Addresstb = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            datePicker = new DateTimePicker();
            timePicker = new DateTimePicker();
            button1 = new Button();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(65, 9);
            label1.Name = "label1";
            label1.Size = new Size(189, 25);
            label1.TabIndex = 0;
            label1.Text = "Оформление заявки";
            // 
            // Nametb
            // 
            Nametb.BackColor = Color.Plum;
            Nametb.Location = new Point(12, 79);
            Nametb.Name = "Nametb";
            Nametb.Size = new Size(324, 23);
            Nametb.TabIndex = 1;
            // 
            // Addresstb
            // 
            Addresstb.BackColor = Color.Plum;
            Addresstb.Location = new Point(12, 137);
            Addresstb.Name = "Addresstb";
            Addresstb.Size = new Size(324, 23);
            Addresstb.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 61);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 4;
            label2.Text = "ФИО";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 119);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 5;
            label3.Text = "Адрес";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 177);
            label4.Name = "label4";
            label4.Size = new Size(32, 15);
            label4.TabIndex = 6;
            label4.Text = "Дата";
            // 
            // datePicker
            // 
            datePicker.CalendarMonthBackground = Color.Plum;
            datePicker.CustomFormat = "";
            datePicker.Location = new Point(12, 195);
            datePicker.Name = "datePicker";
            datePicker.Size = new Size(142, 23);
            datePicker.TabIndex = 7;
            // 
            // timePicker
            // 
            timePicker.Location = new Point(160, 195);
            timePicker.Name = "timePicker";
            timePicker.Size = new Size(157, 23);
            timePicker.TabIndex = 8;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.Location = new Point(12, 265);
            button1.Name = "button1";
            button1.Size = new Size(324, 39);
            button1.TabIndex = 9;
            button1.Text = "Оформить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(160, 177);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 10;
            label5.Text = "Время";
            // 
            // Application
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Plum;
            ClientSize = new Size(348, 326);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(timePicker);
            Controls.Add(datePicker);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Addresstb);
            Controls.Add(Nametb);
            Controls.Add(label1);
            Name = "Application";
            Text = "Оформления заявки";
            FormClosed += Application_FormClosed;
            Load += application_Load;
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Label label1;
        private TextBox Nametb;
        private TextBox Addresstb;
        private Label label2;
        private Label label3;
        private Label label4;
        private DateTimePicker datePicker;
        private DateTimePicker timePicker;
        private Button button1;
        private Label label5;
    }
}