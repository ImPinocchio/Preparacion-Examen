namespace Preparacion_Examen
{
    partial class FormCliente
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            cmbTipoDocumento = new ComboBox();
            txtDocumento = new TextBox();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtCelular = new TextBox();
            txtMail = new TextBox();
            rbSexoM = new RadioButton();
            rbSexoF = new RadioButton();
            labelEstado = new Label();
            panel1 = new Panel();
            btnConsultar = new Button();
            panel2 = new Panel();
            btnNuevo = new Button();
            btnSalir = new Button();
            btnLimpiar = new Button();
            btnInactivar = new Button();
            btnActualizar = new Button();
            btnCrear = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(13, 13);
            label1.Name = "label1";
            label1.Size = new Size(129, 23);
            label1.TabIndex = 0;
            label1.Text = "Tipo De Documento:";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.Location = new Point(13, 48);
            label2.Name = "label2";
            label2.Size = new Size(129, 23);
            label2.TabIndex = 0;
            label2.Text = "Documento:";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.Location = new Point(13, 94);
            label3.Name = "label3";
            label3.Size = new Size(129, 23);
            label3.TabIndex = 0;
            label3.Text = "Nombres:";
            label3.TextAlign = ContentAlignment.TopCenter;
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.Location = new Point(21, 135);
            label4.Name = "label4";
            label4.Size = new Size(129, 23);
            label4.TabIndex = 0;
            label4.Text = "Apellidos:";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // label5
            // 
            label5.Location = new Point(21, 212);
            label5.Name = "label5";
            label5.Size = new Size(129, 23);
            label5.TabIndex = 0;
            label5.Text = "Celular:";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // label6
            // 
            label6.Location = new Point(21, 174);
            label6.Name = "label6";
            label6.Size = new Size(129, 23);
            label6.TabIndex = 0;
            label6.Text = "Sexo:";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // label7
            // 
            label7.Location = new Point(21, 247);
            label7.Name = "label7";
            label7.Size = new Size(129, 23);
            label7.TabIndex = 0;
            label7.Text = "Mail:";
            label7.TextAlign = ContentAlignment.TopCenter;
            // 
            // label8
            // 
            label8.Location = new Point(21, 283);
            label8.Name = "label8";
            label8.Size = new Size(129, 23);
            label8.TabIndex = 0;
            label8.Text = "Estado:";
            label8.TextAlign = ContentAlignment.TopCenter;
            // 
            // cmbTipoDocumento
            // 
            cmbTipoDocumento.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoDocumento.FormattingEnabled = true;
            cmbTipoDocumento.Items.AddRange(new object[] { "CEDULA", "RUC" });
            cmbTipoDocumento.Location = new Point(162, 10);
            cmbTipoDocumento.Name = "cmbTipoDocumento";
            cmbTipoDocumento.Size = new Size(121, 23);
            cmbTipoDocumento.TabIndex = 1;
            // 
            // txtDocumento
            // 
            txtDocumento.Location = new Point(162, 48);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(100, 23);
            txtDocumento.TabIndex = 2;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(162, 91);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 2;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(162, 132);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(100, 23);
            txtApellido.TabIndex = 2;
            // 
            // txtCelular
            // 
            txtCelular.Location = new Point(162, 209);
            txtCelular.Name = "txtCelular";
            txtCelular.Size = new Size(100, 23);
            txtCelular.TabIndex = 2;
            // 
            // txtMail
            // 
            txtMail.Location = new Point(162, 244);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(100, 23);
            txtMail.TabIndex = 2;
            // 
            // rbSexoM
            // 
            rbSexoM.AutoSize = true;
            rbSexoM.Location = new Point(169, 176);
            rbSexoM.Name = "rbSexoM";
            rbSexoM.Size = new Size(80, 19);
            rbSexoM.TabIndex = 3;
            rbSexoM.TabStop = true;
            rbSexoM.Text = "Masculino";
            rbSexoM.UseVisualStyleBackColor = true;
            // 
            // rbSexoF
            // 
            rbSexoF.AutoSize = true;
            rbSexoF.Location = new Point(269, 176);
            rbSexoF.Name = "rbSexoF";
            rbSexoF.Size = new Size(78, 19);
            rbSexoF.TabIndex = 4;
            rbSexoF.TabStop = true;
            rbSexoF.Text = "Femenino";
            rbSexoF.UseVisualStyleBackColor = true;
            // 
            // labelEstado
            // 
            labelEstado.AutoSize = true;
            labelEstado.Location = new Point(162, 283);
            labelEstado.Name = "labelEstado";
            labelEstado.Size = new Size(42, 15);
            labelEstado.TabIndex = 5;
            labelEstado.Text = "Estado";
            // 
            // panel1
            // 
            panel1.Controls.Add(btnConsultar);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(363, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(174, 319);
            panel1.TabIndex = 6;
            // 
            // btnConsultar
            // 
            btnConsultar.Dock = DockStyle.Fill;
            btnConsultar.Location = new Point(0, 0);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(174, 132);
            btnConsultar.TabIndex = 1;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnNuevo);
            panel2.Controls.Add(btnSalir);
            panel2.Controls.Add(btnLimpiar);
            panel2.Controls.Add(btnInactivar);
            panel2.Controls.Add(btnActualizar);
            panel2.Controls.Add(btnCrear);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 132);
            panel2.Name = "panel2";
            panel2.Size = new Size(174, 187);
            panel2.TabIndex = 0;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(3, 15);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(168, 23);
            btnNuevo.TabIndex = 1;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(2, 161);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(172, 23);
            btnSalir.TabIndex = 0;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(2, 134);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(172, 23);
            btnLimpiar.TabIndex = 0;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnInactivar
            // 
            btnInactivar.Location = new Point(2, 105);
            btnInactivar.Name = "btnInactivar";
            btnInactivar.Size = new Size(172, 23);
            btnInactivar.TabIndex = 0;
            btnInactivar.Text = "Inactivar";
            btnInactivar.UseVisualStyleBackColor = true;
            btnInactivar.Click += btnInactivar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(2, 76);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(172, 23);
            btnActualizar.TabIndex = 0;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnCrear
            // 
            btnCrear.Location = new Point(2, 44);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(172, 26);
            btnCrear.TabIndex = 0;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // FormCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(537, 319);
            Controls.Add(panel1);
            Controls.Add(labelEstado);
            Controls.Add(rbSexoF);
            Controls.Add(rbSexoM);
            Controls.Add(txtMail);
            Controls.Add(txtCelular);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(txtDocumento);
            Controls.Add(cmbTipoDocumento);
            Controls.Add(label6);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormCliente";
            Text = "Cliente";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private ComboBox cmbTipoDocumento;
        private TextBox txtDocumento;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtCelular;
        private TextBox txtMail;
        private TextBox txtEstado;
        private RadioButton rbSexoF;
        private RadioButton rbSexoM;
        private Label labelEstado;
        private Panel panel1;
        private Panel panel2;
        private Button btnCrear;
        private Button btnSalir;
        private Button btnLimpiar;
        private Button btnInactivar;
        private Button btnActualizar;
        private Button btnNuevo;
        private Button btnConsultar;
    }
}
