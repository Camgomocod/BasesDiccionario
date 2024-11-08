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
            btTablas = new Button();
            btFuncionalidad = new Button();
            btProcedimiento = new Button();
            btTrigger = new Button();
            btVista = new Button();
            btFiltro = new Button();
            textBoxResultados = new TextBox();
            SuspendLayout();
            // 
            // btTablas
            // 
            btTablas.Location = new Point(109, 255);
            btTablas.Name = "btTablas";
            btTablas.Size = new Size(125, 23);
            btTablas.TabIndex = 1;
            btTablas.Text = "Lista_Tablas";
            btTablas.UseVisualStyleBackColor = true;
            btTablas.Click += btTablas_Click;
            // 
            // btFuncionalidad
            // 
            btFuncionalidad.Location = new Point(109, 341);
            btFuncionalidad.Name = "btFuncionalidad";
            btFuncionalidad.Size = new Size(125, 23);
            btFuncionalidad.TabIndex = 2;
            btFuncionalidad.Text = "Nombre_Funciones";
            btFuncionalidad.UseVisualStyleBackColor = true;
            btFuncionalidad.Click += btFuncionalidad_Click;
            // 
            // btProcedimiento
            // 
            btProcedimiento.Location = new Point(330, 255);
            btProcedimiento.Name = "btProcedimiento";
            btProcedimiento.Size = new Size(157, 23);
            btProcedimiento.TabIndex = 3;
            btProcedimiento.Text = "Nombre_Procedimiento";
            btProcedimiento.UseVisualStyleBackColor = true;
            btProcedimiento.Click += btProcedimiento_Click;
            // 
            // btTrigger
            // 
            btTrigger.Location = new Point(330, 341);
            btTrigger.Name = "btTrigger";
            btTrigger.Size = new Size(157, 23);
            btTrigger.TabIndex = 4;
            btTrigger.Text = "Nombre_Trigger";
            btTrigger.UseVisualStyleBackColor = true;
            btTrigger.Click += btTrigger_Click;
            // 
            // btVista
            // 
            btVista.Location = new Point(583, 255);
            btVista.Name = "btVista";
            btVista.Size = new Size(128, 23);
            btVista.TabIndex = 5;
            btVista.Text = "Nombre_Vistas";
            btVista.UseVisualStyleBackColor = true;
            btVista.Click += btVista_Click;
            // 
            // btFiltro
            // 
            btFiltro.Location = new Point(583, 341);
            btFiltro.Name = "btFiltro";
            btFiltro.Size = new Size(128, 23);
            btFiltro.TabIndex = 6;
            btFiltro.Text = "Filtro_Tablas";
            btFiltro.UseVisualStyleBackColor = true;
            btFiltro.Click += btFiltro_Click;
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
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxResultados);
            Controls.Add(btFiltro);
            Controls.Add(btVista);
            Controls.Add(btTrigger);
            Controls.Add(btProcedimiento);
            Controls.Add(btFuncionalidad);
            Controls.Add(btTablas);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btTablas;
        private Button btFuncionalidad;
        private Button btProcedimiento;
        private Button btTrigger;
        private Button btVista;
        private Button btFiltro;
        private TextBox textBoxResultados;
    }
}
