﻿namespace ContatosMVC.Models
{
    public class ContatoModel
    {
        public ContatoModel()
        {
            Nome = "";
            Email = "";
            Celular = "";
        }

        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Email { get; set; }
        public string? Celular { get; set; }
    }
}
