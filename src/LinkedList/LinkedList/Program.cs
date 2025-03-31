using LinkedList.Perpustakaan;
using LinkedList.ManajemenKaryawan;
using LinkedList.Inventori;

namespace LinkedList;

class Program
{
    static void Main(string[] args)
    {
        // Soal Perpustakaan
        KoleksiPerpustakaan koleksi = new KoleksiPerpustakaan();
            
        koleksi.TambahBuku(new Buku("The Hobbit", "J.R.R. Tolkien", 1937));
        koleksi.TambahBuku(new Buku("1984", "George Orwell", 1949));
        koleksi.TambahBuku(new Buku("The Catcher in the Rye", "J.D. Salinger", 1951));
        
        Console.WriteLine("Koleksi buku:");
        koleksi.TampilkanKoleksi();

        Console.WriteLine("\nMenghapus buku '1984'...");
        koleksi.HapusBuku("1984");
        koleksi.TampilkanKoleksi();
        

        // Soal ManajemenKaryawan
        DaftarKaryawan daftar = new DaftarKaryawan();

        daftar.TambahKaryawan(new Karyawan("001", "John Doe", "Manager"));
        daftar.TambahKaryawan(new Karyawan("002", "Jane Doe", "HR"));
        daftar.TambahKaryawan(new Karyawan("003", "Bob Smith", "IT"));

        Console.WriteLine("Daftar Karyawan:");
        daftar.TampilkanDaftar();

        Console.WriteLine("\nMenghapus karyawan '002'...");
        daftar.HapusKaryawan("002");
        daftar.TampilkanDaftar();
        

        // Soal Inventori
        ManajemenInventori inventori = new ManajemenInventori();
            
        inventori.TambahItem(new Item("Apple", 50));
        inventori.TambahItem(new Item("Orange", 30));
        inventori.TambahItem(new Item("Banana", 20));
        
        Console.WriteLine("Inventori:");
        inventori.TampilkanInventori();

        Console.WriteLine("\nMenghapus item 'Orange'...");
        inventori.HapusItem("Orange");
        inventori.TampilkanInventori();

    }
}
