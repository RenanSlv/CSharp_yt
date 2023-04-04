using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{

    //=====================================================
    abstract class Forma_geometrica
    {
        int _largura,
            _altura;
        
        public int Largura{get { return _largura; } set { _largura = value; }} 
        public int Atura { get { return _altura; } set { _altura = value; } }

        public void Apresentar()
        {
            Console.WriteLine("Este método pertence à classe base.");
        }

        //este método terá que ser implementado em todas as classes derivadas
        abstract public void Desenhar();

        //este método pode ser alterado nas classes derivadas pois é virtual
        public virtual void Desenhar_Outro() 
        {
            Console.WriteLine("Método virtual da classe base.");
        }
    }

    class Retangulo : Forma_geometrica
    {
        public override void Desenhar()
        {
            Console.WriteLine($@"Desenho do retangulo coma as dimenções: {Largura} {Atura}");
        }

        public override void Desenhar_Outro()
        {
            Console.WriteLine($@"Este é um método virtual substituido na classe derivada");
        }

    }

    class Triangulo : Forma_geometrica 
    {
        public override void Desenhar()
        {
            Console.WriteLine($@"Desenho do triangulo coma as dimenções: {Largura} {Atura}");
        }
    }

    class Circulo : Forma_geometrica 
    {
        public override void Desenhar() 
        {
            Console.WriteLine($@"Desenho do circulo coma as dimenções: {Largura} {Atura}");
        }
    }

}
