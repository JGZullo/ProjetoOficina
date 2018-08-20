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
            this.BRDcod = new System.Windows.Forms.RadioButton();
            this.BRDnome = new System.Windows.Forms.RadioButton();
            this.BRDestoq = new System.Windows.Forms.RadioButton();
            this.BRDbandej = new System.Windows.Forms.RadioButton();
            this.BRDcorred = new System.Windows.Forms.RadioButton();
            this.BRDpratel = new System.Windows.Forms.RadioButton();
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
            // 
            // TBLestoq
            // 
            this.TBLestoq.ColumnCount = 6;
            this.TBLestoq.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 114F));
            this.TBLestoq.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 353F));
            this.TBLestoq.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 265F));
            this.TBLestoq.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 244F));
            this.TBLestoq.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 244F));
            this.TBLestoq.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 244F));
            this.TBLestoq.Location = new System.Drawing.Point(12, 139);
            this.TBLestoq.Name = "TBLestoq";
            this.TBLestoq.RowCount = 2;
            this.TBLestoq.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.34426F));
            this.TBLestoq.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.65574F));
            this.TBLestoq.Size = new System.Drawing.Size(1464, 244);
            this.TBLestoq.TabIndex = 2;
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
            this.LBLnomeAplic.Location = new System.Drawing.Point(9, 386);
            this.LBLnomeAplic.Name = "LBLnomeAplic";
            this.LBLnomeAplic.Size = new System.Drawing.Size(69, 17);
            this.LBLnomeAplic.TabIndex = 6;
            this.LBLnomeAplic.Text = "Aplicação";
            // 
            // LBLaplic
            // 
            this.LBLaplic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LBLaplic.Location = new System.Drawing.Point(9, 403);
            this.LBLaplic.Name = "LBLaplic";
            this.LBLaplic.Size = new System.Drawing.Size(1467, 236);
            this.LBLaplic.TabIndex = 7;
            // 
            // BRDcod
            // 
            this.BRDcod.AutoSize = true;
            this.BRDcod.Location = new System.Drawing.Point(260, 76);
            this.BRDcod.Name = "BRDcod";
            this.BRDcod.Size = new System.Drawing.Size(73, 21);
            this.BRDcod.TabIndex = 8;
            this.BRDcod.TabStop = true;
            this.BRDcod.Text = "Código";
            this.BRDcod.UseVisualStyleBackColor = true;
            // 
            // BRDnome
            // 
            this.BRDnome.AutoSize = true;
            this.BRDnome.Location = new System.Drawing.Point(376, 78);
            this.BRDnome.Name = "BRDnome";
            this.BRDnome.Size = new System.Drawing.Size(66, 21);
            this.BRDnome.TabIndex = 9;
            this.BRDnome.TabStop = true;
            this.BRDnome.Text = "Nome";
            this.BRDnome.UseVisualStyleBackColor = true;
            // 
            // BRDestoq
            // 
            this.BRDestoq.AutoSize = true;
            this.BRDestoq.Location = new System.Drawing.Point(492, 76);
            this.BRDestoq.Name = "BRDestoq";
            this.BRDestoq.Size = new System.Drawing.Size(81, 21);
            this.BRDestoq.TabIndex = 10;
            this.BRDestoq.TabStop = true;
            this.BRDestoq.Text = "Estoque";
            this.BRDestoq.UseVisualStyleBackColor = true;
            // 
            // BRDbandej
            // 
            this.BRDbandej.AutoSize = true;
            this.BRDbandej.Location = new System.Drawing.Point(608, 76);
            this.BRDbandej.Name = "BRDbandej";
            this.BRDbandej.Size = new System.Drawing.Size(81, 21);
            this.BRDbandej.TabIndex = 11;
            this.BRDbandej.TabStop = true;
            this.BRDbandej.Text = "Bandeja";
            this.BRDbandej.UseVisualStyleBackColor = true;
            // 
            // BRDcorred
            // 
            this.BRDcorred.AutoSize = true;
            this.BRDcorred.Location = new System.Drawing.Point(724, 76);
            this.BRDcorred.Name = "BRDcorred";
            this.BRDcorred.Size = new System.Drawing.Size(85, 21);
            this.BRDcorred.TabIndex = 12;
            this.BRDcorred.TabStop = true;
            this.BRDcorred.Text = "Corredor";
            this.BRDcorred.UseVisualStyleBackColor = true;
            // 
            // BRDpratel
            // 
            this.BRDpratel.AutoSize = true;
            this.BRDpratel.Location = new System.Drawing.Point(840, 76);
            this.BRDpratel.Name = "BRDpratel";
            this.BRDpratel.Size = new System.Drawing.Size(90, 21);
            this.BRDpratel.TabIndex = 13;
            this.BRDpratel.TabStop = true;
            this.BRDpratel.Text = "Prateleira";
            this.BRDpratel.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1488, 648);
            this.Controls.Add(this.BRDpratel);
            this.Controls.Add(this.BRDcorred);
            this.Controls.Add(this.BRDbandej);
            this.Controls.Add(this.BRDestoq);
            this.Controls.Add(this.BRDnome);
            this.Controls.Add(this.BRDcod);
            this.Controls.Add(this.LBLaplic);
            this.Controls.Add(this.LBLnomeAplic);
            this.Controls.Add(this.LBLestoq);
            this.Controls.Add(this.LBLproc);
            this.Controls.Add(this.BTNsair);
            this.Controls.Add(this.BTNnovo);
            this.Controls.Add(this.TBLestoq);
            this.Controls.Add(this.BTNtudo);
            this.Controls.Add(this.TXTproc);
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
        private System.Windows.Forms.RadioButton BRDcod;
        private System.Windows.Forms.RadioButton BRDnome;
        private System.Windows.Forms.RadioButton BRDestoq;
        private System.Windows.Forms.RadioButton BRDbandej;
        private System.Windows.Forms.RadioButton BRDcorred;
        private System.Windows.Forms.RadioButton BRDpratel;
    }
}


