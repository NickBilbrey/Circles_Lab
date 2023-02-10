using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CirclesLab
{
    public class Circles
    {
        private double Radius;
        public Circles(double radius)
        {
            Radius = radius;
           
        }
        public double CalculatCircumference()
        {
            double circumference = 2 * Radius * Math.PI;
            return circumference;
        }
        public string CalculatedFormattedCircumference()
        {
            double roundedCircumference = Math.Round(CalculatCircumference(),2);
            return roundedCircumference.ToString();

        }
        public double CalculateArea()
        {
            double area = Math.PI * Radius * Radius;
            return area;
        }
     

        public string CalculateFormattedArea()
        {
            double roundedarea = Math.Round(CalculateArea(), 2);
            return roundedarea.ToString();

        }
        /*private string FormatNumber(double x)
        {

        }
*/



    }
}
