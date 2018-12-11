using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using OOP_Project.Classes;

namespace OOP_Project.Module
{
    public class ProductModule
    {

        public ObservableCollection<Product> ProductList { get; set; }= new ObservableCollection<Product>();
        public Product SelectedProduct { get; set; }
        private ListCollectionView _view;
        public ProductModule()
        {
            GenerateProdcut();
            InitializeView();
        }

        public void GenerateProdcut()
        {
            ProductList.Add(new Necklace("Golden Necklace","A necklace made of Gold",5000,0.013,3));
            ProductList.Add(new Earrings("Golden Earrings", "A earrings made of Gold", 1500, 0.005, 5));
            ProductList.Add(new Rings("Golden Ring", "A ring made of Gold", 2000, 0.07, 8));
            ProductList.Add(new Bracelets("Golden Bracelets", "A bracelet made of Gold", 3000, 0.01, 4));
            ProductList.Add(new Necklace("Bronze Necklace", "A necklace made of Bronze", 500, 0.013, 3));
            ProductList.Add(new Earrings("Bronze Earrings", "A earrings made of Bronze", 150, 0.005, 5));
            ProductList.Add(new Rings("Bronze Ring", "A ring made of Bronze", 200, 0.07, 8));
            ProductList.Add(new Bracelets("Bronze Bracelets", "A bracelet made of Bronze", 300, 0.01, 4));
            

        }

        private void InitializeView()
        {
            _view = CollectionViewSource.GetDefaultView(ProductList) as ListCollectionView;
            _view?.GroupDescriptions.Add(new PropertyGroupDescription("ProductType"));
            _view?.SortDescriptions.Add(new SortDescription("ProductType", ListSortDirection.Ascending));
        }
    }
}
