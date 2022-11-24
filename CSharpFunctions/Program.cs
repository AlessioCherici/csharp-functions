/* In questo esercizio vi chiedo di definire qualche funzione di utilità che poi potete usare per poter fare operazioni complesse nei vostri programmi principali.
Scrivete nel vostro programma principale Program.cs le seguenti funzioni di base:
void StampaArrayInteri(int[] array): che preso un array di numeri interi, stampa a video il contenuto dell’array in questa forma “[elemento 1, elemento 2, elemento 3, ...]”. 
Potete prendere quella fatta in classe questa mattina
int Quadrato(int numero): che vi restituisca il quadrato del numero passato come parametro.
int[] ElevaArrayAlQuadrato(int[] array): che preso un array di numeri interi, restituisca un nuovo array con tutti gli elementi elevati quadrato.
Attenzione: è importante restituire un nuovo array, e non modificare l’array come parametro della funzione! Vi ricordate perchè? Pensateci (vedi slide)
int sommaElementiArray(int[] array): che preso un array di numeri interi, restituisca la somma totale di tutti gli elementi dell’array.*/


//------------------------  Codice  ------------------------ 


//Inserisco l' array di numeri interi come richiesto

int[] ArrayNumeriProva = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 78, 75, 55, };


StampaArrayInteri(ElevaArrayAlQuadrato(ArrayNumeriProva));



Console.WriteLine(SommaElementiArray(ArrayNumeriProva));



















// ------------------------  Funzioni  ------------------------ 


void StampaArrayInteri(int[] array)
    {
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
        {
        if (i == array.Length - 1)
            {
            Console.Write(array[i]);
            }
        else
            {
            Console.Write( + array[i] + ",");
            }
        }
    Console.Write("]");
    }


int Quadrato(int numero)
    {
    return numero * numero;
    }

int[] ElevaArrayAlQuadrato(int[] array)
    {
    int[] NuovoArray = (int[])array.Clone();
    for (int i = 0; i < NuovoArray.Length; i++)
        {
        NuovoArray[i] = Quadrato(NuovoArray[i]);
        }
    return NuovoArray;
    }
int SommaElementiArray(int[] array)
    {
    int Somma = 0;
    for (int i = 0; i < array.Length; i++)
        {
        Somma += array[i];
        }
    return Somma;


    }
