﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixacaoConceitosBasicos1.Model
{
   public class MetrosMilimetros
    {
        public static double Converter(double metros)
        {
            return metros * 1000; // 1 metro = 1000 milímetros
        }
    }
