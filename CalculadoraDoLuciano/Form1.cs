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

namespace CalculadoraDoLuciano
{
    public partial class Form1 : Form
    {
        private OpenFileDialog openFileDialog = new OpenFileDialog();
        private Background.CSV table;

        public Form1()
        {
            InitializeComponent();
        }


        private void AbrirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog.FileName;
                table = new Background.CSV(path, ',');
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                string[] test = table.GetLineValues(0); 
                MessageBox.Show(test[0],"", buttons);
            }
        }
    }
}
