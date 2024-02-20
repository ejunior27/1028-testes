using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1028_testes
{
    public class Anagrama
    {
        /*
         O anagrama é um jogo de palavras que utiliza a 
        transposição ou rearranjo de letras de uma palavra ou frase, 
        com o intuito de formar outras palavras com ou sem sentido.
         * */

        public bool VerificarAnagrama(string palavra1, string palavra2)
        {
            // Remover espaços e converter para minúsculas
            palavra1 = palavra1?.Replace(" ", "").ToLower();
            palavra2 = palavra2?.Replace(" ", "").ToLower();

            if (string.IsNullOrEmpty(palavra1) || string.IsNullOrEmpty(palavra2))            
                return false;            

            // Verificar se possuem o mesmo comprimento
            if (palavra1.Length != palavra2.Length)
                return false;

            // Ordenar as letras
            char[] palavra1Array = palavra1.ToCharArray();
            char[] palavra2Array = palavra2.ToCharArray();
            Array.Sort(palavra1Array);
            Array.Sort(palavra2Array);

            // Verificar se são iguais
            for (int i = 0; i < palavra1Array.Length; i++)
            {
                if (palavra1Array[i] != palavra2Array[i])
                    return false;
            }

            return true;
        }
    }
}
