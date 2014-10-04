namespace AppNavegadores
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.chkChrome = new System.Windows.Forms.CheckBox();
            this.chkInternetExplorer = new System.Windows.Forms.CheckBox();
            this.chkMozilla = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblSeleccionado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chkChrome
            // 
            this.chkChrome.AutoSize = true;
            this.chkChrome.Location = new System.Drawing.Point(73, 28);
            this.chkChrome.Name = "chkChrome";
            this.chkChrome.Size = new System.Drawing.Size(62, 17);
            this.chkChrome.TabIndex = 0;
            this.chkChrome.Text = "Chrome";
            this.chkChrome.UseVisualStyleBackColor = true;
            // 
            // chkInternetExplorer
            // 
            this.chkInternetExplorer.AutoSize = true;
            this.chkInternetExplorer.Location = new System.Drawing.Point(73, 58);
            this.chkInternetExplorer.Name = "chkInternetExplorer";
            this.chkInternetExplorer.Size = new System.Drawing.Size(103, 17);
            this.chkInternetExplorer.TabIndex = 1;
            this.chkInternetExplorer.Text = "Internet Explorer";
            this.chkInternetExplorer.UseVisualStyleBackColor = true;
            // 
            // chkMozilla
            // 
            this.chkMozilla.AutoSize = true;
            this.chkMozilla.Location = new System.Drawing.Point(73, 88);
            this.chkMozilla.Name = "chkMozilla";
            this.chkMozilla.Size = new System.Drawing.Size(58, 17);
            this.chkMozilla.TabIndex = 2;
            this.chkMozilla.Text = "Mozilla";
            this.chkMozilla.UseVisualStyleBackColor = true;
            this.chkMozilla.CheckedChanged += new System.EventHandler(this.chkMozilla_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(38, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Navegador Seleccionado";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblSeleccionado
            // 
            this.lblSeleccionado.AutoSize = true;
            this.lblSeleccionado.Location = new System.Drawing.Point(70, 155);
            this.lblSeleccionado.Name = "lblSeleccionado";
            this.lblSeleccionado.Size = new System.Drawing.Size(72, 13);
            this.lblSeleccionado.TabIndex = 4;
            this.lblSeleccionado.Text = "Seleccionado";
            this.lblSeleccionado.Click += new System.EventHandler(this.lblSeleccionado_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lblSeleccionado);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chkMozilla);
            this.Controls.Add(this.chkInternetExplorer);
            this.Controls.Add(this.chkChrome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkChrome;
        private System.Windows.Forms.CheckBox chkInternetExplorer;
        private System.Windows.Forms.CheckBox chkMozilla;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblSeleccionado;
    }
}

