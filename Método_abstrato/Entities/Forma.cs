namespace Método_abstrato.Entities
{
    //Criação de classe abstrata
    abstract class Forma
    {
        //Declarando a variavel da classe "Color"
        public Color Color { get; set; }

        //método personalizado
        public Forma (Color color )
        {
            Color = color;
        }

        //Criação de método abstrato
        public abstract double Area();
    }
}
