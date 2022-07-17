﻿namespace Exercicio01 {
    internal class Estudante {
        public string Nome { get; set; }
        public string Email { get; set; }

        public Estudante(string nome, string email) { 
            Nome = nome;
            Email = email;
        }

        override public string ToString() {
            return $"{Nome}, {Email}";
        }
    }
}
