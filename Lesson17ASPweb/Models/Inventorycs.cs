﻿using Lesson17ASPweb.Models.Domain;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace Lesson17ASPweb.Models
{
    public class Inventorycs
    {
        public List<Product> products = new List<Product>();

        public Inventorycs(string jsonFile)
        {
            string jsonString = File.ReadAllText(jsonFile);
            products = JsonSerializer.Deserialize<List<Product>>(jsonString);
        }

    }
}
