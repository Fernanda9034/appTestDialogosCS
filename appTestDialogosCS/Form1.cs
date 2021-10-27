using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace appTestDialogosCS
{
    public partial class Form1 : Form
    {
        private string linea;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
           
            OpenFileDialog dialogo = new OpenFileDialog();
            if(dialogo.ShowDialog() == DialogResult.OK);
            {
                MessageBox.Show(dialogo.FileName);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialogo = new SaveFileDialog();
            if (dialogo.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(dialogo.FileName);
            }

        }
     
        //int contador = 0;
        //string linea = "";

        // lee el archivo te texto linea por linea.
        //StreamReader file = new StreamReader(@"C:\test.txt");

        //while ((linea = file.ReadLine()) != null)
        //{
        //Console.WriteLine(linea);
        //contador++;
        //}
        //file.Close();
        //Console.WriteLine("There were {0} lines.", contador);
        //Suspend the screen.  
        //Console.ReadLine();
        //}
        
    }
}
