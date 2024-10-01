namespace _3MLIDTS_ControlarArduino
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BTOff = new System.Windows.Forms.Button();
            this.BTOn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTOff
            // 
            this.BTOff.BackColor = System.Drawing.Color.Transparent;
            this.BTOff.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTOff.BackgroundImage")));
            this.BTOff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTOff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTOff.FlatAppearance.BorderSize = 0;
            this.BTOff.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BTOff.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BTOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTOff.Location = new System.Drawing.Point(171, 219);
            this.BTOff.Name = "BTOff";
            this.BTOff.Size = new System.Drawing.Size(134, 120);
            this.BTOff.TabIndex = 1;
            this.BTOff.UseVisualStyleBackColor = false;
            this.BTOff.Click += new System.EventHandler(this.BTOff_Click);
            // 
            // BTOn
            // 
            this.BTOn.BackColor = System.Drawing.Color.Transparent;
            this.BTOn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTOn.BackgroundImage")));
            this.BTOn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTOn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTOn.FlatAppearance.BorderSize = 0;
            this.BTOn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BTOn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BTOn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTOn.Location = new System.Drawing.Point(171, 56);
            this.BTOn.Name = "BTOn";
            this.BTOn.Size = new System.Drawing.Size(134, 131);
            this.BTOn.TabIndex = 2;
            this.BTOn.UseVisualStyleBackColor = false;
            this.BTOn.Click += new System.EventHandler(this.BTOn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(474, 400);
            this.Controls.Add(this.BTOn);
            this.Controls.Add(this.BTOff);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BTOff;
        private System.Windows.Forms.Button BTOn;
    }
}

