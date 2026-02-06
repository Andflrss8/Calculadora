namespace Calculadora.Formulario
{
    partial class frmRegistro
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
            tabControl1 = new TabControl();
            Registros = new TabPage();
            btnRegistrar = new Button();
            label3 = new Label();
            dtmNacimiento = new DateTimePicker();
            tbApellido = new TextBox();
            tbNombre = new TextBox();
            label2 = new Label();
            label1 = new Label();
            tabPage2 = new TabPage();
            dgvPersonas = new DataGridView();
            tabControl1.SuspendLayout();
            Registros.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPersonas).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(Registros);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(31, 10);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(739, 428);
            tabControl1.TabIndex = 0;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // Registros
            // 
            Registros.Controls.Add(btnRegistrar);
            Registros.Controls.Add(label3);
            Registros.Controls.Add(dtmNacimiento);
            Registros.Controls.Add(tbApellido);
            Registros.Controls.Add(tbNombre);
            Registros.Controls.Add(label2);
            Registros.Controls.Add(label1);
            Registros.Location = new Point(4, 29);
            Registros.Name = "Registros";
            Registros.Padding = new Padding(3);
            Registros.Size = new Size(731, 395);
            Registros.TabIndex = 0;
            Registros.Text = "Registro";
            Registros.UseVisualStyleBackColor = true;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(372, 274);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(94, 29);
            btnRegistrar.TabIndex = 6;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 245);
            label3.Name = "label3";
            label3.Size = new Size(149, 20);
            label3.TabIndex = 5;
            label3.Text = "Fecha de Nacimiento";
            // 
            // dtmNacimiento
            // 
            dtmNacimiento.Location = new Point(50, 276);
            dtmNacimiento.Name = "dtmNacimiento";
            dtmNacimiento.Size = new Size(250, 27);
            dtmNacimiento.TabIndex = 4;
            // 
            // tbApellido
            // 
            tbApellido.Location = new Point(45, 166);
            tbApellido.Name = "tbApellido";
            tbApellido.Size = new Size(296, 27);
            tbApellido.TabIndex = 3;
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(43, 84);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(298, 27);
            tbNombre.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 120);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 1;
            label2.Text = "Apellidos";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 46);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dgvPersonas);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(731, 395);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Mostrar";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvPersonas
            // 
            dgvPersonas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPersonas.Location = new Point(79, 69);
            dgvPersonas.Name = "dgvPersonas";
            dgvPersonas.RowHeadersWidth = 51;
            dgvPersonas.Size = new Size(477, 188);
            dgvPersonas.TabIndex = 0;
            // 
            // frmRegistro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 450);
            Controls.Add(tabControl1);
            Name = "frmRegistro";
            Text = "Registro Alumnos";
            tabControl1.ResumeLayout(false);
            Registros.ResumeLayout(false);
            Registros.PerformLayout();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPersonas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage Registros;
        private TabPage tabPage2;
        private Button btnRegistrar;
        private Label label3;
        private DateTimePicker dtmNacimiento;
        private TextBox tbApellido;
        private TextBox tbNombre;
        private Label label2;
        private Label label1;
        private DataGridView dgvPersonas;
    }
}