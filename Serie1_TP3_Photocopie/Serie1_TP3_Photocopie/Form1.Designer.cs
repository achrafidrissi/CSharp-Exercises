namespace Serie1_TP3_Photocopie
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
            labelNbr = new Label();
            nbr = new TextBox();
            total = new TextBox();
            labelTotal = new Label();
            btnCalculer = new Button();
            SuspendLayout();
            // 
            // labelNbr
            // 
            labelNbr.AutoSize = true;
            labelNbr.Font = new Font("Segoe UI", 15F);
            labelNbr.Location = new Point(71, 138);
            labelNbr.Name = "labelNbr";
            labelNbr.Size = new Size(289, 35);
            labelNbr.TabIndex = 0;
            labelNbr.Text = "Nombre de photocopies";
            labelNbr.Click += label1_Click;
            // 
            // nbr
            // 
            nbr.Location = new Point(399, 146);
            nbr.Name = "nbr";
            nbr.Size = new Size(365, 27);
            nbr.TabIndex = 1;
            nbr.TextChanged += textBox1_TextChanged;
            // 
            // total
            // 
            total.Location = new Point(400, 216);
            total.Name = "total";
            total.ReadOnly = true;
            total.Size = new Size(365, 27);
            total.TabIndex = 3;
            // 
            // labelTotal
            // 
            labelTotal.AutoSize = true;
            labelTotal.Font = new Font("Segoe UI", 15F);
            labelTotal.Location = new Point(72, 208);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(157, 35);
            labelTotal.TabIndex = 2;
            labelTotal.Text = "Total à payer";
            // 
            // btnCalculer
            // 
            btnCalculer.BackColor = SystemColors.ButtonShadow;
            btnCalculer.Font = new Font("Segoe UI", 14F);
            btnCalculer.Location = new Point(246, 291);
            btnCalculer.Name = "btnCalculer";
            btnCalculer.Size = new Size(257, 42);
            btnCalculer.TabIndex = 5;
            btnCalculer.Text = "Calculer";
            btnCalculer.UseVisualStyleBackColor = false;
            btnCalculer.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCalculer);
            Controls.Add(total);
            Controls.Add(labelTotal);
            Controls.Add(nbr);
            Controls.Add(labelNbr);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNbr;
        private TextBox nbr;
        private TextBox total;
        private Label labelTotal;
        private Button btnCalculer;
    }
}
