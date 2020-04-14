using System;

public class Karyawan
{
    
    public string _nik {get; set;}
    public string _nama {get; set;}
    public int _gaji {get; set;}
    public int _bonus {get; set;}

    public Karyawan(string nik, string nama, int gaji)
    {
        _nik = nik;
        _nama = nama;

        if (gaji < 0)
        {
            _gaji = 0;
            _bonus = Convert.ToInt32(_gaji * 1.1);
        }else
        {
            _gaji = gaji;
            _bonus = Convert.ToInt32(_gaji * 1.1);
        }

    }
}