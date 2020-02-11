using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace XML_Manipulation
{
    class Program
    {
        static void Main(string[] args)
        {


            XDocument xmlFile = XDocument.Load("C:\\Users\\Dennis\\Desktop\\HTML\\demo\\books.xml");

            var query = from c in xmlFile.Elements("catalog").Elements("author")
                        select c;

            foreach (XElement book in query)
            {
                Console.WriteLine("Before:" + " " + book.ToString());

                book.Attribute("name").Value = "Carlos";
                book.Attribute("lastname").Value = "Anibal";

                Console.WriteLine("After:" + " " + book.ToString());
            }

            xmlFile.Save("C:\\Users\\Dennis\\Desktop\\HTML\\demo\\books.xml");

         
        }
    }
}
