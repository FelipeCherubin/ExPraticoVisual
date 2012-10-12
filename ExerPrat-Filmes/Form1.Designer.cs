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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewGroup listViewGroup73 = new System.Windows.Forms.ListViewGroup("Ação", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup74 = new System.Windows.Forms.ListViewGroup("Aventura", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup75 = new System.Windows.Forms.ListViewGroup("Comédia", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup76 = new System.Windows.Forms.ListViewGroup("Terror", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup77 = new System.Windows.Forms.ListViewGroup("Suspense", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup78 = new System.Windows.Forms.ListViewGroup("Documentario", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup79 = new System.Windows.Forms.ListViewGroup("Infantil", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup80 = new System.Windows.Forms.ListViewGroup("Romance", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup81 = new System.Windows.Forms.ListViewGroup("Ficção-Científica", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup82 = new System.Windows.Forms.ListViewGroup("Ação", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup83 = new System.Windows.Forms.ListViewGroup("Aventura", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup84 = new System.Windows.Forms.ListViewGroup("Comédia", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup85 = new System.Windows.Forms.ListViewGroup("Terror", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup86 = new System.Windows.Forms.ListViewGroup("Suspense", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup87 = new System.Windows.Forms.ListViewGroup("Documentario", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup88 = new System.Windows.Forms.ListViewGroup("Infantil", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup89 = new System.Windows.Forms.ListViewGroup("Romance", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup90 = new System.Windows.Forms.ListViewGroup("Ficção-Científica", System.Windows.Forms.HorizontalAlignment.Left);
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pesqnome = new System.Windows.Forms.TextBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.pesqlocal = new System.Windows.Forms.TextBox();
            this.listView2 = new System.Windows.Forms.ListView();
            this.colunanome1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colunaassistido1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colunalocal1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.checkdata = new System.Windows.Forms.CheckBox();
            this.pesqgenero = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colunanome,
            this.colunaassistido,
            this.colunalocal});
            this.listView1.FullRowSelect = true;
            listViewGroup73.Header = "Ação";
            listViewGroup73.Name = "grupoacao";
            listViewGroup74.Header = "Aventura";
            listViewGroup74.Name = "grupoAvent";
            listViewGroup75.Header = "Comédia";
            listViewGroup75.Name = "grupocomedia";
            listViewGroup76.Header = "Terror";
            listViewGroup76.Name = "grupoterror";
            listViewGroup77.Header = "Suspense";
            listViewGroup77.Name = "gruposuspen";
            listViewGroup78.Header = "Documentario";
            listViewGroup78.Name = "grupodoc";
            listViewGroup79.Header = "Infantil";
            listViewGroup79.Name = "grupoinfant";
            listViewGroup80.Header = "Romance";
            listViewGroup80.Name = "gruporomance";
            listViewGroup81.Header = "Ficção-Científica";
            listViewGroup81.Name = "grupoficcao";
            this.listView1.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup73,
            listViewGroup74,
            listViewGroup75,
            listViewGroup76,
            listViewGroup77,
            listViewGroup78,
            listViewGroup79,
            listViewGroup80,
            listViewGroup81});
            this.listView1.Location = new System.Drawing.Point(12, 234);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(434, 218);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // colunanome
            // 
            this.colunanome.Text = "Nome";
            this.colunanome.Width = 197;
            // 
            // colunaassistido
            // 
            this.colunaassistido.Text = "Data";
            this.colunaassistido.Width = 132;
            // 
            // colunalocal
            // 
            this.colunalocal.Text = "Local";
            this.colunalocal.Width = 242;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome do Filmes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(190, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Genero";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Data que foi assistido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Local";
            // 
            // nomefilme
            // 
            this.nomefilme.Location = new System.Drawing.Point(9, 31);
            this.nomefilme.Name = "nomefilme";
            this.nomefilme.Size = new System.Drawing.Size(391, 20);
            this.nomefilme.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            "Ficção-Científica"});
            this.comboBox1.Location = new System.Drawing.Point(193, 69);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(114, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // local
            // 
            this.local.Location = new System.Drawing.Point(9, 109);
            this.local.Multiline = true;
            this.local.Name = "local";
            this.local.Size = new System.Drawing.Size(391, 22);
            this.local.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(9, 70);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(105, 20);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // Cadastrar
            // 
            this.Cadastrar.Location = new System.Drawing.Point(220, 201);
            this.Cadastrar.Name = "Cadastrar";
            this.Cadastrar.Size = new System.Drawing.Size(65, 27);
            this.Cadastrar.TabIndex = 10;
            this.Cadastrar.Text = "Cadastrar";
            this.Cadastrar.UseVisualStyleBackColor = true;
            this.Cadastrar.Click += new System.EventHandler(this.Cadastrar_Click);
            // 
            // Editar
            // 
            this.Editar.Location = new System.Drawing.Point(291, 201);
            this.Editar.Name = "Editar";
            this.Editar.Size = new System.Drawing.Size(75, 27);
            this.Editar.TabIndex = 11;
            this.Editar.Text = "Editar";
            this.Editar.UseVisualStyleBackColor = true;
            this.Editar.Click += new System.EventHandler(this.Editar_Click);
            // 
            // excluir
            // 
            this.excluir.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.excluir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.excluir.Location = new System.Drawing.Point(372, 201);
            this.excluir.Name = "excluir";
            this.excluir.Size = new System.Drawing.Size(75, 27);
            this.excluir.TabIndex = 12;
            this.excluir.Text = "Excluir";
            this.excluir.UseVisualStyleBackColor = true;
            this.excluir.Click += new System.EventHandler(this.excluir_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(1, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(919, 27);
            this.textBox1.TabIndex = 13;
            this.textBox1.Text = "Cadastro de filmes";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(721, 201);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 27);
            this.button1.TabIndex = 14;
            this.button1.Text = "Pesquisa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(802, 201);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 27);
            this.button2.TabIndex = 16;
            this.button2.Text = "Limpar Pesquisa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Nome";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Local";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(143, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Data Final";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Data inicial";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(269, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Genero";
            // 
            // pesqnome
            // 
            this.pesqnome.Location = new System.Drawing.Point(9, 32);
            this.pesqnome.Name = "pesqnome";
            this.pesqnome.Size = new System.Drawing.Size(384, 20);
            this.pesqnome.TabIndex = 22;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(30, 72);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(102, 20);
            this.dateTimePicker2.TabIndex = 24;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker3.Location = new System.Drawing.Point(138, 72);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(100, 20);
            this.dateTimePicker3.TabIndex = 25;
            // 
            // pesqlocal
            // 
            this.pesqlocal.Location = new System.Drawing.Point(9, 114);
            this.pesqlocal.Multiline = true;
            this.pesqlocal.Name = "pesqlocal";
            this.pesqlocal.Size = new System.Drawing.Size(384, 19);
            this.pesqlocal.TabIndex = 26;
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colunanome1,
            this.colunaassistido1,
            this.colunalocal1});
            listViewGroup82.Header = "Ação";
            listViewGroup82.Name = "Ação";
            listViewGroup83.Header = "Aventura";
            listViewGroup83.Name = "Aventura";
            listViewGroup84.Header = "Comédia";
            listViewGroup84.Name = "Comédia";
            listViewGroup85.Header = "Terror";
            listViewGroup85.Name = "Terror";
            listViewGroup86.Header = "Suspense";
            listViewGroup86.Name = "Suspense";
            listViewGroup87.Header = "Documentario";
            listViewGroup87.Name = "Documentario";
            listViewGroup88.Header = "Infantil";
            listViewGroup88.Name = "Infantil";
            listViewGroup89.Header = "Romance";
            listViewGroup89.Name = "Romance";
            listViewGroup90.Header = "Ficção-Científica";
            listViewGroup90.Name = "Ficção-Científica";
            this.listView2.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup82,
            listViewGroup83,
            listViewGroup84,
            listViewGroup85,
            listViewGroup86,
            listViewGroup87,
            listViewGroup88,
            listViewGroup89,
            listViewGroup90});
            this.listView2.Location = new System.Drawing.Point(471, 234);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(434, 218);
            this.listView2.TabIndex = 27;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // colunanome1
            // 
            this.colunanome1.Text = "Nome";
            this.colunanome1.Width = 196;
            // 
            // colunaassistido1
            // 
            this.colunaassistido1.Text = "Data";
            this.colunaassistido1.Width = 130;
            // 
            // colunalocal1
            // 
            this.colunalocal1.Text = "Local";
            this.colunalocal1.Width = 262;
            // 
            // checkdata
            // 
            this.checkdata.AutoSize = true;
            this.checkdata.Location = new System.Drawing.Point(9, 76);
            this.checkdata.Name = "checkdata";
            this.checkdata.Size = new System.Drawing.Size(15, 14);
            this.checkdata.TabIndex = 29;
            this.checkdata.UseVisualStyleBackColor = true;
            // 
            // pesqgenero
            // 
            this.pesqgenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pesqgenero.FormattingEnabled = true;
            this.pesqgenero.Items.AddRange(new object[] {
            "Ação",
            "Aventura",
            "Comédia",
            "Terror",
            "Suspense",
            "Documentario",
            "Infantil",
            "Romance",
            "Ficção-Científica"});
            this.pesqgenero.Location = new System.Drawing.Point(272, 70);
            this.pesqgenero.Name = "pesqgenero";
            this.pesqgenero.Size = new System.Drawing.Size(121, 21);
            this.pesqgenero.TabIndex = 32;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.nomefilme);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.local);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Location = new System.Drawing.Point(12, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(434, 161);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastro";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.pesqgenero);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.checkdata);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.pesqlocal);
            this.groupBox2.Controls.Add(this.pesqnome);
            this.groupBox2.Controls.Add(this.dateTimePicker3);
            this.groupBox2.Controls.Add(this.dateTimePicker2);
            this.groupBox2.Location = new System.Drawing.Point(471, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(434, 161);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pesquisa";
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(917, 464);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.excluir);
            this.Controls.Add(this.Editar);
            this.Controls.Add(this.Cadastrar);
            this.Controls.Add(this.listView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Filmes";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox pesqnome;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.TextBox pesqlocal;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader colunanome1;
        private System.Windows.Forms.ColumnHeader colunaassistido1;
        private System.Windows.Forms.ColumnHeader colunalocal1;
        private System.Windows.Forms.CheckBox checkdata;
        private System.Windows.Forms.ComboBox pesqgenero;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

