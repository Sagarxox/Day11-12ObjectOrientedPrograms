
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagment
{
    public class JsonMain
    {
        Model Inventory = new Model();
        List<Model> InventoryList = new List<Model>();
        public void convert(string jFilePath)
        {
            using (StreamReader reader = new StreamReader(jFilePath))
            {
                var json = reader.ReadToEnd();
                var items = JsonConvert.DeserializeObject<List<Model>>(json);
                Console.WriteLine("Name Weight Price Total Value ");
                foreach (var item in items)
                {
                    double value = item.price * item.weight;
                    Console.WriteLine(item.Name + "  " + item.weight + "  " + item.price + " " + value);
                }
            }
        }
    }
}
