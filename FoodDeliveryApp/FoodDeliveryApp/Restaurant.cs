using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FoodDeliveryApp
{
    interface Restaurant
    {
        //methods
        String GetName();
        double GetRating();
        String GetLocation();
        Image GetPicture();
        String GetRestType();
    }
    class Lucky : Restaurant
    {
        public String GetName()
        {
            return "Lucky Restaurant";
        }
        public double GetRating()
        {
            return 4.2;
        }
        public String GetLocation()
        {
            return "Bandra";
        }
        public Image GetPicture()
        {
            return Image.FromFile(@"\Users\mcamock\source\repos\FoodDeliveryApp\FoodDeliveryApp\images\lucky.jpg");
        }
        public String GetRestType()
        {
            return "MultiCuisine|Dining|Veg|NonVeg";
        }
    }
    class Bbqnation : Restaurant
    {
        public String GetName()
        {
            return "BBQ Nation";
        }
        public double GetRating()
        {
            return 4.5;
        }
        public String GetLocation()
        {
            return "Andheri";
        }
        public Image GetPicture()
        {
            return Image.FromFile(@"C:\Users\mcamock\source\repos\FoodDeliveryApp\FoodDeliveryApp\images\bbq nation.jpg");
        }
        public String GetRestType()
        {
            return "MultiCuisine|Dining|Veg|NonVeg|Buffet";
        }
    }
    class h2o : Restaurant
    {
        public String GetName()
        {
            return "H2O";
        }
        public double GetRating()
        {
            return 3.5;
        }
        public String GetLocation()
        {
            return "Bandra";
        }
        public Image GetPicture()
        {
            return Image.FromFile(@"C:\Users\mcamock\source\repos\FoodDeliveryApp\FoodDeliveryApp\images\h2o.jpg");
        }
        public String GetRestType()
        {
            return "MultiCuisine|Dining|Veg|NonVeg";
        }
    }
}
