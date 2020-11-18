using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace LW2
{

    internal class Search
    {
        private SearchXmlStrategy strategy;
        private Books request;
        private string path;
        public Search(SearchXmlStrategy s, Books b, string p)
        {
            strategy = s;
            request = b;
            path = p;
        }

        public List<Books> Start()
        {
            return strategy.Search(request, path);
        }
    }
    interface SearchXmlStrategy
    {
        List<Books> Search(Books book, string path);
    }

   class Range { 
   public static bool IsInRange(string val, string range)
    {
        int iVal = int.Parse(val);
        if (range != "")
        {
            int index = range.IndexOf('-');
            int left = int.Parse(range.Substring(0, index - 1));
            int right = int.Parse(range.Substring(index + 2));
            if (iVal >= left && iVal <= right) return true;
            else return false;
        }
        else return false;
    }
}
    class SearchDOMStrategy : SearchXmlStrategy
    {
        public List<Books> Search(Books book, string path)
        {
            List<Books> result = new List<Books>();
            XmlDocument doc = new XmlDocument();
            doc.Load(path);

            XmlNode root = doc.DocumentElement;

            foreach (XmlNode node in root.ChildNodes)
            {
                string author = "";
                string genre = "";
                string whelm = "";
                string edition = "";
                string pages = "";
                string name = "";
                string price = "";

                foreach (XmlAttribute attr in node.Attributes)
                {
                    if (attr.Name.Equals("Author") && (attr.Value.Equals(book.Author) || book.Author.Equals(String.Empty)))
                    {
                        author = attr.Value;
                    }

                    if (attr.Name.Equals("Genre") && (attr.Value.Equals(book.Genre) || book.Genre.Equals(String.Empty)))
                    {
                        genre = attr.Value;
                    }

                    if (attr.Name.Equals("Overwhelm") && (attr.Value.Equals(book.Overwhelm) || book.Overwhelm.Equals(String.Empty)))
                    {
                        whelm = attr.Value;
                    }

                    if (attr.Name.Equals("Edition") && (attr.Value.Equals(book.Edition) || book.Edition.Equals(String.Empty)))
                    {
                        edition = attr.Value;
                    }

                    if (attr.Name.Equals("Name"))
                    {
                        name = attr.Value;
                    }

                    if (attr.Name.Equals("PageAmount") && (Range.IsInRange(attr.Value, book.Pages) || book.Pages.Equals(String.Empty)))
                    {
                        pages = attr.Value;
                    }

                    if (attr.Name.Equals("Price") && (Range.IsInRange(attr.Value, book.Price) || book.Price.Equals(String.Empty)))
                    {
                        price = attr.Value;
                    }
                }

                if (author != "" && pages != "" && price != "" && genre != "" && whelm != "" && edition != "")
                {
                    Books res = new Books();
                    res.Author = author;
                    res.Edition = edition;
                    res.Name = name;
                    res.Overwhelm = whelm;
                    res.Genre = genre;
                    res.Pages = pages;
                    res.Price = price;
                    result.Add(res);
                }
            }

            return result;
        }
    }

    class SearchSaxStrategy : SearchXmlStrategy
    {
        public List<Books> Search(Books book, string path)
        {
            List<Books> result = new List<Books>();
            var XmlReader = new XmlTextReader(path);
            while (XmlReader.Read())
            {
                if (XmlReader.HasAttributes)
                {
                    while (XmlReader.MoveToNextAttribute())
                    {
                        string author = "";
                        string genre = "";
                        string whelm = "";
                        string edition = "";
                        string pages = "";
                        string name = "";
                        string price = "";
                        if (XmlReader.Name.Equals("Name"))
                        {
                            name = XmlReader.Value;
                            XmlReader.MoveToNextAttribute();

                            if (XmlReader.Name.Equals("Author") && (XmlReader.Value.Equals(book.Author) || book.Author.Equals(String.Empty)))
                        {
                            author = XmlReader.Value;
                            XmlReader.MoveToNextAttribute();

                            if (XmlReader.Name.Equals("Genre") && (XmlReader.Value.Equals(book.Genre) || book.Genre.Equals(String.Empty)))
                            {
                                genre = XmlReader.Value;
                                XmlReader.MoveToNextAttribute();

                                    if (XmlReader.Name.Equals("PageAmount") && (Range.IsInRange(XmlReader.Value, book.Pages) || book.Pages.Equals(String.Empty)))
                                    {
                                        pages = XmlReader.Value;
                                        XmlReader.MoveToNextAttribute();

                                        if (XmlReader.Name.Equals("Overwhelm") && (XmlReader.Value.Equals(book.Overwhelm) || book.Overwhelm.Equals(String.Empty)))
                                {
                                    whelm = XmlReader.Value;
                                    XmlReader.MoveToNextAttribute();

                                    if (XmlReader.Name.Equals("Edition") && (XmlReader.Value.Equals(book.Edition) || book.Edition.Equals(String.Empty)))
                                    {
                                        edition = XmlReader.Value;
                                        XmlReader.MoveToNextAttribute();

                                                if (XmlReader.Name.Equals("Price") && (Range.IsInRange(XmlReader.Value, book.Price) || book.Price.Equals(String.Empty)))
                                                {
                                                    price = XmlReader.Value;

                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }

                        if (author != "" && pages != "" && price != "" && genre != "" && whelm != "" && edition != "")
                        {
                            Books res = new Books();
                            res.Author = author;
                            res.Edition = edition;
                            res.Name = name;
                            res.Overwhelm = whelm;
                            res.Genre = genre;
                            res.Pages = pages;
                            res.Price = price;
                            result.Add(res);
                        }
                    }
                }
            }
            XmlReader.Close();
            return result;
        }
    }

    class SearchLinqStrategy : SearchXmlStrategy
    {
        public List<Books> Search(Books book, string path)
        {
            List<Books> result = new List<Books>();
            XDocument doc = XDocument.Load(path);
            var resCollection = from obj in doc.Descendants("Book")
                                where(
                                (obj.Attribute("Author").Value.Equals(book.Author) || book.Author.Equals(String.Empty)) &&
                                (obj.Attribute("Genre").Value.Equals(book.Genre) || book.Genre.Equals(String.Empty)) &&
                                (Range.IsInRange(obj.Attribute("PageAmount").Value, book.Price) || book.Pages.Equals(String.Empty)) &&
                                (obj.Attribute("Overwhelm").Value.Equals(book.Overwhelm) || book.Overwhelm.Equals(String.Empty)) &&
                                (obj.Attribute("Edition").Value.Equals(book.Edition) || book.Edition.Equals(String.Empty)) &&
                                (Range.IsInRange(obj.Attribute("Price").Value, book.Price) || book.Price.Equals(String.Empty))
                                )
                                select new
                                {
                                       name = (string)obj.Attribute("Name"),
                                       author = (string)obj.Attribute("Author"),
                                       genre = (string)obj.Attribute("Genre"),
                                       pages = (string)obj.Attribute("PageAmount"),
                                       overwhelm = (string)obj.Attribute("Overwhelm"),
                                       edition = (string)obj.Attribute("Edition"),
                                       price = (string)obj.Attribute("Price"),
                                   };
            foreach (var b in resCollection)
            {
                Books nBook = new Books();
                    nBook.Name = b.name;
                    nBook.Author = b.author;
                    nBook.Genre = b.genre;
                    nBook.Pages = b.pages;
                    nBook.Overwhelm = b.overwhelm;
                    nBook.Edition = b.edition;
                    nBook.Price = b.price;
                
                    result.Add(nBook);
            }
            return result;
        }
    }

}
