using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Oficina
{
    public class Produto
    {
        private String prodNome;
        private String prodCodigo;
        private String prodAplic;
        private int prodQtd;

        public Produto(String nome, String codigo, String aplic, int qtd)
        {
            this.setNome(nome);
            this.setCodigo(codigo);
            this.setAplicacao(aplic);
            this.setQuantidade(qtd);
        }

        public void alterarQuantidade(int qtd, int operacao)
        {
            if (operacao < 0 && this.prodQtd < qtd)
                throw new Exception("quantidade a ser decrementada invalida");

            setQuantidade(this.prodQtd + qtd);
        }

        public void setNome (String nome)
        {
            if (nome.Equals("") || nome == null)
                throw new Exception("nome em branco");

            this.prodNome = nome;
        }

        public void setCodigo (String codigo)
        {
            if (codigo.Equals("") || codigo == null)
                throw new Exception("codigo em branco");

            this.prodCodigo = codigo;
        }

        public void setAplicacao(string aplic)
        {
            if (aplic.Equals("") || aplic == null)
                throw new Exception("aplicacao em branco");

            this.prodAplic = aplic;
        }

        public void setQuantidade (int quantidade)
        {
            if (quantidade < 0)
                throw new Exception("quantidade invalida: negativa");

            this.prodQtd = quantidade;
        }

        public String getNome() { return this.prodNome; }
        
        public String getCodigo() { return this.prodCodigo; }
        
        public String getAplicacao() { return this.prodAplic; }
        
        public int getQuantidade() { return this.prodQtd; }

        public override bool Equals(object obj)
        {
            var produto = obj as Produto;
            return produto != null &&
                   prodNome == produto.prodNome &&
                   prodCodigo == produto.prodCodigo &&
                   prodAplic == produto.prodAplic &&
                   prodQtd == produto.prodQtd;
        }

        public override int GetHashCode()
        {
            var hashCode = 1816063662;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(prodNome);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(prodCodigo);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(prodAplic);
            hashCode = hashCode * -1521134295 + prodQtd.GetHashCode();
            return hashCode;
        }

        public override string ToString()
        {
            return "Produto(prodNome= " + prodNome + ", prodCodigo= " + prodCodigo
                + ", prodAplic= " + prodAplic + ", prodQtd= " + prodQtd;
        }
    }

}
