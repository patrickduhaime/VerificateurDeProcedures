using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Verificateur : Form
    {
        public static Verificateur instance = null;

        public Verificateur()
        {
            instance = this;
            InitializeComponent();
        }

        public void showMessage(string message)
        {
            textBoxResultats.Text = message;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxProcedure.Text = "Procedure identi1 declare id2 : entier ;declare id3 : reel ; id2 = (3 + 2) * 3 ; id3 = id2 / (4 - 5) Fin_Procedure identi1";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            File.WriteAllText("file.txt", textBoxProcedure.Text);
            Analyseur.Run();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            textBoxProcedure.Text = "Procedure identi1 declare id2 : entier ;declare id3 : reel ; id2 = (3 + 2) * 3 ; id3 = id2 / (4 - 5) Fin_Procedure identi1";
            textBoxResultats.Clear();
        }
    }
}
