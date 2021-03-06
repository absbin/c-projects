using System.Collections.Generic;

namespace ClassPrpoerties2
{
    public class CarModel
    {
        List<string> validColors = new List<string>() { "Blue", "Brown", "Black" };
        public string Name; // attribute
        public string Manufacturer;
        private string _Color;



        public CarModel(string name, string manu, string _Color)
        {
            Name = name;
            Manufacturer = manu;
            Color = _Color; // using setter  and getter
        }
        public string Color  //property
        {
            get { return _Color; }
            set
            {
                if (validColors.Contains(value))
                {
                    _Color = value;
                }
                else
                {
                    _Color = "Not Defined!";
                }
            }
        }
        public string Color2 { get; set; } //auto property
    }
}