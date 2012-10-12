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
        List<filme> ListaFilmes;
        ListViewItem Filmes = new ListViewItem();
        filme Atributo = new filme();
         filme Filme;
        List<filme> TodososFilmes = new List<filme>();

        public void LimpaTexbox()
        {
            //limpando texboxs
            nomefilme.Clear();
            local.Clear();
            comboBox1.SelectedItem = null;
            nomefilme.Focus();
        }

        public void DetectaErro()
        {
            foreach (Control tex in this.groupBox1.Controls)
            {
                if (tex is TextBox)
                {
                    TextBox t = (TextBox)tex;
                    if (t.Text == "")
                        errorProvider1.SetError(t, "Digite o(s) Campo(s) Vazio(s)");
                    else
                        errorProvider1.SetError(t, "");
                }
            }

            if (comboBox1.SelectedItem == null)
                errorProvider1.SetError(comboBox1, "Digite o(s) Campo(s) Vazio(s)");
            else
                errorProvider1.SetError(comboBox1, "");
        }

        public void AdicionaItemListView2(filme f)
        {
            Filmes = new ListViewItem();
            Filmes.Text = f.nomes;
            Filmes.Group = listView2.Groups[f.genero ];
            listView2.Items.Add(Filmes);
            Filmes.SubItems.Add(f.data.ToShortDateString());
            Filmes.SubItems.Add(f.local);
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
                        Filme = new filme();
                        //pega o objeto de cada filme que esta no pesqlist
                        Filme = pesqlist[i];
                        //se a data nao for checada entra no if, se nao vai para outra condição
                        if (checkdata.Checked == false)
                        {
                            if ( pesqnome.Text == "" && pesqlocal.Text == "")
                               AdicionaItemListView2(Filme);

                            else if (((pesqnome.Text != "" && Filme.nomes.Contains(pesqnome.Text)) && (pesqlocal.Text != "" && Filme.local.Contains(pesqlocal.Text))))
                                AdicionaItemListView2(Filme);

                            else if ((pesqnome.Text != "" && Filme.nomes.Contains(pesqnome.Text) && pesqlocal.Text == "")
                            || ((pesqlocal.Text != "" && Filme.local.Contains(pesqlocal.Text) && pesqnome.Text == "")))
                                AdicionaItemListView2(Filme);
                        }
                        else
                        {
                            DateTime dataA = dateTimePicker2.Value.Date;
                            DateTime dataB = dateTimePicker3.Value.Date;
                            
                            if ((dataA <= Filme.data && dataB >= Filme.data) && pesqnome.Text == "" && pesqlocal.Text == "")
                                AdicionaItemListView2(Filme);
                            
                            else if ((pesqnome.Text != "" && Filme.nomes.Contains(pesqnome.Text) && pesqlocal.Text != "" && Filme.local.Contains(pesqlocal.Text)
                                && (dataA <= Filme.data && dataB >= Filme.data)))
                                AdicionaItemListView2(Filme);
                            
                            else if ((pesqnome.Text != "" && Filme.nomes.Contains(pesqnome.Text) && (dataA <= Filme.data && dataB >= Filme.data) && pesqlocal.Text == "")
                                || (pesqlocal.Text != "" && Filme.local.Contains(pesqlocal.Text) && (dataA <= Filme.data && dataB >= Filme.data) && pesqnome.Text == ""))
                                AdicionaItemListView2(Filme);                         
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
                    TodososFilmes.AddRange(todalista);

                //percorre cada filme ate que i < TodososFilmes
                for (int i = 0; i < TodososFilmes.Count; i++)
                {
                    Filme = new filme();
                    Filme = TodososFilmes[i];
                    //se a data nao for checada entra no if, se nao vai para outra condição
                    if (checkdata.Checked == false)
                    {
                        if ((pesqnome.Text != "" && Filme.nomes.Contains(pesqnome.Text) && pesqlocal.Text == "")
                            || ((pesqlocal.Text != "" && Filme.local.Contains(pesqlocal.Text) && pesqnome.Text == "")))
                            AdicionaItemListView2(Filme);                            
                        
                        else if (pesqnome.Text != "" && Filme.nomes.Contains(pesqnome.Text) && pesqlocal.Text != "" && Filme.local.Contains(pesqlocal.Text))
                            AdicionaItemListView2(Filme);                           
                    }
                    else
                    {
                        DateTime dataA = dateTimePicker2.Value.Date;
                        DateTime dataB = dateTimePicker3.Value.Date;
                       
                        if ((pesqnome.Text != "" && Filme.nomes.Contains(pesqnome.Text) && (dataA <= Filme.data && dataB >= Filme.data) && pesqlocal.Text == "")
                            || (pesqlocal.Text != "" && Filme.local.Contains(pesqlocal.Text) && (dataA <= Filme.data && dataB >= Filme.data) && pesqnome.Text == ""))
                            AdicionaItemListView2(Filme);

                        else if (pesqnome.Text != "" && Filme.nomes.Contains(pesqnome.Text) && (dataA <= Filme.data && dataB >= Filme.data)
                            && pesqlocal.Text != "" && Filme.local.Contains(pesqlocal.Text))
                            AdicionaItemListView2(Filme);

                        else if ((dataA <= Filme.data && dataB >= Filme.data) && pesqnome.Text == "" && pesqlocal.Text == "")
                            AdicionaItemListView2(Filme);                     
                    }                    
                }
            }           
        }

        public void EditaLista()
        {
            //pega o objeto do grupo selecionado e joga em um List
            ListaFilmes = Difilmes[listView1.SelectedItems[0].Group.Header];
            for (int i = 0; i < ListaFilmes.Count; i++)
            {
                //criei uma variavel local do meu objeto filme e atribui o item do listafilmes para a variavel l.
                filme L = ListaFilmes[i];
                if (L.nomes == listView1.SelectedItems[0].Text)
                {
                    L.nomes = nomefilme.Text;
                    L.local = local.Text;
                    L.genero = comboBox1.SelectedItem.ToString();
                    L.data = dateTimePicker1.Value.Date;
                    if (Difilmes.ContainsKey(L.genero))
                    {
                        List<filme> list = Difilmes[L.genero];
                        list.Add(L);
                    }
                    else
                    {                       
                        List<filme> list = new List<filme>();                       
                        list.Add(L);                       
                        Difilmes.Add(L.genero, list);
                    }
                    ListaFilmes.Remove(L);
                }              
            }           
        }

        public void DicionarioeClasseFilme()
        {
                Atributo = new filme();
            
                Atributo.nomes = nomefilme.Text;
                Atributo.local = local.Text;
                Atributo.genero = comboBox1.SelectedItem.ToString();
                Atributo.data = dateTimePicker1.Value.Date ;
                //verifica se a chave ja existe
                if (Difilmes.ContainsKey(Atributo.genero))
                {
                    List<filme> lista = Difilmes[Atributo.genero];
                    lista.Add(Atributo);
                }
                else
                {
                    //cria uma lista nova
                    List<filme> lista = new List<filme>();
                    lista.Add(Atributo);
                    Difilmes.Add(Atributo.genero, lista);
                }          
        }

        private void Cadastrar_Click(object sender, EventArgs e)
        {
            //se nome, local e grupo estiverem sem conteudo ele retorna a mensagem, se nao ele entra na condição &&
            if (nomefilme.Text != "" && local.Text != "" && comboBox1.SelectedItem != null)
            {
                errorProvider1.Clear();
                DicionarioeClasseFilme();
                //inserção dos dados na tabela
                Filmes = new ListViewItem();
                Filmes.Text = Atributo.nomes;
                Filmes.Group = listView1.Groups[comboBox1.SelectedIndex];
                listView1.Items.Add(Filmes);
                Filmes.SubItems.Add(Atributo.data.ToShortDateString());
                Filmes.SubItems.Add(Atributo.local);
                LimpaTexbox();
            }
            else
                DetectaErro();
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
            //percorre o laço pegando os itens selecionados e editando o que esta no texbos e combobox
            if (nomefilme.Text != "" && local.Text != "" && comboBox1.SelectedItem != null)
            {
                errorProvider1.Clear();
                EditaLista();
                for (int i = listView1.SelectedItems.Count - 1; i >= 0; i--)
                {
                    ListViewItem altera = listView1.SelectedItems[i];
                    altera.Group = listView1.Groups[comboBox1.SelectedIndex];
                    altera.Text = nomefilme.Text;
                    altera.SubItems[1].Text = dateTimePicker1.Value.ToShortDateString();
                    altera.SubItems[2].Text = local.Text;
                }
                Editar.Enabled = false;
                LimpaTexbox();
            }
            else
                DetectaErro();
        }

        private void excluir_Click(object sender, EventArgs e)
        {            
                ListaFilmes = Difilmes[listView1.SelectedItems[0].Group.Header];
                //remove os itens da lista
                for (int i = 0; i < ListaFilmes.Count; i++)
                {
                    filme l = ListaFilmes[i];
                    if (l.nomes == listView1.SelectedItems[0].Text)
                    {
                        ListaFilmes.Remove(l);
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
        //botão pesquisa
        private void button1_Click(object sender, EventArgs e)
        {
            Pesquisa();
            button1.Enabled = false;
        }
        //botão limpa Pesquisa
        private void button2_Click(object sender, EventArgs e)
        {
            listView2.Items.Clear();
            pesqnome.Clear();
            pesqlocal.Clear();
            pesqgenero.Text = null;
            checkdata.Checked = false;
            button1.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
