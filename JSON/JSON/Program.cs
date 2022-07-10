namespace JSON
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the choice you want \n 1.JsonSerialization\n 2.jsonDeserializeation\n 3.XMLserialization\n 4.XMLDeserialization\n 5.CSVSerialization\n 6.CSVdeserialization\n 7.ReadFreomCsvWriteToJson\n 8.ReadFromJsonWriteIntoCsv");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:

                    JSONDataOperation.jsonSerialize();
                    break;
                case 2:
                    JSONDataOperation.JsonDeserialization();
                    break;
                case 3:
                    XMLDataOperation.xmlSerialize();
                    break;
                case 4:
                    XMLDataOperation.XmlDeSerialize();
                    break;
                case 5:
                    CSVOperation.CSVSerilaization();
                    break;

                case 6:
                    CSVOperation.CSVDeserialize();
                    break;
                case 7:
                    JsonAndCSVOperation.ReadFromCsvWriteIntoJson();
                    break;
                case 8:
                    JsonAndCSVOperation.ReadFromJsonWriteIntoCsv();
                    break;


            }


        }

    }
}
//Enter the choice you want
// 1.JsonSerialization
// 2.jsonDeserializeation
// 3.XMLserialization
// 4.XMLDeserialization
// 5.CSVSerialization
// 6.CSVdeserialization
// 7.ReadFreomCsvWriteToJson
// 8.ReadFromJsonWriteIntoCsv
//7
//Id:  12 Name: Jivesh Address:  Kayar
//Id:  13 Name: Gaurav Address:  Bengalaru
//Id:  14 Name: Chetan Address:  Assam