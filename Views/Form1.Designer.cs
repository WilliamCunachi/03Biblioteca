namespace _03Biblioteca
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAgregarMiembro = new System.Windows.Forms.Button();
            this.btnEliminarMiembro = new System.Windows.Forms.Button();
            this.btnModificarMiembro = new System.Windows.Forms.Button();
            this.txt_miembroid = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.lstmiembros = new System.Windows.Forms.ListBox();
            this.txt_fecha = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAgregarMiembro
            // 
            this.btnAgregarMiembro.Location = new System.Drawing.Point(44, 313);
            this.btnAgregarMiembro.Name = "btnAgregarMiembro";
            this.btnAgregarMiembro.Size = new System.Drawing.Size(144, 94);
            this.btnAgregarMiembro.TabIndex = 0;
            this.btnAgregarMiembro.Text = "AgregarMiembro";
            this.btnAgregarMiembro.UseVisualStyleBackColor = true;
            this.btnAgregarMiembro.Click += new System.EventHandler(this.btnAgregarMiembro_Click);
            // 
            // btnEliminarMiembro
            // 
            this.btnEliminarMiembro.Location = new System.Drawing.Point(212, 313);
            this.btnEliminarMiembro.Name = "btnEliminarMiembro";
            this.btnEliminarMiembro.Size = new System.Drawing.Size(148, 94);
            this.btnEliminarMiembro.TabIndex = 1;
            this.btnEliminarMiembro.Text = "EliminarMiembro";
            this.btnEliminarMiembro.UseVisualStyleBackColor = true;
            this.btnEliminarMiembro.Click += new System.EventHandler(this.btnEliminarMiembro_Click);
            // 
            // btnModificarMiembro
            // 
            this.btnModificarMiembro.Location = new System.Drawing.Point(422, 313);
            this.btnModificarMiembro.Name = "btnModificarMiembro";
            this.btnModificarMiembro.Size = new System.Drawing.Size(190, 94);
            this.btnModificarMiembro.TabIndex = 2;
            this.btnModificarMiembro.Text = "ModificarMiembro";
            this.btnModificarMiembro.UseVisualStyleBackColor = true;
            this.btnModificarMiembro.Click += new System.EventHandler(this.btnModificarMiembro_Click);
            // 
            // txt_miembroid
            // 
            this.txt_miembroid.Location = new System.Drawing.Point(212, 35);
            this.txt_miembroid.Name = "txt_miembroid";
            this.txt_miembroid.Size = new System.Drawing.Size(100, 26);
            this.txt_miembroid.TabIndex = 3;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(212, 81);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(100, 26);
            this.txt_nombre.TabIndex = 4;
            // 
            // txt_apellido
            // 
            this.txt_apellido.Location = new System.Drawing.Point(212, 126);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(100, 26);
            this.txt_apellido.TabIndex = 5;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(212, 173);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(100, 26);
            this.txt_email.TabIndex = 6;
            // 
            // lstmiembros
            // 
            this.lstmiembros.FormattingEnabled = true;
            this.lstmiembros.ItemHeight = 20;
            this.lstmiembros.Location = new System.Drawing.Point(530, 47);
            this.lstmiembros.Name = "lstmiembros";
            this.lstmiembros.Size = new System.Drawing.Size(200, 204);
            this.lstmiembros.TabIndex = 8;
            // 
            // txt_fecha
            // 
            this.txt_fecha.Location = new System.Drawing.Point(212, 225);
            this.txt_fecha.Name = "txt_fecha";
            this.txt_fecha.Size = new System.Drawing.Size(200, 26);
            this.txt_fecha.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Id_Miembro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(84, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Fecha";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_fecha);
            this.Controls.Add(this.lstmiembros);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_apellido);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.txt_miembroid);
            this.Controls.Add(this.btnModificarMiembro);
            this.Controls.Add(this.btnEliminarMiembro);
            this.Controls.Add(this.btnAgregarMiembro);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarMiembro;
        private System.Windows.Forms.Button btnEliminarMiembro;
        private System.Windows.Forms.Button btnModificarMiembro;
        private System.Windows.Forms.TextBox txt_miembroid;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_apellido;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.ListBox lstmiembros;
        private System.Windows.Forms.DateTimePicker txt_fecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

