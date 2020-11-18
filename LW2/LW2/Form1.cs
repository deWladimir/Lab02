using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Xsl;

namespace LW2
{
    public partial class Form1 : Form
    {
        List<Books> current = new List<Books>();
        public Form1()
        {
            InitializeComponent();
        }

        public void GetBooks()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(@"C:\Users\User\source\repos\LW2\LW2\Books.xml");
            XmlElement docRoot = doc.DocumentElement;
            XmlNodeList nodes = docRoot.SelectNodes("Book");
            for (int i = 0; i < nodes.Count; ++i)
            {
                XmlNode element = nodes.Item(i);
                AddElementToCombo(element);
            }

            pageBox.Items.Add("0 - 100");
            pageBox.Items.Add("101 - 250");
            pageBox.Items.Add("251 - 500");
            pageBox.Items.Add("501 - 1000");

            priceBox.Items.Add("0 - 200");
            priceBox.Items.Add("201 - 500");
            priceBox.Items.Add("501 - 1000");
        }

        public void AddElementToCombo(XmlNode el)
        {
            if (!authorBox.Items.Contains(el.SelectSingleNode("@Author").Value))
            {
                authorBox.Items.Add(el.SelectSingleNode("@Author").Value);
            }
            if (!genreBox.Items.Contains(el.SelectSingleNode("@Genre").Value))
            {
                genreBox.Items.Add(el.SelectSingleNode("@Genre").Value);
            }
            if (!whelmBox.Items.Contains(el.SelectSingleNode("@Overwhelm").Value))
            {
                whelmBox.Items.Add(el.SelectSingleNode("@Overwhelm").Value);
            }
            if (!editionBox.Items.Contains(el.SelectSingleNode("@Edition").Value))
            {
                editionBox.Items.Add(el.SelectSingleNode("@Edition").Value);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetBooks();
            Display();
        }

        private void checkAuthor_CheckedChanged(object sender, EventArgs e)
        {
            if (authorBox.Enabled) authorBox.Enabled = false;
            else authorBox.Enabled = true;
        }

        private void checkGenre_CheckedChanged(object sender, EventArgs e)
        {
            if (genreBox.Enabled) genreBox.Enabled = false;
            else genreBox.Enabled = true;
        }

        private void checkPage_CheckedChanged(object sender, EventArgs e)
        {
            if (pageBox.Enabled) pageBox.Enabled = false;
            else pageBox.Enabled = true;
        }

        private void checkWhelm_CheckedChanged(object sender, EventArgs e)
        {
            if (whelmBox.Enabled) whelmBox.Enabled = false;
            else whelmBox.Enabled = true;
        }

        private void checkEdition_CheckedChanged(object sender, EventArgs e)
        {
            if (editionBox.Enabled) editionBox.Enabled = false;
            else editionBox.Enabled = true;
        }

        private void checkPrice_CheckedChanged(object sender, EventArgs e)
        {
            if (priceBox.Enabled) priceBox.Enabled = false;
            else priceBox.Enabled = true;
        }

        public void Display()
        {
            Books book = new Books();

            string path = @"C:\Users\User\source\repos\LW2\LW2\Books.xml";

            if (checkAuthor.Checked) book.Author = authorBox.SelectedItem.ToString();
            if (checkGenre.Checked) book.Genre = genreBox.SelectedItem.ToString();
            if (checkEdition.Checked) book.Edition = editionBox.SelectedItem.ToString();
            if (checkPage.Checked) book.Pages = pageBox.SelectedItem.ToString();
            if (checkPrice.Checked) book.Price = priceBox.SelectedItem.ToString();
            if (checkWhelm.Checked) book.Overwhelm = whelmBox.SelectedItem.ToString();

            SearchXmlStrategy strategy = new SearchDOMStrategy();
            if (radioButton2.Checked) strategy = new SearchSaxStrategy();
            if (radioButton3.Checked) strategy = new SearchLinqStrategy();

            Search search = new Search(strategy, book, path);
            List<Books> output = search.Start();

            if (output.Count == 0) richTextBox1.Text = "Нічого не знайшлось";

            foreach (Books b in output)
            {
                richTextBox1.Text += "Назва книги: " + b.Name + "\n";
                richTextBox1.Text += "Автор:" + b.Author + "\n";
                richTextBox1.Text += "Жанр: " + b.Genre + "\n";
                richTextBox1.Text += "Кількість сторінок: " + b.Pages + "\n";
                richTextBox1.Text += "Перепліт: " + b.Overwhelm + "\n";
                richTextBox1.Text += "Видання: " + b.Edition + "\n";
                richTextBox1.Text += "Ціна: " + b.Price + "\n";
                richTextBox1.Text += "\n\n";
            }
            current = output;
            ActiveControl = richTextBox1;
            richTextBox1.Focus();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            Display();
        }

        private void HTMLButton_Click(object sender, EventArgs e)
        {
            XslCompiledTransform xct = new XslCompiledTransform();
            xct.Load(@"C:\Users\User\source\repos\LW2\LW2\XSLFile.xsl");
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "|*.html",
                Title = "Зберегти .html файл    ",
                FileName = "TransformedHTML",
            };
            if (saveFileDialog.ShowDialog() != DialogResult.OK)
                return;
            string htmlPath = saveFileDialog.FileName;
            xct.Transform(CurrentToXml(current), htmlPath);
            MessageBox.Show("HTML-файл збережено");
        }

        private string CurrentToXml(List<Books> cur)
        {
            XDocument xdoc = new XDocument();
            XElement Books = new XElement("Books");
            foreach (Books book in cur)
            {
                XElement newbook = new XElement("Book");
                newbook.Add(new XAttribute("Price", book.Price));
                newbook.Add(new XAttribute("Edition", book.Edition));
                newbook.Add(new XAttribute("Overwhelm", book.Overwhelm));
                newbook.Add(new XAttribute("PageAmount", book.Pages));
                newbook.Add(new XAttribute("Genre", book.Genre));
                newbook.Add(new XAttribute("Author", book.Author));
                newbook.Add(new XAttribute("Name", book.Name));
                Books.Add(newbook);
            }
            xdoc.Add(Books);
            string path = "currentlyDisplayed.xml";
            xdoc.Save(path);
            return path;
        }
    }
}
