using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SpeedMeasuremetRazor.Models;

namespace SpeedMeasuremetRazor.Helpers
{
    public class JsonFileWriterGenerics<T>
    {
        public static void WriteToJson(T elements, string filePath)
        {
            string output = JsonConvert.SerializeObject(elements, Formatting.Indented);

            File.WriteAllText(filePath, output);
        }

    }
}
