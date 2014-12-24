using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithDataSerialization
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new DatabaseTable.TestTableAdapters.TestTableTableAdapter();
            var table = db.GetData();

            var items = table.ToList();

            var serialized = Newtonsoft.Json.JsonConvert.SerializeObject(items);
            var path = Path.Combine(Environment.CurrentDirectory, "Text.json");
            File.WriteAllText(path, serialized);

            table.Clear();

            var text =  File.ReadAllText(path);

            var data = Newtonsoft.Json.JsonConvert.DeserializeObject(text);
        }
    }
}
