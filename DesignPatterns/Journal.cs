﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class Journal
    {
        private readonly List<string> entries = new List<string>();
        private static int count = 0;
        public int AddEntry(string entry)
        {
            entries.Add($"{++count}: {entry}");
            return count;
        }

        public int RemoveEntry(string entry)
        {
            entries.Remove(entry);
            return count;
        }
        public override string ToString()
        {
            return string.Join(Environment.NewLine, entries);
        }

    }
}
