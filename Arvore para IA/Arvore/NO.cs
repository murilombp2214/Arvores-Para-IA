using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IA_Arvore.Core.Interfaces;

namespace IA_Arvore.Core
{
    public class No : INo
    {
        public No()
        {
        }

        /// <summary>
        /// Valor do NO, caso não existe então 0
        /// </summary>
        public decimal ValorDoNo { get; set; } = 0;
        /// <summary>
        /// Valor da Aresta direita, caso não exista então 0
        /// </summary>
        public decimal ValorArestaDireita { get; set; } = 0;
        /// <summary>
        /// Valor da Aresta esquerda, caso não exista então 0
        /// </summary>
        public decimal ValorArestaEsquerda { get; set; } = 0;
        /// <summary>
        /// No a direita,caso não exisa então NULL
        /// </summary>
        public No Direita { get; set; } = null;
        /// <summary>
        /// No a esqueda, caso não exista então NULL 
        /// </summary>
        public No Esquerda { get; set; } = null;
        /// <summary>
        /// Opecacao Diferente Entre o valor do NO
        /// </summary>
        /// <param name="a">No</param>
        /// <param name="b">No</param>
        /// <returns>Se é diferente</returns>
        public static bool operator !=(No a, No b)
            => a?.ValorDoNo != b?.ValorDoNo;
        /// <summary>
        /// Opecacao Igualdade Entre o valor do NO
        /// </summary>
        /// <param name="a">No</param>
        /// <param name="b">No</param>
        /// <returns>Se é igual</returns>
        public static bool operator ==(No a, No b)
            => a?.ValorDoNo == b?.ValorDoNo;
        /// <summary>
        /// Opecacao maior que Entre o valor do NO
        /// </summary>
        /// <param name="a">No</param>
        /// <param name="b">No</param>
        /// <returns>Se é maior que</returns>
        public static bool operator >(No a, No b)
            => a.ValorDoNo > b.ValorDoNo;
        /// <summary>
        /// Opecacao maior igual Entre o valor do NO
        /// </summary>
        /// <param name="a">No</param>
        /// <param name="b">No</param>
        /// <returns>Se é maior ou igual</returns>
        public static bool operator >=(No a, No b)
            => a.ValorDoNo >= b.ValorDoNo;
        /// <summary>
        /// Opecacao Menor que Entre o valor do NO
        /// </summary>
        /// <param name="a">No</param>
        /// <param name="b">No</param>
        /// <returns>Se é menor</returns>
        public static bool operator <(No a, No b)
            => a.ValorDoNo < b.ValorDoNo;
        /// <summary>
        /// Opecacao menor igual Entre o valor do NO
        /// </summary>
        /// <param name="a">No</param>
        /// <param name="b">No</param>
        /// <returns>Se é menor igual</returns>
        public static bool operator <=(No a, No b)
            => a.ValorDoNo <= b.ValorDoNo;

        /// <summary>
        /// Valida se o NO é igual
        /// </summary>
        /// <param name="obj">objeto No</param>
        /// <returns>se é o mesmo no</returns>
        public override bool Equals(object obj)
        {
            var no = obj as No;
            return no != null &&
                   ValorDoNo == no.ValorDoNo;
        }

        /// <summary>
        /// Hash Code do Objeto
        /// </summary>
        /// <returns>Hash</returns>
        public override int GetHashCode()
        {
            return -1705808697 + ValorDoNo.GetHashCode();
        }

        /// <summary>
        /// Valor do No em String
        /// </summary>
        /// <returns>Valor d No</returns>
        public override string ToString()
        {
            return ValorDoNo.ToString();
        }
    }
}
