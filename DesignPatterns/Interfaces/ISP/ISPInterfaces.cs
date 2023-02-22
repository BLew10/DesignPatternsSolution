using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Models.ISP;

namespace DesignPatterns.Interfaces.ISP
{
    public interface IPrinter
    {
        void Print(Document d);

    }
    public interface IScanner
    {
        void Scan(Document d);
    }
    public interface IFaxer
    {
        void Fax(Document d);
    }

    public interface IMultiFunctionDevice : IPrinter, IScanner, IFaxer
    {


    }
}
