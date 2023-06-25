namespace Listas
{
    class Pilas
    {
        class Nodo
        {
            public int infoNodo;
            public Nodo siguienteNodo;
        }
        private Nodo nodoInicial;

        public Pilas()
        {
            nodoInicial = null;
        }

        public void Agregar(int x)
        {
            Nodo nuevo;
            nuevo = new Nodo();
            nuevo.infoNodo = x;
            if (nodoInicial == null)
            {
                nuevo.siguienteNodo = null;
                nodoInicial = nuevo;
            }
            else
            {
                nuevo.siguienteNodo = nodoInicial;
                nodoInicial = nuevo;
            }
        }

        public int Extraer()
        {
            if (nodoInicial != null)
            {
                int informacion = nodoInicial.infoNodo;
                nodoInicial = nodoInicial.siguienteNodo;
                return informacion;
            }
            else
            {
                return int.MaxValue;
            }
        }
        public void Imprimir()
        {
            Nodo reco = nodoInicial;
            Console.WriteLine("Listado de todos los elementos de la pila.");
            while (reco != null)
            {
                Console.Write(reco.infoNodo + "-");
                reco = reco.siguienteNodo;
            }
            Console.WriteLine();
        }
        public bool EstaVacia()
        {
            if (nodoInicial == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public int Cantidad()
        {
            int cant = 0;
            Nodo reco = nodoInicial;
            while (reco != null)
            {
                cant++;
                reco = reco.siguienteNodo;
            }

            return cant;
        }

        static void Main(string[] args)
        {
            Pilas pila1 = new Pilas();
            pila1.Agregar(10);
            pila1.Agregar(20);
            pila1.Agregar(30);
            pila1.Imprimir();
            Console.WriteLine("La cantidad de nodos de la lista es:" + pila1.Cantidad());
            while (pila1.EstaVacia() == false)
            {
                Console.WriteLine(pila1.Extraer());
            }
            Console.ReadKey();
        }

    }
}

