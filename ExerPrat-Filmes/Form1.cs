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

        string Nome;
        string Local;
        DateTime Data;
        string Genero;
       
        Dictionary<string, List<filme>> filmes = new Dictionary<string, List<filme>>();
            
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Cadastrar_Click(object sender, EventArgs e)
        {
            List<filme> listafilmes = new List<filme>();

              Nome = nomefilme.Text;
             Local = local.Text;
            Data = dateTimePicker1.MaxDate;
            Genero = comboBox1.SelectedText;

            //filme Novofilme = new filme(Nome, Local, Data, Genero);
            
         
        }
    }
}
