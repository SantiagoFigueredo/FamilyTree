using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class Node
    {
        private Persona persona;
        private List<Node> hijos = new List<Node>();

        public Persona Persona
        {
            get { return persona; }
        }

        public ReadOnlyCollection<Node> Hijos
        {
            get { return hijos.AsReadOnly(); }
        }

        public Node(Persona persona)
        {
            this.persona = persona;
        }

        public void AddChildren(Node hijo)
        {
            hijos.Add(hijo);
        }
    }
}
