namespace WinFormsApp1.forms
{
    partial class Choose
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
            Servicecb = new ComboBox();
            button1 = new Button();
            label1 = new Label();
            Area = new TextBox();
            label2 = new Label();
            button2 = new Button();
            label3 = new Label();
            PriceLabel = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // Servicecb
            // 
            Servicecb.BackColor = Color.Plum;
            Servicecb.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Servicecb.FormattingEnabled = true;
            Servicecb.Location = new Point(12, 85);
            Servicecb.Name = "Servicecb";
            Servicecb.Size = new Size(321, 33);
            Servicecb.TabIndex = 0;
            Servicecb.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(240, 212);
            button1.Name = "button1";
            button1.Size = new Size(93, 40);
            button1.TabIndex = 1;
            button1.Text = "Перейти к оформлению";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 67);
            label1.Name = "label1";
            label1.Size = new Size(130, 15);
            label1.TabIndex = 2;
            label1.Text = "Наименование услуги";
            // 
            // Area
            // 
            Area.BackColor = Color.Plum;
            Area.Location = new Point(12, 153);
            Area.Name = "Area";
            Area.Size = new Size(321, 23);
            Area.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 135);
            label2.Name = "label2";
            label2.Size = new Size(172, 15);
            label2.TabIndex = 4;
            label2.Text = "Площадь помещения (в кв.м)";
            // 
            // button2
            // 
            button2.Location = new Point(12, 203);
            button2.Name = "button2";
            button2.Size = new Size(101, 59);
            button2.TabIndex = 5;
            button2.Text = "Рассчитать Цену";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 270);
            label3.Name = "label3";
            label3.Size = new Size(81, 15);
            label3.TabIndex = 6;
            label3.Text = "Цена услуги: ";
            // 
            // PriceLabel
            // 
            PriceLabel.AutoSize = true;
            PriceLabel.Location = new Point(99, 270);
            PriceLabel.Name = "PriceLabel";
            PriceLabel.Size = new Size(0, 15);
            PriceLabel.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(99, 9);
            label4.Name = "label4";
            label4.Size = new Size(143, 30);
            label4.TabIndex = 8;
            label4.Text = "Выбор услуги";
            // 
            // Choose
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Plum;
            ClientSize = new Size(345, 314);
            Controls.Add(label4);
            Controls.Add(PriceLabel);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(Area);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(Servicecb);
            Name = "Choose";
            Text = "Выбор услуги";
            FormClosed += Choose_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox Servicecb;
        private Button button1;
        private Label label1;
        private TextBox Area;
        private Label label2;
        private Button button2;
        private Label label3;
        private Label PriceLabel;
        private Label label4;
    }
}