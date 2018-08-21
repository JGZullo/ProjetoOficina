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
            this.TBLestoq = new System.Windows.Forms.TableLayoutPanel();
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
            this.SuspendLayout();
            // 
            // TXTproc
            // 
            this.TXTproc.Location = new System.Drawing.Point(196, 31);
            this.TXTproc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TXTproc.Name = "TXTproc";
            this.TXTproc.Size = new System.Drawing.Size(517, 20);
            this.TXTproc.TabIndex = 0;
            // 
            // BTNtudo
            // 
            this.BTNtudo.Location = new System.Drawing.Point(774, 15);
            this.BTNtudo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTNtudo.Name = "BTNtudo";
            this.BTNtudo.Size = new System.Drawing.Size(78, 19);
            this.BTNtudo.TabIndex = 1;
            this.BTNtudo.Text = "Mostrar tudo";
            this.BTNtudo.UseVisualStyleBackColor = true;
            this.BTNtudo.Click += new System.EventHandler(this.BTNtudo_Click);
            // 
            // TBLestoq
            // 
            this.TBLestoq.ColumnCount = 6;
            this.TBLestoq.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 86F));
            this.TBLestoq.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 265F));
            this.TBLestoq.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 199F));
            this.TBLestoq.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 183F));
            this.TBLestoq.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 183F));
            this.TBLestoq.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 183F));
            this.TBLestoq.Location = new System.Drawing.Point(9, 113);
            this.TBLestoq.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TBLestoq.Name = "TBLestoq";
            this.TBLestoq.RowCount = 2;
            this.TBLestoq.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.34426F));
            this.TBLestoq.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.65574F));
            this.TBLestoq.Size = new System.Drawing.Size(1098, 198);
            this.TBLestoq.TabIndex = 2;
            // 
            // BTNnovo
            // 
            this.BTNnovo.Location = new System.Drawing.Point(774, 38);
            this.BTNnovo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTNnovo.Name = "BTNnovo";
            this.BTNnovo.Size = new System.Drawing.Size(78, 19);
            this.BTNnovo.TabIndex = 3;
            this.BTNnovo.Text = "Novo";
            this.BTNnovo.UseVisualStyleBackColor = true;
            this.BTNnovo.Click += new System.EventHandler(this.BTNnovo_Click);
            // 
            // BTNsair
            // 
            this.BTNsair.Location = new System.Drawing.Point(774, 62);
            this.BTNsair.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTNsair.Name = "BTNsair";
            this.BTNsair.Size = new System.Drawing.Size(78, 19);
            this.BTNsair.TabIndex = 4;
            this.BTNsair.Text = "Sair";
            this.BTNsair.UseVisualStyleBackColor = true;
            // 
            // LBLproc
            // 
            this.LBLproc.AutoSize = true;
            this.LBLproc.Location = new System.Drawing.Point(194, 15);
            this.LBLproc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBLproc.Name = "LBLproc";
            this.LBLproc.Size = new System.Drawing.Size(47, 13);
            this.LBLproc.TabIndex = 0;
            this.LBLproc.Text = "Procurar";
            // 
            // LBLestoq
            // 
            this.LBLestoq.AutoSize = true;
            this.LBLestoq.Location = new System.Drawing.Point(7, 97);
            this.LBLestoq.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBLestoq.Name = "LBLestoq";
            this.LBLestoq.Size = new System.Drawing.Size(46, 13);
            this.LBLestoq.TabIndex = 5;
            this.LBLestoq.Text = "Estoque";
            // 
            // LBLnomeAplic
            // 
            this.LBLnomeAplic.AutoSize = true;
            this.LBLnomeAplic.Location = new System.Drawing.Point(7, 314);
            this.LBLnomeAplic.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBLnomeAplic.Name = "LBLnomeAplic";
            this.LBLnomeAplic.Size = new System.Drawing.Size(54, 13);
            this.LBLnomeAplic.TabIndex = 6;
            this.LBLnomeAplic.Text = "Aplicação";
            // 
            // LBLaplic
            // 
            this.LBLaplic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LBLaplic.Location = new System.Drawing.Point(7, 327);
            this.LBLaplic.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBLaplic.Name = "LBLaplic";
            this.LBLaplic.Size = new System.Drawing.Size(1100, 192);
            this.LBLaplic.TabIndex = 7;
            // 
            // CHKcod
            // 
            this.CHKcod.AutoSize = true;
            this.CHKcod.Location = new System.Drawing.Point(196, 63);
            this.CHKcod.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CHKcod.Name = "CHKcod";
            this.CHKcod.Size = new System.Drawing.Size(59, 17);
            this.CHKcod.TabIndex = 8;
            this.CHKcod.Text = "Código";
            this.CHKcod.UseVisualStyleBackColor = true;
            // 
            // CHKnome
            // 
            this.CHKnome.AutoSize = true;
            this.CHKnome.Location = new System.Drawing.Point(274, 63);
            this.CHKnome.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CHKnome.Name = "CHKnome";
            this.CHKnome.Size = new System.Drawing.Size(54, 17);
            this.CHKnome.TabIndex = 9;
            this.CHKnome.Text = "Nome";
            this.CHKnome.UseVisualStyleBackColor = true;
            // 
            // CHKqtd
            // 
            this.CHKqtd.AutoSize = true;
            this.CHKqtd.Location = new System.Drawing.Point(361, 63);
            this.CHKqtd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CHKqtd.Name = "CHKqtd";
            this.CHKqtd.Size = new System.Drawing.Size(81, 17);
            this.CHKqtd.TabIndex = 10;
            this.CHKqtd.Text = "Quantidade";
            this.CHKqtd.UseVisualStyleBackColor = true;
            // 
            // CHKbandej
            // 
            this.CHKbandej.AutoSize = true;
            this.CHKbandej.Location = new System.Drawing.Point(450, 63);
            this.CHKbandej.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CHKbandej.Name = "CHKbandej";
            this.CHKbandej.Size = new System.Drawing.Size(65, 17);
            this.CHKbandej.TabIndex = 11;
            this.CHKbandej.Text = "Bandeja";
            this.CHKbandej.UseVisualStyleBackColor = true;
            // 
            // CHKcorred
            // 
            this.CHKcorred.AutoSize = true;
            this.CHKcorred.Location = new System.Drawing.Point(544, 63);
            this.CHKcorred.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CHKcorred.Name = "CHKcorred";
            this.CHKcorred.Size = new System.Drawing.Size(66, 17);
            this.CHKcorred.TabIndex = 12;
            this.CHKcorred.Text = "Corredor";
            this.CHKcorred.UseVisualStyleBackColor = true;
            // 
            // CHKpratel
            // 
            this.CHKpratel.AutoSize = true;
            this.CHKpratel.Location = new System.Drawing.Point(639, 63);
            this.CHKpratel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CHKpratel.Name = "CHKpratel";
            this.CHKpratel.Size = new System.Drawing.Size(70, 17);
            this.CHKpratel.TabIndex = 13;
            this.CHKpratel.Text = "Prateleira";
            this.CHKpratel.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 526);
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
            this.Controls.Add(this.TBLestoq);
            this.Controls.Add(this.BTNtudo);
            this.Controls.Add(this.TXTproc);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TXTproc;
        private System.Windows.Forms.Button BTNtudo;
        private System.Windows.Forms.TableLayoutPanel TBLestoq;
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
    }
}


