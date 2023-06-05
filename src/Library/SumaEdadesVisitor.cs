using System;

namespace Library
{
    public class SumaEdadesVisitor
    {
        private int sumaEdades;

        public int CalcularSumaEdades(Node node)
        {
            sumaEdades = 0;
            VisitarNodo(node);
            return sumaEdades;
        }

        private void VisitarNodo(Node node)
        {
            sumaEdades += node.Persona.Edad;

            foreach (var hijo in node.Hijos)
            {
                VisitarNodo(hijo);
            }
        }
    }
}
