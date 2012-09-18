using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ExerPrat_Filmes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Cadastrar_Click(object sender, EventArgs e)
        {
            Dictionary<string, List<string>> filmes = new Dictionary<string, List<string>>();
            List<string> listafilmes = new List<string>();
            switch (comboBox1.SelectedText)
            {
                case "ação" :
                    {
                        listafilmes.Add(nomefilme.Text);
                        filmes.Add(comboBox1.SelectedText, listafilmes);
                    }


            }
            


        }
    }
}
