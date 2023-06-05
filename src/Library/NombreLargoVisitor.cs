using System;

namespace Library
{
    public class NombreLargoVisitor
    {
        private string nombreMasLargo;

        public string EncontrarNombreMasLargo(Node node)
        {
            nombreMasLargo = null;
            VisitarNodo(node);
            return nombreMasLargo;
        }

        private void VisitarNodo(Node node)
        {
            if (node.Persona.Nombre.Length > nombreMasLargo.Length)
            {
                nombreMasLargo = node.Persona.Nombre;
            }

            foreach (var hijo in node.Hijos)
            {
                VisitarNodo(hijo);
            }
        }
    }
}
