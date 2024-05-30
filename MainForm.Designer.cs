namespace Lab_16_OOP
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            buttonDisplayHashTable = new Button();
            buttonAddGoods = new Button();
            buttonAddProduct = new Button();
            buttonAddMilk = new Button();
            buttonAddToy = new Button();
            buttonFind = new Button();
            textBoxFindWeight = new TextBox();
            textBoxFindName = new TextBox();
            textBoxFindPrice = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            buttonSave = new Button();
            buttonDownload = new Button();
            buttonGenerateHashTable = new Button();
            buttonCleanHashTable = new Button();
            buttonSaveAll = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(316, 38);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(604, 254);
            dataGridView1.TabIndex = 0;
            // 
            // buttonDisplayHashTable
            // 
            buttonDisplayHashTable.Location = new Point(488, 306);
            buttonDisplayHashTable.Name = "buttonDisplayHashTable";
            buttonDisplayHashTable.Size = new Size(201, 29);
            buttonDisplayHashTable.TabIndex = 1;
            buttonDisplayHashTable.Text = "Вывести хеш-таблицу";
            buttonDisplayHashTable.UseVisualStyleBackColor = true;
            buttonDisplayHashTable.Click += buttonDisplayHashTable_Click;
            // 
            // buttonAddGoods
            // 
            buttonAddGoods.Location = new Point(6, 35);
            buttonAddGoods.Name = "buttonAddGoods";
            buttonAddGoods.Size = new Size(94, 29);
            buttonAddGoods.TabIndex = 3;
            buttonAddGoods.Text = "Goods";
            buttonAddGoods.UseVisualStyleBackColor = true;
            buttonAddGoods.Click += buttonAddGoods_Click;
            // 
            // buttonAddProduct
            // 
            buttonAddProduct.Location = new Point(106, 35);
            buttonAddProduct.Name = "buttonAddProduct";
            buttonAddProduct.Size = new Size(94, 29);
            buttonAddProduct.TabIndex = 4;
            buttonAddProduct.Text = "Product";
            buttonAddProduct.UseVisualStyleBackColor = true;
            buttonAddProduct.Click += buttonAddProduct_Click;
            // 
            // buttonAddMilk
            // 
            buttonAddMilk.Location = new Point(106, 70);
            buttonAddMilk.Name = "buttonAddMilk";
            buttonAddMilk.Size = new Size(118, 29);
            buttonAddMilk.TabIndex = 5;
            buttonAddMilk.Text = "MilkProduct";
            buttonAddMilk.UseVisualStyleBackColor = true;
            buttonAddMilk.Click += buttonAddMilk_Click;
            // 
            // buttonAddToy
            // 
            buttonAddToy.Location = new Point(6, 70);
            buttonAddToy.Name = "buttonAddToy";
            buttonAddToy.Size = new Size(94, 29);
            buttonAddToy.TabIndex = 6;
            buttonAddToy.Text = "Toy";
            buttonAddToy.UseVisualStyleBackColor = true;
            buttonAddToy.Click += buttonAddToy_Click;
            // 
            // buttonFind
            // 
            buttonFind.Location = new Point(54, 125);
            buttonFind.Name = "buttonFind";
            buttonFind.Size = new Size(145, 32);
            buttonFind.TabIndex = 7;
            buttonFind.Text = "Найти";
            buttonFind.UseVisualStyleBackColor = true;
            buttonFind.Click += buttonFind_Click;
            // 
            // textBoxFindWeight
            // 
            textBoxFindWeight.Location = new Point(109, 59);
            textBoxFindWeight.Name = "textBoxFindWeight";
            textBoxFindWeight.Size = new Size(125, 27);
            textBoxFindWeight.TabIndex = 8;
            // 
            // textBoxFindName
            // 
            textBoxFindName.Location = new Point(109, 26);
            textBoxFindName.Name = "textBoxFindName";
            textBoxFindName.Size = new Size(125, 27);
            textBoxFindName.TabIndex = 9;
            // 
            // textBoxFindPrice
            // 
            textBoxFindPrice.Location = new Point(109, 92);
            textBoxFindPrice.Name = "textBoxFindPrice";
            textBoxFindPrice.Size = new Size(125, 27);
            textBoxFindPrice.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 33);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 11;
            label2.Text = "Название";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(61, 95);
            label3.Name = "label3";
            label3.Size = new Size(33, 20);
            label3.TabIndex = 12;
            label3.Text = "Вес";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(58, 66);
            label4.Name = "label4";
            label4.Size = new Size(45, 20);
            label4.TabIndex = 13;
            label4.Text = "Цена";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaption;
            groupBox1.Controls.Add(textBoxFindWeight);
            groupBox1.Controls.Add(buttonFind);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBoxFindPrice);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBoxFindName);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(32, 280);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(240, 161);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Поиск элемента";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ActiveCaption;
            groupBox2.Controls.Add(buttonAddGoods);
            groupBox2.Controls.Add(buttonAddProduct);
            groupBox2.Controls.Add(buttonAddMilk);
            groupBox2.Controls.Add(buttonAddToy);
            groupBox2.Location = new Point(32, 119);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(235, 125);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            groupBox2.Text = "Добавление элементов";
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(472, 393);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(98, 44);
            buttonSave.TabIndex = 16;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonDownload
            // 
            buttonDownload.Location = new Point(591, 393);
            buttonDownload.Name = "buttonDownload";
            buttonDownload.Size = new Size(98, 44);
            buttonDownload.TabIndex = 17;
            buttonDownload.Text = "Загрузить";
            buttonDownload.UseVisualStyleBackColor = true;
            buttonDownload.Click += buttonDownload_Click;
            // 
            // buttonGenerateHashTable
            // 
            buttonGenerateHashTable.Location = new Point(741, 313);
            buttonGenerateHashTable.Name = "buttonGenerateHashTable";
            buttonGenerateHashTable.Size = new Size(190, 58);
            buttonGenerateHashTable.TabIndex = 18;
            buttonGenerateHashTable.Text = "Сгенерировать хеш-таблицу";
            buttonGenerateHashTable.UseVisualStyleBackColor = true;
            buttonGenerateHashTable.Click += buttonGenerateHashTable_Click;
            // 
            // buttonCleanHashTable
            // 
            buttonCleanHashTable.Location = new Point(744, 393);
            buttonCleanHashTable.Name = "buttonCleanHashTable";
            buttonCleanHashTable.Size = new Size(187, 35);
            buttonCleanHashTable.TabIndex = 19;
            buttonCleanHashTable.Text = "Очистить хеш-таблицу";
            buttonCleanHashTable.UseVisualStyleBackColor = true;
            buttonCleanHashTable.Click += buttonCleanHashTable_Click;
            // 
            // buttonSaveAll
            // 
            buttonSaveAll.Location = new Point(328, 389);
            buttonSaveAll.Name = "buttonSaveAll";
            buttonSaveAll.Size = new Size(128, 48);
            buttonSaveAll.TabIndex = 20;
            buttonSaveAll.Text = "Сравнение времени сохранения";
            buttonSaveAll.UseVisualStyleBackColor = true;
            buttonSaveAll.Click += buttonSaveAll_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(1067, 476);
            Controls.Add(buttonSaveAll);
            Controls.Add(buttonCleanHashTable);
            Controls.Add(buttonGenerateHashTable);
            Controls.Add(buttonDownload);
            Controls.Add(buttonSave);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(buttonDisplayHashTable);
            Controls.Add(dataGridView1);
            Name = "MainForm";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button buttonDisplayHashTable;
        private Button buttonAddGoods;
        private Button buttonAddProduct;
        private Button buttonAddMilk;
        private Button buttonAddToy;
        private Button buttonFind;
        private TextBox textBoxFindWeight;
        private TextBox textBoxFindName;
        private TextBox textBoxFindPrice;
        private Label label2;
        private Label label3;
        private Label label4;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button buttonSave;
        private Button buttonDownload;
        private Button buttonGenerateHashTable;
        private Button buttonCleanHashTable;
        private Button buttonSaveAll;
    }
}