namespace IA_Arvore.Core.Interfaces
{
    public interface INo
    {
        No Direita { get; set; }
        No Esquerda { get; set; }
        decimal ValorArestaDireita { get; set; }
        decimal ValorArestaEsquerda { get; set; }
        decimal ValorDoNo { get; set; }

        bool Equals(object obj);
        int GetHashCode();
    }
}