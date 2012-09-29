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
            excluir.Enabled = false;
        }

       
        
        Dictionary<string, List<filme>> Difilmes = new Dictionary<string, List<filme>>();
        List<filme> listafilmes;
        ListViewItem filmes = new ListViewItem();
        filme atributo = new filme();
         filme filme;
        List<filme> TodososFilmes = new List<filme>();

        public void LimpaTexbox()
        {
            //limpando texboxs
            nomefilme.Clear();
            local.Clear();
            comboBox1.Text = "";
            nomefilme.Focus();
        }

        public void AdicionaItemListView2(filme f)
        {
            filmes = new ListViewItem();
            filmes.Text = f.nomes;
            filmes.Group = listView2.Groups[f.genero ];
            listView2.Items.Add(filmes);
            filmes.SubItems.Add(f.data.ToShortDateString());
            filmes.SubItems.Add(f.local);
        }
        public void Pesquisa()
        {
            //verifica se o combobox não é nulo, se for entra, se nao vai para outra condição
            if (pesqgenero.SelectedItem != null)
            {
                //verifica se genero ja existe no dicionario, se existe entra , se nao retorna uma mensagem dizendo que o genero nao foi encontrado 
                if (Difilmes.ContainsKey(pesqgenero.SelectedItem.ToString()))
                {
                    //pega os valores da chave do dicionario.
                    List<filme> pesqlist = Difilmes[pesqgenero.Text];

                    //percorre cada filme ate que i < pesqlist 
                    for (int i = 0; i < pesqlist.Count; i++)
                    {
                        filme = new filme();
                        //pega o objeto de cada filme que esta no pesqlist
                        filme = pesqlist[i];
                        //se a data nao for checada entra no if, se nao vai para outra condição
                        if (checkdata.Checked == false)
                        {
                            if ((pesqgenero.SelectedItem.ToString() == filme.genero && pesqnome.Text == "" && pesqlocal.Text == ""))
                            {

                                AdicionaItemListView2(filme);
                            }
                            else if (((pesqnome.Text != "" && filme.nomes.Contains(pesqnome.Text)) && (pesqlocal.Text != "" && filme.local.Contains(pesqlocal.Text))))
                            {
                                AdicionaItemListView2(filme);
                            }
                            else if ((pesqnome.Text != "" && filme.nomes.Contains(pesqnome.Text) && pesqlocal.Text == "")
                            || ((pesqlocal.Text != "" && filme.local.Contains(pesqlocal.Text) && pesqnome.Text == "")))
                            {
                                AdicionaItemListView2(filme);
                            }
                        }
                        else
                        {
                            DateTime dataA = dateTimePicker2.Value.Date;
                            DateTime dataB = dateTimePicker3.Value.Date;
                            if ((dataA <= filme.data && dataB >= filme.data) && pesqgenero.SelectedItem.ToString() == filme.genero && pesqnome.Text == "" && pesqlocal.Text == "")
                            {
                                AdicionaItemListView2(filme);
                            }
                            else if ((pesqnome.Text != "" && filme.nomes.Contains(pesqnome.Text) && pesqlocal.Text != "" && filme.local.Contains(pesqlocal.Text)
                                && (dataA <= filme.data && dataB >= filme.data)))
                            {
                                AdicionaItemListView2(filme);
                            }
                            else if ((pesqnome.Text != "" && filme.nomes.Contains(pesqnome.Text) && (dataA <= filme.data && dataB >= filme.data))
                                || (pesqlocal.Text != "" && filme.local.Contains(pesqlocal.Text) && (dataA <= filme.data && dataB >= filme.data)))
                            {
                                AdicionaItemListView2(filme);
                            }
                        }
                    }
                }
                else
                    MessageBox.Show("Este genero não possui na sua Lista de Filmes", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
          
                TodososFilmes.Clear();
                //Pega todos os valores do dicionadio
                foreach (List<filme> todalista in Difilmes.Values)
                {
                    TodososFilmes.AddRange(todalista);
                }
                //percorre cada filme ate que i < TodososFilmes
                for (int i = 0; i < TodososFilmes.Count; i++)
                {
                    filme = new filme();
                    filme = TodososFilmes[i];
                    //se a data nao for checada entra no if, se nao vai para outra condição
                    if (checkdata.Checked == false)
                    {

                        if ((pesqnome.Text != "" && filme.nomes.Contains(pesqnome.Text) && pesqlocal.Text == "")
                            || ((pesqlocal.Text != "" && filme.local.Contains(pesqlocal.Text) && pesqnome.Text == "")))
                        {
                            AdicionaItemListView2(filme);
                            
                        }
                        else if (pesqnome.Text != "" && filme.nomes.Contains(pesqnome.Text) && pesqlocal.Text != "" && filme.local.Contains(pesqlocal.Text))
                        {
                            AdicionaItemListView2(filme);
                            
                        }
                    }
                    else
                    {
                        DateTime dataA = dateTimePicker2.Value.Date;
                        DateTime dataB = dateTimePicker3.Value.Date;
                        if ((pesqnome.Text != "" && filme.nomes.Contains(pesqnome.Text) && (dataA <= filme.data && dataB >= filme.data) && pesqlocal.Text == "")
                            || (pesqlocal.Text != "" && filme.local.Contains(pesqlocal.Text) && (dataA <= filme.data && dataB >= filme.data) && pesqnome.Text == ""))
                        {
                            AdicionaItemListView2(filme);
                            
                        }
                        else if (pesqnome.Text != "" && filme.nomes.Contains(pesqnome.Text) && (dataA <= filme.data && dataB >= filme.data)
                            && pesqlocal.Text != "" && filme.local.Contains(pesqlocal.Text))
                        {
                            AdicionaItemListView2(filme);
                            
                        }
                        else if ((dataA <= filme.data && dataB >= filme.data) && pesqnome.Text== "" && pesqlocal.Text == "")
                        {
                            AdicionaItemListView2(filme);
                        }
                    }
                    
                }
            }
            
        }

        public void editalista()
        {
            //pega o objeto do grupo selecionado e joga em um List
            listafilmes = Difilmes[listView1.SelectedItems[0].Group.Header];
            for (int i = 0; i < listafilmes.Count; i++)
            {
                //criei uma variavel local do meu objeto filme e atribui o item do listafilmes para a variavel l.
                filme l = listafilmes[i];
                if (l.nomes == listView1.SelectedItems[0].Text)
                {
                    l.nomes = nomefilme.Text;
                    l.local = local.Text;
                    l.genero = comboBox1.SelectedItem.ToString();
                    l.data = dateTimePicker1.Value.Date;
                    if (Difilmes.ContainsKey(l.genero))
                    {
                        List<filme> list = Difilmes[l.genero];
                        list.Add(l);
                    }
                    else
                    {
                        
                        List<filme> list = new List<filme>();
                       
                        list.Add(l);
                        
                        Difilmes.Add(l.genero, list);
                    }
                    listafilmes.Remove(l);
                }
              
            }           

        }

        public void Dicioeatriutos()
        {

            atributo = new filme();
            
               atributo.nomes = nomefilme.Text;
                atributo.local = local.Text;
                atributo.genero = comboBox1.SelectedItem.ToString();
                atributo.data = dateTimePicker1.Value.Date ;
                //verifica se a chave ja existe
                if (Difilmes.ContainsKey(atributo.genero))
                {

                    List<filme> lista = Difilmes[atributo.genero];
                    lista.Add(atributo);
                }
                else
                {
                    //cria uma lista nova
                    List<filme> lista = new List<filme>();
                    lista.Add(atributo);
                    Difilmes.Add(atributo.genero, lista);
                }          
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Cadastrar_Click(object sender, EventArgs e)
        {
            //se nome, local e grupo estiverem sem conteudo ele retorna a mensagem, se nao ele entra na condição
            if (nomefilme.Text != "" && local.Text != "" && comboBox1.SelectedItem != null)
            {
                Dicioeatriutos();
                //inserção dos dados na tabela
                filmes = new ListViewItem();
                filmes.Text = atributo.nomes;
                filmes.Group = listView1.Groups[comboBox1.SelectedIndex];
                listView1.Items.Add(filmes);
                filmes.SubItems.Add(atributo.data.ToShortDateString());
                filmes.SubItems.Add(atributo.local);
            }
            else
                MessageBox.Show("Campo(s) não preenchidos", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimpaTexbox();
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Editar.Enabled = true;
            Cadastrar.Enabled = false;
            excluir.Enabled = true;
            //coloca os itens e subitens nos texboxs para edição
            nomefilme.Text = listView1.SelectedItems[0].Text;
            dateTimePicker1.Text = listView1.FocusedItem.SubItems[1].Text;
            local.Text = listView1.FocusedItem.SubItems[2].Text;
            comboBox1.Text = listView1.SelectedItems[0].Group.Header;

        }

        private void Editar_Click(object sender, EventArgs e)
        {
            Cadastrar.Enabled = true;
            excluir.Enabled = false;
            editalista();
            //percorre o laço pegando os itens selecionados e editando o que esta no texbos e combobox
            for (int i = listView1.SelectedItems.Count - 1; i >= 0; i--)
            {
                ListViewItem remove = listView1.SelectedItems[i];
                remove.Group = listView1.Groups[comboBox1.SelectedIndex];
                remove.Text = nomefilme.Text;
                remove.SubItems[1].Text = dateTimePicker1.Value.ToShortDateString();
                remove.SubItems[2].Text = local.Text;
            }

                Editar.Enabled = false;
                LimpaTexbox();
        }

        private void excluir_Click(object sender, EventArgs e)
        {
            
                listafilmes = Difilmes[listView1.SelectedItems[0].Group.Header];
                //remove os itens da lista
                for (int i = 0; i < listafilmes.Count; i++)
                {
                    filme l = listafilmes[i];
                    if (l.nomes == listView1.SelectedItems[0].Text)
                    {
                        listafilmes.Remove(l);
                    }

                }
                LimpaTexbox();
            //percorre o laço pegando todos os itens selecionados e depois os exclui
                for (int i = listView1.SelectedItems.Count - 1; i >= 0; i--)
                {
                    ListViewItem remove = listView1.SelectedItems[i];
                    remove.Remove();
                }
                Cadastrar.Enabled = true;
                excluir.Enabled = false;
                Editar.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pesquisa();
            button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listView2.Items.Clear();
            pesqnome.Clear();
            pesqlocal.Clear();
            pesqgenero.Text = null;
            checkdata.Checked = false;
            button1.Enabled = true;
        }
    }
}
