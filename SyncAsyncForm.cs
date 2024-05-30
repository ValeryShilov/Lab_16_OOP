using Lab_16_OOP.Serialization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_16_OOP
{
    public partial class SyncAsyncForm : Form
    {
        BinaryDump<HashTable<Goods>> binDump = new BinaryDump<HashTable<Goods>>();
        TextDump<HashTable<Goods>> textDump = new TextDump<HashTable<Goods>>();
        JSONDump<HashTable<Goods>> jsonDump = new JSONDump<HashTable<Goods>>();
        XMLDump<HashTable<Goods>> xmlDump = new XMLDump<HashTable<Goods>>();
        public SyncAsyncForm(HashTable<Goods> hashTable)
        {
            InitializeComponent();
            MeasureSync(hashTable);
            MeasureAsync(hashTable);
        }

        public void MeasureSync(HashTable<Goods> hashTable)
        {
            Stopwatch stopwatch1 = Stopwatch.StartNew();
            textDump.Save("123.txt", hashTable);
            stopwatch1.Stop();
            syncTime1.Text = $"{stopwatch1.Elapsed.TotalMilliseconds} мс";

            Stopwatch stopwatch2 = Stopwatch.StartNew();
            binDump.Save("123.bin", hashTable);
            stopwatch2.Stop();
            syncTime2.Text = $"{stopwatch2.Elapsed.TotalMilliseconds} мс";

            Stopwatch stopwatch3 = Stopwatch.StartNew();
            jsonDump.Save("123.json", hashTable);
            stopwatch3.Stop();
            syncTime3.Text = $"{stopwatch3.Elapsed.TotalMilliseconds} мс";

            Stopwatch stopwatch4 = Stopwatch.StartNew();
            xmlDump.Save("123.xml", hashTable);
            stopwatch4.Stop();
            syncTime4.Text = $"{stopwatch4.Elapsed.TotalMilliseconds} мс";
        }

        public void MeasureAsync(HashTable<Goods> hashTable)
        {
            Stopwatch stopwatch1 = Stopwatch.StartNew();
            textDump.SaveAsync("123A.txt", hashTable);
            stopwatch1.Stop();
            asyncTime1.Text = $"{stopwatch1.Elapsed.TotalMilliseconds} мс";

            Stopwatch stopwatch2 = Stopwatch.StartNew();
            binDump.SaveAsync("123A.bin", hashTable);
            stopwatch2.Stop();
            asyncTime2.Text = $"{stopwatch2.Elapsed.TotalMilliseconds} мс";

            Stopwatch stopwatch3 = Stopwatch.StartNew();
            jsonDump.SaveAsync("123A.json", hashTable);
            stopwatch3.Stop();
            asyncTime3.Text = $"{stopwatch3.Elapsed.TotalMilliseconds} мс";

            Stopwatch stopwatch4 = Stopwatch.StartNew();
            xmlDump.SaveAsync("123A.xml", hashTable);
            stopwatch4.Stop();
            asyncTime4.Text = $"{stopwatch4.Elapsed.TotalMilliseconds} мс";
        }

    }
}
