using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_Project.Classes;

namespace OOP_Project.Module
{
    public class ProductModule
    {

        public ObservableCollection<Product> ProductList { get; set; }= new ObservableCollection<Product>();
        public Product SelectedProduct { get; set; }
        public ProductModule()
        {
            GenerateProdcut();
        }

        public void GenerateProdcut()
        {
            ProductList.Add(new Necklace("Golden Necklace","A necklace made of Gold",5000,0.013,3));
            ProductList.Add(new Earrings("Golden Earrings", "A earrings made of Gold", 1500, 0.005, 5));
            ProductList.Add(new Rings("Golden Ring", "A ring made of Gold", 2000, 0.07, 8));
            ProductList.Add(new Bracelets("Golden Bracelets", "A bracelet made of Gold", 3000, 0.01, 4));
            var necklace = new Necklace();
            necklace.Name = "ata";
            ProductList.Add(necklace);

        }
    }
}
