using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Xml.Linq;
using ExcelDataReader;
using GalaSoft.MvvmLight.CommandWpf;
using Microsoft.Win32;
using OOP_Project.Classes;

namespace OOP_Project.Module
{
    public class CalculationModule  
    {
        //for Payroll
        public double TaxRate { get; set; }
        public PersonModule PersonModule = new PersonModule();
        public ObservableCollection<Person> PersonList = new ObservableCollection<Person>();

        public CalculationModule()
        {
            GetList();
            GetIncomeTax();
            ExcelToDataTable();
        }
        
        private void GetList()
        {
            //Taking the customers Payroll HAHAHA
            //Adds PersonModule list to here
            foreach (var person in PersonModule.CustomerList)
            {
                PersonList.Add(person);
            }
        }

        public void GetIncomeTax()
        {
            foreach (var person in PersonList)
            {
                if (person.IncomePerYear < 250000)
                {
                    TaxRate = 0;
                }
                else if (person.IncomePerYear < 400000 && person.IncomePerYear > 250000)
                {
                    TaxRate = 0.20;
                }
                else if (person.IncomePerYear < 800000 && person.IncomePerYear > 400000)
                {
                    TaxRate = 0.25;
                }
                else if (person.IncomePerYear < 2000000 && person.IncomePerYear > 800000)
                {
                    TaxRate = 0.30;
                }
                else if (person.IncomePerYear < 8000000 && person.IncomePerYear > 2000000)
                {
                    TaxRate = 0.32;
                }
                else if(person.IncomePerYear > 8000000)
                {
                    TaxRate = 0.35;
                }
            }
        }

       // public ICommand OpenExcelCommand = new RelayCommand(OpenExcelProc);
        public void CalculateSalary()
        {

        }

        public void CalculateTaxDeduction()
        {

        }

        public void CalculateSSSDeduction()
        {

        }

        public void CalculatePhilHealthDeduction()
        {

        }

        public void PagIbigDeduction()
        {

        }

        public void CalculateNetPay()
        {

        }
        private static void OpenExcelProc(string filePath)
        {
            FileStream stream = File.Open(filePath, FileMode.Open, FileAccess.Read);
        }

        public ICommand OpenExcel => new RelayCommand(ExcelToDataTable);
        public static void ExcelToDataTable()
        {
          
        }

    }
}
