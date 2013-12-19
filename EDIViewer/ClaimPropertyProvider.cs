﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDIViewer
{
    public enum EdiDataType
    {
        Numeric=1,
        Decimal=2,
        Identifier=3, 
        String=4,
        Date=5,
        Time=6,
        Binary=7
    }
}
