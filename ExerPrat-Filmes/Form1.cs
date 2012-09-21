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

       
       
        Dictionary<string, List<filme>> Difilmes = new Dictionary<string, List<filme>>();
        List<filme> listafilmes = new List<filme>();
        filme atributo = new filme();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Cadastrar_Click(object sender, EventArgs e)
        {

            

            atributo.nomes = nomefilme.Text;
            atributo.local = local.Text;
            atributo.genero = comboBox1.SelectedItem.ToString();
            atributo.data = dateTimePicker1.Value.ToShortDateString();

            if (Difilmes.ContainsKey(atributo.genero))
            {

                Difilmes[atributo.genero].Add(atributo);
            }
            else
            {
                Difilmes[atributo.genero] = new List<filme>();
                Difilmes[atributo.genero].Add(atributo);
            }

            ListViewItem filmes = new ListViewItem();
            filmes.Text = atributo.nomes;
            filmes.Group = listView1.Groups[comboBox1.SelectedIndex];
            listView1.Items.Add(filmes);
            filmes.SubItems.Add(atributo.data);
            filmes.SubItems.Add(atributo.local);
            nomefilme.Clear();
            local.Clear();
            comboBox1.Text = "";
            nomefilme.Focus();
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            nomefilme.Text = listView1.SelectedItems[0].Text;
            dateTimePicker1.Text = listView1.FocusedItem.SubItems[1].Text;
            local.Text = listView1.FocusedItem.SubItems[2].Text;
            comboBox1.Text = listView1.SelectedItems[0].Group.Header;

        }

        private void Editar_Click(object sender, EventArgs e)
        {
            
            listView1.SelectedItems[0].Text = nomefilme.Text;
            listView1.FocusedItem.SubItems[1].Text = dateTimePicker1.Text;
            listView1.FocusedItem.SubItems[2].Text = local.Text;


            nomefilme.Clear();
            local.Clear();
            comboBox1.Text = "";
            nomefilme.Focus();
        }

        private void excluir_Click(object sender, EventArgs e)
        {
            listView1.SelectedItems[0].Remove();
       
        }
    }
}
