using System;
using ClassAndObject.OperasiMatematika;
using ClassAndObject.TokoSepeda;
using ClassAndObject.TokoLaptop;
using ClassAndObject.Kendaraan;
using ClassAndObject.Perpustakaan;


namespace ClassAndObject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Buku
            Buku buku = new Buku("ini judul","ini penulis",2021);//judul,penulis,tahun terbit

            buku.TampilkanInfo();
           

            // Kendaraan
            Mobil mobil=new Mobil("ini merek","ini model",2121); //merek,model,tahun Produksi
           mobil.TampilkanSpesifikasi();

            // Laptop
           Laptop laptop = new Laptop("ini Merk","ini prosesor",13,15); // merek,prosesor,ram,penyimpanan

           laptop.TampilkanSpesifikasi();
            // Sepeda
            Sepeda sepeda=new Sepeda("ini merk","ini tipe",10);//merek,tipe,berat

            sepeda.TampilkanInformasi();

            // Kalkulator
            Kalkulator calculator = new Kalkulator();
            Console.WriteLine("Masukkan angka pertama:");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Masukkan angka kedua:");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Pilih operasi (Tambah, Kurang, Kali, Bagi):");
            string operasi = Console.ReadLine();

            switch (operasi.ToLower())
            {
                case "tambah":
                    calculator.Tambah(a, b);
                    break;
                case "kurang":
                    calculator.Kurang(a, b);
                    break;
                case "kali":
                    calculator.Kali(a, b);
                    break;
                case "bagi":
                    calculator.Bagi(a, b);
                    break;
                default:
                    Console.WriteLine("Operasi tidak valid. Silakan pilih Tambah, Kurang, Kali, atau Bagi.");
                    break;
            }


        }
    }
}
