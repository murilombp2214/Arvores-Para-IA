using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IA_Arvore.Core;

namespace IA_Arvore
{
    public partial class FrmPrincipal : Form
    {
        private Arvore MinhaArvore { get; set; } = new Arvore();
        private string texto = string.Empty;
        public FrmPrincipal()
        {
            InitializeComponent();
            txtInserirPai.Focus();
        }

        private void BtnInserir_Click(object sender, EventArgs e)
        {
            try
            {
                if (MinhaArvore.Raiz is null)
                {
                    txtInserirPai.Focus();
                    throw new Exception("Insira a Raiz primeiro!");
                }
                MinhaArvore.Inserir(new No()
                {
                    ValorDoNo = decimal.Parse(txtInserir.Text)
                });
                BtnImprimir_Click(null, null);
                txtInserir.Focus();
                txtInserir.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Program.Title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnInserirPai_Click(object sender, EventArgs e)
        {
            MinhaArvore.Raiz = new No()
            {
                ValorDoNo = decimal.Parse(txtInserirPai.Text),

            };
            Habilitar(true);
            BtnImprimir_Click(null, null);
            txtInserir.Focus();

        }

        private void Habilitar(bool hbl)
        {
            txtInserirPai.Enabled = !hbl;
            btnInserirPai.Enabled = !hbl;

            txtInserir.Visible = hbl;
            btnInserir.Visible = hbl;

            btnRemover.Visible = hbl;
            txtRemover.Visible = hbl;

            btnImprimir.Visible = hbl;

            btnDFS.Visible = hbl;
            btnBFS.Visible = hbl;

            btnRota.Visible = hbl;
            txtRota.Visible = hbl;

            labelCusto.Visible = hbl;
            labelNo1.Visible = hbl;
            labelNo2.Visible = hbl;
            txtNoCusto1.Visible = hbl;
            txtNoCusto2.Visible = hbl;
            txtCusto.Visible = hbl;
            btnAddCusto.Visible = hbl;

            btnMenorCusto.Visible = hbl;

            txtDesenho.Visible = hbl;
        }

        private void ImprimirArvore(No Raiz)
        {
            texto += (string.IsNullOrEmpty(texto) ? string.Empty : Environment.NewLine) + $"({ Raiz.ToString()})";
            if(Raiz.Esquerda != null)
            {
                texto += $"-({Raiz.ValorArestaEsquerda})->Esquerda({Raiz.Esquerda.ToString()})";
            }
            if (Raiz.Direita != null)
            {
                texto += $"-({Raiz.ValorArestaDireita})->Direita({Raiz.Direita.ToString()})";
            }
            if (Raiz.Esquerda != null)
            {
                ImprimirArvore(Raiz.Esquerda);
            }
            if (Raiz.Direita != null)
            {
                ImprimirArvore(Raiz.Direita);
            }

        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            if(MinhaArvore.Raiz != null)
            {
                btnMenorCusto.Visible = true;
                texto = string.Empty;
                ImprimirArvore(MinhaArvore.Raiz);
                txtDesenho.Text = texto;
            }
            else
            {
                MessageBox.Show("Arvore vazia", Program.Title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void TxtInserir_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                BtnInserir_Click(null, null);
            }
        }

        private void BtnRemover_Click(object sender, EventArgs e)
        {
            No nodeRemover = new No() { ValorDoNo = decimal.Parse(txtRemover.Text) };
            if(MinhaArvore.Raiz == nodeRemover)
            {
                Habilitar(false);
            }
            MinhaArvore.Remover(nodeRemover);
            BtnImprimir_Click(null, null);
        }

        private void BtnRemover_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                BtnRemover_Click(null, null);
            }
        }

        private void BtnDFS_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtRota.Text))
                {
                    txtRota.Focus();
                    throw new Exception("Preencha o caminho final da rota!");
                }
                decimal caminho = MinhaArvore.DFS(new No() { ValorDoNo = decimal.Parse(txtRota.Text) });
                MessageBox.Show($"Custo para chegar no objetivo : {caminho}", Program.Title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Program.Title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnBFS_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtRota.Text))
                {
                    txtRota.Focus();
                    throw new Exception("Preencha o caminho final da rota!");
                }
                decimal caminho = MinhaArvore.BFS(new No() { ValorDoNo = decimal.Parse(txtRota.Text) });
                MessageBox.Show($"Custo para chegar no objetivo : {caminho}", Program.Title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Program.Title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void TxtInserirPai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                BtnInserirPai_Click(null, null);
            }
        }

        private void BtnAddCusto_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtCusto.Text))
                {
                    txtCusto.Focus();
                    throw new Exception("Preencha o custo");
                }

                if (string.IsNullOrEmpty(txtNoCusto1.Text))
                {
                    txtNoCusto1.Focus();
                    throw new Exception("Preencha o No inicial");
                }

                if (string.IsNullOrEmpty(txtNoCusto2.Text))
                {
                    txtNoCusto2.Focus();
                    throw new Exception("Preencha o No Final");
                }

                MinhaArvore.InsiraValorAresta(
                    new No() { ValorDoNo = decimal.Parse(txtNoCusto1.Text) },
                    new No() { ValorDoNo = decimal.Parse(txtNoCusto2.Text)},
                    decimal.Parse(txtCusto.Text)
                    );
                BtnImprimir_Click(null, null);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, Program.Title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnMenorCusto_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtCusto.Text))
                {
                    txtCusto.Focus();
                    throw new Exception("Preencha o custo");
                }

                if (string.IsNullOrEmpty(txtNoCusto1.Text))
                {
                    txtNoCusto1.Focus();
                    throw new Exception("Preencha o No inicial");
                }

                if (string.IsNullOrEmpty(txtNoCusto2.Text))
                {
                    txtNoCusto2.Focus();
                    throw new Exception("Preencha o No Final");
                }

                Tuple<decimal,decimal> tupla = MinhaArvore.BuscaMenorCaminho(
                                        new No()
                                        {
                                            ValorDoNo = decimal.Parse(txtRota.Text)
                                        });

                string msg = $"Quantidade de iterações: {tupla.Item1}";
                msg += Environment.NewLine + $"Custo: {tupla.Item2}";
                MessageBox.Show(msg,Program.Title, MessageBoxButtons.OK, 
                                 MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Program.Title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
        }

        private void TxtCusto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                BtnAddCusto_Click(null,null);
            }
        }
    }
}
