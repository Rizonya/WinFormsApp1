namespace WinFormsApp1.forms
{
    partial class AddService
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
            button1 = new Button();
            label1 = new Label();
            nametb = new TextBox();
            pricetb = new TextBox();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 346);
            button1.Name = "button1";
            button1.Size = new Size(333, 43);
            button1.TabIndex = 0;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(77, 27);
            label1.Name = "label1";
            label1.Size = new Size(198, 30);
            label1.TabIndex = 1;
            label1.Text = "Добавление услуги";
            // 
            // nametb
            // 
            nametb.Location = new Point(12, 111);
            nametb.Name = "nametb";
            nametb.Size = new Size(333, 23);
            nametb.TabIndex = 2;
            // 
            // pricetb
            // 
            pricetb.Location = new Point(12, 197);
            pricetb.Name = "pricetb";
            pricetb.Size = new Size(333, 23);
            pricetb.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 93);
            label2.Name = "label2";
            label2.Size = new Size(130, 15);
            label2.TabIndex = 4;
            label2.Text = "Наименование услуги";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 179);
            label3.Name = "label3";
            label3.Size = new Size(111, 15);
            label3.TabIndex = 5;
            label3.Text = "Стоимость за кв. м";
            // 
            // AddService
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Plum;
            ClientSize = new Size(357, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pricetb);
            Controls.Add(nametb);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "AddService";
            Text = "AddService";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox nametb;
        private TextBox pricetb;
        private Label label2;
        private Label label3;
    }
}