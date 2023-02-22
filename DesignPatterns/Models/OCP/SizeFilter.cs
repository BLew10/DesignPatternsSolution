using DesignPatterns.Interfaces;
using DesignPatterns.Interfaces.OCP;
using DesignPatterns.Models.OCP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Models
{
    public class SizeFilter : IFilter<Product>
    {
        public IEnumerable<Product> Filter(IEnumerable<Product> items, ISpecification<Product> spec)
        {
            foreach (var i in items)
            {
                if (spec.IsSpecified(i))
                {
                    yield return i;
                }
            }
        }
    }
}
