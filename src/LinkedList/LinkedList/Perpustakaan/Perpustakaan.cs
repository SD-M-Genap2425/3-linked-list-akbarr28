using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList.Perpustakaan
{
    public class Buku
    {
        public string Judul { get; }
        public string Penulis { get; }
        public int Tahun { get; }

        public Buku(string judul, string penulis, int tahun)
        {
            Judul = judul;
            Penulis = penulis;
            Tahun = tahun;
        }
    }

    public class BukuNode
    {
        public Buku Data { get; }
        public BukuNode Next { get; set; }

        public BukuNode(Buku data)
        {
            Data = data;
            Next = null;
        }
    }

    public class KoleksiPerpustakaan
    {
        private BukuNode head;

        public void TambahBuku(Buku buku)
        {
            BukuNode newNode = new BukuNode(buku);
            if (head == null)
                head = newNode;
            else
            {
                BukuNode current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
        }

        public bool HapusBuku(string judul)
        {
            if (head == null) return false;
            if (head.Data.Judul == judul)
            {
                head = head.Next;
                return true;
            }

            BukuNode current = head;
            while (current.Next != null && current.Next.Data.Judul != judul)
            {
                current = current.Next;
            }

            if (current.Next == null) return false;
            current.Next = current.Next.Next;
            return true;
        }

        public Buku[] CariBuku(string kataKunci)
        {
            List<Buku> hasil = new List<Buku>();
            BukuNode current = head;
            while (current != null)
            {
                if (current.Data.Judul.Contains(kataKunci, StringComparison.OrdinalIgnoreCase))
                {
                    hasil.Add(current.Data);
                }
                current = current.Next;
            }
            return hasil.ToArray();
        }

        public string TampilkanKoleksi()
        {
            if (head == null) return string.Empty;

            StringBuilder sb = new StringBuilder();
            BukuNode current = head;
            while (current != null)
            {
                sb.AppendLine($"\"{current.Data.Judul}\"; {current.Data.Penulis}; {current.Data.Tahun}");
                current = current.Next;
            }
            return sb.ToString().Trim();
        }
    }
}