using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeStudy.Components.PartialClass
{
    internal class Product
    {
        public bool IsActive { get; set; }
        public string ActiveText
        {
            get
            {
                return (IsActive) ? "Актуален" : "Нет в наличии";
            }
        }
    }
}
