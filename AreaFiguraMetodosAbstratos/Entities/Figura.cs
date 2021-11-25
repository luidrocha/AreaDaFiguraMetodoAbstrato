using System;
using System.Collections.Generic;
using AreaFiguraMetodosAbstratos.Entities.Enuns;

namespace AreaFiguraMetodosAbstratos.Entities
{
    abstract class Figura
    {
        public Color Color { get; set; }

        public Figura(Color color)
        {
            Color = color;
        }

        public abstract double Area() ; // Class abstrata não tem implementação 
    }


}
