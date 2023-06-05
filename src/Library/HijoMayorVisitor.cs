using System;

namespace Library
{
    public class HijoMayorVisitor
    {
        private Node hijoMayor;

        public Node EncontrarHijoMayor(Node node)
        {
            hijoMayor = null;
            VisitarNodo(node);
            return hijoMayor;
        }

        private void VisitarNodo(Node node)
        {
            if (node.Hijos.Count == 0) 
            {
                if (hijoMayor == null || node.Persona.Edad > hijoMayor.Persona.Edad)
                {
                    hijoMayor = node;
                }
            }

            foreach (var hijo in node.Hijos)
            {
                VisitarNodo(hijo);
            }
        }
    }
}
