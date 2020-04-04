namespace MiddleCourseApp
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
            this.components = new System.ComponentModel.Container();
            this.button_ledon = new System.Windows.Forms.Button();
            this.button_ledoff = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.SuspendLayout();
            // 
            // button_ledon
            // 
            this.button_ledon.Location = new System.Drawing.Point(12, 12);
            this.button_ledon.Name = "button_ledon";
            this.button_ledon.Size = new System.Drawing.Size(75, 23);
            this.button_ledon.TabIndex = 0;
            this.button_ledon.Text = "ON";
            this.button_ledon.UseVisualStyleBackColor = true;
            this.button_ledon.Click += new System.EventHandler(this.button_ledon_Click);
            // 
            // button_ledoff
            // 
            this.button_ledoff.Location = new System.Drawing.Point(12, 41);
            this.button_ledoff.Name = "button_ledoff";
            this.button_ledoff.Size = new System.Drawing.Size(75, 23);
            this.button_ledoff.TabIndex = 1;
            this.button_ledoff.Text = "OFF";
            this.button_ledoff.UseVisualStyleBackColor = true;
            this.button_ledoff.Click += new System.EventHandler(this.button_ledoff_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 347);
            this.Controls.Add(this.button_ledoff);
            this.Controls.Add(this.button_ledon);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_ledon;
        private System.Windows.Forms.Button button_ledoff;
        private System.IO.Ports.SerialPort serialPort1;
    }
}

