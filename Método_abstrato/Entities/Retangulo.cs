namespace Método_abstrato.Entities
{
    class Retangulo : Forma
    {
        //Declarando as variaveis
        public double Largura { get; set; }
        public double Altura { get; set; }

        //Criando construtor peronalizado com herança da classe "Forma"
        public Retangulo(double largura, double altura, Color cor) : base(cor)
        {
            Largura = largura;
            Altura = altura;
        }

        //método abstrato da classe "Forma"
        public override double Area()
        {
            return Largura * Altura;
        }


    }
}
