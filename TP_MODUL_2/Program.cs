Console.WriteLine("Program A"); // Program pertama
bool lanjut = false;

// statement untuk mengulang program pertama 
do
{
    Console.Write("Masukan 1 Karakter: "); // meminta untuk memasukan karakter
    char karakter = char.ToUpper(Console.ReadKey().KeyChar); // membaca inputan untuk variabel karakter serta Mengubah ke huruf besar bila inputan berupa huruf kecil

    // Statement untuk mengecek apakah variabel inputan berupa huruf vokal atau konsonan
    if (karakter == 'A' || karakter == 'I' || karakter == 'U' || karakter == 'E' || karakter == 'O')
    {
        Console.WriteLine("\nHuruf {0} merupakan huruf Vokal", karakter);
    }
    else
    {
        Console.WriteLine("\nHuruf {0} merupakan huruf Konsonan", karakter);
    }

    Console.Write("\nLanjut ke program kedua? (true/false) ");
    lanjut = Convert.ToBoolean(Console.ReadLine());

} while (!lanjut);

Console.Write("\nProgram B"); // Program kedua
int[] genap = { 2, 4, 6, 8, 10 }; // Array untuk angka genap 2-10

// Statement untuk print semua element yang berada di dalam array genap
for (int i = 0; i < 5; i++)
{
    Console.Write("\nAngka genap {0} : {1}", i, genap[i]);
}
