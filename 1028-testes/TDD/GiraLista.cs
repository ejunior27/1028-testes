using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1028_testes.TDD
{
    public class GiraLista
    {
        public List<int> Girar(List<int> lista)
        {
            //return lista;

            //return new List<int> { 15, 0, 0, 10 };

            //var item1 = lista[1];
            //return new List<int> { item1, 30, 12 };

            //var item0 = lista[0];
            //var nova = new List<int>();
            //lista.RemoveAt(0);
            //nova.AddRange(lista);
            //nova.Add(item0);
            //return nova;

            //if (lista.Count == 0)
            //{
            //    throw new ArgumentException("A lista não pode ser vazia.");
            //}
            //var item0 = lista[0];
            //var nova = new List<int>();
            //lista.RemoveAt(0);
            //nova.AddRange(lista);
            //nova.Add(item0);
            //return nova;


            if (lista.Count <= 1)
            {
                throw new ArgumentException("A lista deve conter mais de um elemento");
            }

            var item0 = lista[0];
            var nova = new List<int>();
            lista.RemoveAt(0);
            nova.AddRange(lista);
            nova.Add(item0);
            return nova;
        }
    }
}
