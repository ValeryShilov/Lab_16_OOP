using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Lab_16_OOP
{
    partial class SyncAsyncForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            syncTime4 = new Label();
            syncTime1 = new Label();
            syncTime2 = new Label();
            syncTime3 = new Label();
            asyncTime4 = new Label();
            asyncTime1 = new Label();
            asyncTime2 = new Label();
            asyncTime3 = new Label();
            label19 = new Label();
            label20 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 29);
            label1.Name = "label1";
            label1.Size = new Size(105, 20);
            label1.TabIndex = 1;
            label1.Text = "Синхронные: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(391, 29);
            label2.Name = "label2";
            label2.Size = new Size(113, 20);
            label2.TabIndex = 2;
            label2.Text = "Асинхронные: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 160);
            label3.Name = "label3";
            label3.Size = new Size(84, 20);
            label3.TabIndex = 3;
            label3.Text = "JSON Файл";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 116);
            label4.Name = "label4";
            label4.Size = new Size(122, 20);
            label4.TabIndex = 4;
            label4.Text = "Бинарный Файл";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 71);
            label5.Name = "label5";
            label5.Size = new Size(85, 20);
            label5.TabIndex = 5;
            label5.Text = "Текст Файл";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(14, 203);
            label6.Name = "label6";
            label6.Size = new Size(78, 20);
            label6.TabIndex = 6;
            label6.Text = "XML Файл";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(391, 203);
            label7.Name = "label7";
            label7.Size = new Size(78, 20);
            label7.TabIndex = 10;
            label7.Text = "XML Файл";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(391, 71);
            label8.Name = "label8";
            label8.Size = new Size(85, 20);
            label8.TabIndex = 9;
            label8.Text = "Текст Файл";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(391, 116);
            label9.Name = "label9";
            label9.Size = new Size(122, 20);
            label9.TabIndex = 8;
            label9.Text = "Бинарный Файл";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(391, 160);
            label10.Name = "label10";
            label10.Size = new Size(84, 20);
            label10.TabIndex = 7;
            label10.Text = "JSON Файл";
            // 
            // syncTime4
            // 
            syncTime4.AutoSize = true;
            syncTime4.Location = new Point(161, 203);
            syncTime4.Name = "syncTime4";
            syncTime4.Size = new Size(39, 20);
            syncTime4.TabIndex = 14;
            syncTime4.Text = "0 мс";
            // 
            // syncTime1
            // 
            syncTime1.AutoSize = true;
            syncTime1.Location = new Point(161, 71);
            syncTime1.Name = "syncTime1";
            syncTime1.Size = new Size(39, 20);
            syncTime1.TabIndex = 13;
            syncTime1.Text = "0 мс";
            // 
            // syncTime2
            // 
            syncTime2.AutoSize = true;
            syncTime2.Location = new Point(161, 116);
            syncTime2.Name = "syncTime2";
            syncTime2.Size = new Size(39, 20);
            syncTime2.TabIndex = 12;
            syncTime2.Text = "0 мс";
            // 
            // syncTime3
            // 
            syncTime3.AutoSize = true;
            syncTime3.Location = new Point(161, 160);
            syncTime3.Name = "syncTime3";
            syncTime3.Size = new Size(39, 20);
            syncTime3.TabIndex = 11;
            syncTime3.Text = "0 мс";
            // 
            // asyncTime4
            // 
            asyncTime4.AutoSize = true;
            asyncTime4.Location = new Point(537, 203);
            asyncTime4.Name = "asyncTime4";
            asyncTime4.Size = new Size(39, 20);
            asyncTime4.TabIndex = 18;
            asyncTime4.Text = "0 мс";
            // 
            // asyncTime1
            // 
            asyncTime1.AutoSize = true;
            asyncTime1.Location = new Point(537, 71);
            asyncTime1.Name = "asyncTime1";
            asyncTime1.Size = new Size(39, 20);
            asyncTime1.TabIndex = 17;
            asyncTime1.Text = "0 мс";
            // 
            // asyncTime2
            // 
            asyncTime2.AutoSize = true;
            asyncTime2.Location = new Point(537, 116);
            asyncTime2.Name = "asyncTime2";
            asyncTime2.Size = new Size(39, 20);
            asyncTime2.TabIndex = 16;
            asyncTime2.Text = "0 мс";
            // 
            // asyncTime3
            // 
            asyncTime3.AutoSize = true;
            asyncTime3.Location = new Point(537, 160);
            asyncTime3.Name = "asyncTime3";
            asyncTime3.Size = new Size(39, 20);
            asyncTime3.TabIndex = 15;
            asyncTime3.Text = "0 мс";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(161, 29);
            label19.Name = "label19";
            label19.Size = new Size(61, 20);
            label19.TabIndex = 19;
            label19.Text = "Время: ";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(537, 29);
            label20.Name = "label20";
            label20.Size = new Size(61, 20);
            label20.TabIndex = 20;
            label20.Text = "Время: ";
            // 
            // SyncAsyncForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(778, 252);
            Controls.Add(label20);
            Controls.Add(label19);
            Controls.Add(asyncTime4);
            Controls.Add(asyncTime1);
            Controls.Add(asyncTime2);
            Controls.Add(asyncTime3);
            Controls.Add(syncTime4);
            Controls.Add(syncTime1);
            Controls.Add(syncTime2);
            Controls.Add(syncTime3);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "SyncAsyncForm";
            Text = "Синхронные-Асинхронные Сохранения";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label syncTime4;
        private Label syncTime1;
        private Label syncTime2;
        private Label syncTime3;
        private Label asyncTime4;
        private Label asyncTime1;
        private Label asyncTime2;
        private Label asyncTime3;
        private Label label19;
        private Label label20;
    }
}