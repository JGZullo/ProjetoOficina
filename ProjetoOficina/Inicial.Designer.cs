namespace ProjetoOficina
{
    partial class Inicial
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.TXTproc = new System.Windows.Forms.TextBox();
            this.BTNtudo = new System.Windows.Forms.Button();
            this.BTNnovo = new System.Windows.Forms.Button();
            this.BTNsair = new System.Windows.Forms.Button();
            this.LBLproc = new System.Windows.Forms.Label();
            this.LBLestoq = new System.Windows.Forms.Label();
            this.LBLnomeAplic = new System.Windows.Forms.Label();
            this.LBLaplic = new System.Windows.Forms.Label();
            this.LSTestoq = new System.Windows.Forms.ListView();
            this.GRPatualizar = new System.Windows.Forms.GroupBox();
            this.TXTatzQtd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BTNatualizar = new System.Windows.Forms.Button();
            this.TXTatzAplic = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TXTatzPratel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TXTatzCorred = new System.Windows.Forms.TextBox();
            this.TXTatzBandej = new System.Windows.Forms.TextBox();
            this.TXTatzCod = new System.Windows.Forms.TextBox();
            this.LBLatzNome = new System.Windows.Forms.Label();
            this.LBLatzCod = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TXTatzNome = new System.Windows.Forms.TextBox();
            this.LBKajuda = new System.Windows.Forms.LinkLabel();
            this.BTNexcluir = new System.Windows.Forms.Button();
            this.GRPatualizar.SuspendLayout();
            this.SuspendLayout();
            // 
            // TXTproc
            // 
            this.TXTproc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TXTproc.Location = new System.Drawing.Point(262, 38);
            this.TXTproc.Name = "TXTproc";
            this.TXTproc.Size = new System.Drawing.Size(688, 22);
            this.TXTproc.TabIndex = 0;
            this.TXTproc.TextChanged += new System.EventHandler(this.TXTproc_TextChanged);
            // 
            // BTNtudo
            // 
            this.BTNtudo.Location = new System.Drawing.Point(1032, 18);
            this.BTNtudo.Name = "BTNtudo";
            this.BTNtudo.Size = new System.Drawing.Size(104, 23);
            this.BTNtudo.TabIndex = 1;
            this.BTNtudo.Text = "Mostrar tudo";
            this.BTNtudo.UseVisualStyleBackColor = true;
            this.BTNtudo.Click += new System.EventHandler(this.BTNtudo_Click);
            // 
            // BTNnovo
            // 
            this.BTNnovo.Location = new System.Drawing.Point(1032, 47);
            this.BTNnovo.Name = "BTNnovo";
            this.BTNnovo.Size = new System.Drawing.Size(104, 23);
            this.BTNnovo.TabIndex = 2;
            this.BTNnovo.Text = "Novo";
            this.BTNnovo.UseVisualStyleBackColor = true;
            this.BTNnovo.Click += new System.EventHandler(this.BTNnovo_Click);
            // 
            // BTNsair
            // 
            this.BTNsair.Location = new System.Drawing.Point(1032, 105);
            this.BTNsair.Name = "BTNsair";
            this.BTNsair.Size = new System.Drawing.Size(104, 23);
            this.BTNsair.TabIndex = 4;
            this.BTNsair.Text = "Sair";
            this.BTNsair.UseVisualStyleBackColor = true;
            this.BTNsair.Click += new System.EventHandler(this.BTNsair_Click);
            // 
            // LBLproc
            // 
            this.LBLproc.AutoSize = true;
            this.LBLproc.Location = new System.Drawing.Point(259, 18);
            this.LBLproc.Name = "LBLproc";
            this.LBLproc.Size = new System.Drawing.Size(63, 17);
            this.LBLproc.TabIndex = 0;
            this.LBLproc.Text = "Procurar";
            // 
            // LBLestoq
            // 
            this.LBLestoq.AutoSize = true;
            this.LBLestoq.Location = new System.Drawing.Point(9, 119);
            this.LBLestoq.Name = "LBLestoq";
            this.LBLestoq.Size = new System.Drawing.Size(60, 17);
            this.LBLestoq.TabIndex = 5;
            this.LBLestoq.Text = "Estoque";
            // 
            // LBLnomeAplic
            // 
            this.LBLnomeAplic.AutoSize = true;
            this.LBLnomeAplic.Location = new System.Drawing.Point(6, 571);
            this.LBLnomeAplic.Name = "LBLnomeAplic";
            this.LBLnomeAplic.Size = new System.Drawing.Size(69, 17);
            this.LBLnomeAplic.TabIndex = 6;
            this.LBLnomeAplic.Text = "Aplicação";
            // 
            // LBLaplic
            // 
            this.LBLaplic.BackColor = System.Drawing.Color.LightGray;
            this.LBLaplic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LBLaplic.Location = new System.Drawing.Point(9, 588);
            this.LBLaplic.Name = "LBLaplic";
            this.LBLaplic.Size = new System.Drawing.Size(1412, 236);
            this.LBLaplic.TabIndex = 7;
            // 
            // LSTestoq
            // 
            this.LSTestoq.BackColor = System.Drawing.Color.LightGray;
            this.LSTestoq.FullRowSelect = true;
            this.LSTestoq.GridLines = true;
            this.LSTestoq.HideSelection = false;
            this.LSTestoq.Location = new System.Drawing.Point(9, 139);
            this.LSTestoq.MultiSelect = false;
            this.LSTestoq.Name = "LSTestoq";
            this.LSTestoq.Size = new System.Drawing.Size(1127, 429);
            this.LSTestoq.TabIndex = 14;
            this.LSTestoq.UseCompatibleStateImageBehavior = false;
            this.LSTestoq.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.LSTestoq_ColumnClick);
            this.LSTestoq.ItemActivate += new System.EventHandler(this.LSTestoq_ItemActivate);
            this.LSTestoq.Leave += new System.EventHandler(this.LSTestoq_Leave);
            // 
            // GRPatualizar
            // 
            this.GRPatualizar.BackColor = System.Drawing.Color.LightGray;
            this.GRPatualizar.Controls.Add(this.TXTatzQtd);
            this.GRPatualizar.Controls.Add(this.label2);
            this.GRPatualizar.Controls.Add(this.BTNatualizar);
            this.GRPatualizar.Controls.Add(this.TXTatzAplic);
            this.GRPatualizar.Controls.Add(this.label1);
            this.GRPatualizar.Controls.Add(this.label5);
            this.GRPatualizar.Controls.Add(this.TXTatzPratel);
            this.GRPatualizar.Controls.Add(this.label4);
            this.GRPatualizar.Controls.Add(this.TXTatzCorred);
            this.GRPatualizar.Controls.Add(this.TXTatzBandej);
            this.GRPatualizar.Controls.Add(this.TXTatzCod);
            this.GRPatualizar.Controls.Add(this.LBLatzNome);
            this.GRPatualizar.Controls.Add(this.LBLatzCod);
            this.GRPatualizar.Controls.Add(this.label3);
            this.GRPatualizar.Controls.Add(this.TXTatzNome);
            this.GRPatualizar.Location = new System.Drawing.Point(1142, 139);
            this.GRPatualizar.Name = "GRPatualizar";
            this.GRPatualizar.Size = new System.Drawing.Size(279, 429);
            this.GRPatualizar.TabIndex = 8;
            this.GRPatualizar.TabStop = false;
            this.GRPatualizar.Text = "Atualizar dados";
            // 
            // TXTatzQtd
            // 
            this.TXTatzQtd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TXTatzQtd.Location = new System.Drawing.Point(6, 142);
            this.TXTatzQtd.Name = "TXTatzQtd";
            this.TXTatzQtd.Size = new System.Drawing.Size(267, 22);
            this.TXTatzQtd.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 26;
            this.label2.Text = "Quantidade";
            // 
            // BTNatualizar
            // 
            this.BTNatualizar.Location = new System.Drawing.Point(121, 16);
            this.BTNatualizar.Name = "BTNatualizar";
            this.BTNatualizar.Size = new System.Drawing.Size(152, 27);
            this.BTNatualizar.TabIndex = 12;
            this.BTNatualizar.Text = "Atualizar";
            this.BTNatualizar.UseVisualStyleBackColor = true;
            this.BTNatualizar.Click += new System.EventHandler(this.BTNatualizar_Click);
            // 
            // TXTatzAplic
            // 
            this.TXTatzAplic.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TXTatzAplic.Location = new System.Drawing.Point(6, 322);
            this.TXTatzAplic.Multiline = true;
            this.TXTatzAplic.Name = "TXTatzAplic";
            this.TXTatzAplic.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TXTatzAplic.Size = new System.Drawing.Size(264, 101);
            this.TXTatzAplic.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 302);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 24;
            this.label1.Text = "Aplicação";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "Prateleira";
            // 
            // TXTatzPratel
            // 
            this.TXTatzPratel.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TXTatzPratel.Location = new System.Drawing.Point(9, 277);
            this.TXTatzPratel.Name = "TXTatzPratel";
            this.TXTatzPratel.Size = new System.Drawing.Size(267, 22);
            this.TXTatzPratel.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "Corredor";
            // 
            // TXTatzCorred
            // 
            this.TXTatzCorred.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TXTatzCorred.Location = new System.Drawing.Point(6, 232);
            this.TXTatzCorred.Name = "TXTatzCorred";
            this.TXTatzCorred.Size = new System.Drawing.Size(267, 22);
            this.TXTatzCorred.TabIndex = 9;
            // 
            // TXTatzBandej
            // 
            this.TXTatzBandej.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TXTatzBandej.Location = new System.Drawing.Point(6, 187);
            this.TXTatzBandej.Name = "TXTatzBandej";
            this.TXTatzBandej.Size = new System.Drawing.Size(267, 22);
            this.TXTatzBandej.TabIndex = 8;
            // 
            // TXTatzCod
            // 
            this.TXTatzCod.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TXTatzCod.Location = new System.Drawing.Point(6, 94);
            this.TXTatzCod.Name = "TXTatzCod";
            this.TXTatzCod.Size = new System.Drawing.Size(267, 22);
            this.TXTatzCod.TabIndex = 6;
            // 
            // LBLatzNome
            // 
            this.LBLatzNome.AutoSize = true;
            this.LBLatzNome.Location = new System.Drawing.Point(6, 29);
            this.LBLatzNome.Name = "LBLatzNome";
            this.LBLatzNome.Size = new System.Drawing.Size(45, 17);
            this.LBLatzNome.TabIndex = 16;
            this.LBLatzNome.Text = "Nome";
            // 
            // LBLatzCod
            // 
            this.LBLatzCod.AutoSize = true;
            this.LBLatzCod.Location = new System.Drawing.Point(6, 74);
            this.LBLatzCod.Name = "LBLatzCod";
            this.LBLatzCod.Size = new System.Drawing.Size(52, 17);
            this.LBLatzCod.TabIndex = 18;
            this.LBLatzCod.Text = "Código";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Bandeja";
            // 
            // TXTatzNome
            // 
            this.TXTatzNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TXTatzNome.Location = new System.Drawing.Point(6, 49);
            this.TXTatzNome.Name = "TXTatzNome";
            this.TXTatzNome.Size = new System.Drawing.Size(267, 22);
            this.TXTatzNome.TabIndex = 5;
            // 
            // LBKajuda
            // 
            this.LBKajuda.AutoSize = true;
            this.LBKajuda.Location = new System.Drawing.Point(1379, 9);
            this.LBKajuda.Name = "LBKajuda";
            this.LBKajuda.Size = new System.Drawing.Size(44, 17);
            this.LBKajuda.TabIndex = 13;
            this.LBKajuda.TabStop = true;
            this.LBKajuda.Text = "Ajuda";
            this.LBKajuda.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LBKajuda_LinkClicked);
            // 
            // BTNexcluir
            // 
            this.BTNexcluir.Location = new System.Drawing.Point(1032, 76);
            this.BTNexcluir.Name = "BTNexcluir";
            this.BTNexcluir.Size = new System.Drawing.Size(104, 23);
            this.BTNexcluir.TabIndex = 3;
            this.BTNexcluir.Text = "Excluir";
            this.BTNexcluir.UseVisualStyleBackColor = true;
            this.BTNexcluir.Click += new System.EventHandler(this.BTNexcluir_Click);
            // 
            // Inicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1435, 833);
            this.Controls.Add(this.BTNexcluir);
            this.Controls.Add(this.LBKajuda);
            this.Controls.Add(this.GRPatualizar);
            this.Controls.Add(this.LSTestoq);
            this.Controls.Add(this.LBLaplic);
            this.Controls.Add(this.LBLnomeAplic);
            this.Controls.Add(this.LBLestoq);
            this.Controls.Add(this.LBLproc);
            this.Controls.Add(this.BTNsair);
            this.Controls.Add(this.BTNnovo);
            this.Controls.Add(this.BTNtudo);
            this.Controls.Add(this.TXTproc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Inicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estoque";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GRPatualizar.ResumeLayout(false);
            this.GRPatualizar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TXTproc;
        private System.Windows.Forms.Button BTNtudo;
        private System.Windows.Forms.Button BTNnovo;
        private System.Windows.Forms.Button BTNsair;
        private System.Windows.Forms.Label LBLproc;
        private System.Windows.Forms.Label LBLestoq;
        private System.Windows.Forms.Label LBLnomeAplic;
        private System.Windows.Forms.Label LBLaplic;
        private System.Windows.Forms.ListView LSTestoq;
        private System.Windows.Forms.GroupBox GRPatualizar;
        private System.Windows.Forms.TextBox TXTatzAplic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TXTatzPratel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TXTatzCorred;
        private System.Windows.Forms.TextBox TXTatzBandej;
        private System.Windows.Forms.TextBox TXTatzCod;
        private System.Windows.Forms.Label LBLatzNome;
        private System.Windows.Forms.Label LBLatzCod;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TXTatzNome;
        private System.Windows.Forms.Button BTNatualizar;
        private System.Windows.Forms.TextBox TXTatzQtd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel LBKajuda;
        private System.Windows.Forms.Button BTNexcluir;
    }
}


