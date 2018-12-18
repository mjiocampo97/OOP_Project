using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using OOP_Project.Classes;

namespace OOP_Project.Module
{
    public class ProductModule : ObservableObject
    {
        public bool CurrenlyOnNeklace
        {
            get => _currenlyOnNeklace;
            set
            {
                _currenlyOnNeklace = value;
                RaisePropertyChanged(nameof(CurrenlyOnNeklace));
            } 
        }

        public bool CurrentlyOnEarrings
        {
            get => _currentlyOnEarrings;
            set
            {
                _currentlyOnEarrings = value;
                RaisePropertyChanged(nameof(CurrentlyOnEarrings));
            }

        }

        public bool CurrentlyOnRings
        {
            get => _currentlyOnRings;
            set
            {
                _currentlyOnRings = value;
                RaisePropertyChanged(nameof(CurrentlyOnRings));
            }
        }

        public bool CurrentlyOnBracelets
        {
            get => _currentlyOnBracelets;
            set
            {   
                _currentlyOnBracelets = value;
                RaisePropertyChanged(nameof(CurrentlyOnBracelets));
            }
        }

        public ObservableCollection<Product> ProductList { get; set; }= new ObservableCollection<Product>();
        public Product SelectedProduct { get; set; }
        private ListCollectionView _view;
        private bool _currenlyOnNeklace;
        private bool _currentlyOnEarrings;
        private bool _currentlyOnRings;
        private bool _currentlyOnBracelets;

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
        {   //View by producttype
            _view = CollectionViewSource.GetDefaultView(ProductList) as ListCollectionView;
            _view?.GroupDescriptions.Add(new PropertyGroupDescription("ProductType"));
            _view?.SortDescriptions.Add(new SortDescription("ProductType", ListSortDirection.Ascending));
        }

        public ICommand ResetViewCommand => new RelayCommand(ResetViewProc);
        private void ResetViewProc()
        {
            _view.Filter = Reset;
            CurrentlyOnBracelets = true;
            CurrenlyOnNeklace = true;
            CurrentlyOnRings = true;
            CurrentlyOnEarrings = true;
        }

        private bool Reset(object o)
        {
            return true;
        }
        public  ICommand ViewBraceletsCommand => new RelayCommand(ViewBraceletsProc);

        private void ViewBraceletsProc()
        {
            _view.Filter = FilterBracelets;
            CurrentlyOnBracelets = true;
            CurrenlyOnNeklace = false;
            CurrentlyOnRings = false;
            CurrentlyOnEarrings = false;
        }
        private bool FilterBracelets(object o)
        {
            if (o is Bracelets)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public ICommand ViewNecklaceCommand => new RelayCommand(ViewNecklaceProc);

        private void ViewNecklaceProc()
        {
            _view.Filter = FilterNecklace;
            CurrentlyOnBracelets = false;
            CurrenlyOnNeklace = true;
            CurrentlyOnRings = false;
            CurrentlyOnEarrings = false;
        }
        private bool FilterNecklace(object o)
        {
            if (o is Necklace)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public ICommand ViewEarringsCommand => new RelayCommand(ViewEarringsProc);

        private void ViewEarringsProc()
        {
            _view.Filter = FilterEarrings;
            CurrentlyOnBracelets = false;
            CurrenlyOnNeklace = false;
            CurrentlyOnRings = false;
            CurrentlyOnEarrings = true;
        }
        private bool FilterEarrings(object o)
        {
            if (o is Earrings)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public ICommand ViewRingsCommand => new RelayCommand(ViewRingsProc);

        private void ViewRingsProc()
        {
            _view.Filter = FilterRings;
            CurrentlyOnBracelets = false;
            CurrenlyOnNeklace = false;
            CurrentlyOnRings = true;
            CurrentlyOnEarrings = false;
        }
        private bool FilterRings(object o)
        {
            if (o is Rings)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
