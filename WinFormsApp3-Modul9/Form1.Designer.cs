namespace WinFormsApp3_Modul9
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
            lblSaldo = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            tbUang = new TextBox();
            tbPassword = new TextBox();
            button1 = new Button();
            rbSetor = new RadioButton();
            rbTarik = new RadioButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(181, 46);
            label1.Name = "label1";
            label1.Size = new Size(107, 15);
            label1.TabIndex = 0;
            label1.Text = "Saldo Akun Umum";
            // 
            // lblSaldo
            // 
            lblSaldo.AutoSize = true;
            lblSaldo.Location = new Point(213, 97);
            lblSaldo.Name = "lblSaldo";
            lblSaldo.Size = new Size(38, 15);
            lblSaldo.TabIndex = 1;
            lblSaldo.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(124, 177);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 2;
            label3.Text = "Action:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(90, 222);
            label4.Name = "label4";
            label4.Size = new Size(79, 15);
            label4.TabIndex = 3;
            label4.Text = "Jumlah Uang:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(109, 268);
            label5.Name = "label5";
            label5.Size = new Size(60, 15);
            label5.TabIndex = 4;
            label5.Text = "Password:";
            // 
            // tbUang
            // 
            tbUang.Location = new Point(188, 219);
            tbUang.Name = "tbUang";
            tbUang.Size = new Size(172, 23);
            tbUang.TabIndex = 5;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(188, 265);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(172, 23);
            tbPassword.TabIndex = 6;
            tbPassword.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            button1.Location = new Point(181, 328);
            button1.Name = "button1";
            button1.Size = new Size(107, 58);
            button1.TabIndex = 7;
            button1.Text = "Lanjut";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // rbSetor
            // 
            rbSetor.AutoSize = true;
            rbSetor.Location = new Point(188, 175);
            rbSetor.Name = "rbSetor";
            rbSetor.Size = new Size(52, 19);
            rbSetor.TabIndex = 8;
            rbSetor.TabStop = true;
            rbSetor.Text = "Setor";
            rbSetor.UseVisualStyleBackColor = true;
            // 
            // rbTarik
            // 
            rbTarik.AutoSize = true;
            rbTarik.Location = new Point(257, 175);
            rbTarik.Name = "rbTarik";
            rbTarik.Size = new Size(49, 19);
            rbTarik.TabIndex = 9;
            rbTarik.TabStop = true;
            rbTarik.Text = "Tarik";
            rbTarik.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(479, 450);
            Controls.Add(rbTarik);
            Controls.Add(rbSetor);
            Controls.Add(button1);
            Controls.Add(tbPassword);
            Controls.Add(tbUang);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lblSaldo);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblSaldo;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox tbUang;
        private TextBox tbPassword;
        private Button button1;
        private RadioButton rbSetor;
        private RadioButton rbTarik;
    }
}