//using Lab_12_OOP;
//using Lab_10_lib;
using Lab_16_OOP.Serialization;
using System.Data;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

#pragma warning disable SYSLIB0011
namespace Lab_16_OOP
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
            hashTable = new(1000);
            DisplayHashTable();
        }

        DataTable dataTable;
        HashTable<Goods> hashTable;

        private void buttonGenerateHashTable_Click(object sender, EventArgs e)
        {
            Random rnd = new();
            for (int i = 0; i < rnd.Next(150, 300); i++)
            {
                Goods goods = new();
                goods.RandomInit();
                hashTable.Add(goods);
            }

            for (int i = 0; i < rnd.Next(150, 300); i++)
            {
                Goods goods = new Product();
                goods.RandomInit();
                hashTable.Add(goods);
            }

            for (int i = 0; i < rnd.Next(150, 300); i++)
            {
                Goods goods = new MilkProduct();
                goods.RandomInit();
                hashTable.Add(goods);
            }

            for (int i = 0; i < rnd.Next(150, 300); i++)
            {
                Goods goods = new Toy();
                goods.RandomInit();
                hashTable.Add(goods);
            }

            MessageBox.Show("Хеш-таблица сгенерирована");
            DisplayHashTable();
        }

        private void buttonDisplayHashTable_Click(object sender, EventArgs e)
        {
            DisplayHashTable();
        }

        private void DisplayHashTable()
        {
            dataTable = new();
            dataTable.Columns.Add("Название");
            dataTable.Columns.Add("Цена");
            dataTable.Columns.Add("Вес");
            dataTable.Columns.Add("Тип");
            foreach (var item in hashTable)
            {
                dataTable.Rows.Add(item.Name, item.Price, item.Weight, item.GetType().ToString().Substring(11));
            }

            dataGridView1.DataSource = dataTable;
        }


        private void buttonCleanHashTable_Click(object sender, EventArgs e)
        {
            hashTable.Clear();
            hashTable = new(1000);
            MessageBox.Show("Хеш-таблица очищена");
            DisplayHashTable();
        }

        private void buttonAddGoods_Click(object sender, EventArgs e)
        {
            FormAddItem addItem = new("Goods");
            addItem.ItemAdded += AddItemForm_ItemAdded;
            addItem.Show();
        }

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            FormAddItem addItem = new("Product");
            addItem.ItemAdded += AddItemForm_ItemAdded;
            addItem.Show();
        }

        private void buttonAddToy_Click(object sender, EventArgs e)
        {
            FormAddItem addItem = new("Toy");
            addItem.ItemAdded += AddItemForm_ItemAdded;
            addItem.Show();
        }

        private void buttonAddMilk_Click(object sender, EventArgs e)
        {
            FormAddItem addItem = new FormAddItem("MilkProduct");
            addItem.ItemAdded += AddItemForm_ItemAdded;
            addItem.ShowDialog();
        }

        private void AddItemForm_ItemAdded(object sender, Goods item)
        {
            // Добавление элемента в hashTable
            hashTable.Add(item);

        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            Goods findGoods = new Goods(textBoxFindName.Text, double.Parse(textBoxFindPrice.Text), double.Parse(textBoxFindWeight.Text));
            var findResult = hashTable.FindPoint(findGoods);
            MessageBox.Show("Результаты поиска: " + findResult);
            textBoxFindName.Clear();
            textBoxFindPrice.Clear();
            textBoxFindWeight.Clear();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            ChoiceSerialize choiceSerialize = new(hashTable);
            choiceSerialize.Show();
        }

        private void buttonDownload_Click(object sender, EventArgs e)
        {
            BinaryDump<HashTable<Goods>> binDump = new BinaryDump<HashTable<Goods>>();
            TextDump<HashTable<Goods>> textDump = new TextDump<HashTable<Goods>>();
            JSONDump<HashTable<Goods>> jsonDump = new JSONDump<HashTable<Goods>>();
            XMLDump<HashTable<Goods>> xmlDump = new XMLDump<HashTable<Goods>>();

            OpenFileDialog openFile = new();
            string selectedFileName = "";
            openFile.InitialDirectory = @"D:\Labs OOP\Lab_16_OOP\bin\Debug\net7.0-windows";
            openFile.Filter = "Text files (*.txt)|*.txt|Binary files (*.bin)|*.bin|XML files (*.xml)|*.xml|JSON files (*.json)|*.json|All files (*.*)|*.*";
            if (openFile.ShowDialog() == DialogResult.Cancel)
            {
                MessageBox.Show("Вы не выбрали файл");
            }
            else
            {
                string filePath = openFile.FileName;

                // Определяем тип файла и вызываем соответствующий метод загрузки
                string fileExtension = Path.GetExtension(filePath).ToLower();
                switch (fileExtension)
                {

                    case ".txt":
                        hashTable = textDump.Load(filePath);
                        break;
                    case ".bin":
                        hashTable = binDump.Load(filePath);
                        break;
                    case ".json":
                        hashTable = jsonDump.Load(filePath);
                        break;
                    case ".xml":
                        hashTable = xmlDump.Load(filePath);
                        break;
                    default:
                        MessageBox.Show("Неподдерживаемый формат");
                        break;
                }
            }
            DisplayHashTable();
        }

        private void buttonSaveAll_Click(object sender, EventArgs e)
        {
            SyncAsyncForm syncAsyncForm = new(hashTable);
            syncAsyncForm.Show();
        }
    }
}