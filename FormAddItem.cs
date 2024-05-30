
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab_16_OOP
{
    public partial class FormAddItem : Form
    {
        public delegate void ItemAddedEventHandler(object sender, Goods item);
        public event ItemAddedEventHandler ItemAdded;

        public string TypeG { get; set; }

        public FormAddItem(string type)
        {
            TypeG = type;
            InitializeComponent();
            labelType.Text = "Добавление " + type;

            switch (type)
            {
                case "Goods":
                    textBoxExpDateOrAge.Visible = false;
                    textBoxFat.Visible = false;
                    labelExpDateOr.Visible = false;
                    labelFat.Visible = false;
                    break;
                case "Product":
                    labelFat.Visible = false;
                    textBoxFat.Visible = false;
                    break;
                case "Toy":
                    labelExpDateOr.Text = "Рек. возраст";
                    labelFat.Visible = false;
                    textBoxFat.Visible = false;
                    break;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Goods newItem = null;
            switch (TypeG)
            {
                case "Goods":
                    newItem = new Goods(textBoxName.Text, double.Parse(textBoxPrice.Text), double.Parse(textBoxWeight.Text));
                    break;
                case "Product":
                    newItem = new Product(textBoxName.Text, double.Parse(textBoxPrice.Text), double.Parse(textBoxWeight.Text), int.Parse(textBoxExpDateOrAge.Text));
                    break;
                case "Toy":
                    newItem = new Toy(textBoxName.Text, double.Parse(textBoxPrice.Text), double.Parse(textBoxWeight.Text), int.Parse(textBoxExpDateOrAge.Text));
                    break;
                case "MilkProduct":
                    newItem = new MilkProduct(textBoxName.Text, double.Parse(textBoxPrice.Text), double.Parse(textBoxWeight.Text), int.Parse(textBoxExpDateOrAge.Text), double.Parse(textBoxFat.Text));
                    break;
            }

            if (newItem != null)
            {
                // Вызов события при добавлении нового элемента
                ItemAdded?.Invoke(this, newItem);
                MessageBox.Show("Элемент успешно добавлен");
                this.Close();
            }
        }



        #region restinput
        private void textBoxPrice_TextChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(textBoxPrice.Text, out double value))
            {
                MessageBox.Show("Please enter a valid number.");
                textBoxPrice.Text = string.Empty;
            }
        }
        private void textBoxWeight_TextChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(textBoxWeight.Text, out double value))
            {
                MessageBox.Show("Вводите только вещественные числа");
                textBoxWeight.Text = string.Empty;
            }
        }
        private void textBoxFat_TextChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(textBoxFat.Text, out double value))
            {
                MessageBox.Show("Вводите только вещественные числа");
                textBoxFat.Text = string.Empty;
            }
        }
        private void textBoxExpDateOrAge_TextChanged(object sender, EventArgs e)
        {
            if (TypeG == "Toy")
            {
                if (!int.TryParse(textBoxExpDateOrAge.Text, out int value))
                {
                    MessageBox.Show("Вводите только целые числа");
                    textBoxExpDateOrAge.Text = string.Empty;
                }
            }
        }
        #endregion
    }
}
