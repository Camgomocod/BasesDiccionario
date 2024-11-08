namespace BasesDiccionario
{
    partial class LoginForm
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
            groupBox1 = new GroupBox();
            ButtonConectar = new Button();
            txtPassword = new TextBox();
            txtUser = new TextBox();
            label3 = new Label();
            label2 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(224, 9);
            label1.Name = "label1";
            label1.Size = new Size(277, 45);
            label1.TabIndex = 0;
            label1.Text = "Conexion a la BD";
            label1.Click += label1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(ButtonConectar);
            groupBox1.Controls.Add(txtPassword);
            groupBox1.Controls.Add(txtUser);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(42, 67);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(658, 361);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ingrese los datos requeridos:";
            // 
            // ButtonConectar
            // 
            ButtonConectar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ButtonConectar.Location = new Point(282, 312);
            ButtonConectar.Name = "ButtonConectar";
            ButtonConectar.Size = new Size(111, 36);
            ButtonConectar.TabIndex = 2;
            ButtonConectar.Text = "Conectar";
            ButtonConectar.UseVisualStyleBackColor = true;
            ButtonConectar.Click += BotonConectar_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(232, 234);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(338, 33);
            txtPassword.TabIndex = 1;
            txtPassword.TextChanged += textBox2_TextChanged;
            // 
            // txtUser
            // 
            txtUser.Location = new Point(232, 119);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(338, 33);
            txtUser.TabIndex = 1;
            txtUser.TextChanged += txtUser_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 237);
            label3.Name = "label3";
            label3.Size = new Size(110, 25);
            label3.TabIndex = 0;
            label3.Text = "PASSWORD";
            label3.Click += label2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 122);
            label2.Name = "label2";
            label2.Size = new Size(56, 25);
            label2.TabIndex = 0;
            label2.Text = "USER";
            label2.Click += label2_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(737, 450);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Acceso";
            Load += LoginForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label label2;
        private Label label3;
        private Button ButtonConectar;
        private TextBox txtPassword;
        private TextBox txtUser;
    }
}