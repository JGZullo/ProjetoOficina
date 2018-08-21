namespace ProjetoOficina
{
    partial class Form1
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
            this.CHKcod = new System.Windows.Forms.CheckBox();
            this.CHKnome = new System.Windows.Forms.CheckBox();
            this.CHKqtd = new System.Windows.Forms.CheckBox();
            this.CHKbandej = new System.Windows.Forms.CheckBox();
            this.CHKcorred = new System.Windows.Forms.CheckBox();
            this.CHKpratel = new System.Windows.Forms.CheckBox();
            this.LSTestoq = new System.Windows.Forms.ListView();
            this.GRPatualizar = new System.Windows.Forms.GroupBox();
            this.LBLatzNome = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.LBLatzCod = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.GRPatualizar.SuspendLayout();
            this.SuspendLayout();
            // 
            // TXTproc
            // 
            this.TXTproc.Location = new System.Drawing.Point(262, 38);
            this.TXTproc.Name = "TXTproc";
            this.TXTproc.Size = new System.Drawing.Size(688, 22);
            this.TXTproc.TabIndex = 0;
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
            this.BTNnovo.TabIndex = 3;
            this.BTNnovo.Text = "Novo";
            this.BTNnovo.UseVisualStyleBackColor = true;
            // 
            // BTNsair
            // 
            this.BTNsair.Location = new System.Drawing.Point(1032, 76);
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
            // CHKcod
            // 
            this.CHKcod.AutoSize = true;
            this.CHKcod.Location = new System.Drawing.Point(359, 78);
            this.CHKcod.Name = "CHKcod";
            this.CHKcod.Size = new System.Drawing.Size(74, 21);
            this.CHKcod.TabIndex = 8;
            this.CHKcod.Text = "Código";
            this.CHKcod.UseVisualStyleBackColor = true;
            // 
            // CHKnome
            // 
            this.CHKnome.AutoSize = true;
            this.CHKnome.Location = new System.Drawing.Point(262, 78);
            this.CHKnome.Name = "CHKnome";
            this.CHKnome.Size = new System.Drawing.Size(67, 21);
            this.CHKnome.TabIndex = 9;
            this.CHKnome.Text = "Nome";
            this.CHKnome.UseVisualStyleBackColor = true;
            // 
            // CHKqtd
            // 
            this.CHKqtd.AutoSize = true;
            this.CHKqtd.Location = new System.Drawing.Point(457, 78);
            this.CHKqtd.Name = "CHKqtd";
            this.CHKqtd.Size = new System.Drawing.Size(104, 21);
            this.CHKqtd.TabIndex = 10;
            this.CHKqtd.Text = "Quantidade";
            this.CHKqtd.UseVisualStyleBackColor = true;
            // 
            // CHKbandej
            // 
            this.CHKbandej.AutoSize = true;
            this.CHKbandej.Location = new System.Drawing.Point(580, 78);
            this.CHKbandej.Name = "CHKbandej";
            this.CHKbandej.Size = new System.Drawing.Size(82, 21);
            this.CHKbandej.TabIndex = 11;
            this.CHKbandej.Text = "Bandeja";
            this.CHKbandej.UseVisualStyleBackColor = true;
            // 
            // CHKcorred
            // 
            this.CHKcorred.AutoSize = true;
            this.CHKcorred.Location = new System.Drawing.Point(684, 78);
            this.CHKcorred.Name = "CHKcorred";
            this.CHKcorred.Size = new System.Drawing.Size(86, 21);
            this.CHKcorred.TabIndex = 12;
            this.CHKcorred.Text = "Corredor";
            this.CHKcorred.UseVisualStyleBackColor = true;
            // 
            // CHKpratel
            // 
            this.CHKpratel.AutoSize = true;
            this.CHKpratel.Location = new System.Drawing.Point(804, 78);
            this.CHKpratel.Name = "CHKpratel";
            this.CHKpratel.Size = new System.Drawing.Size(91, 21);
            this.CHKpratel.TabIndex = 13;
            this.CHKpratel.Text = "Prateleira";
            this.CHKpratel.UseVisualStyleBackColor = true;
            // 
            // LSTestoq
            // 
            this.LSTestoq.BackColor = System.Drawing.Color.LightGray;
            this.LSTestoq.FullRowSelect = true;
            this.LSTestoq.GridLines = true;
            this.LSTestoq.Location = new System.Drawing.Point(9, 139);
            this.LSTestoq.Name = "LSTestoq";
            this.LSTestoq.Size = new System.Drawing.Size(1127, 429);
            this.LSTestoq.TabIndex = 14;
            this.LSTestoq.UseCompatibleStateImageBehavior = false;
            this.LSTestoq.Click += new System.EventHandler(this.LSTestoq_Click);
            // 
            // GRPatualizar
            // 
            this.GRPatualizar.BackColor = System.Drawing.Color.LightGray;
            this.GRPatualizar.Controls.Add(this.textBox6);
            this.GRPatualizar.Controls.Add(this.label1);
            this.GRPatualizar.Controls.Add(this.label5);
            this.GRPatualizar.Controls.Add(this.textBox5);
            this.GRPatualizar.Controls.Add(this.label4);
            this.GRPatualizar.Controls.Add(this.textBox4);
            this.GRPatualizar.Controls.Add(this.textBox3);
            this.GRPatualizar.Controls.Add(this.textBox2);
            this.GRPatualizar.Controls.Add(this.LBLatzNome);
            this.GRPatualizar.Controls.Add(this.LBLatzCod);
            this.GRPatualizar.Controls.Add(this.label3);
            this.GRPatualizar.Controls.Add(this.textBox1);
            this.GRPatualizar.Location = new System.Drawing.Point(1142, 139);
            this.GRPatualizar.Name = "GRPatualizar";
            this.GRPatualizar.Size = new System.Drawing.Size(279, 429);
            this.GRPatualizar.TabIndex = 15;
            this.GRPatualizar.TabStop = false;
            this.GRPatualizar.Text = "Atualizar dados";
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(267, 22);
            this.textBox1.TabIndex = 17;
            // 
            // LBLatzCod
            // 
            this.LBLatzCod.AutoSize = true;
            this.LBLatzCod.Location = new System.Drawing.Point(6, 87);
            this.LBLatzCod.Name = "LBLatzCod";
            this.LBLatzCod.Size = new System.Drawing.Size(52, 17);
            this.LBLatzCod.TabIndex = 18;
            this.LBLatzCod.Text = "Código";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Bandeja";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "Corredor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "Prateleira";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(6, 107);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(267, 22);
            this.textBox2.TabIndex = 20;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(6, 165);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(267, 22);
            this.textBox3.TabIndex = 21;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(6, 218);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(267, 22);
            this.textBox4.TabIndex = 22;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(6, 268);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(267, 22);
            this.textBox5.TabIndex = 23;
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
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(9, 322);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox6.Size = new System.Drawing.Size(264, 101);
            this.textBox6.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1435, 833);
            this.Controls.Add(this.GRPatualizar);
            this.Controls.Add(this.LSTestoq);
            this.Controls.Add(this.CHKpratel);
            this.Controls.Add(this.CHKcorred);
            this.Controls.Add(this.CHKbandej);
            this.Controls.Add(this.CHKqtd);
            this.Controls.Add(this.CHKnome);
            this.Controls.Add(this.CHKcod);
            this.Controls.Add(this.LBLaplic);
            this.Controls.Add(this.LBLnomeAplic);
            this.Controls.Add(this.LBLestoq);
            this.Controls.Add(this.LBLproc);
            this.Controls.Add(this.BTNsair);
            this.Controls.Add(this.BTNnovo);
            this.Controls.Add(this.BTNtudo);
            this.Controls.Add(this.TXTproc);
            this.Name = "Form1";
            this.Text = "Form1";
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
        private System.Windows.Forms.CheckBox CHKcod;
        private System.Windows.Forms.CheckBox CHKnome;
        private System.Windows.Forms.CheckBox CHKqtd;
        private System.Windows.Forms.CheckBox CHKbandej;
        private System.Windows.Forms.CheckBox CHKcorred;
        private System.Windows.Forms.CheckBox CHKpratel;
        private System.Windows.Forms.ListView LSTestoq;
        private System.Windows.Forms.GroupBox GRPatualizar;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label LBLatzNome;
        private System.Windows.Forms.Label LBLatzCod;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
    }
}


