namespace crud.formularios
{
    partial class FormCadastroSimples
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
            this.salvar = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.TextBox();
            this.nome = new System.Windows.Forms.TextBox();
            this.sobrenome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sair = new System.Windows.Forms.Button();
            this.excluir = new System.Windows.Forms.Button();
            this.anterior = new System.Windows.Forms.Button();
            this.proximo = new System.Windows.Forms.Button();
            this.cancelar = new System.Windows.Forms.Button();
            this.novo = new System.Windows.Forms.Button();
            this.alterar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // salvar
            // 
            this.salvar.Location = new System.Drawing.Point(702, 356);
            this.salvar.Name = "salvar";
            this.salvar.Size = new System.Drawing.Size(75, 23);
            this.salvar.TabIndex = 0;
            this.salvar.Text = "Salvar";
            this.salvar.UseVisualStyleBackColor = true;
            this.salvar.Click += new System.EventHandler(this.btnSalvar);
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(25, 36);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(69, 20);
            this.id.TabIndex = 1;
            this.id.TextChanged += new System.EventHandler(this.textBoxId);
            // 
            // nome
            // 
            this.nome.Location = new System.Drawing.Point(116, 36);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(315, 20);
            this.nome.TabIndex = 2;
            this.nome.TextChanged += new System.EventHandler(this.textBoxNome);
            // 
            // sobrenome
            // 
            this.sobrenome.Location = new System.Drawing.Point(454, 36);
            this.sobrenome.Name = "sobrenome";
            this.sobrenome.Size = new System.Drawing.Size(323, 20);
            this.sobrenome.TabIndex = 3;
            this.sobrenome.TextChanged += new System.EventHandler(this.textBoxSobrenome);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Id";
            this.label1.Click += new System.EventHandler(this.labelId);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nome";
            this.label2.Click += new System.EventHandler(this.labelNome);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(451, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Sobrenome";
            this.label3.Click += new System.EventHandler(this.labelSobrenome);
            // 
            // sair
            // 
            this.sair.Location = new System.Drawing.Point(702, 406);
            this.sair.Name = "sair";
            this.sair.Size = new System.Drawing.Size(75, 23);
            this.sair.TabIndex = 7;
            this.sair.Text = "Sair";
            this.sair.UseVisualStyleBackColor = true;
            this.sair.Click += new System.EventHandler(this.buttonSair);
            // 
            // excluir
            // 
            this.excluir.Location = new System.Drawing.Point(559, 406);
            this.excluir.Name = "excluir";
            this.excluir.Size = new System.Drawing.Size(75, 23);
            this.excluir.TabIndex = 8;
            this.excluir.Text = "Excluir";
            this.excluir.UseVisualStyleBackColor = true;
            this.excluir.Click += new System.EventHandler(this.buttonExcluir);
            // 
            // anterior
            // 
            this.anterior.Location = new System.Drawing.Point(397, 406);
            this.anterior.Name = "anterior";
            this.anterior.Size = new System.Drawing.Size(75, 23);
            this.anterior.TabIndex = 9;
            this.anterior.Text = "Anterior";
            this.anterior.UseVisualStyleBackColor = true;
            this.anterior.Click += new System.EventHandler(this.buttonAnterior);
            // 
            // proximo
            // 
            this.proximo.Location = new System.Drawing.Point(478, 406);
            this.proximo.Name = "proximo";
            this.proximo.Size = new System.Drawing.Size(75, 23);
            this.proximo.TabIndex = 10;
            this.proximo.Text = "Proximo";
            this.proximo.UseVisualStyleBackColor = true;
            this.proximo.Click += new System.EventHandler(this.buttonProximo);
            // 
            // cancelar
            // 
            this.cancelar.Location = new System.Drawing.Point(559, 356);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(75, 23);
            this.cancelar.TabIndex = 11;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Click += new System.EventHandler(this.buttonCancelar);
            // 
            // novo
            // 
            this.novo.Location = new System.Drawing.Point(397, 356);
            this.novo.Name = "novo";
            this.novo.Size = new System.Drawing.Size(75, 23);
            this.novo.TabIndex = 12;
            this.novo.Text = "Novo";
            this.novo.UseVisualStyleBackColor = true;
            this.novo.Click += new System.EventHandler(this.buttonNovo);
            // 
            // alterar
            // 
            this.alterar.Location = new System.Drawing.Point(478, 356);
            this.alterar.Name = "alterar";
            this.alterar.Size = new System.Drawing.Size(75, 23);
            this.alterar.TabIndex = 13;
            this.alterar.Text = "Alterar";
            this.alterar.UseVisualStyleBackColor = true;
            this.alterar.Click += new System.EventHandler(this.buttonAlterar);
            // 
            // FormCadastroSimples
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.alterar);
            this.Controls.Add(this.novo);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.proximo);
            this.Controls.Add(this.anterior);
            this.Controls.Add(this.excluir);
            this.Controls.Add(this.sair);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sobrenome);
            this.Controls.Add(this.nome);
            this.Controls.Add(this.id);
            this.Controls.Add(this.salvar);
            this.Name = "FormCadastroSimples";
            this.Text = "FormCadastroSimples";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button salvar;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.TextBox nome;
        private System.Windows.Forms.TextBox sobrenome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button sair;
        private System.Windows.Forms.Button excluir;
        private System.Windows.Forms.Button anterior;
        private System.Windows.Forms.Button proximo;
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.Button novo;
        private System.Windows.Forms.Button alterar;
    }
}