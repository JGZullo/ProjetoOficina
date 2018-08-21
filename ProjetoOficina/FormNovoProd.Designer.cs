namespace ProjetoOficina
{
    partial class FormNovoProd
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TXTnome = new System.Windows.Forms.TextBox();
            this.TXTcodigo = new System.Windows.Forms.TextBox();
            this.TXTaplic = new System.Windows.Forms.TextBox();
            this.TXTqtd = new System.Windows.Forms.TextBox();
            this.BTNadd = new System.Windows.Forms.Button();
            this.BTNexcluir = new System.Windows.Forms.Button();
            this.BTNcancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do Produto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Código";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Aplicação";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Quantidade";
            // 
            // TXTnome
            // 
            this.TXTnome.Location = new System.Drawing.Point(112, 12);
            this.TXTnome.Name = "TXTnome";
            this.TXTnome.Size = new System.Drawing.Size(147, 20);
            this.TXTnome.TabIndex = 4;
            // 
            // TXTcodigo
            // 
            this.TXTcodigo.Location = new System.Drawing.Point(112, 47);
            this.TXTcodigo.Name = "TXTcodigo";
            this.TXTcodigo.Size = new System.Drawing.Size(147, 20);
            this.TXTcodigo.TabIndex = 5;
            // 
            // TXTaplic
            // 
            this.TXTaplic.Location = new System.Drawing.Point(112, 85);
            this.TXTaplic.Name = "TXTaplic";
            this.TXTaplic.Size = new System.Drawing.Size(147, 20);
            this.TXTaplic.TabIndex = 6;
            // 
            // TXTqtd
            // 
            this.TXTqtd.Location = new System.Drawing.Point(112, 127);
            this.TXTqtd.Name = "TXTqtd";
            this.TXTqtd.Size = new System.Drawing.Size(147, 20);
            this.TXTqtd.TabIndex = 7;
            // 
            // BTNadd
            // 
            this.BTNadd.Location = new System.Drawing.Point(31, 205);
            this.BTNadd.Name = "BTNadd";
            this.BTNadd.Size = new System.Drawing.Size(75, 23);
            this.BTNadd.TabIndex = 8;
            this.BTNadd.Text = "Adicionar";
            this.BTNadd.UseVisualStyleBackColor = true;
            this.BTNadd.Click += new System.EventHandler(this.BTNadd_Click);
            // 
            // BTNexcluir
            // 
            this.BTNexcluir.Location = new System.Drawing.Point(150, 205);
            this.BTNexcluir.Name = "BTNexcluir";
            this.BTNexcluir.Size = new System.Drawing.Size(75, 23);
            this.BTNexcluir.TabIndex = 9;
            this.BTNexcluir.Text = "Excluir";
            this.BTNexcluir.UseVisualStyleBackColor = true;
            // 
            // BTNcancel
            // 
            this.BTNcancel.Location = new System.Drawing.Point(274, 205);
            this.BTNcancel.Name = "BTNcancel";
            this.BTNcancel.Size = new System.Drawing.Size(75, 23);
            this.BTNcancel.TabIndex = 10;
            this.BTNcancel.Text = "Cancelar";
            this.BTNcancel.UseVisualStyleBackColor = true;
            this.BTNcancel.Click += new System.EventHandler(this.BTNcancel_Click);
            // 
            // FormNovoProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BTNcancel);
            this.Controls.Add(this.BTNexcluir);
            this.Controls.Add(this.BTNadd);
            this.Controls.Add(this.TXTqtd);
            this.Controls.Add(this.TXTaplic);
            this.Controls.Add(this.TXTcodigo);
            this.Controls.Add(this.TXTnome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormNovoProd";
            this.Size = new System.Drawing.Size(380, 245);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TXTnome;
        private System.Windows.Forms.TextBox TXTcodigo;
        private System.Windows.Forms.TextBox TXTaplic;
        private System.Windows.Forms.TextBox TXTqtd;
        private System.Windows.Forms.Button BTNadd;
        private System.Windows.Forms.Button BTNexcluir;
        private System.Windows.Forms.Button BTNcancel;
    }
}
