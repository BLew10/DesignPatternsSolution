using DesignPatterns.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Models
{
    public class AndSpecification : ISpecification<Product>
    {
        private IEnumerable<ISpecification<Product>> specs;
        public AndSpecification(IEnumerable<ISpecification<Product>> Specs)
        {
            this.specs = Specs;
        }

        public bool IsSpecified(Product t)
        {
            return specs.All(x => x.IsSpecified(t));
        }
    }

}
