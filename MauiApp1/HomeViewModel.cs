using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1
{
    public class HomeViewModel : BindableObject
    {
        public HomeViewModel()
        {

        }

        public string Title { get; set; } = "Hello Ram";
    }
}
