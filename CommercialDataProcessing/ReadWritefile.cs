
namespace ObjectOrientedPrograms.CommercialDataProcessing
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using Newtonsoft.Json;

    public class ReadWritefile
    {
        public static List<CompanyShares> ReadFromFile()
        {
            if(File.Exists(""))
            {
                string jsonData = File.ReadAllText("");
                List<CompanyShares> jsonObjectArray = JsonConvert.DeserializeObject<List<CompanyShares>>(jsonData);

                foreach(CompanyShares companyShares in jsonObjectArray)
                {
                    CompanyShares.Add(companyShares);
                }
                return jsonObjectArray;
            }
            else
            {
                Console.WriteLine("File path not found");
                return new List<CompanyShares>();
            }
        }

        public static void WriteToFile(List<CompanyShares> companyShares)
        {
            string jsonData = JsonConvert.SerializeObject(companyShares);
            File.WriteAllText("",jsonData);
        }
    }
}
