using System;

namespace ClassAndObject.TokoLaptop
{
    public class Laptop
    {
        public string Merk;
        public string Prosesor;
        public int Ram;
        public int Penyimpanan;

        public Laptop(string merk, string prosesor, int ram, int penyimpanan)
        {
            this.Merk = merk;
            this.Prosesor = prosesor;
            this.Ram = ram;
            this.Penyimpanan = penyimpanan;
        }
        
        public void TampilkanSpesifikasi()
        {
            Console.WriteLine($"Merk: {Merk}, Prosesor: {Prosesor}, RAM: {Ram} GB, Penyimpanan: {Penyimpanan} GB");
        }
    }

}