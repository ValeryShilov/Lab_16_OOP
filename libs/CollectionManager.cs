//using Lab_16_OOP.Serialization;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Lab_16_OOP
//{

//    public class CollectionManager
//    {
//        BinaryDump<HashTable<Goods>> binDump = new BinaryDump<HashTable<Goods>>();
//        TextDump<HashTable<Goods>> textDump = new TextDump<HashTable<Goods>>();
//        JSONDump<HashTable<Goods>> jsonDump = new JSONDump<HashTable<Goods>>();
//        XMLDump<HashTable<Goods>> xmlDump = new XMLDump<HashTable<Goods>>();
//        public void SaveCollection(SaveFileDialog saveFileDialog, HashTable<Goods> hashTable)
//        {
//            string selectedSaveType = "";
//            using (var saveDialog = new ChoiceSerialize())
//            {
//                if (saveDialog.ShowDialog() == DialogResult.Cancel)
//                {
//                    return;
//                }
//                selectedSaveType = saveDialog.SelectedSaveType;
//                using (saveFileDialog)
//                {
//                    // Устанавливаем фильтр для выбора типов файлов
//                    switch (selectedSaveType)
//                    {
//                        case "Text":
//                            saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
//                            break;
//                        case "Bin":
//                            saveFileDialog.Filter = "Binary files (*.bin)|*.bin|All files (*.*)|*.*";
//                            break;
//                        case "JSON":
//                            saveFileDialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
//                            break;
//                        case "XML":
//                            saveFileDialog.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
//                            break;
//                        default:
//                            MessageBox.Show("Неверный тип сохранения", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
//                            return;
//                    }
//                }
//                if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
//                {
//                    return;
//                }
//                string filePath = saveFileDialog.FileName;
//                switch (selectedSaveType)
//                {
//                    case "Text":
//                        textDump.Save(filePath, hashTable);
//                        break;
//                    case "Bin":
//                        binDump.Save(filePath, hashTable);
//                        break;
//                    case "JSON":
//                        jsonDump.Save(filePath, hashTable);
//                        break;
//                    case "XML":
//                        xmlDump.Save(filePath, hashTable);
//                        break;
//                }

//                MessageBox.Show("Коллекция успешно сохранена", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);


//            }
//        }

//        public HashTable<AnimalKey, Animal> LoadCollection(OpenFileDialog openFileDialog)
//        {
//            openFileDialog = new OpenFileDialog();
//            openFileDialog.Filter = "Text files (*.txt)|*.txt|Binary files (*.bin)|*.bin|JSON files (*.json)|*.json|XML files (*.xml)|*.xml|All files (*.*)|*.*";
//            openFileDialog.FilterIndex = 1; // Устанавливаем фильтр по умолчанию
//            var hashTable = new HashTable<AnimalKey, Animal>();
//            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
//            {
//                return null;
//            }

//            string filePath = openFileDialog.FileName;

//            // Определяем тип файла и вызываем соответствующий метод загрузки
//            string fileExtension = Path.GetExtension(filePath).ToLower();
//            var loadedCollection = new HashTable<AnimalKey, Animal>(1000);

//            switch (fileExtension)
//            {

//                case ".txt":
//                    hashTable = textDump.Load(filePath);
//                    break;
//                case ".bin":
//                    hashTable = binDump.Load(filePath);
//                    break;
//                case ".json":
//                    hashTable = jsonDump.Load(filePath);
//                    break;
//                case ".xml":
//                    hashTable = xmlDump.Load(filePath);
//                    break;
//                default:
//                    MessageBox.Show("Неподдерживаемый формат");
//                    break;
//            }

//            return hashTable;
//        }

//    }

//}
