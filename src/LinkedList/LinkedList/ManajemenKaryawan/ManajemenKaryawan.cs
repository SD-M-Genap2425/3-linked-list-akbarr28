using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList.ManajemenKaryawan
{
    public class Karyawan
    {
        public string NomorKaryawan { get; }
        public string Nama { get; }
        public string Posisi { get; }

        public Karyawan(string nomorKaryawan, string nama, string posisi)
        {
            NomorKaryawan = nomorKaryawan;
            Nama = nama;
            Posisi = posisi;
        }
    }

    public class KaryawanNode
    {
        public Karyawan Karyawan { get; }
        public KaryawanNode Next { get; set; }
        public KaryawanNode Prev { get; set; }

        public KaryawanNode(Karyawan karyawan)
        {
            Karyawan = karyawan;
            Next = null;
            Prev = null;
        }
    }

    public class DaftarKaryawan
    {
        private KaryawanNode head;
        private KaryawanNode tail;

        public void TambahKaryawan(Karyawan karyawan)
        {
            KaryawanNode newNode = new KaryawanNode(karyawan);
            if (head == null)
            {
                head = tail = newNode;
            }
            else
            {
                tail.Next = newNode;
                newNode.Prev = tail;
                tail = newNode;
            }
        }

        public bool HapusKaryawan(string nomorKaryawan)
        {
            KaryawanNode current = head;
            while (current != null)
            {
                if (current.Karyawan.NomorKaryawan == nomorKaryawan)
                {
                    if (current.Prev != null)
                        current.Prev.Next = current.Next;
                    else
                        head = current.Next;

                    if (current.Next != null)
                        current.Next.Prev = current.Prev;
                    else
                        tail = current.Prev;

                    return true;
                }
                current = current.Next;
            }
            return false;
        }

        public Karyawan[] CariKaryawan(string kataKunci)
        {
            List<Karyawan> hasil = new List<Karyawan>();
            KaryawanNode current = head;
            while (current != null)
            {
                if (current.Karyawan.Nama.Contains(kataKunci, StringComparison.OrdinalIgnoreCase))
                {
                    hasil.Add(current.Karyawan);
                }
                current = current.Next;
            }
            return hasil.ToArray();
        }

        public string TampilkanDaftar()
        {
            StringBuilder hasil = new StringBuilder();
            KaryawanNode current = tail;
            while (current != null)
            {
                hasil.AppendLine($"{current.Karyawan.NomorKaryawan}; {current.Karyawan.Nama}; {current.Karyawan.Posisi}");
                current = current.Prev;
            }
            return hasil.ToString().TrimEnd();
        }
    }
}