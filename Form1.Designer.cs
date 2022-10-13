
namespace Integrador_Carritos
{
    partial class fondo
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
            this.pista = new System.Windows.Forms.PictureBox();
            this.puntuaje = new System.Windows.Forms.Label();
            this.timerCar1 = new System.Windows.Forms.Timer(this.components);
            this.timerAnimationCar1 = new System.Windows.Forms.Timer(this.components);
            this.timerGenObj1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pista)).BeginInit();
            this.SuspendLayout();
            // 
            // pista
            // 
            this.pista.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pista.Location = new System.Drawing.Point(0, 0);
            this.pista.Name = "pista";
            this.pista.Size = new System.Drawing.Size(406, 704);
            this.pista.TabIndex = 0;
            this.pista.TabStop = false;
            this.pista.Paint += new System.Windows.Forms.PaintEventHandler(this.pista_Paint);
            // 
            // puntuaje
            // 
            this.puntuaje.AutoSize = true;
            this.puntuaje.BackColor = System.Drawing.Color.Transparent;
            this.puntuaje.ForeColor = System.Drawing.Color.Blue;
            this.puntuaje.Location = new System.Drawing.Point(359, 9);
            this.puntuaje.Name = "puntuaje";
            this.puntuaje.Size = new System.Drawing.Size(13, 13);
            this.puntuaje.TabIndex = 1;
            this.puntuaje.Text = "0";
            // 
            // fondo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 704);
            this.Controls.Add(this.puntuaje);
            this.Controls.Add(this.pista);
            this.Name = "fondo";
            this.Text = "Carreras de carritos";
            this.Load += new System.EventHandler(this.fondo_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fondo_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pista;
        private System.Windows.Forms.Label puntuaje;
        private System.Windows.Forms.Timer timerCar1;
        private System.Windows.Forms.Timer timerAnimationCar1;
        private System.Windows.Forms.Timer timerGenObj1;
    }
}

