using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList.Inventori
{
    public class Item
    {
        public string Nama { get; }
        public int Kuantitas { get; }

        public Item(string nama, int kuantitas)
        {
            Nama = nama;
            Kuantitas = kuantitas;
        }
    }

    public class ManajemenInventori
    {
        private LinkedList<Item> inventori = new LinkedList<Item>();

        public void TambahItem(Item item)
        {
            inventori.AddLast(item);
        }

        public bool HapusItem(string nama)
        {
            var current = inventori.First;
            while (current != null)
            {
                if (current.Value.Nama.Equals(nama, StringComparison.OrdinalIgnoreCase))
                {
                    inventori.Remove(current);
                    return true;
                }
                current = current.Next;
            }
            return false;
        }

        public string TampilkanInventori()
        {
            if (inventori.Count == 0)
                return string.Empty;

            StringBuilder sb = new StringBuilder();
            foreach (var item in inventori)
            {
                sb.AppendLine($"{item.Nama}; {item.Kuantitas}");
            }
            return sb.ToString().TrimEnd();
        }
    }
}
