using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroDeProduto
{
    public partial class Form1 : Form
    {
        //private List<Produto> listaProdutos = new List<Produto>();
        private const int MaxProdutos = 100; // Define o tamanho máximo do array
        private Produto[] produtos = new Produto[MaxProdutos]; // Array para armazenar os produtos
        private int contadorProdutos = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Salvar_Click(object sender, EventArgs e)
        {
            if (contadorProdutos >= MaxProdutos)
            {
                MessageBox.Show("Limite máximo de produtos atingido.");
                return;
            }



            String nome = NomeProduto.Text;
            decimal preco= Convert.ToDecimal(Preco.Text);
            int quantidade = Convert.ToInt32(Quantidade.Text);

            Produto novoProduto = new Produto(nome, preco, quantidade);

            int posicaoVazia = -1;
            for (int i = 0; i < produtos.Length; i++)
            {
                if (produtos[i] == null)
                {
                    posicaoVazia = i;
                    break;
                }
            }

            // Se não encontrou posição vazia, exibir mensagem de erro
            if (posicaoVazia == -1)
            {
                MessageBox.Show("Erro ao adicionar produto.");
                return;
            }

            // Adicionar o novo produto à posição encontrada no array
            produtos[posicaoVazia] = novoProduto;

            // Incrementa o contador de produtos
            contadorProdutos++;




            LimparCampos();
            exibir.Text = ($"| Nome : {nome}----|, Preço : {preco}----,| Quantdade{quantidade} |");


            // Exibir uma mensagem de sucesso
            MessageBox.Show("Produto cadastrado com sucesso!");


        }
        private void LimparCampos()
        {
            NomeProduto.Text = "";
            Preco.Text = "";
            Quantidade.Text = "";
        }
    }

    public class Produto
    {
        private string NomeProduto { get; set; }
        public decimal Preco { get; set; }

        public int Quantidade { get; set; }

        public Produto(string NomeProduto, decimal preco, int quantidade)
        {
            NomeProduto = NomeProduto;
            Preco = preco;
            Quantidade = quantidade;
        }
    }
}

