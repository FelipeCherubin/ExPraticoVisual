namespace ExerPrat_Filmes
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Ação", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Aventura", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("Comedia", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup4 = new System.Windows.Forms.ListViewGroup("Terror", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup5 = new System.Windows.Forms.ListViewGroup("Suspense", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup6 = new System.Windows.Forms.ListViewGroup("Documentario", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup7 = new System.Windows.Forms.ListViewGroup("Infantil", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup8 = new System.Windows.Forms.ListViewGroup("Romance", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup9 = new System.Windows.Forms.ListViewGroup("Ficção-Cientifica", System.Windows.Forms.HorizontalAlignment.Left);
            this.listView1 = new System.Windows.Forms.ListView();
            this.colunanome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colunaassistido = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colunalocal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nomefilme = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.local = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Cadastrar = new System.Windows.Forms.Button();
            this.Editar = new System.Windows.Forms.Button();
            this.excluir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colunanome,
            this.colunaassistido,
            this.colunalocal});
            this.listView1.FullRowSelect = true;
            listViewGroup1.Header = "Ação";
            listViewGroup1.Name = "grupoacao";
            listViewGroup2.Header = "Aventura";
            listViewGroup2.Name = "grupoAvent";
            listViewGroup3.Header = "Comedia";
            listViewGroup3.Name = "grupocomedia";
            listViewGroup4.Header = "Terror";
            listViewGroup4.Name = "grupoterror";
            listViewGroup5.Header = "Suspense";
            listViewGroup5.Name = "gruposuspen";
            listViewGroup6.Header = "Documentario";
            listViewGroup6.Name = "grupodoc";
            listViewGroup7.Header = "Infantil";
            listViewGroup7.Name = "grupoinfant";
            listViewGroup8.Header = "Romance";
            listViewGroup8.Name = "gruporomance";
            listViewGroup9.Header = "Ficção-Cientifica";
            listViewGroup9.Name = "grupoficcao";
            this.listView1.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2,
            listViewGroup3,
            listViewGroup4,
            listViewGroup5,
            listViewGroup6,
            listViewGroup7,
            listViewGroup8,
            listViewGroup9});
            this.listView1.Location = new System.Drawing.Point(44, 163);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(356, 248);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // colunanome
            // 
            this.colunanome.Text = "Nome";
            this.colunanome.Width = 129;
            // 
            // colunaassistido
            // 
            this.colunaassistido.Text = "Data";
            this.colunaassistido.Width = 100;
            // 
            // colunalocal
            // 
            this.colunalocal.Text = "Local";
            this.colunalocal.Width = 242;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome do Filmes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Genero";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(192, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Data que foi assistido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(192, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Local";
            // 
            // nomefilme
            // 
            this.nomefilme.Location = new System.Drawing.Point(53, 38);
            this.nomefilme.Name = "nomefilme";
            this.nomefilme.Size = new System.Drawing.Size(100, 20);
            this.nomefilme.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Ação",
            "Aventura",
            "Comédia",
            "Terror",
            "Suspense",
            "Documentario",
            "Infantil",
            "Romance",
            "Ficção Científica"});
            this.comboBox1.Location = new System.Drawing.Point(53, 109);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // local
            // 
            this.local.Location = new System.Drawing.Point(195, 109);
            this.local.Name = "local";
            this.local.Size = new System.Drawing.Size(100, 20);
            this.local.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(195, 37);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(100, 20);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // Cadastrar
            // 
            this.Cadastrar.Location = new System.Drawing.Point(325, 22);
            this.Cadastrar.Name = "Cadastrar";
            this.Cadastrar.Size = new System.Drawing.Size(75, 23);
            this.Cadastrar.TabIndex = 10;
            this.Cadastrar.Text = "Cadastrar";
            this.Cadastrar.UseVisualStyleBackColor = true;
            this.Cadastrar.Click += new System.EventHandler(this.Cadastrar_Click);
            // 
            // Editar
            // 
            this.Editar.Location = new System.Drawing.Point(325, 65);
            this.Editar.Name = "Editar";
            this.Editar.Size = new System.Drawing.Size(75, 23);
            this.Editar.TabIndex = 11;
            this.Editar.Text = "Editar";
            this.Editar.UseVisualStyleBackColor = true;
            // 
            // excluir
            // 
            this.excluir.Location = new System.Drawing.Point(325, 106);
            this.excluir.Name = "excluir";
            this.excluir.Size = new System.Drawing.Size(75, 23);
            this.excluir.TabIndex = 12;
            this.excluir.Text = "Excluir";
            this.excluir.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 428);
            this.Controls.Add(this.excluir);
            this.Controls.Add(this.Editar);
            this.Controls.Add(this.Cadastrar);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.local);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.nomefilme);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nomefilme;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox local;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ColumnHeader colunanome;
        private System.Windows.Forms.ColumnHeader colunaassistido;
        private System.Windows.Forms.ColumnHeader colunalocal;
        private System.Windows.Forms.Button Cadastrar;
        private System.Windows.Forms.Button Editar;
        private System.Windows.Forms.Button excluir;
    }
}

