using System;

class Mahasiswa
{
    public string NIM;
    public string Nama;
    public int Nilai;
}

class Program
{
    static void Main(string[] args)
    {
        Mahasiswa[] arrayMhs = new Mahasiswa[2];
        // Input data mahasiswa
        for (int i = 0; i < arrayMhs.Length; i++)
        {
            arrayMhs[i] = new Mahasiswa();

            Console.WriteLine("Data Mahasiswa ke-" + (i + 1));
            Console.Write("NIM\t: ");
            arrayMhs[i].NIM = Console.ReadLine();
            Console.Write("Nama\t: ");
            arrayMhs[i].Nama = Console.ReadLine();
            Console.Write("Nilai\t: ");
            arrayMhs[i].Nilai = int.Parse(Console.ReadLine());
            Console.WriteLine();
        }

        // Cari nilai tertinggi
        int maxNilai = 0;
        string maxNIM = "";
        string maxNama = "";

        for (int i = 0; i < arrayMhs.Length; i++)
        {
            if (arrayMhs[i].Nilai > maxNilai)
            {
                maxNIM = arrayMhs[i].NIM;
                maxNama = arrayMhs[i].Nama;
                maxNilai = arrayMhs[i].Nilai;
            }
        }

        // Output nilai tertinggi
        Console.WriteLine("Mahasiswa dengan nilai tertinggi:");
        Console.WriteLine("NIM\t: " + maxNIM);
        Console.WriteLine("Nama\t: " + maxNama);
        Console.WriteLine("Nilai\t: " + maxNilai);

        Console.ReadLine();
    }
}
