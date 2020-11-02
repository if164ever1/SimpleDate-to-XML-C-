using System;
using System.Collections.Generic;
using System.Xml.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForm1
{
    class Repository
    {
        static string path = "Users.xml";
        
        public static void WriteToXML(User user)
        {
            XElement element = new XElement("Users", 
                new XElement("LastName", user.LastName), 
                new XElement("FirstName", user.FirstName),
                new XElement("Country", user.County),
                new XElement("City", user.City),
                new XElement("Phone", user.Phone),
                new XElement("Birthday", user.birthDay.Date),
                new XElement("Sex", user.Sex));
            
            element.Save(path);
        }
    }
}
