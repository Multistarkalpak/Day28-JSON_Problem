using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace JSON
{
    public class XMLDataOperation
    {
        public static void xmlSerialize()
        {
            StreamWriter sw = null;
            try
            {
                string xmlpath = @"C:\Users\kalpak\Desktop\Assignments\Day-28\JSON\Files\Data.txt";
                List<Person> person = new List<Person>()
                {
                new Person() { PersonId = 12, Name = "Jivesh", Address = "kayar" },
                new Person() { PersonId = 13, Name = "gaurav", Address = "Bengalaru" },
                new Person() { PersonId = 14, Name = "Chetan", Address = "Assam" }
                };
                XmlSerializer xml = new XmlSerializer(typeof(List<Person>));

                sw = new StreamWriter(xmlpath);
                xml.Serialize(sw, person);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally 
            {
                sw.Close();
            }
           
        }
        public static void XmlDeSerialize()
        {
            try
            {
                StreamReader sr = null;
                string xmlpath = @"C:\Users\kalpak\Desktop\Assignments\Day-28\JSON\Files\Data.txt";

                if (File.Exists(xmlpath))
                {

                    XmlSerializer xml = new XmlSerializer(typeof(List<Person>));
                    sr = new StreamReader(xmlpath);
                    List<Person> res = (List<Person>)xml.Deserialize(sr); //expicit casting
                    if (res.Count != 0) 
                    {
                        foreach (Person person in res)
                        {
                            Console.WriteLine(person);
                        }
                    }
                }

            }

            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);


            }
            
            
        }


    }


}
