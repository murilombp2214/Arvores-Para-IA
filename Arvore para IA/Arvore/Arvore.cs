using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IA_Arvore.Core
{
    public class Arvore
    {
        #region Propiedades
        public No Raiz { get; set; }
        #endregion Propiedades
        #region Construtor
        public Arvore()
        {

        }
        #endregion Construtor
        #region Metodos
        private void ValidarInserir(No node)
        {
            if (Raiz is null)
            {
                throw new Exception("O No Raiz esta nulo");
            }
            if (node is null)
            {
                throw new ArgumentNullException(nameof(node));
            }

        }
        public void Inserir(No node)
        {
            ValidarInserir(node);
            InserirRecursivo(Raiz, node);
        }
        public void Remover(No node)
        {
            ValidarInserir(node);
            if(node == Raiz)
            {
                Raiz = null;
            }
            else
            {
                RemoverRecursivo(Raiz, node);
            }
            GC.Collect();
        }
        private void InserirRecursivo(No raizparam, No node)
        {
            if(node < raizparam)
            {
                if(raizparam.Esquerda is null)
                {
                    raizparam.Esquerda = node;
                }
                else
                {
                    InserirRecursivo(raizparam.Esquerda, node);
                }
            }
            else
            {
                if (raizparam.Direita is null)
                {
                    raizparam.Direita = node;
                }
                else
                {
                    InserirRecursivo(raizparam.Direita, node);
                }
            }
        }

        private bool RemoverRecursivo(No raizparam, No node)
        {
            if(raizparam == node)
            {
                raizparam = null;
                return true;
            }
            else
            {
                if(raizparam.Direita == node)
                {
                    raizparam.Direita = null;
                    return true;
                }
                else
                {
                    if(raizparam.Esquerda == node)
                    {
                        raizparam.Esquerda = null;
                        return true;
                    }
                    else
                    {
                        if(raizparam.Esquerda != null && RemoverRecursivo(raizparam.Esquerda, node))
                        {
                            return true;
                        }
                        if(raizparam.Direita != null &&  RemoverRecursivo(raizparam.Direita, node))
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        public decimal BFS(No node)
        {
            var fila = new Queue<No>();
            fila.Enqueue(Raiz);
            return BFS_Recursivo(fila,node);
        }
        private decimal BFS_Recursivo(Queue<No> filaRaizparam,No node, decimal qtd = 0) 
        {
            var fila = new Queue<No>();
            while (filaRaizparam.Any())
            {
                ++qtd;
                No nodeFila = filaRaizparam.Dequeue();
                if(nodeFila == node)
                {
                    return qtd;
                }
                if(nodeFila.Esquerda != null)
                {
                    fila.Enqueue(nodeFila.Esquerda);
                }

                if(nodeFila.Direita != null)
                {
                    fila.Enqueue(nodeFila.Direita);
                }
            }

            if(fila.Any())
            {
                return BFS_Recursivo(fila, node, qtd);
            }
            return 0;
        }

        public decimal DFS(No node)
        {
            decimal resultado = 0;
            bool achou = false;
            DFS_Recusivo(Raiz, node, ref resultado,ref achou);
            return resultado;
        }
        private void DFS_Recusivo(No raizparam,No node, ref decimal qtd, ref bool achou)
        {
            ++qtd;
            if(raizparam == node)
            {
                achou = true;
                return;
            }


            if(!achou &&  raizparam.Esquerda != null)
            {
                DFS_Recusivo(raizparam.Esquerda, node,ref  qtd,ref achou);
            }

            if (!achou &&  raizparam.Direita != null)
            {
                DFS_Recusivo(raizparam.Direita, node, ref qtd, ref achou);
            }
        }
        public void InsiraValorAresta(No nodeInicio, No nodeFinal,decimal valorAresta)
        {
            InsiraValorAresta_Recursirvo(Raiz, nodeInicio, nodeFinal, valorAresta);
        }

        private void InsiraValorAresta_Recursirvo(No raizparam,No nodeInicio, 
                                                 No nodeFinal, decimal valorAresta)
        {
            if(raizparam == nodeInicio)
            {
                if(raizparam.Esquerda != null && raizparam.Esquerda == nodeFinal)
                {
                    raizparam.ValorArestaEsquerda = valorAresta;
                    return;
                }

                if (raizparam.Direita != null && raizparam.Direita == nodeFinal)
                {
                    raizparam.ValorArestaDireita = valorAresta;
                }
            }

            if(raizparam.Direita != null)
            {
                InsiraValorAresta_Recursirvo(raizparam.Direita, nodeInicio,
                                             nodeFinal, valorAresta);
            }

            if (raizparam.Esquerda != null)
            {
                InsiraValorAresta_Recursirvo(raizparam.Esquerda, nodeInicio,
                                             nodeFinal, valorAresta);
            }
        }

        public Tuple<decimal,decimal> BuscaMenorCaminho(No node)
        {
            var list = new List<decimal>();
            bool achou = false;
            decimal qtd = 0;
            decimal valorCamiho = 0;
            BuscaMenorCaminho_Recursivo(Raiz, node,list,ref qtd,ref achou);
            list.ForEach(x => { valorCamiho += x; });
            
            if (achou)
                return Tuple.Create(qtd, valorCamiho);
            throw new Exception("Vertice não encontrado!");

        }

        private decimal BuscaMenorCaminho_Recursivo(No raizparam,No node,
                                                    List<decimal>list,ref decimal qtdIteracaos,
                                                    ref bool achou)
        {
            ++qtdIteracaos ;
            //Se achou coloca o valor do No
            if(raizparam == node)
            {
                list.Add(node.ValorDoNo);
                achou = true;
                return qtdIteracaos;
            }
            //certeza que os dois não são nulos, buscar pelos dois
            if (raizparam.Esquerda != null && raizparam.Direita != null)
            {
                decimal valorE = raizparam.ValorArestaEsquerda + raizparam.Esquerda.ValorDoNo;
                decimal valorD = raizparam.ValorArestaDireita + raizparam.Direita.ValorDoNo;
                if(valorE < valorD)//Esquerda menor que direita
                {
                    if(BuscaMenorCaminho_RecursivoEsqueda(list,ref achou,raizparam,node,ref qtdIteracaos))
                    {
                        return qtdIteracaos;
                    }
                }
                else if (BuscaMenorCaminho_RecursivoDireita(list, ref achou, raizparam, node, ref qtdIteracaos))
                {
                    return qtdIteracaos;
                }

                if (valorE >= valorD)//Direita maior
                {
                    if (BuscaMenorCaminho_RecursivoEsqueda(list, ref achou, raizparam, node, ref qtdIteracaos))
                    {
                        return qtdIteracaos;
                    }
                }
                else if (BuscaMenorCaminho_RecursivoDireita(list, ref achou, raizparam, node, ref qtdIteracaos))
                {
                    return qtdIteracaos;
                }


            }
            else
            {
                if(raizparam.Esquerda != null)
                {
                    if (BuscaMenorCaminho_RecursivoEsqueda(list, ref achou, raizparam, node, ref qtdIteracaos))
                    {
                        return qtdIteracaos;
                    }
                }

                if(raizparam.Direita != null)
                {
                    if (BuscaMenorCaminho_RecursivoDireita(list, ref achou, raizparam, node, ref qtdIteracaos))
                    {
                        return qtdIteracaos;
                    }
                }


            }
            return qtdIteracaos;
        }

        private bool BuscaMenorCaminho_RecursivoEsqueda(List<decimal> list,ref bool achou, 
                                                        No raizparam, No node, ref decimal qtdIteracaos)
        {
            decimal qtdListAux = list.Count;
            BuscaMenorCaminho_Recursivo(raizparam.Esquerda, node, list, ref qtdIteracaos, ref achou);
            if (achou)
            {
                list.Add(raizparam.ValorArestaEsquerda);
                return true;
            }
            else
            {
                while (qtdListAux < list.Count)
                {
                    list.RemoveAt(list.Count);
                }
            }
            return false;
        }
        private bool BuscaMenorCaminho_RecursivoDireita(List<decimal> list, ref bool achou,
                                                No raizparam, No node, ref decimal qtdIteracaos)
        {
            decimal qtdListAux = list.Count;
            BuscaMenorCaminho_Recursivo(raizparam.Direita, node, list, ref qtdIteracaos, ref achou);
            if (achou)
            {
                list.Add(raizparam.ValorArestaDireita);
                return true;
            }
            else
            {
                while (qtdListAux < list.Count)
                {
                    list.RemoveAt(list.Count);
                }
            }
            return false;
        }



        #endregion Metodos
    }

}
