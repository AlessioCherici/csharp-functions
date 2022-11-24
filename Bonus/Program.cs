/* In questo esercizio vi chiedo di definire qualche funzione di utilità che poi potete usare per poter fare operazioni complesse nei vostri programmi principali.
Scrivete nel vostro programma principale Program.cs le seguenti funzioni di base:
void StampaArrayInteri(int[] array): che preso un array di numeri interi, stampa a video il contenuto dell’array in questa forma “[elemento 1, elemento 2, elemento 3, ...]”. 
Potete prendere quella fatta in classe questa mattina
int Quadrato(int numero): che vi restituisca il quadrato del numero passato come parametro.
int[] ElevaArrayAlQuadrato(int[] array): che preso un array di numeri interi, restituisca un nuovo array con tutti gli elementi elevati quadrato.
Attenzione: è importante restituire un nuovo array, e non modificare l’array come parametro della funzione! Vi ricordate perchè? Pensateci (vedi slide)
int sommaElementiArray(int[] array): che preso un array di numeri interi, restituisca la somma totale di tutti gli elementi dell’array. */


// ------------------------  Codice  ------------------------ 

/* Una volta completate queste funzioni di utilità di base, e dato il seguente array di numeri [2, 6, 7, 5, 3, 9]
già dichiarato nel vostro codice, si vogliono utilizzare le funzioni per:*/


int[] ArrayNumeri;

Console.WriteLine("Quanti numeri vuoi inserire nell' array?");

int LunghezzaArray = int.Parse(Console.ReadLine());
ArrayNumeri = new int[LunghezzaArray];

Console.WriteLine("Quali numeri vuoi inserire nell' array?");

for (int i = 0;i < LunghezzaArray; i++)
    {
    Console.WriteLine($"Inserisci il {i+1}° numero");
    int InputUtente = (int) float.Parse(Console.ReadLine());
    ArrayNumeri[i] = InputUtente;   
    }


// Stampare l’array di numeri fornito a video

StampaArrayInteri(ArrayNumeri);
Console.WriteLine(" Array standard");
// Stampare l’array di numeri fornito a video, dove ogni numero è stato prima elevato al quadrato 

StampaArrayInteri(ElevaArrayAlQuadrato(ArrayNumeri));
Console.WriteLine(" Array al quadrato");

/* Verificare che 
l’array originale non sia stato modificato quindi ristampare nuovamente l’array originale 
e verificare che sia rimasto [2, 6, 7, 5, 3, 9])*/

StampaArrayInteri(ArrayNumeri);
Console.Write(" Check array invariato");
Console.WriteLine();

// Stampare la somma di tutti i numeri

SommaElementiArray(ArrayNumeri);
Console.WriteLine(" Somma di tutti i numeri");

// Stampare la somma di tutti i numeri elevati al quadrati 

SommaElementiArray(ElevaArrayAlQuadrato(ArrayNumeri));
Console.WriteLine(" Somma di tutti i numeri elevati al quadrato");






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
            Console.Write(+array[i] + ",");
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
    Console.Write(Somma);
    return Somma;


    }
