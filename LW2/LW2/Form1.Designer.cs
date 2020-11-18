namespace LW2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkAuthor = new System.Windows.Forms.CheckBox();
            this.checkGenre = new System.Windows.Forms.CheckBox();
            this.checkPage = new System.Windows.Forms.CheckBox();
            this.checkWhelm = new System.Windows.Forms.CheckBox();
            this.checkEdition = new System.Windows.Forms.CheckBox();
            this.checkPrice = new System.Windows.Forms.CheckBox();
            this.authorBox = new System.Windows.Forms.ComboBox();
            this.genreBox = new System.Windows.Forms.ComboBox();
            this.pageBox = new System.Windows.Forms.ComboBox();
            this.whelmBox = new System.Windows.Forms.ComboBox();
            this.editionBox = new System.Windows.Forms.ComboBox();
            this.priceBox = new System.Windows.Forms.ComboBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.searchButton = new System.Windows.Forms.Button();
            this.HTMLButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkAuthor
            // 
            this.checkAuthor.AutoSize = true;
            this.checkAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkAuthor.Location = new System.Drawing.Point(12, 41);
            this.checkAuthor.Name = "checkAuthor";
            this.checkAuthor.Size = new System.Drawing.Size(67, 20);
            this.checkAuthor.TabIndex = 0;
            this.checkAuthor.Text = "Автор";
            this.checkAuthor.UseVisualStyleBackColor = true;
            this.checkAuthor.CheckedChanged += new System.EventHandler(this.checkAuthor_CheckedChanged);
            // 
            // checkGenre
            // 
            this.checkGenre.AutoSize = true;
            this.checkGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkGenre.Location = new System.Drawing.Point(12, 81);
            this.checkGenre.Name = "checkGenre";
            this.checkGenre.Size = new System.Drawing.Size(64, 20);
            this.checkGenre.TabIndex = 1;
            this.checkGenre.Text = "Жанр";
            this.checkGenre.UseVisualStyleBackColor = true;
            this.checkGenre.CheckedChanged += new System.EventHandler(this.checkGenre_CheckedChanged);
            // 
            // checkPage
            // 
            this.checkPage.AutoSize = true;
            this.checkPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkPage.Location = new System.Drawing.Point(12, 121);
            this.checkPage.Name = "checkPage";
            this.checkPage.Size = new System.Drawing.Size(143, 20);
            this.checkPage.TabIndex = 2;
            this.checkPage.Text = "Кількість сторінок";
            this.checkPage.UseVisualStyleBackColor = true;
            this.checkPage.CheckedChanged += new System.EventHandler(this.checkPage_CheckedChanged);
            // 
            // checkWhelm
            // 
            this.checkWhelm.AutoSize = true;
            this.checkWhelm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkWhelm.Location = new System.Drawing.Point(12, 161);
            this.checkWhelm.Name = "checkWhelm";
            this.checkWhelm.Size = new System.Drawing.Size(87, 20);
            this.checkWhelm.TabIndex = 3;
            this.checkWhelm.Text = "Перепліт";
            this.checkWhelm.UseVisualStyleBackColor = true;
            this.checkWhelm.CheckedChanged += new System.EventHandler(this.checkWhelm_CheckedChanged);
            // 
            // checkEdition
            // 
            this.checkEdition.AutoSize = true;
            this.checkEdition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkEdition.Location = new System.Drawing.Point(12, 201);
            this.checkEdition.Name = "checkEdition";
            this.checkEdition.Size = new System.Drawing.Size(83, 20);
            this.checkEdition.TabIndex = 4;
            this.checkEdition.Text = "Видання";
            this.checkEdition.UseVisualStyleBackColor = true;
            this.checkEdition.CheckedChanged += new System.EventHandler(this.checkEdition_CheckedChanged);
            // 
            // checkPrice
            // 
            this.checkPrice.AutoSize = true;
            this.checkPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkPrice.Location = new System.Drawing.Point(12, 241);
            this.checkPrice.Name = "checkPrice";
            this.checkPrice.Size = new System.Drawing.Size(117, 20);
            this.checkPrice.TabIndex = 5;
            this.checkPrice.Text = "Діапазон ціни";
            this.checkPrice.UseVisualStyleBackColor = true;
            this.checkPrice.CheckedChanged += new System.EventHandler(this.checkPrice_CheckedChanged);
            // 
            // authorBox
            // 
            this.authorBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.authorBox.Enabled = false;
            this.authorBox.FormattingEnabled = true;
            this.authorBox.Location = new System.Drawing.Point(176, 39);
            this.authorBox.Name = "authorBox";
            this.authorBox.Size = new System.Drawing.Size(121, 21);
            this.authorBox.TabIndex = 6;
            // 
            // genreBox
            // 
            this.genreBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genreBox.Enabled = false;
            this.genreBox.FormattingEnabled = true;
            this.genreBox.Location = new System.Drawing.Point(176, 79);
            this.genreBox.Name = "genreBox";
            this.genreBox.Size = new System.Drawing.Size(121, 21);
            this.genreBox.TabIndex = 7;
            // 
            // pageBox
            // 
            this.pageBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pageBox.Enabled = false;
            this.pageBox.FormattingEnabled = true;
            this.pageBox.Location = new System.Drawing.Point(176, 119);
            this.pageBox.Name = "pageBox";
            this.pageBox.Size = new System.Drawing.Size(121, 21);
            this.pageBox.TabIndex = 8;
            // 
            // whelmBox
            // 
            this.whelmBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.whelmBox.Enabled = false;
            this.whelmBox.FormattingEnabled = true;
            this.whelmBox.Location = new System.Drawing.Point(176, 159);
            this.whelmBox.Name = "whelmBox";
            this.whelmBox.Size = new System.Drawing.Size(121, 21);
            this.whelmBox.TabIndex = 9;
            // 
            // editionBox
            // 
            this.editionBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.editionBox.Enabled = false;
            this.editionBox.FormattingEnabled = true;
            this.editionBox.Location = new System.Drawing.Point(176, 199);
            this.editionBox.Name = "editionBox";
            this.editionBox.Size = new System.Drawing.Size(121, 21);
            this.editionBox.TabIndex = 10;
            // 
            // priceBox
            // 
            this.priceBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.priceBox.Enabled = false;
            this.priceBox.FormattingEnabled = true;
            this.priceBox.Location = new System.Drawing.Point(176, 239);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(121, 21);
            this.priceBox.TabIndex = 11;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(390, 39);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(401, 345);
            this.richTextBox1.TabIndex = 12;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 305);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Варіант пошуку";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton1.Location = new System.Drawing.Point(176, 303);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(57, 20);
            this.radioButton1.TabIndex = 14;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "DOM";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton2.Location = new System.Drawing.Point(176, 327);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(52, 20);
            this.radioButton2.TabIndex = 15;
            this.radioButton2.Text = "SAX";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton3.Location = new System.Drawing.Point(176, 351);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(56, 20);
            this.radioButton3.TabIndex = 16;
            this.radioButton3.Text = "LINQ";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchButton.Location = new System.Drawing.Point(390, 390);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 29);
            this.searchButton.TabIndex = 17;
            this.searchButton.Text = "ПОШУК";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // HTMLButton
            // 
            this.HTMLButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HTMLButton.Location = new System.Drawing.Point(716, 390);
            this.HTMLButton.Name = "HTMLButton";
            this.HTMLButton.Size = new System.Drawing.Size(75, 29);
            this.HTMLButton.TabIndex = 18;
            this.HTMLButton.Text = "В HTML";
            this.HTMLButton.UseVisualStyleBackColor = true;
            this.HTMLButton.Click += new System.EventHandler(this.HTMLButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 450);
            this.Controls.Add(this.HTMLButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.priceBox);
            this.Controls.Add(this.editionBox);
            this.Controls.Add(this.whelmBox);
            this.Controls.Add(this.pageBox);
            this.Controls.Add(this.genreBox);
            this.Controls.Add(this.authorBox);
            this.Controls.Add(this.checkPrice);
            this.Controls.Add(this.checkEdition);
            this.Controls.Add(this.checkWhelm);
            this.Controls.Add(this.checkPage);
            this.Controls.Add(this.checkGenre);
            this.Controls.Add(this.checkAuthor);
            this.Name = "Form1";
            this.Text = "LabWork2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkAuthor;
        private System.Windows.Forms.CheckBox checkGenre;
        private System.Windows.Forms.CheckBox checkPage;
        private System.Windows.Forms.CheckBox checkWhelm;
        private System.Windows.Forms.CheckBox checkEdition;
        private System.Windows.Forms.CheckBox checkPrice;
        private System.Windows.Forms.ComboBox authorBox;
        private System.Windows.Forms.ComboBox genreBox;
        private System.Windows.Forms.ComboBox pageBox;
        private System.Windows.Forms.ComboBox whelmBox;
        private System.Windows.Forms.ComboBox editionBox;
        private System.Windows.Forms.ComboBox priceBox;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button HTMLButton;
    }
}

