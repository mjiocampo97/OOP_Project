using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;

namespace OOP_Project.Classes
{
    public abstract class Product : ObservableObject
    {
        private string _name;
        public ProductTypes _productType;
        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                RaisePropertyChanged(nameof(Name));
            }
        }

        public string Description { get; set; }
        public double Price { get; set; }
        public double SRP { get; set; }
        public double InterestRate { get; set; }
        public int Quantity { get; set; }
        public virtual ProductTypes ProductType
        {
            get { return _productType; }
            set
            {
                _productType = value;
                RaisePropertyChanged(nameof(ProductType));
            }
        }

      

    }



    public class Necklace : Product
    {
        public Necklace()
        {
            
        }
        public Necklace(string name, string description, double price, double interestRate, int quantity)
        {
            Name = name;
            Description = description;
            Price = price;
            InterestRate = interestRate;
            Quantity = quantity;
        }


        public override ProductTypes ProductType => ProductTypes.Necklace;

       
    }

    public class Earrings : Product
    {
        public Earrings(string name, string description, double price, double interestRate, int quantity)
        {
            Name = name;
            Description = description;
            Price = price;
            InterestRate = interestRate;
            Quantity = quantity;
        }
        public override string ToString()
        {
            return $"{Name}";
        }
        public override ProductTypes ProductType => ProductTypes.Earrings;
    }

    public class Rings : Product
    {
        public Rings(string name, string description, double price, double interestRate, int quantity)
        {
            Name = name;
            Description = description;
            Price = price;
            InterestRate = interestRate;
            Quantity = quantity;
        }
        public override string ToString()
        {
            return $"{Name}";
        }
        public override ProductTypes ProductType => ProductTypes.Rings;
    }

    public class Bracelets : Product
    {
        public Bracelets(string name, string description, double price, double interestRate, int quantity)
        {
            Name = name;
            Description = description;
            Price = price;
            InterestRate = interestRate;
            Quantity = quantity;
        }
        public override string ToString()
        {
            return $"{Name}";
        }
        public override ProductTypes ProductType => ProductTypes.Bracelets;
    }

    public enum ProductTypes
    {
        Necklace,
        Earrings,
        Rings,
        Bracelets
    }

}
