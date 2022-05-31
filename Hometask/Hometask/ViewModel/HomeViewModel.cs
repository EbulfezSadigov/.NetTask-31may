using Hometask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hometask.ViewModel
{
    public class HomeViewModel
    {
        public List<Slider> sliders { get; set; }
        public List<Projects> projects { get; set; }
        public List<Features> features { get; set; }
        public List<News> news { get; set; }
        public List<Testimonials> ts { get; set; }
    }
}
