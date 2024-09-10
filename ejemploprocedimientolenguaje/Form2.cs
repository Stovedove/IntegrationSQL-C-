using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejemploprocedimientolenguaje
{
    public partial class Form2 : Form
    {
        /*Crear una Instancia de la clase ManipulaBD*/
        ManipulaBD obj1M = new ManipulaBD();
        string param, proc;

        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            proc = "validarUsuario";
            param = "" + textBox2.Text + "," + textBox1.Text + ""; //Orden de parametros del procedure
            obj1M.ConsultarBD(proc, param);

            if (obj1M.dt.Tables["objeto1"].Rows.Count == 0)
            {
                MessageBox.Show("Usuario NO VALIDO");
            }
            else
            {
                MessageBox.Show("Usuario VALIDO");
                Form1 f1 = new Form1();
                f1.Show();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
