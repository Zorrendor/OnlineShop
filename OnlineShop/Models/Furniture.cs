using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineShop.Models
{
    public class Furniture
    {
        int ID { get; set; }
        string Name { get; set; }
        float Price { get; set; }
        int Width { get; set; }
        int Height { get; set; }
        int Length { get; set; }
        string Photo { get; set; }
        string TypeFurniture { get; set; }
    }
}