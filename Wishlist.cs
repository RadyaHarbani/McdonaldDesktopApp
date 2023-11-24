using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McdonaldDesktopApp
{
    public class Wishlist
    {
        private static Wishlist instance;
        private List<DataCatalogue.McdonaldsData> selectedMcdonaldsData;

        private Wishlist()
        {
            selectedMcdonaldsData = new List<DataCatalogue.McdonaldsData>();
        }

        public static Wishlist Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Wishlist();
                }
                return instance;
            }
        }

        public List<DataCatalogue.McdonaldsData> SelectedMcdonaldsData
        {
            get { return selectedMcdonaldsData; }
        }

        public void AddSelectedData(DataCatalogue.McdonaldsData mcdonaldsData)
        {
            selectedMcdonaldsData.Add(mcdonaldsData);
        }
    }
}
