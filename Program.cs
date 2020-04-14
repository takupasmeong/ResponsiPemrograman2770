using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Abiyu Putra Aronggear\n");
        Console.WriteLine("19.11.2770\n");
        
        var karyawan1 = new Karyawan("190302123", "paijo", 3000000);
        var karyawan2 = new Karyawan("190302124", "Jono", -2000000);

        Console.WriteLine("No  Nik / Nama\t\tGaji Bulanan");
        Console.WriteLine("1.  {0} {1}\t{2}", karyawan1._nik, karyawan1._nama, karyawan1._gaji);
        Console.WriteLine("1.  {0} {1}\t{2}", karyawan2._nik, karyawan2._nama, karyawan2._gaji);

        Console.WriteLine("\nAsik kenaikan gaji 10%");

        Console.WriteLine("No  Nik / Nama\t\tGaji Bulanan");
        Console.WriteLine("1.  {0} {1}\t{2}", karyawan1._nik, karyawan1._nama, karyawan1._bonus);
        Console.WriteLine("1.  {0} {1}\t{2}", karyawan2._nik, karyawan2._nama, karyawan2._bonus);

        Console.ReadKey();
    }   
}
