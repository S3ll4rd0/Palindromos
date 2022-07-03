namespace Palindromos
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
            this.TextBox = new System.Windows.Forms.TextBox();
            this.Label = new System.Windows.Forms.Label();
            this.Boton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextBox
            // 
            this.TextBox.Location = new System.Drawing.Point(12, 49);
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(558, 22);
            this.TextBox.TabIndex = 0;
            // 
            // Label
            // 
            this.Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label.Location = new System.Drawing.Point(12, 201);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(558, 23);
            this.Label.TabIndex = 1;
            this.Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Boton
            // 
            this.Boton.Location = new System.Drawing.Point(243, 86);
            this.Boton.Name = "Boton";
            this.Boton.Size = new System.Drawing.Size(100, 100);
            this.Boton.TabIndex = 2;
            this.Boton.Text = "Comprobar";
            this.Boton.UseVisualStyleBackColor = true;
            this.Boton.Click += new System.EventHandler(this.Boton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 253);
            this.Controls.Add(this.Boton);
            this.Controls.Add(this.Label);
            this.Controls.Add(this.TextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBox;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.Button Boton;
    }
}

