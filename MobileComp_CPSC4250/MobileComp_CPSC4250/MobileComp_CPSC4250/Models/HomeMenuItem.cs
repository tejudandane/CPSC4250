using System;
using System.Collections.Generic;
using System.Text;

namespace MobileComp_CPSC4250.Models
{
    public enum MenuItemType
    {
        Items,
        About,
        Game
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
