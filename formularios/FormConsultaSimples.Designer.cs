namespace crud.formularios
{
    partial class FormConsultaSimples
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
            this.busca = new System.Windows.Forms.TextBox();
            this.buscar = new System.Windows.Forms.Button();
            this.pesquisa = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.incluir = new System.Windows.Forms.Button();
            this.alterar = new System.Windows.Forms.Button();
            this.sair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // busca
            // 
            this.busca.Location = new System.Drawing.Point(12, 43);
            this.busca.Name = "busca";
            this.busca.Size = new System.Drawing.Size(683, 20);
            this.busca.TabIndex = 0;
            this.busca.TextChanged += new System.EventHandler(this.textBoxBusca);
            // 
            // buscar
            // 
            this.buscar.Location = new System.Drawing.Point(713, 40);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(75, 24);
            this.buscar.TabIndex = 1;
            this.buscar.Text = "Buscar";
            this.buscar.UseVisualStyleBackColor = true;
            this.buscar.Click += new System.EventHandler(this.buttonBuscar);
            // 
            // pesquisa
            // 
            this.pesquisa.AutoSize = true;
            this.pesquisa.Location = new System.Drawing.Point(12, 22);
            this.pesquisa.Name = "pesquisa";
            this.pesquisa.Size = new System.Drawing.Size(50, 13);
            this.pesquisa.TabIndex = 2;
            this.pesquisa.Text = "Pesquisa";
            this.pesquisa.Click += new System.EventHandler(this.labelBuscar);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 150);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid);
            // 
            // incluir
            // 
            this.incluir.Location = new System.Drawing.Point(713, 399);
            this.incluir.Name = "incluir";
            this.incluir.Size = new System.Drawing.Size(75, 23);
            this.incluir.TabIndex = 4;
            this.incluir.Text = "Incluir";
            this.incluir.UseVisualStyleBackColor = true;
            this.incluir.Click += new System.EventHandler(this.buttonIncluir);
            // 
            // alterar
            // 
            this.alterar.Location = new System.Drawing.Point(620, 399);
            this.alterar.Name = "alterar";
            this.alterar.Size = new System.Drawing.Size(75, 23);
            this.alterar.TabIndex = 5;
            this.alterar.Text = "Alterar";
            this.alterar.UseVisualStyleBackColor = true;
            this.alterar.Click += new System.EventHandler(this.buttonAlterar);
            // 
            // sair
            // 
            this.sair.Location = new System.Drawing.Point(530, 399);
            this.sair.Name = "sair";
            this.sair.Size = new System.Drawing.Size(75, 23);
            this.sair.TabIndex = 6;
            this.sair.Text = "Sair";
            this.sair.UseVisualStyleBackColor = true;
            this.sair.Click += new System.EventHandler(this.buttonSair);
            // 
            // FormConsultaSimples
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 451);
            this.Controls.Add(this.sair);
            this.Controls.Add(this.alterar);
            this.Controls.Add(this.incluir);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pesquisa);
            this.Controls.Add(this.buscar);
            this.Controls.Add(this.busca);
            this.Name = "FormConsultaSimples";
            this.Text = "FormConsultaSimples";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox busca;
        private System.Windows.Forms.Button buscar;
        private System.Windows.Forms.Label pesquisa;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button incluir;
        private System.Windows.Forms.Button alterar;
        private System.Windows.Forms.Button sair;
    }
}