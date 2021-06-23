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
    public partial class inicio : Form
    {
        public inicio()
        {
            InitializeComponent();
        }
    

        private void Form1_Load(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bienvenido a preguntados", "Evaluacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {

            }
            else
            {
                Application.Exit();
            }
            
        }


        private void cmdhistoria_Click(object sender, EventArgs e)
        {
            Form formulario = new Historia1();
            formulario.Show();
           
           


        }

        
        
       


    } 
}
       
