namespace Lab_16_OOP
{
    partial class ChoiceSerialize
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
            buttonBinary = new Button();
            buttonJson = new Button();
            buttonXml = new Button();
            buttonTxt = new Button();
            SuspendLayout();
            // 
            // buttonBinary
            // 
            buttonBinary.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonBinary.Location = new Point(32, 43);
            buttonBinary.Name = "buttonBinary";
            buttonBinary.Size = new Size(167, 67);
            buttonBinary.TabIndex = 0;
            buttonBinary.Text = "Binary";
            buttonBinary.UseVisualStyleBackColor = true;
            buttonBinary.Click += buttonBinary_Click;
            // 
            // buttonJson
            // 
            buttonJson.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonJson.Location = new Point(233, 136);
            buttonJson.Name = "buttonJson";
            buttonJson.Size = new Size(167, 67);
            buttonJson.TabIndex = 1;
            buttonJson.Text = "JSON";
            buttonJson.UseVisualStyleBackColor = true;
            buttonJson.Click += buttonJson_Click;
            // 
            // buttonXml
            // 
            buttonXml.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonXml.Location = new Point(233, 43);
            buttonXml.Name = "buttonXml";
            buttonXml.Size = new Size(167, 67);
            buttonXml.TabIndex = 2;
            buttonXml.Text = "XML";
            buttonXml.UseVisualStyleBackColor = true;
            buttonXml.Click += buttonXml_Click;
            // 
            // buttonTxt
            // 
            buttonTxt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonTxt.Location = new Point(32, 136);
            buttonTxt.Name = "buttonTxt";
            buttonTxt.Size = new Size(167, 67);
            buttonTxt.TabIndex = 3;
            buttonTxt.Text = "TXT";
            buttonTxt.UseVisualStyleBackColor = true;
            buttonTxt.Click += buttonTxt_Click;
            // 
            // ChoiceSerialize
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(465, 251);
            Controls.Add(buttonTxt);
            Controls.Add(buttonXml);
            Controls.Add(buttonJson);
            Controls.Add(buttonBinary);
            Name = "ChoiceSerialize";
            Text = "ChoiceSerialize";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonBinary;
        private Button buttonJson;
        private Button buttonXml;
        private Button buttonTxt;
    }
}