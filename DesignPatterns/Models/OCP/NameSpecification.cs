using DesignPatterns.Interfaces;
using DesignPatterns.Models.OCP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Models
{

    public class NameSpecification : ISpecification<Product>
    {
        private string name;
        public NameSpecification(string name)
        {
            this.name = name;
        }

        public bool IsSpecified(Product t)
        {
            return t.Name.ToLower() == name.ToLower();
        }
    }
}
