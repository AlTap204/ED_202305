namespace ListasColas
{
    class Cola
    {
        class NodoColas
        {
            public int infoNodo;
            public NodoColas siguienteNodo;
        }
        private NodoColas nodoInicial, fondo;
        public Cola()
        {
            nodoInicial = null;
            fondo = null;
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
        public void Insertar(int info)
        {
            NodoColas nuevo;
            nuevo = new NodoColas();
            nuevo.infoNodo = info;
            nuevo.siguienteNodo = null;
            if (EstaVacia())
            {
                nodoInicial = nuevo;
                fondo = nuevo;
            }
            else
            {
                fondo.siguienteNodo = nuevo;
                fondo = nuevo;
            }
        }

        public int Extraer()
        {
            if (!EstaVacia())
            {
                int informacion = nodoInicial.infoNodo;
                if (nodoInicial == fondo)
                {
                    nodoInicial = null;
                    fondo = null;
                }
                else
                {
                    nodoInicial = nodoInicial.siguienteNodo;
                }
                return informacion;
            }
            else
                return int.MaxValue;
        }

        public void Imprimir()
        {
            NodoColas reco = nodoInicial;
            Console.WriteLine("Listado de todos los elementos de la cola ");
            while (reco != null)
            {
                Console.Write(reco.infoNodo + "\n ----- \n");
                reco = reco.siguienteNodo;
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Cola cola = new Cola();
            cola.Insertar(1);
            cola.Insertar(2);
            cola.Insertar(3);
            cola.Imprimir();
            Console.WriteLine("Extraemos un elemento de la cola:" + cola.Extraer());
            cola.Imprimir();
            Console.ReadKey();
        }
    }
}
