
namespace SnakeGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.FondoJuego = new System.Windows.Forms.Panel();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.Coords = new System.Windows.Forms.Label();
            this.Reiniciar = new System.Windows.Forms.Button();
            this.derechaBtn = new System.Windows.Forms.Button();
            this.izquierdaBtn = new System.Windows.Forms.Button();
            this.abajoBtn = new System.Windows.Forms.Button();
            this.arribaBtn = new System.Windows.Forms.Button();
            this.Fondo = new System.Windows.Forms.Panel();
            this.MuertoTexto = new System.Windows.Forms.Label();
            this.Fondo.SuspendLayout();
            this.SuspendLayout();
            // 
            // FondoJuego
            // 
            this.FondoJuego.BackColor = System.Drawing.SystemColors.ControlDark;
            this.FondoJuego.Location = new System.Drawing.Point(12, 12);
            this.FondoJuego.Name = "FondoJuego";
            this.FondoJuego.Size = new System.Drawing.Size(348, 348);
            this.FondoJuego.TabIndex = 0;
            // 
            // Timer
            // 
            this.Timer.Interval = 500;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // Coords
            // 
            this.Coords.AutoSize = true;
            this.Coords.Location = new System.Drawing.Point(243, 365);
            this.Coords.Name = "Coords";
            this.Coords.Size = new System.Drawing.Size(40, 13);
            this.Coords.TabIndex = 4;
            this.Coords.Text = "Coords";
            // 
            // Reiniciar
            // 
            this.Reiniciar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Reiniciar.BackgroundImage = global::SnakeGame.Properties.Resources.Restart;
            this.Reiniciar.Location = new System.Drawing.Point(284, 474);
            this.Reiniciar.Margin = new System.Windows.Forms.Padding(0);
            this.Reiniciar.Name = "Reiniciar";
            this.Reiniciar.Size = new System.Drawing.Size(75, 75);
            this.Reiniciar.TabIndex = 5;
            this.Reiniciar.UseVisualStyleBackColor = false;
            this.Reiniciar.Click += new System.EventHandler(this.Reiniciar_Click);
            // 
            // derechaBtn
            // 
            this.derechaBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.derechaBtn.Image = global::SnakeGame.Properties.Resources.Derecha;
            this.derechaBtn.Location = new System.Drawing.Point(171, 431);
            this.derechaBtn.Name = "derechaBtn";
            this.derechaBtn.Size = new System.Drawing.Size(75, 75);
            this.derechaBtn.TabIndex = 3;
            this.derechaBtn.UseVisualStyleBackColor = false;
            this.derechaBtn.Click += new System.EventHandler(this.derechaBtn_Click);
            // 
            // izquierdaBtn
            // 
            this.izquierdaBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.izquierdaBtn.BackgroundImage = global::SnakeGame.Properties.Resources.Izquierda;
            this.izquierdaBtn.Location = new System.Drawing.Point(9, 431);
            this.izquierdaBtn.Name = "izquierdaBtn";
            this.izquierdaBtn.Size = new System.Drawing.Size(75, 75);
            this.izquierdaBtn.TabIndex = 2;
            this.izquierdaBtn.UseVisualStyleBackColor = false;
            this.izquierdaBtn.Click += new System.EventHandler(this.izquierdaBtn_Click);
            // 
            // abajoBtn
            // 
            this.abajoBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.abajoBtn.BackgroundImage = global::SnakeGame.Properties.Resources.Abajo;
            this.abajoBtn.Location = new System.Drawing.Point(90, 464);
            this.abajoBtn.Name = "abajoBtn";
            this.abajoBtn.Size = new System.Drawing.Size(75, 75);
            this.abajoBtn.TabIndex = 1;
            this.abajoBtn.UseVisualStyleBackColor = false;
            this.abajoBtn.Click += new System.EventHandler(this.abajoBtn_Click);
            // 
            // arribaBtn
            // 
            this.arribaBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.arribaBtn.Image = global::SnakeGame.Properties.Resources.Arriba;
            this.arribaBtn.Location = new System.Drawing.Point(90, 373);
            this.arribaBtn.Margin = new System.Windows.Forms.Padding(0);
            this.arribaBtn.Name = "arribaBtn";
            this.arribaBtn.Size = new System.Drawing.Size(75, 75);
            this.arribaBtn.TabIndex = 0;
            this.arribaBtn.UseVisualStyleBackColor = false;
            this.arribaBtn.Click += new System.EventHandler(this.arribaBtn_Click);
            // 
            // Fondo
            // 
            this.Fondo.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Fondo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Fondo.BackgroundImage")));
            this.Fondo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Fondo.Controls.Add(this.MuertoTexto);
            this.Fondo.Location = new System.Drawing.Point(12, 12);
            this.Fondo.Name = "Fondo";
            this.Fondo.Size = new System.Drawing.Size(350, 350);
            this.Fondo.TabIndex = 0;
            // 
            // MuertoTexto
            // 
            this.MuertoTexto.AutoSize = true;
            this.MuertoTexto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.MuertoTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 50.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MuertoTexto.Location = new System.Drawing.Point(54, 133);
            this.MuertoTexto.Name = "MuertoTexto";
            this.MuertoTexto.Size = new System.Drawing.Size(246, 78);
            this.MuertoTexto.TabIndex = 0;
            this.MuertoTexto.Text = "Muerto";
            this.MuertoTexto.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(368, 558);
            this.Controls.Add(this.Reiniciar);
            this.Controls.Add(this.Coords);
            this.Controls.Add(this.derechaBtn);
            this.Controls.Add(this.izquierdaBtn);
            this.Controls.Add(this.abajoBtn);
            this.Controls.Add(this.arribaBtn);
            this.Controls.Add(this.Fondo);
            this.Name = "Form1";
            this.Text = "Snake";
            this.Fondo.ResumeLayout(false);
            this.Fondo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Fondo;
        private System.Windows.Forms.Button arribaBtn;
        private System.Windows.Forms.Button abajoBtn;
        private System.Windows.Forms.Button izquierdaBtn;
        private System.Windows.Forms.Button derechaBtn;
        private System.Windows.Forms.Panel FondoJuego;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Label Coords;
        private System.Windows.Forms.Button Reiniciar;
        private System.Windows.Forms.Label MuertoTexto;
    }
}

