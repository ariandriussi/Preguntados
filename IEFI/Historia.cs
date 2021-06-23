using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IEFI
{
    public partial class Historia1 : Form
    {
        public Historia1()
        {
            InitializeComponent();
        }

        private void preguntas_Load(object sender, EventArgs e)
        {
            pregunta1historia();

        }
        int resultado = 0;
        int seleccion = 1;
        int falla = 0;

     


      
        
        private void pregunta1historia()
        {

            {
                pregunta.Text = "¿Cual es el unico pais de Sudamerica que no habla español?";
                this.opcion1.Text = " Argentina";
                this.opcion2.Text = "Chile";
                 this.opcion3.Text = "Brasil"; 
                this.opcion4.Text = "Colombia.";
               

            }





        }

        private void pregunta2historia()
        {
            this.pregunta.Text = "¿En que año fue la revolucion de mayo?";
            this.opcion1.Text = "1810."; 
            this.opcion2.Text = "1816.";
            this.opcion3.Text = "1813.";
            this.opcion4.Text = "1799.";
            seleccion++;
        }
        private void pregunta3historia()
        {
            this.pregunta.Text = "¿Cual era la capital del imperio inca?";
            this.opcion1.Text = "Cuzco"; 
            this.opcion2.Text = "Quito";
            this.opcion3.Text = "Machu picchu";
            this.opcion4.Text = "Lima";
            seleccion++;
        }
        private void pregunta4historia()
        {
            this.pregunta.Text = "¿En que guerra participo juana de arco? ";
            this.opcion1.Text = "Primera cruzada";
            this.opcion2.Text = "Guerras napoleonicas";
            this.opcion3.Text = "La guerra de los 100 años"; 
            this.opcion4.Text = "La guerra de los 30 años";
            seleccion++;
        }
        private void pregunta5historia()
        {
            this.pregunta.Text = "¿Quien fue el primer emperador romano?";
            this.opcion1.Text = "Julio Cesar";
            this.opcion2.Text = " Cesar Augusto"; 
            this.opcion3.Text = "Nerón";
            this.opcion4.Text = "Caligula";
            seleccion++;
        }

        void jugadorAcierta()
        {

            lblmuestra.Text = Convert.ToString("Acertaste");
            lblmuestra.BackColor = Color.Green;
            resultado++;


        }
        void jugadorpierde()
        {

            lblmuestra.Text = Convert.ToString("Fallaste");
            lblmuestra.BackColor = Color.Red;
            falla++;
            
        }
        private void Limpiar()
        {
            this.opcion1.Checked = true;
          
        }






        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cmdsiguiente_Click(object sender, EventArgs e)
        {
           
        }

        private void cmdopcion_Click(object sender, EventArgs e)
        {
            switch (seleccion)
            {
                case 1:
                    if (this.opcion3.Checked == true)
                    {

                        jugadorAcierta();
                        resultado++;
                    }
                    else
                    {
                        jugadorpierde();
                    }
                    Limpiar();
                    pregunta2historia();
                    

                    break;
                case 2:
                    if (this.opcion1.Checked == true)
                    {

                        jugadorAcierta();
                        resultado++;
                    }
                    else
                    {
                        jugadorpierde();
                    }
                    Limpiar();
                    pregunta3historia();

                    break;
                case 3:
                    if (this.opcion1.Checked == true)
                    {
                        jugadorAcierta();

                        resultado++;
                    }
                    else
                    {
                        jugadorpierde();
                    }
                    Limpiar();
                    pregunta4historia();

                    break;
                case 4:
                    if (this.opcion3.Checked == true)
                    {
                        jugadorAcierta();

                        resultado++;
                    }
                    else
                    {
                        jugadorpierde();
                    }
                    Limpiar();
                    pregunta5historia();

                    break;
                case 5:
                    if (this.opcion2.Checked == true)
                    {

                        jugadorAcierta();
                        resultado++;
                    }
                    else
                    {
                        jugadorpierde();
                    }

                    Limpiar();

                    break;
            }
        }
    }
}

