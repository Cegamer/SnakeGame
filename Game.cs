using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeGame
{
    public partial class Game : Form
    {
        static int movimiento = 35, posicionActual = 1, tamanoCola = 0;
        static Size tamanoBloques = new Size(35, 35);
        static Panel fruta;
        static Panel[] Serpiente = new Panel[100];
        static Point ultimoPunto, guardarPunto;

        public Game()
        {

            //Timer.Start();
            InitializeComponent();
            InicializarSerpiente();
            GenerarFruta();

            Timer.Start();

        }

        private void InicializarSerpiente()
        {
            Fondo.Controls.Remove(MuertoTexto);
            posicionActual = 1;
 
                for(int i =0; i <= tamanoCola; i++)
                {
                    Fondo.Controls.Remove(Serpiente[i]);
                    Serpiente[i] = null;
                }
         
            tamanoCola = 0;

            Serpiente[0] = new Panel();

            Serpiente[0].Location = new Point(0, 0);
            Serpiente[0].BackColor = Color.Red;
            Serpiente[0].Size = tamanoBloques;

            Fondo.Controls.Add(Serpiente[0]);
        }

        private void GenerarFruta()
        {
            if (fruta == null)
            {
                Random rand = new Random();

                int x = 1;
                int y = 1;

                while (x % 35 != 0)
                {
                    x = rand.Next(0, 315);
                }
                while (y % 35 != 0)
                {
                    y = rand.Next(0, 315);
                }

                fruta = new Panel();
                fruta.Location = new Point(x, y);
                fruta.Size = tamanoBloques;
                fruta.BackColor = Color.Transparent;
                fruta.BackgroundImage = SnakeGame.Properties.Resources.fruit;

                Fondo.Controls.Add(fruta);
            }
        }

        private void Alargar()
        {
            if (fruta.Location == Serpiente[0].Location)
            {

                Fondo.Controls.Remove(fruta);
                fruta = null;
                GenerarFruta();

                Serpiente[tamanoCola + 1] = new Panel();
                Serpiente[tamanoCola + 1].Location = ultimoPunto;
                Serpiente[tamanoCola + 1].BackColor = Color.Blue;
                Serpiente[tamanoCola + 1].Size = tamanoBloques;

                Fondo.Controls.Add(Serpiente[tamanoCola + 1]);

                tamanoCola++;
            }
        }

        /*Temporizador que ejecuta el programa en bucle, evalua si la serpiente choca con los muros, si no, entonces sigue*/
        private void Timer_Tick(object sender, EventArgs e)
        {
            if ((Serpiente[0].Location.X == 315 && posicionActual == 3)
                || (Serpiente[0].Location.Y == 315 && posicionActual == 1)
                || (Serpiente[0].Location.X == 0 && posicionActual == 4)
                || (Serpiente[0].Location.Y == 0 && posicionActual == 2)) {
                Fondo.Controls.Add(MuertoTexto);
                Timer.Stop();
            }
            else
            {
                Mover();
            }

            Coords.Text = $"Coords:\nCabeza: {Serpiente[0].Location})\n Fruta: {fruta.Location}\n Tamaño cola: {tamanoCola}";

        }

        /*******  Funciones Botones  ******/

        private void arribaBtn_Click(object sender, EventArgs e)
        {
            if (Serpiente[1] == null && posicionActual != 1)
            posicionActual = 2;
            else if(posicionActual != 1)
            posicionActual = 2;

        }
        private void derechaBtn_Click(object sender, EventArgs e)
        {
            if (Serpiente[1] == null && posicionActual != 4)
            posicionActual = 3;
            else if (posicionActual != 4)
            posicionActual = 3;
        }

        private void abajoBtn_Click(object sender, EventArgs e)
        {
            if(Serpiente[1] == null && posicionActual != 2)
            posicionActual = 1;
            else if (posicionActual != 2)
            posicionActual = 1;
        }

        private void izquierdaBtn_Click(object sender, EventArgs e)
        {
            if (Serpiente[1] == null && posicionActual != 3)
            posicionActual = 4;
            else if (posicionActual != 3)
            posicionActual = 4;
        }

        private void Reiniciar_Click(object sender, EventArgs e)
        {
            InicializarSerpiente();
            GenerarFruta();
            Timer.Start();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        /* Movimiento del personaje 
           Serpiente[0] es la cabeza, se mueve independientemente del resto
           Luego se ejecuta la funcion MoverCola
           Luego, si choca con una fruta, ejecuta la funcion Alargar
         */
        private void Mover()
        {
            ultimoPunto = Serpiente[0].Location;
            switch (posicionActual)
            {
                case 1: //Abajo

                    Serpiente[0].Location = new Point(Serpiente[0].Location.X, Serpiente[0].Location.Y + movimiento);
                    break;

                case 2: //Arriba

                    Serpiente[0].Location = new Point(Serpiente[0].Location.X, Serpiente[0].Location.Y - movimiento);
                    break;

                case 3: //Derecha

                    Serpiente[0].Location = new Point(Serpiente[0].Location.X + movimiento, Serpiente[0].Location.Y);
                    break;

                case 4: //Izquierda

                    Serpiente[0].Location = new Point(Serpiente[0].Location.X - movimiento, Serpiente[0].Location.Y);
                    break;
            }
            Morir();
            MoverCola();
            Alargar();
        }

        private void Morir()
        {
            if (Serpiente[1] != null)
            {
                for (int a = 1; a <= tamanoCola; a++)
                {
                    if (Serpiente[0].Location == Serpiente[a].Location)
                    {
                        Fondo.Controls.Add(MuertoTexto);
                        Timer.Stop();
                    }
                }
            }
        }

        private void MoverCola()
        {
            if(Serpiente[1] != null)
            {
                for(int i = 1; i <= tamanoCola; i++) {

                    guardarPunto = Serpiente[i].Location;
                    Serpiente[i].Location = ultimoPunto;
                    ultimoPunto = guardarPunto;
                }
            }
            
        }
    }
}
