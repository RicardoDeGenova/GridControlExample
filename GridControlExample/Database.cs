using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GridControlExample;
public class Database
{    
    public IEnumerable<Seed?> GetSeeds(Func<Seed, bool> getSeeds)
    {
        var Seeds = JsonConvert.DeserializeObject<IEnumerable<Seed>>(JsonSeeds);
        if (Seeds is null) return Array.Empty<Seed>();

        return Seeds.Where(getSeeds);
    }

    public Seed? GetSeed(Func<Seed, bool> getSeeds)
    {
        var Seeds = JsonConvert.DeserializeObject<IEnumerable<Seed>>(JsonSeeds);
        if (Seeds is null) return null;

        return Seeds.Where(getSeeds).FirstOrDefault();
    }

    private readonly string JsonSeeds = @"[
    {
        ""Id"": 1,
        ""Name"": ""Tomato Seeds"",
        ""Description"": ""High yield tomato seeds."",
        ""Category"": ""Vegetable"",
        ""Quantity"": 50.0,
        ""UnitPrice"": 0.50,
        ""TotalPrice"": 25.0
    },
    {
        ""Id"": 2,
        ""Name"": ""Strawberry Seeds"",
        ""Description"": ""Sweet and juicy strawberries."",
        ""Category"": ""Fruit"",
        ""Quantity"": 100.0,
        ""UnitPrice"": 0.30,
        ""TotalPrice"": 30.0
    },
    {
        ""Id"": 3,
        ""Name"": ""Rose Seeds"",
        ""Description"": ""Beautiful red roses."",
        ""Category"": ""Flower"",
        ""Quantity"": 20.0,
        ""UnitPrice"": 1.00,
        ""TotalPrice"": 20.0
    },
    {
        ""Id"": 4,
        ""Name"": ""Basil Seeds"",
        ""Description"": ""Fresh and aromatic basil."",
        ""Category"": ""Herb"",
        ""Quantity"": 40.0,
        ""UnitPrice"": 0.25,
        ""TotalPrice"": 10.0
    },
    {
        ""Id"": 5,
        ""Name"": ""Wheat Seeds"",
        ""Description"": ""Organic wheat grains."",
        ""Category"": ""Grain"",
        ""Quantity"": 200.0,
        ""UnitPrice"": 0.10,
        ""TotalPrice"": 20.0
    },
    {
        ""Id"": 6,
        ""Name"": ""Cucumber Seeds"",
        ""Description"": ""Crispy cucumbers for salads."",
        ""Category"": ""Vegetable"",
        ""Quantity"": 30.0,
        ""UnitPrice"": 0.40,
        ""TotalPrice"": 12.0
    },
    {
        ""Id"": 7,
        ""Name"": ""Blueberry Seeds"",
        ""Description"": ""Rich in antioxidants."",
        ""Category"": ""Fruit"",
        ""Quantity"": 70.0,
        ""UnitPrice"": 0.35,
        ""TotalPrice"": 24.5
    },
    {
        ""Id"": 8,
        ""Name"": ""Sunflower Seeds"",
        ""Description"": ""Bright and tall sunflowers."",
        ""Category"": ""Flower"",
        ""Quantity"": 60.0,
        ""UnitPrice"": 0.20,
        ""TotalPrice"": 12.0
    },
    {
        ""Id"": 9,
        ""Name"": ""Mint Seeds"",
        ""Description"": ""Cool and refreshing mint."",
        ""Category"": ""Herb"",
        ""Quantity"": 50.0,
        ""UnitPrice"": 0.15,
        ""TotalPrice"": 7.5
    },
    {
        ""Id"": 10,
        ""Name"": ""Corn Seeds"",
        ""Description"": ""Sweet corn for grilling."",
        ""Category"": ""Grain"",
        ""Quantity"": 150.0,
        ""UnitPrice"": 0.12,
        ""TotalPrice"": 18.0
    },
    {
        ""Id"": 11,
        ""Name"": ""Pepper Seeds"",
        ""Description"": ""Spicy chili peppers."",
        ""Category"": ""Vegetable"",
        ""Quantity"": 25.0,
        ""UnitPrice"": 0.60,
        ""TotalPrice"": 15.0
    },
    {
        ""Id"": 12,
        ""Name"": ""Apple Seeds"",
        ""Description"": ""Crisp and sweet apples."",
        ""Category"": ""Fruit"",
        ""Quantity"": 80.0,
        ""UnitPrice"": 0.50,
        ""TotalPrice"": 40.0
    },
    {
        ""Id"": 13,
        ""Name"": ""Tulip Seeds"",
        ""Description"": ""Colorful tulip flowers."",
        ""Category"": ""Flower"",
        ""Quantity"": 30.0,
        ""UnitPrice"": 0.70,
        ""TotalPrice"": 21.0
    },
    {
        ""Id"": 14,
        ""Name"": ""Oregano Seeds"",
        ""Description"": ""Perfect for Italian dishes."",
        ""Category"": ""Herb"",
        ""Quantity"": 45.0,
        ""UnitPrice"": 0.22,
        ""TotalPrice"": 9.9
    },
    {
        ""Id"": 15,
        ""Name"": ""Rice Seeds"",
        ""Description"": ""High-quality rice grains."",
        ""Category"": ""Grain"",
        ""Quantity"": 180.0,
        ""UnitPrice"": 0.09,
        ""TotalPrice"": 16.2
    },
    {
        ""Id"": 16,
        ""Name"": ""Lettuce Seeds"",
        ""Description"": ""Fresh lettuce for salads."",
        ""Category"": ""Vegetable"",
        ""Quantity"": 35.0,
        ""UnitPrice"": 0.18,
        ""TotalPrice"": 6.3
    },
    {
        ""Id"": 17,
        ""Name"": ""Grape Seeds"",
        ""Description"": ""Juicy and sweet grapes."",
        ""Category"": ""Fruit"",
        ""Quantity"": 90.0,
        ""UnitPrice"": 0.45,
        ""TotalPrice"": 40.5
    },
    {
        ""Id"": 18,
        ""Name"": ""Lavender Seeds"",
        ""Description"": ""Fragrant lavender flowers."",
        ""Category"": ""Flower"",
        ""Quantity"": 40.0,
        ""UnitPrice"": 0.55,
        ""TotalPrice"": 22.0
    },
    {
        ""Id"": 19,
        ""Name"": ""Thyme Seeds"",
        ""Description"": ""Aromatic thyme herb."",
        ""Category"": ""Herb"",
        ""Quantity"": 50.0,
        ""UnitPrice"": 0.20,
        ""TotalPrice"": 10.0
    },
    {
        ""Id"": 20,
        ""Name"": ""Barley Seeds"",
        ""Description"": ""Nutritious barley grains."",
        ""Category"": ""Grain"",
        ""Quantity"": 160.0,
        ""UnitPrice"": 0.11,
        ""TotalPrice"": 17.6
    }
]";
}
