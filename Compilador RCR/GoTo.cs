﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Compilador_RCR
{
    public class GoTo
    {
        public List<string> Jump = new List<string>();
        public List<Int32> adr = new List<Int32>();

        public void add(Int32 offset, string f, Int32 a)
        {
            if (f[f.Length - 1] == ':') f = f.Remove(f.Length - 1);
            Jump.Add(f);
            adr.Add((a * 16) + offset);
        }

        public bool find(string f)
        {
            if (f[f.Length - 1] == ':') f = f.Remove(f.Length - 1);

            foreach (string i in Jump)
                if (i == f) return true;
            return false;
        }

        public Int32 getADR(string f)
        {
            for (Int32 i = 0; i < adr.Count; i++)
                if (f == Jump[i]) return adr[i];
            return -1;
        }
    }
}
