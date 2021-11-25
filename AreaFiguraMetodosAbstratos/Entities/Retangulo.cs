using AreaFiguraMetodosAbstratos.Entities;
using AreaFiguraMetodosAbstratos.Entities.Enuns;

class Retangulo : Figura
{
    public double Altura { get; set; }
    public double Largura { get; set; }

    public Retangulo(double altura, double largura, Color cor) 
        : base(cor)
    {
        Altura = altura;
        Largura = largura;
    }

    public override double Area()
    {
        return Altura*Largura;
    }
}


