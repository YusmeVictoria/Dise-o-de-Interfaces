namespace UD4_FichaAlumno
{
    partial class FormFichaAlumno
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
            this.grpDatosAlumno = new System.Windows.Forms.GroupBox();
            this.chkRepetidor = new System.Windows.Forms.CheckBox();
            this.txtCiclo = new System.Windows.Forms.TextBox();
            this.lblCiclo = new System.Windows.Forms.Label();
            this.numEdad = new System.Windows.Forms.NumericUpDown();
            this.lblEdad = new System.Windows.Forms.Label();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.grpDatosAlumno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numEdad)).BeginInit();
            this.SuspendLayout();
            // 
            // grpDatosAlumno
            // 
            this.grpDatosAlumno.Controls.Add(this.chkRepetidor);
            this.grpDatosAlumno.Controls.Add(this.txtCiclo);
            this.grpDatosAlumno.Controls.Add(this.lblCiclo);
            this.grpDatosAlumno.Controls.Add(this.numEdad);
            this.grpDatosAlumno.Controls.Add(this.lblEdad);
            this.grpDatosAlumno.Controls.Add(this.txtApellidos);
            this.grpDatosAlumno.Controls.Add(this.lblApellidos);
            this.grpDatosAlumno.Controls.Add(this.txtNombre);
            this.grpDatosAlumno.Controls.Add(this.lblNombre);
            this.grpDatosAlumno.Location = new System.Drawing.Point(12, 12);
            this.grpDatosAlumno.Name = "grpDatosAlumno";
            this.grpDatosAlumno.Size = new System.Drawing.Size(360, 205);
            this.grpDatosAlumno.TabIndex = 0;
            this.grpDatosAlumno.TabStop = false;
            this.grpDatosAlumno.Text = "Datos del alumno";
            // 
            // chkRepetidor
            // 
            this.chkRepetidor.AutoSize = true;
            this.chkRepetidor.Enabled = false;
            this.chkRepetidor.Location = new System.Drawing.Point(110, 167);
            this.chkRepetidor.Name = "chkRepetidor";
            this.chkRepetidor.Size = new System.Drawing.Size(90, 17);
            this.chkRepetidor.TabIndex = 8;
            this.chkRepetidor.Text = "Es repetidor";
            this.chkRepetidor.UseVisualStyleBackColor = true;
            // 
            // txtCiclo
            // 
            this.txtCiclo.Location = new System.Drawing.Point(110, 131);
            this.txtCiclo.Name = "txtCiclo";
            this.txtCiclo.ReadOnly = true;
            this.txtCiclo.Size = new System.Drawing.Size(225, 20);
            this.txtCiclo.TabIndex = 7;
            // 
            // lblCiclo
            // 
            this.lblCiclo.AutoSize = true;
            this.lblCiclo.Location = new System.Drawing.Point(20, 134);
            this.lblCiclo.Name = "lblCiclo";
            this.lblCiclo.Size = new System.Drawing.Size(33, 13);
            this.lblCiclo.TabIndex = 6;
            this.lblCiclo.Text = "Ciclo:";
            // 
            // numEdad
            // 
            this.numEdad.Enabled = false;
            this.numEdad.Location = new System.Drawing.Point(110, 97);
            this.numEdad.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numEdad.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numEdad.Name = "numEdad";
            this.numEdad.Size = new System.Drawing.Size(60, 20);
            this.numEdad.TabIndex = 5;
            this.numEdad.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(20, 99);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(35, 13);
            this.lblEdad.TabIndex = 4;
            this.lblEdad.Text = "Edad:";
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(110, 63);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.ReadOnly = true;
            this.txtApellidos.Size = new System.Drawing.Size(225, 20);
            this.txtApellidos.TabIndex = 3;
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Location = new System.Drawing.Point(20, 66);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(52, 13);
            this.lblApellidos.TabIndex = 2;
            this.lblApellidos.Text = "Apellidos:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(110, 29);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(225, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(20, 32);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // FormFichaAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 231);
            this.Controls.Add(this.grpDatosAlumno);
            this.Name = "FormFichaAlumno";
            this.Text = "Ficha del alumno";
            this.Load += new System.EventHandler(this.FormFichaAlumno_Load);
            this.grpDatosAlumno.ResumeLayout(false);
            this.grpDatosAlumno.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numEdad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDatosAlumno;
        private System.Windows.Forms.CheckBox chkRepetidor;
        private System.Windows.Forms.TextBox txtCiclo;
        private System.Windows.Forms.Label lblCiclo;
        private System.Windows.Forms.NumericUpDown numEdad;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
    }
}
