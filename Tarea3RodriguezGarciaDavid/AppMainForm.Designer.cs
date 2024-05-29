namespace Tarea3RodriguezGarciaDavid
{
    partial class AppMainForm
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnCombate = new System.Windows.Forms.Button();
            this.lstEquipoAleatorio = new System.Windows.Forms.ListBox();
            this.btnCrearEquipoAleatorio = new System.Windows.Forms.Button();
            this.txtPokemonSelec = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.dgPokemons = new System.Windows.Forms.DataGridView();
            this.lstPokemons = new System.Windows.Forms.ListBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.numeroPokedexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pesoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pokemonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPokemons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokemonBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(180, 38);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(296, 14);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(761, 38);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(296, 14);
            this.panel4.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1268, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "v1.0";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.btnCombate);
            this.panel1.Controls.Add(this.lstEquipoAleatorio);
            this.panel1.Controls.Add(this.btnCrearEquipoAleatorio);
            this.panel1.Controls.Add(this.txtPokemonSelec);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.dgPokemons);
            this.panel1.Controls.Add(this.lstPokemons);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(22, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1315, 730);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = global::Tarea3RodriguezGarciaDavid.Properties.Resources.pb22;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Location = new System.Drawing.Point(1112, 355);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(148, 134);
            this.pictureBox5.TabIndex = 14;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImage = global::Tarea3RodriguezGarciaDavid.Properties.Resources.pb11;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(920, 355);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(148, 134);
            this.pictureBox4.TabIndex = 13;
            this.pictureBox4.TabStop = false;
            // 
            // btnCombate
            // 
            this.btnCombate.BackColor = System.Drawing.Color.Red;
            this.btnCombate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCombate.ForeColor = System.Drawing.Color.White;
            this.btnCombate.Location = new System.Drawing.Point(888, 502);
            this.btnCombate.Name = "btnCombate";
            this.btnCombate.Size = new System.Drawing.Size(407, 101);
            this.btnCombate.TabIndex = 12;
            this.btnCombate.Text = "Combate  Pokémon";
            this.btnCombate.UseVisualStyleBackColor = false;
            this.btnCombate.Click += new System.EventHandler(this.btnCombate_Click);
            // 
            // lstEquipoAleatorio
            // 
            this.lstEquipoAleatorio.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstEquipoAleatorio.FormattingEnabled = true;
            this.lstEquipoAleatorio.ItemHeight = 23;
            this.lstEquipoAleatorio.Location = new System.Drawing.Point(962, 178);
            this.lstEquipoAleatorio.Name = "lstEquipoAleatorio";
            this.lstEquipoAleatorio.Size = new System.Drawing.Size(262, 142);
            this.lstEquipoAleatorio.TabIndex = 11;
            // 
            // btnCrearEquipoAleatorio
            // 
            this.btnCrearEquipoAleatorio.BackColor = System.Drawing.Color.Red;
            this.btnCrearEquipoAleatorio.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearEquipoAleatorio.ForeColor = System.Drawing.Color.White;
            this.btnCrearEquipoAleatorio.Location = new System.Drawing.Point(932, 77);
            this.btnCrearEquipoAleatorio.Name = "btnCrearEquipoAleatorio";
            this.btnCrearEquipoAleatorio.Size = new System.Drawing.Size(316, 74);
            this.btnCrearEquipoAleatorio.TabIndex = 10;
            this.btnCrearEquipoAleatorio.Text = "Crear  Equipo  Aleatorio";
            this.btnCrearEquipoAleatorio.UseVisualStyleBackColor = false;
            this.btnCrearEquipoAleatorio.Click += new System.EventHandler(this.btnCrearEquipoAleatorio_Click);
            // 
            // txtPokemonSelec
            // 
            this.txtPokemonSelec.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPokemonSelec.Location = new System.Drawing.Point(528, 203);
            this.txtPokemonSelec.Multiline = true;
            this.txtPokemonSelec.Name = "txtPokemonSelec";
            this.txtPokemonSelec.Size = new System.Drawing.Size(297, 424);
            this.txtPokemonSelec.TabIndex = 9;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::Tarea3RodriguezGarciaDavid.Properties.Resources.pokedexlat;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(487, 148);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(376, 532);
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // dgPokemons
            // 
            this.dgPokemons.AutoGenerateColumns = false;
            this.dgPokemons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPokemons.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numeroPokedexDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.pesoDataGridViewTextBoxColumn,
            this.alturaDataGridViewTextBoxColumn});
            this.dgPokemons.DataSource = this.pokemonBindingSource;
            this.dgPokemons.Location = new System.Drawing.Point(149, 189);
            this.dgPokemons.Name = "dgPokemons";
            this.dgPokemons.RowHeadersWidth = 51;
            this.dgPokemons.RowTemplate.Height = 24;
            this.dgPokemons.Size = new System.Drawing.Size(324, 476);
            this.dgPokemons.TabIndex = 7;
            this.dgPokemons.DoubleClick += new System.EventHandler(this.dgPokemons_DoubleClick);
            // 
            // lstPokemons
            // 
            this.lstPokemons.FormattingEnabled = true;
            this.lstPokemons.ItemHeight = 16;
            this.lstPokemons.Location = new System.Drawing.Point(158, 271);
            this.lstPokemons.Name = "lstPokemons";
            this.lstPokemons.Size = new System.Drawing.Size(230, 276);
            this.lstPokemons.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Tarea3RodriguezGarciaDavid.Properties.Resources.pokedex;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(0, 15);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(559, 707);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Tarea3RodriguezGarciaDavid.Properties.Resources.lgg;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(508, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(218, 69);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // numeroPokedexDataGridViewTextBoxColumn
            // 
            this.numeroPokedexDataGridViewTextBoxColumn.DataPropertyName = "NumeroPokedex";
            this.numeroPokedexDataGridViewTextBoxColumn.HeaderText = "Num";
            this.numeroPokedexDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numeroPokedexDataGridViewTextBoxColumn.Name = "numeroPokedexDataGridViewTextBoxColumn";
            this.numeroPokedexDataGridViewTextBoxColumn.Width = 45;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.Width = 125;
            // 
            // pesoDataGridViewTextBoxColumn
            // 
            this.pesoDataGridViewTextBoxColumn.DataPropertyName = "Peso";
            this.pesoDataGridViewTextBoxColumn.HeaderText = "Peso";
            this.pesoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pesoDataGridViewTextBoxColumn.Name = "pesoDataGridViewTextBoxColumn";
            this.pesoDataGridViewTextBoxColumn.Width = 60;
            // 
            // alturaDataGridViewTextBoxColumn
            // 
            this.alturaDataGridViewTextBoxColumn.DataPropertyName = "Altura";
            this.alturaDataGridViewTextBoxColumn.HeaderText = "Altura";
            this.alturaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.alturaDataGridViewTextBoxColumn.Name = "alturaDataGridViewTextBoxColumn";
            this.alturaDataGridViewTextBoxColumn.Width = 60;
            // 
            // pokemonBindingSource
            // 
            this.pokemonBindingSource.DataSource = typeof(Tarea3RodriguezGarciaDavid.Pokemon);
            // 
            // AppMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(1362, 829);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "AppMainForm";
            this.Text = "Centro Pokemon - Main Window";
            this.Load += new System.EventHandler(this.AppMainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPokemons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokemonBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstPokemons;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView dgPokemons;
        private System.Windows.Forms.BindingSource pokemonBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroPokedexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pesoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox txtPokemonSelec;
        private System.Windows.Forms.Button btnCrearEquipoAleatorio;
        private System.Windows.Forms.ListBox lstEquipoAleatorio;
        private System.Windows.Forms.Button btnCombate;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}