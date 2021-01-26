using GameDemo.SalesPlatform.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.SalesPlatform.Entities
{
    public class Games : IEntity
    {
        public string GameName { get; set; }
        public double GamePrice { get; set; }
    }
}
