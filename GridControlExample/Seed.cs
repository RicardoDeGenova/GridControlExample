using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GridControlExample;
public enum SeedCategory
{
    Vegetable,
    Fruit,
    Flower,
    Herb,
    Grain
}

public class Seed
{
    [DisplayName("Id")]
    public long Id { get; set; }

    [DisplayName("Nome")]
    public string Name { get; set; } = string.Empty;

    [DisplayName("Descrição")]
    public string Description { get; set; } = string.Empty;

    [DisplayName("Categoria")]
    public SeedCategory Category { get; set; }

    [DisplayName("Qtde")]
    public float Quantity { get; set; } = 0f;

    [DisplayName("Preço Unitário")]
    public decimal UnitPrice { get; set; } = 0m;

    [DisplayName("R$ Total")]
    public decimal TotalPrice => (decimal)Quantity * UnitPrice;
}
