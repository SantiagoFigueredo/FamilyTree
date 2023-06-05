using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona abuelo = new Persona("Pedro", 70);
            Persona padre = new Persona("Nestor", 45);
            Persona madre = new Persona("Silvia", 42);
            Persona hijo1 = new Persona("Mateo", 8);
            Persona hijo2 = new Persona("Santiago", 18);
            Persona hijo3 = new Persona("Sebastian", 15);
            Persona hija1 = new Persona("Sol", 12);
            Persona hija2 = new Persona("Isabella", 20);

            Node nodeAbuelo = new Node(abuelo);
            Node nodePadre = new Node(padre);
            Node nodeMadre = new Node(madre);
            Node nodeHijo1 = new Node(hijo1);
            Node nodeHijo2 = new Node(hijo2);
            Node nodeHijo3 = new Node(hijo3);
            Node nodeHija1 = new Node(hija1);
            Node nodeHija2 = new Node(hija2);

            nodeAbuelo.AddChildren(nodePadre);
            nodeAbuelo.AddChildren(nodeMadre);

            nodePadre.AddChildren(nodeHijo1);
            nodePadre.AddChildren(nodeHijo2);
            nodePadre.AddChildren(nodeHijo3);

            nodeMadre.AddChildren(nodeHija1);
            nodeMadre.AddChildren(nodeHija2);

            // Calcular suma de edades
            SumaEdadesVisitor sumaEdadesVisitor = new SumaEdadesVisitor();
            int sumaEdades = sumaEdadesVisitor.CalcularSumaEdades(nodeAbuelo);
            Console.WriteLine("La suma de las edades de la familia es: " + sumaEdades);

            // Encontrar hijo mayor
            HijoMayorVisitor hijoMayorVisitor = new HijoMayorVisitor();
            Node hijoMayor = hijoMayorVisitor.EncontrarHijoMayor(nodeAbuelo);
            Console.WriteLine("El hijo más grande es: " + hijoMayor.Persona.Nombre);

            // Encontrar nombre más largo
            NombreLargoVisitor nombreLargoVisitor = new NombreLargoVisitor();
            string nombreMasLargo = nombreLargoVisitor.EncontrarNombreMasLargo(nodeAbuelo);
            Console.WriteLine("El nombre más largo es: " + nombreMasLargo);
        }
    }
}
