namespace BasesDiccionario
{
    partial class MainForm
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
            bt_tablas = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            textBoxResultados = new TextBox();
            SuspendLayout();
            // 
            // bt_tablas
            // 
            bt_tablas.Location = new Point(109, 255);
            bt_tablas.Name = "bt_tablas";
            bt_tablas.Size = new Size(125, 23);
            bt_tablas.TabIndex = 1;
            bt_tablas.Text = "Lista_Tablas";
            bt_tablas.UseVisualStyleBackColor = true;
            bt_tablas.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(109, 341);
            button2.Name = "button2";
            button2.Size = new Size(125, 23);
            button2.TabIndex = 2;
            button2.Text = "Nombre_Funciones";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(330, 255);
            button3.Name = "button3";
            button3.Size = new Size(157, 23);
            button3.TabIndex = 3;
            button3.Text = "Nombre_Procedimiento";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(330, 341);
            button4.Name = "button4";
            button4.Size = new Size(157, 23);
            button4.TabIndex = 4;
            button4.Text = "Nombre_Trigger";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(583, 255);
            button5.Name = "button5";
            button5.Size = new Size(128, 23);
            button5.TabIndex = 5;
            button5.Text = "Nombre_Vistas";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(583, 341);
            button6.Name = "button6";
            button6.Size = new Size(128, 23);
            button6.TabIndex = 6;
            button6.Text = "Filtro_Tablas";
            button6.UseVisualStyleBackColor = true;
            // 
            // textBoxResultados
            // 
            textBoxResultados.BackColor = SystemColors.ActiveCaption;
            textBoxResultados.Location = new Point(133, 53);
            textBoxResultados.Multiline = true;
            textBoxResultados.Name = "textBoxResultados";
            textBoxResultados.ReadOnly = true;
            textBoxResultados.ScrollBars = ScrollBars.Both;
            textBoxResultados.Size = new Size(552, 154);
            textBoxResultados.TabIndex = 7;
            textBoxResultados.TextChanged += textBoxResultados_TextChanged;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxResultados);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(bt_tablas);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bt_tablas;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private TextBox textBoxResultados;
    }
}
