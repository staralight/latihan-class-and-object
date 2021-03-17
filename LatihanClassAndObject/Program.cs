using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanClassAndObject
{
    class Program
    {
        static void Main(string[] args)
        {
            // membuat objek dari class Mahasiswa
            Mahasiswa mhs1 = new Mahasiswa();
            Mahasiswa mhs2 = new Mahasiswa();

            // mengatur nilai properties objek mhs1 dan mhs2
            mhs1.Nim = "1991";
            mhs1.Nama = "Pete";
            mhs1.Ipk = 39.9f;

            mhs2.Nim = "1993"; ;
            mhs2.Nama = "Kao";
            mhs2.Ipk = 4.00f;

            // memanggil method registrasi dan isi krs
            mhs1.Registrasi();
            mhs1.IsiKrs();

            mhs2.Registrasi();
            mhs2.IsiKrs();

            Console.ReadKey();
        }
    }
}
