using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McdonaldDesktopApp
{
    public class DataCatalogue
    {
        public List<McdonaldsData> GetMcdonaldsData()
        {
            List<McdonaldsData> mcdonaldsDataList = new List<McdonaldsData>
            {
                new McdonaldsData { Id = 1, Title = "Nasi Uduk", Subtitle = "Nasi dengan rempah", Image = "../../../Assets/List_Data_Image/nasi_uduk.png"},
                new McdonaldsData { Id = 2, Title = "Big Mac", Subtitle = "Burger daging sapi", Image = "../../../Assets/List_Data_Image/big_mac.png" },
                new McdonaldsData { Id = 3, Title = "CheeseBurger", Subtitle = "Berger dengan keju", Image = "../../../Assets/List_Data_Image/cheese_burger.jpg" },
                new McdonaldsData { Id = 4, Title = "Chicken", Subtitle = "Ayam goreng spicy", Image = "../../../Assets/List_Data_Image/spicy_chicken.jpg" },
                new McdonaldsData { Id = 5, Title = "Mc' Float", Subtitle = "Kopi float Mc'd", Image = "../../../Assets/List_Data_Image/mc_float.png" },
            };

            return mcdonaldsDataList;
        }

        public class McdonaldsData
        {
            public int Id { get; set; }
            public string Title { get; set; }
            public string Subtitle { get; set; }
            public string Image { get; set; }
        }
    }
}
