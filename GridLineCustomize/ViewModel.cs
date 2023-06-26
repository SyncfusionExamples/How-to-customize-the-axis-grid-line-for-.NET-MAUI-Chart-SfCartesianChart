using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GridLineCustomize
{
    public class ViewModel
    {
        public List<Model> Data { get; set; }

        public ViewModel()
        {
            Data = new List<Model>()
        {
            new Model { Month = "Jan", Temperature = 36 },
            new Model { Month = "Feb", Temperature = 36 },
            new Model { Month = "Mar", Temperature = 39},
            new Model { Month = "Apr", Temperature = 43 },
            new Model { Month = "May", Temperature = 47 },
            new Model { Month = "Jun", Temperature = 53 },
            new Model { Month = "Jul", Temperature = 57 },
            new Model { Month = "Aug", Temperature = 57 },
            new Model { Month = "Sep", Temperature = 53 },
            new Model { Month = "Oct", Temperature = 48 },
            new Model { Month = "Nov", Temperature = 44 },
            new Model { Month = "Dec", Temperature = 37 },

        };
        }
    }
}
