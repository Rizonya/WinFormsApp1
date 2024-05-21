namespace WinFormsApp1.forms
{
    partial class ViewOrders
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
            Orderslv = new ListView();
            button1 = new Button();
            SuspendLayout();
            // 
            // Orderslv
            // 
            Orderslv.Location = new Point(27, 24);
            Orderslv.MultiSelect = false;
            Orderslv.Name = "Orderslv";
            Orderslv.Size = new Size(798, 356);
            Orderslv.TabIndex = 0;
            Orderslv.UseCompatibleStateImageBehavior = false;
            // 
            // button1
            // 
            button1.Location = new Point(27, 406);
            button1.Name = "button1";
            button1.Size = new Size(142, 44);
            button1.TabIndex = 1;
            button1.Text = "Отметить выполненным";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ViewOrders
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Plum;
            ClientSize = new Size(869, 462);
            Controls.Add(button1);
            Controls.Add(Orderslv);
            Name = "ViewOrders";
            Text = "ViewOrders";
            ResumeLayout(false);
        }

        #endregion

        private ListView Orderslv;
        private Button button1;
    }
}