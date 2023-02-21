using DesignPatterns;
using DesignPatterns.Interfaces;
using DesignPatterns.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

static int Area(Rectangle r) => r.Width * r.Height;
Rectangle rc = new Rectangle(4,8);
WriteLine(Area(rc));

WriteLine(rc.ToString());

Rectangle sq = new Square(3);

WriteLine(sq);
