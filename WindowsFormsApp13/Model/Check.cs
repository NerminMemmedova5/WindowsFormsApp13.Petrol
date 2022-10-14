using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp13.Model
{
    public class Check
    {
        public int Id { get; set; }
        public string PetrolName { get; set; }
        public double TotalLiter { get; set; }
        public double Payment { get; set; }
        public DateTime DateTime { get; set; }=DateTime.Now;

        public override string ToString()
        {
            return $@"
Id: {Id}
Petrol Name: {PetrolName}
Total Liter: {TotalLiter}
Payment:     {Payment}
Date Time:   {DateTime}";
        }
    }
}
