using System;

namespace exammodul1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1) visualizza richiesta per numero prodotti
            //2) raccolta numero inserito da utente
            //3) creo lista prodotti vuota
            //4) riempire lista: ciclo da 0 a numero prodotti -1, 
            //5) creo lista prodotti (oggetto prodotto )
            //6) stamparli 



            //1) Chiedo il numero  da inserire
            Console.WriteLine("Inserisci numero prodotti (da 1 a 10) ");
            int totalProduct = LeggiNumeroInteroDaConsole(1, 10);

            //2) raccolta numero inserito da utente
            static int LeggiNumeroInteroDaConsole(int minValue, int maxValue)
            {
                //Leggo il valore stringa da console
                string valoreString;
                int valoreIntero = 0;

                //Predisposizione al fallimento: 
                //se non è digitato un numero o non è compreso tra 1 e 10,sarà visualizzato messaggio di errore
                bool isInteger = false;
                bool isInRange = false;

                do
                {
                    try
                    {
                        //Eseguo la lettura del valore da console
                        //Console.Write("- selezione: ");
                        valoreString = Console.ReadLine();

                        //Validazione e parsing del valore
                        valoreIntero = int.Parse(valoreString);
                        isInteger = true;

                        //Verifico se è nel range
                        if (valoreIntero >= minValue && valoreIntero <= maxValue)
                        {
                            //imposto il flag IsInRange
                            isInRange = true;
                        }
                        else
                        {
                            //Messaggio di errore
                            Console.WriteLine("Attenzione! Il valore immesso non è nel range indicato");

                            //Ripristino condizioni di predisposizione fallimento iniziali
                            valoreIntero = 0;
                            isInteger = false;
                            isInRange = false;
                        }
                    }
                    catch (Exception exc)
                    {
                        //Messaggio di errore
                        Console.WriteLine("Attenzione! Il valore immesso non è un numero!");

                        //Ripristino condizioni di predisposizione fallimento iniziali
                        valoreIntero = 0;
                        isInteger = false;
                        isInRange = false;
                    }
                }
                while (isInteger == false || isInRange == false);

                //Ritorno il valore intero
                return valoreIntero;
            }

            // 3) Dimensionamento della lista dei prodotti "products"

            // 4) Itero per il numero di prodotti richiesto
            List<Prodotto> products = new List<Prodotto>
                    for (int index = 0; index < totalProduct; index++)

            {
                //Richiamo una funzione a cui passo la lista products
                //e l'indice corrente e questa mi aggiunge il prodotto
                AggiungiProdottoaLista(products);
            }

            // 5) Richiedo il Name e Code del prodotto

            static void AggiungiProdottoaLista(List<Prodotto> products)
            {
                
                Console.Write("Name: ");
                var nome = Console.ReadLine();
                Console.Write("Code: ");
                var cognome = Console.ReadLine();

                // Creo oggetto Prodotto da inserire in lista
                public class Prodotto
                {
                 public string Code;
                 public string Name;
                };


               // Aggiungo persona a rubrica
                 products.Add(Prodotto)
    

                 
           

            //6) Itero la lista e stampo a video (con for) tutte le persone
            Stampalista(products);


        }

    }
}
