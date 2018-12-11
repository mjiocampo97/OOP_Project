using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_Project.Module;

namespace OOP_Project.ViewModelLocator
{
   public class ViewModelLocator
    {
        public ViewModelLocator()
        {
            PersonModule = new PersonModule();

            ProductModule = new ProductModule();

            CalculationModule = new CalculationModule();
        }

        public PersonModule PersonModule { get; set; }

        public ProductModule ProductModule { get; set; }

        public CalculationModule CalculationModule { get; set; }
    }
}
