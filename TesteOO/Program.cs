using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Http.Headers;

namespace TesteOO
{
    class Program
    {
        static void Main(string[] args)
        {


            //Exemplo 1 - Teste de Dictionary<int,value>
            //TesteDictionary();

            // Exemplo 2 - Iteração com List<T>
            // TesteList();

            //Exemplo 3 - Teste Queue<T>
            //TesteQueueT();

            //Exemplo 4 - SortedList < Tkey,Tvalue >
            // TesteSortedListT();

            //Exemplo 5 - Stack<T>
            //TesteStackT();

            //Exemplo 6- ArrayList
            // TesteArrayList();

            //Exemplo 7 - HashTable
            //TesteHashTable();

            //Exemplo 8- Queue
            // TesteQueue();

            //Exemplo 9 - Stack
            //TesteStack();



            Console.ReadLine();
        }
        /// <summary>
        /// Exemplo 9 - Stack
        /// </summary>
        static void TesteStack()
        {
            Stack stackPF = new Stack();

            //Adicionando item na Queue
            stackPF.Push(new clsPessoaFisica("Fulano", new DateTime(1980, 05, 30)));
            stackPF.Push(new clsPessoaFisica("Beltrano", new DateTime(1990, 04, 10)));
            stackPF.Push(new clsPessoaFisica("Ciclano", new DateTime(1995, 02, 25)));
            stackPF.Push(new clsPessoaFisica("Ellen", new DateTime(1986, 01, 28)));
            stackPF.Push(new clsPessoaFisica("Chun Li", new DateTime(2014, 02, 03)));
            stackPF.Push(new clsPessoaFisica("Sindel", new DateTime(2014, 04, 07)));

            Console.WriteLine("PF Stack");
            Console.WriteLine("\nQuantidade:    {0}", stackPF.Count);
            Console.Write("\nValores:");
            foreach (clsPessoaFisica objPF in stackPF)
                Console.Write("    {0}", objPF.Nome);

            Console.WriteLine("\nRemovendo o item " + ((clsPessoaFisica)stackPF.Pop()).Nome);

            Console.WriteLine("nova lista é: ");
            foreach (clsPessoaFisica objPF in stackPF)
                Console.Write("    {0}", objPF.Nome);
        }
        /// <summary>
        /// Exemplo 8 - Queue
        /// </summary>
        static void TesteQueue()
        {
            Queue queuePF = new Queue();

            //Adicionando item na Queue
            queuePF.Enqueue(new clsPessoaFisica("Fulano", new DateTime(1980, 05, 30)));
            queuePF.Enqueue(new clsPessoaFisica("Beltrano", new DateTime(1990, 04, 10)));
            queuePF.Enqueue(new clsPessoaFisica("Ciclano", new DateTime(1995, 02, 25)));
            queuePF.Enqueue(new clsPessoaFisica("Ellen", new DateTime(1986, 01, 28)));
            queuePF.Enqueue(new clsPessoaFisica("Chun Li", new DateTime(2014, 02, 03)));
            queuePF.Enqueue(new clsPessoaFisica("Sindel", new DateTime(2014, 04, 07)));

            // queuePF.Enqueue("Mais um");

            // Displays the properties and values of the Queue.
            Console.WriteLine("Queue");
            Console.WriteLine("\nQtde:    {0}", queuePF.Count);
            Console.Write("\nValores:");
            foreach (clsPessoaFisica objPF in queuePF)
                Console.Write("    {0}", objPF.Nome);

            Console.WriteLine("\nRemovendo item : " + ((clsPessoaFisica)queuePF.Dequeue()).Nome);
            foreach (clsPessoaFisica objPF in queuePF)
                Console.Write("    {0}", objPF.Nome);

        }

        /// <summary>
        /// Exemplo 7 - HashTable
        /// </summary>
        static void TesteHashTable()
        {
            Hashtable htPessoaFisica = new Hashtable();

            htPessoaFisica.Add(1, new clsPessoaFisica("Fulano", new DateTime(1980, 05, 30)));
            htPessoaFisica.Add(2, new clsPessoaFisica("Beltrano", new DateTime(1990, 04, 10)));
            htPessoaFisica.Add(3, new clsPessoaFisica("Ciclano", new DateTime(1995, 02, 25)));
            htPessoaFisica.Add(4, new clsPessoaFisica("Ellen", new DateTime(1986, 01, 28)));
            htPessoaFisica.Add(5, new clsPessoaFisica("Chun Li", new DateTime(2014, 02, 03)));
            htPessoaFisica.Add(6, new clsPessoaFisica("Sindel", new DateTime(2014, 04, 07)));

            //  htPessoaFisica.Add(11, "Teste");

            /* //teste tentando adicionar item ja existente
             htPessoaFisica.Add(1, new clsPessoaFisica("Fapen", new DateTime(1980, 05, 30)));*/


            //obtendo um unico item
            Console.WriteLine("chave = \"5\", value = {0}.", ((clsPessoaFisica)htPessoaFisica[5]).Nome);


            htPessoaFisica[5] = new clsPessoaFisica("Ryu", new DateTime(2014, 02, 13));
            Console.WriteLine("chave key = \"5\", value = {0}.", ((clsPessoaFisica)htPessoaFisica[5]).Nome);

            // If a key does not exist, setting the default Item property
            // for that key adds a new key/value pair.
            htPessoaFisica[4] = new clsPessoaFisica("Pentagono", new DateTime(2000, 12, 13));

            // ContainsKey can be used to test keys before inserting
            // them.
            if (!htPessoaFisica.ContainsKey(7))
            {
                htPessoaFisica.Add(7, new clsPessoaFisica("Professor XY", new DateTime(1988, 09, 15)));
                Console.WriteLine("Valor adicionado na chave = \"7\": {0}", ((clsPessoaFisica)htPessoaFisica[7]).Nome);
            }

            //percorrendo hashtable
            foreach (DictionaryEntry de in htPessoaFisica)
            {
                Console.WriteLine("Chave = {0}, Valor = {1}", de.Key, ((clsPessoaFisica)de.Value).Nome);
            }

            // Para obter valores sozinhos
            ICollection htValues = htPessoaFisica.Values;

            // Perocorrendo valores sozinhos
            Console.WriteLine();
            foreach (clsPessoaFisica objPF in htValues)
            {
                Console.WriteLine("Valor = {0}", objPF.Nome);
            }

            // Para obter chaves sozinhas
            ICollection htKeys = htPessoaFisica.Keys;

            // Perocrrendo chaves sozinhas
            Console.WriteLine();
            foreach (int chave in htKeys)
            {
                Console.WriteLine("Chave = {0}", chave);
            }

            // Removendo item.
            Console.WriteLine("\nRemove(\"5\")");
            htPessoaFisica.Remove(5);

            if (!htPessoaFisica.ContainsKey(5))
            {
                Console.WriteLine("Chave \"5\" não encontrada");
            }

            foreach (DictionaryEntry de in htPessoaFisica)
            {
                Console.WriteLine("Nova lista Chave = {0}, Valor = {1}", de.Key, ((clsPessoaFisica)de.Value).Nome);
            }
        }
        /// <summary>
        /// Exemplo 6- ArrayList
        /// </summary>
        static void TesteArrayList()
        {
            ArrayList alPessoaFisica = new ArrayList();
            alPessoaFisica.Add(new clsPessoaFisica("Fulano", new DateTime(1980, 05, 30)));
            alPessoaFisica.Add(new clsPessoaFisica("Beltrano", new DateTime(1990, 04, 10)));
            alPessoaFisica.Add(new clsPessoaFisica("Ciclano", new DateTime(1995, 02, 25)));
            alPessoaFisica.Add(new clsPessoaFisica("Ellen", new DateTime(1986, 01, 28)));
            alPessoaFisica.Add(new clsPessoaFisica("Chun Li", new DateTime(2014, 02, 03)));
            alPessoaFisica.Add(new clsPessoaFisica("Sindel", new DateTime(2014, 04, 07)));

            //  alPessoaFisica.Add("Teste");

            try
            {
                // Imprime valores do ArrayList.
                Console.WriteLine("Array List Pessoa Fisica");
                Console.WriteLine("    Total Itens:    {0}", alPessoaFisica.Count);
                Console.WriteLine("    Capacidade: {0}", alPessoaFisica.Capacity);
                Console.Write("    \nValores com object:");

                foreach (Object obj in alPessoaFisica)
                    Console.WriteLine("   {0}", ((clsPessoaFisica)obj).Nome);

                Console.Write("    \nValores com clsPessoaFisica:");
                foreach (clsPessoaFisica objPF in alPessoaFisica)
                    Console.WriteLine("   {0}", objPF.Nome);

                Console.WriteLine("Com var...");
                foreach (var item in alPessoaFisica)
                {
                    Console.WriteLine(" {0}", ((clsPessoaFisica)item).Nome);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Existe um item incluso que não é do tipo clsPEssoaFisica! " + ex);
            }
            finally
            {
                Console.WriteLine("Fim da execução");
            }

        }
        /// <summary>
        /// Exemplo 5 - Stack<T>
        /// </summary>
        static void TesteStackT()
        {
            Stack<clsPessoaFisica> stackPF = new Stack<clsPessoaFisica>();

            //Adicionando item na Queue
            stackPF.Push(new clsPessoaFisica("Fulano", new DateTime(1980, 05, 30)));
            stackPF.Push(new clsPessoaFisica("Beltrano", new DateTime(1990, 04, 10)));
            stackPF.Push(new clsPessoaFisica("Ciclano", new DateTime(1995, 02, 25)));
            stackPF.Push(new clsPessoaFisica("Ellen", new DateTime(1986, 01, 28)));
            stackPF.Push(new clsPessoaFisica("Chun Li", new DateTime(2014, 02, 03)));
            stackPF.Push(new clsPessoaFisica("Sindel", new DateTime(2014, 04, 07)));

            //percorrendo Stack
            foreach (clsPessoaFisica objPF in stackPF)
            {
                Console.Write(objPF.Nome + " | ");
            }

            Console.WriteLine("com o var...");
            foreach (var objPF in stackPF)
            {
                Console.Write(objPF.Nome + " | ");
            }

            //acessando o item Top  sem remove-lo
            Console.WriteLine("\nTop é : {0}", stackPF.Peek().Nome);

            //Removendo item da Stack
            Console.WriteLine("\nItem Top removido da Stack : " + stackPF.Pop().Nome);

            Console.WriteLine("\n Stack atual é : ");
            foreach (clsPessoaFisica objPF in stackPF)
            {
                Console.Write(objPF.Nome + " | ");
            }
        }
        /// <summary>
        /// Exemplo 4 - SortedList < Tkey,Tvalue >
        /// </summary>
        static void TesteSortedListT()
        {
            SortedList<int, clsPessoaFisica> slPessoaFisica = new SortedList<int, clsPessoaFisica>();

            slPessoaFisica.Add(1, new clsPessoaFisica("Fulano", new DateTime(1980, 05, 30)));
            slPessoaFisica.Add(2, new clsPessoaFisica("Beltrano", new DateTime(1990, 04, 10)));
            slPessoaFisica.Add(3, new clsPessoaFisica("Ciclano", new DateTime(1995, 02, 25)));
            slPessoaFisica.Add(4, new clsPessoaFisica("Ellen", new DateTime(1986, 01, 28)));
            slPessoaFisica.Add(5, new clsPessoaFisica("Chun Li", new DateTime(2014, 02, 03)));
            slPessoaFisica.Add(6, new clsPessoaFisica("Sindel", new DateTime(2014, 04, 07)));

            //retornando um item
            clsPessoaFisica objPessoaFisica = slPessoaFisica[5];
            Console.WriteLine("A pessoa escolhida é :" + objPessoaFisica.Nome);

            //percorrendo a sortedlist
            foreach (KeyValuePair<int, clsPessoaFisica> sl in slPessoaFisica)
            {
                Console.WriteLine("Key : {0} - Value : {1}", sl.Key, ((clsPessoaFisica)sl.Value).Nome);
            }

            Console.WriteLine("Com o var");
            foreach (var sl in slPessoaFisica)
            {
                Console.WriteLine("Key : {0} - Value : {1}", sl.Key, ((clsPessoaFisica)sl.Value).Nome);
            }


        }
        /// <summary>
        /// Exemplo 3 - Teste Queue<T>
        /// </summary>
        static void TesteQueueT()
        {
            Queue<clsPessoaFisica> queuePF = new Queue<clsPessoaFisica>();

            //Adicionando item na Queue
            queuePF.Enqueue(new clsPessoaFisica("Fulano", new DateTime(1980, 05, 30)));
            queuePF.Enqueue(new clsPessoaFisica("Beltrano", new DateTime(1990, 04, 10)));
            queuePF.Enqueue(new clsPessoaFisica("Ciclano", new DateTime(1995, 02, 25)));
            queuePF.Enqueue(new clsPessoaFisica("Ellen", new DateTime(1986, 01, 28)));
            queuePF.Enqueue(new clsPessoaFisica("Chun Li", new DateTime(2014, 02, 03)));
            queuePF.Enqueue(new clsPessoaFisica("Sindel", new DateTime(2014, 04, 07)));

            //retornando a queue
            foreach (var objPF in queuePF)
            {
                Console.Write(objPF.Nome + " | ");
            }

            //Removendo Item da queue
            Console.WriteLine("\nRemovendo {0} da Queue. \nNova queue é : ", queuePF.Dequeue().Nome);
            //teste como está a queue após a remoção de um item
            foreach (clsPessoaFisica objPF in queuePF)
            {
                Console.Write(objPF.Nome + " | ");
            }
        }

        /// <summary>
        /// Exemplo 2 - Iteração com List<T>
        /// </summary>
        static void TesteList()
        {
            List<clsPessoaFisica> lstPessoaFisica = new List<clsPessoaFisica>();

            lstPessoaFisica.Add(new clsPessoaFisica("Fulano", new DateTime(1980, 05, 30)));

            lstPessoaFisica.Add(new clsPessoaFisica("Beltrano", new DateTime(1990, 04, 10)));

            lstPessoaFisica.Add(new clsPessoaFisica("Ciclano", new DateTime(1995, 02, 25)));

            lstPessoaFisica.Add(new clsPessoaFisica("Ellen", new DateTime(1986, 01, 28)));

            lstPessoaFisica.Add(new clsPessoaFisica("Chun Li", new DateTime(2014, 02, 03)));

            lstPessoaFisica.Add(new clsPessoaFisica("Sindel", new DateTime(2014, 04, 07)));

            //retornar um unico item
            clsPessoaFisica objPessoaFisica = lstPessoaFisica[4];

            Console.WriteLine("A pessoa escolhida é : " + objPessoaFisica.Nome);

            //para iterar a lista
            Console.WriteLine("Percorre lista com tipo var");
            foreach (var objPF in lstPessoaFisica)
            {
                Console.WriteLine(objPF.Nome);
            }

            Console.WriteLine("Percorre lista com objeto");
            foreach (clsPessoaFisica objPF in lstPessoaFisica)
            {
                Console.WriteLine(objPF.Nome);
            }


        }
        /// <summary>
        /// Exemplo 1 - Teste de Dictionary<int,value>
        /// </summary>
        static void TesteDictionary()
        {
            Dictionary<int, clsPessoaFisica> dicPessoaFisica = new Dictionary<int, clsPessoaFisica>();

            dicPessoaFisica.Add(1, new clsPessoaFisica("Fulano", new DateTime(1980, 05, 30)));

            dicPessoaFisica.Add(2, new clsPessoaFisica("Beltrano", new DateTime(1990, 04, 10)));

            dicPessoaFisica.Add(3, new clsPessoaFisica("Ciclano", new DateTime(1995, 02, 25)));

            dicPessoaFisica.Add(4, new clsPessoaFisica("Ellen", new DateTime(1986, 01, 28)));

            dicPessoaFisica.Add(5, new clsPessoaFisica("Chun Li", new DateTime(2014, 02, 03)));

            dicPessoaFisica.Add(6, new clsPessoaFisica("Sindel", new DateTime(2014, 04, 07)));

            //como implementar um unico objeto do dictionary
            clsPessoaFisica objPessoaFisica = dicPessoaFisica[5];

            Console.WriteLine("Pessoa escolhida: " + objPessoaFisica.Nome);

            //Existem duas formas de iterar com o dictionary

            //declarando o comando KeyValuePair<key,value>
            foreach (KeyValuePair<int, clsPessoaFisica> objPF in dicPessoaFisica)
            {
                Console.WriteLine(objPF.Value.Nome);
            }

            //ou declarando apenas a collection

            foreach (var objPF in dicPessoaFisica)
            {
                Console.WriteLine(objPF.Value.Nome);
            }
        }

       
        static void RetornaListaT()
        {
            List<int> lstInt = new List<int>();
            lstInt.Add(1);
            lstInt.Add(2);
            lstInt.Add(3);

            lstInt.Remove(1);
        }
        
    }
}
