using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    class Book
    {
        private string _titulo;
        private string _autor;
        private int _paginas;


        public string Titulo { get => _titulo; set => _titulo = value; }
        public string Autor { get => _autor; set => _autor = value; }
        public int Paginas { get => _paginas; set => _paginas = value; }
        
        
        public Book(string titulo, string autor, int paginas)
        {
            Titulo = titulo;
            Autor = autor;
            Paginas = paginas;
        }
    }
}
