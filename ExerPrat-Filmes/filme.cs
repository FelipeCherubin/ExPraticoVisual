using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExerPrat_Filmes
{
    class filme
    {
        public string nomes;
        public string local;
        public string genero;
        public DateTime data;
       

       

        public filme(string Nome, string Local, DateTime Data, string Genero)
        {
            // TODO: Complete member initialization
            nomes = Nome;
            local = Local;
            genero = Genero;
            data = Data;
        }
    }
}
