using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    class Aluno
    {
        private string _nome;
        private string _curso;
        private double _nota;

        public string Nome { get => _nome; set => _nome = value; }
        public string Curso { get => _curso; set => _curso = value; }
        public double Nota { get => _nota; set => _nota = value; }

        public Aluno(string nome, string curso, double nota)
        {
            Nome = nome;
            Curso = curso;
            Nota = nota;
        }

        public bool HasHonors()
        {
            if (Nota >= 3.5)
            {
                return true;
            }
            return false;
        }
    }
}
