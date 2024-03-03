namespace informacion_de_asignatura
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
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.btn_Limpiar = new System.Windows.Forms.Button();
            this.rb_Presencial = new System.Windows.Forms.RadioButton();
            this.rb_Virtual = new System.Windows.Forms.RadioButton();
            this.txt_informacion = new System.Windows.Forms.TextBox();
            this.lbl_Profesor = new System.Windows.Forms.Label();
            this.lbl_asignatura = new System.Windows.Forms.Label();
            this.txt_Asignatura = new System.Windows.Forms.TextBox();
            this.txt_Profesor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Location = new System.Drawing.Point(658, 84);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_Aceptar.TabIndex = 0;
            this.btn_Aceptar.Text = "Aceptar";
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.Location = new System.Drawing.Point(658, 189);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(75, 23);
            this.btn_Salir.TabIndex = 1;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.Location = new System.Drawing.Point(658, 139);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(75, 23);
            this.btn_Limpiar.TabIndex = 2;
            this.btn_Limpiar.Text = "Limpiar";
            this.btn_Limpiar.UseVisualStyleBackColor = true;
            // 
            // rb_Presencial
            // 
            this.rb_Presencial.AutoSize = true;
            this.rb_Presencial.Location = new System.Drawing.Point(216, 268);
            this.rb_Presencial.Name = "rb_Presencial";
            this.rb_Presencial.Size = new System.Drawing.Size(74, 17);
            this.rb_Presencial.TabIndex = 3;
            this.rb_Presencial.TabStop = true;
            this.rb_Presencial.Text = "Presencial";
            this.rb_Presencial.UseVisualStyleBackColor = true;
            // 
            // rb_Virtual
            // 
            this.rb_Virtual.AutoSize = true;
            this.rb_Virtual.Location = new System.Drawing.Point(396, 268);
            this.rb_Virtual.Name = "rb_Virtual";
            this.rb_Virtual.Size = new System.Drawing.Size(54, 17);
            this.rb_Virtual.TabIndex = 4;
            this.rb_Virtual.TabStop = true;
            this.rb_Virtual.Text = "Virtual";
            this.rb_Virtual.UseVisualStyleBackColor = true;
            // 
            // txt_informacion
            // 
            this.txt_informacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_informacion.Location = new System.Drawing.Point(129, 338);
            this.txt_informacion.Name = "txt_informacion";
            this.txt_informacion.Size = new System.Drawing.Size(444, 24);
            this.txt_informacion.TabIndex = 5;
            // 
            // lbl_Profesor
            // 
            this.lbl_Profesor.AutoSize = true;
            this.lbl_Profesor.Location = new System.Drawing.Point(213, 94);
            this.lbl_Profesor.Name = "lbl_Profesor";
            this.lbl_Profesor.Size = new System.Drawing.Size(46, 13);
            this.lbl_Profesor.TabIndex = 6;
            this.lbl_Profesor.Text = "Profesor";
            // 
            // lbl_asignatura
            // 
            this.lbl_asignatura.AutoSize = true;
            this.lbl_asignatura.Location = new System.Drawing.Point(213, 165);
            this.lbl_asignatura.Name = "lbl_asignatura";
            this.lbl_asignatura.Size = new System.Drawing.Size(57, 13);
            this.lbl_asignatura.TabIndex = 7;
            this.lbl_asignatura.Text = "Asignatura";
            // 
            // txt_Asignatura
            // 
            this.txt_Asignatura.Location = new System.Drawing.Point(287, 158);
            this.txt_Asignatura.Name = "txt_Asignatura";
            this.txt_Asignatura.Size = new System.Drawing.Size(118, 20);
            this.txt_Asignatura.TabIndex = 8;
            // 
            // txt_Profesor
            // 
            this.txt_Profesor.Location = new System.Drawing.Point(330, 86);
            this.txt_Profesor.Name = "txt_Profesor";
            this.txt_Profesor.Size = new System.Drawing.Size(118, 20);
            this.txt_Profesor.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(229, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "INFORMACION DE PROFESOR Y ASIGNATURA";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Profesor);
            this.Controls.Add(this.txt_Asignatura);
            this.Controls.Add(this.lbl_asignatura);
            this.Controls.Add(this.lbl_Profesor);
            this.Controls.Add(this.txt_informacion);
            this.Controls.Add(this.rb_Virtual);
            this.Controls.Add(this.rb_Presencial);
            this.Controls.Add(this.btn_Limpiar);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_Aceptar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Aceptar;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Button btn_Limpiar;
        private System.Windows.Forms.RadioButton rb_Presencial;
        private System.Windows.Forms.RadioButton rb_Virtual;
        private System.Windows.Forms.TextBox txt_informacion;
        private System.Windows.Forms.Label lbl_Profesor;
        private System.Windows.Forms.Label lbl_asignatura;
        private System.Windows.Forms.TextBox txt_Asignatura;
        private System.Windows.Forms.TextBox txt_Profesor;
        private System.Windows.Forms.Label label1;
    }
}

