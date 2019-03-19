﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Masterchef.Domain.Receita.Entity
{
    public class Receita
    {
        public Receita()
        { }

        public Guid ReceitaId { get; set; }
        public string Titulo { get; set; }
        public string ModoPreparo { get; set; }
        public ICollection<Ingrediente.Entity.Ingrediente> Ingredientes { get; set; }
    }
}