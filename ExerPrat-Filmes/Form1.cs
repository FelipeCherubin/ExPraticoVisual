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
            Editar.Enabled = false;
        }


        
        Dictionary<string, List<filme>> Difilmes = new Dictionary<string, List<filme>>();
        List<filme> listafilmes;
        ListViewItem filmes = new ListViewItem();
        filme atributo = new filme();
        
        public void editalista()
        {
         
            string nome = listView1.SelectedItems[0].Text;
            string data = listView1.FocusedItem.SubItems[1].Text;
            string locals = listView1.FocusedItem.SubItems[2].Text;
            string genero = listView1.SelectedItems[0].Group.Header;
            foreach (List<filme> fil in Difilmes.Values)
            {
                foreach (filme i in fil)
                {
                     if (nome == i.nomes && data == i.data && locals == i.local && genero == i .genero)
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
                            //cria uma lista nova
                            Difilmes[atributo.genero] = new List<filme>();
                            Difilmes[atributo.genero].Add(atributo);
                        }
                    }
                }
            
               
                
            }           

        }

        public void pesquisa()
        {
            foreach (List<filme> fil in Difilmes.Values)
            {
                foreach (filme i in fil)
                {
                    listBox1.Items.Add(i.nomes);
                    listBox1.Items.Add(i.local );
                    listBox1.Items.Add(i.data );
                    listBox1.Items.Add(i.genero );
                }
            }
        }

        public void Dicioeatriutos()
        {

            atributo = new filme();
            
               atributo.nomes = nomefilme.Text;
                atributo.local = local.Text;
                atributo.genero = comboBox1.SelectedItem.ToString();
                atributo.data = dateTimePicker1.Value.ToShortDateString();
                //verifica se a chave ja existe
                if (Difilmes.ContainsKey(atributo.genero))
                {

                    Difilmes[atributo.genero].Add(atributo);
                }
                else
                {
                    //cria uma lista nova
                    Difilmes[atributo.genero] = new List<filme>();
                    Difilmes[atributo.genero].Add(atributo);
                }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Cadastrar_Click(object sender, EventArgs e)
        {

            Dicioeatriutos();
            //inserção dos dados na tabela
            filmes = new ListViewItem();
            filmes.Text = atributo.nomes;
            filmes.Group = listView1.Groups[comboBox1.SelectedIndex];
            listView1.Items.Add(filmes);
            filmes.SubItems.Add(atributo.data);
            filmes.SubItems.Add(atributo.local);
            
            
            //limpando texboxs
            nomefilme.Clear();
            local.Clear();
            comboBox1.Text = "";
            nomefilme.Focus();
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Editar.Enabled = true;
            Cadastrar.Enabled = false;
            //coloca os itens e subitens nos texboxs para edição
            nomefilme.Text = listView1.SelectedItems[0].Text;
            dateTimePicker1.Text = listView1.FocusedItem.SubItems[1].Text;
            local.Text = listView1.FocusedItem.SubItems[2].Text;
            comboBox1.Text = listView1.SelectedItems[0].Group.Header;

        }

        private void Editar_Click(object sender, EventArgs e)
        {
            Cadastrar.Enabled = true;
            Dicioeatriutos();
            editalista();
            for (int i = listView1.SelectedItems.Count - 1; i >= 0; i--)
            {
                ListViewItem remove = listView1.SelectedItems[i];
                remove.Group = listView1.Groups[comboBox1.SelectedIndex];
                remove.Text = nomefilme.Text;
                remove.SubItems[1].Text = dateTimePicker1.Text;
                remove.SubItems[2].Text = local.Text;
            }

                Editar.Enabled = false;


            nomefilme.Clear();
            local.Clear();
            comboBox1.Text = "";
            nomefilme.Focus();
        }

        private void excluir_Click(object sender, EventArgs e)
        {
            listView1.SelectedItems[0].Remove();
       
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pesquisa();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
