using System;
using AreaFiguraMetodosAbstratos.Entities.Enuns;
using AreaFiguraMetodosAbstratos.Entities;

namespace AreaFiguraMetodosAbstratos
{
    class Circulo : Figura
    {
        public double Raio { get; set; }

        public Circulo(double raio, Color cor): base (cor)
        {
            this.Raio = raio;
        }

        public override double Area()
        {
            return Math.PI * Raio * Raio;
        }
    }
}
