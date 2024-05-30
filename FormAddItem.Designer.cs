namespace Lab_16_OOP
{
    partial class FormAddItem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxPrice = new TextBox();
            textBoxWeight = new TextBox();
            textBoxExpDateOrAge = new TextBox();
            textBoxFat = new TextBox();
            buttonAdd = new Button();
            textBoxName = new TextBox();
            labelName = new Label();
            labelWeight = new Label();
            labelPrice = new Label();
            labelExpDateOr = new Label();
            labelFat = new Label();
            labelType = new Label();
            SuspendLayout();
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(143, 117);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(125, 27);
            textBoxPrice.TabIndex = 1;
            textBoxPrice.TextChanged += textBoxPrice_TextChanged;
            // 
            // textBoxWeight
            // 
            textBoxWeight.Location = new Point(143, 84);
            textBoxWeight.Name = "textBoxWeight";
            textBoxWeight.Size = new Size(125, 27);
            textBoxWeight.TabIndex = 2;
            textBoxWeight.TextChanged += textBoxWeight_TextChanged;
            // 
            // textBoxExpDateOrAge
            // 
            textBoxExpDateOrAge.Location = new Point(143, 150);
            textBoxExpDateOrAge.Name = "textBoxExpDateOrAge";
            textBoxExpDateOrAge.Size = new Size(125, 27);
            textBoxExpDateOrAge.TabIndex = 3;
            textBoxExpDateOrAge.TextChanged += textBoxExpDateOrAge_TextChanged;
            // 
            // textBoxFat
            // 
            textBoxFat.Location = new Point(143, 183);
            textBoxFat.Name = "textBoxFat";
            textBoxFat.Size = new Size(125, 27);
            textBoxFat.TabIndex = 4;
            textBoxFat.TextChanged += textBoxFat_TextChanged;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(136, 216);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(160, 29);
            buttonAdd.TabIndex = 5;
            buttonAdd.Text = "Добавить элемент";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(143, 54);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(125, 27);
            textBoxName.TabIndex = 0;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(60, 54);
            labelName.Name = "labelName";
            labelName.Size = new Size(77, 20);
            labelName.TabIndex = 6;
            labelName.Text = "Название";
            // 
            // labelWeight
            // 
            labelWeight.AutoSize = true;
            labelWeight.Location = new Point(104, 87);
            labelWeight.Name = "labelWeight";
            labelWeight.Size = new Size(33, 20);
            labelWeight.TabIndex = 7;
            labelWeight.Text = "Вес";
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Location = new Point(92, 120);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(45, 20);
            labelPrice.TabIndex = 8;
            labelPrice.Text = "Цена";
            // 
            // labelExpDateOr
            // 
            labelExpDateOr.AutoSize = true;
            labelExpDateOr.Location = new Point(27, 153);
            labelExpDateOr.Name = "labelExpDateOr";
            labelExpDateOr.Size = new Size(110, 20);
            labelExpDateOr.TabIndex = 9;
            labelExpDateOr.Text = "Срок годности";
            // 
            // labelFat
            // 
            labelFat.AutoSize = true;
            labelFat.Location = new Point(60, 186);
            labelFat.Name = "labelFat";
            labelFat.Size = new Size(79, 20);
            labelFat.TabIndex = 10;
            labelFat.Text = "Жирность";
            // 
            // labelType
            // 
            labelType.AutoSize = true;
            labelType.Location = new Point(162, 19);
            labelType.Name = "labelType";
            labelType.Size = new Size(50, 20);
            labelType.TabIndex = 11;
            labelType.Text = "label1";
            // 
            // FormAddItem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(418, 273);
            Controls.Add(labelType);
            Controls.Add(labelFat);
            Controls.Add(labelExpDateOr);
            Controls.Add(labelPrice);
            Controls.Add(labelWeight);
            Controls.Add(labelName);
            Controls.Add(buttonAdd);
            Controls.Add(textBoxFat);
            Controls.Add(textBoxExpDateOrAge);
            Controls.Add(textBoxWeight);
            Controls.Add(textBoxPrice);
            Controls.Add(textBoxName);
            Name = "FormAddItem";
            Text = "FormAddItem";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxPrice;
        private TextBox textBoxWeight;
        private TextBox textBoxExpDateOrAge;
        private TextBox textBoxFat;
        private Button buttonAdd;
        private TextBox textBoxName;
        private Label labelName;
        private Label labelWeight;
        private Label labelPrice;
        private Label labelExpDateOr;
        private Label labelFat;
        private Label labelType;
    }
}