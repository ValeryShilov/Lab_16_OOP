using Lab_16_OOP.Serialization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

#pragma warning disable SYSLIB0011
namespace Lab_16_OOP
{
    public partial class ChoiceSerialize : Form
    {
        BinaryDump<HashTable<Goods>> binDump = new BinaryDump<HashTable<Goods>>();
        TextDump<HashTable<Goods>> textDump = new TextDump<HashTable<Goods>>();
        JSONDump<HashTable<Goods>> jsonDump = new JSONDump<HashTable<Goods>>();
        XMLDump<HashTable<Goods>> xmlDump = new XMLDump<HashTable<Goods>>();
        string filePath = "HashTable";
        public HashTable<Goods> hashTable;
        public ChoiceSerialize(HashTable<Goods> hashTable)
        {
            this.hashTable = hashTable;
            InitializeComponent();
        }

        private void buttonBinary_Click(object sender, EventArgs e)
        {
            SaveBinary(hashTable);
            MessageBox.Show("Коллекция сохранена в файл");
        }

        public void SaveBinary(HashTable<Goods> hashTable)
        {
            filePath += ".bin";
            binDump.Save(filePath, hashTable);
            filePath = "HashTable";
        }

        public void SaveTXT(HashTable<Goods> hashTable)
        {
            filePath += ".txt";
            textDump.Save(filePath, hashTable);
            filePath = "HashTable";
        }

        public void SaveXML(HashTable<Goods> hashTable)
        {
            filePath += ".xml";
            xmlDump.Save(filePath, hashTable);
            filePath = "HashTable";
        }

        public void SaveJSON(HashTable<Goods> hashTable)
        {
            filePath += ".json";
            jsonDump.Save(filePath, hashTable);
            filePath = "HashTable";
        }

        private void buttonXml_Click(object sender, EventArgs e)
        {
            SaveXML(hashTable);
            MessageBox.Show("Коллекция сохранена в файл");
        }

        private void buttonTxt_Click(object sender, EventArgs e)
        {
            SaveTXT(hashTable);
            MessageBox.Show("Коллекция сохранена в файл");
        }

        private void buttonJson_Click(object sender, EventArgs e)
        {
            SaveJSON(hashTable);
            MessageBox.Show("Коллекция сохранена в файл");
        }
    }
}
