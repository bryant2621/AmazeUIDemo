using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AmazeDemo.Entities
{
    public enum B_Target
    {        
        敌方单体 = 0,
        敌方全体 = 1,
        友方单体 = 2,
        友方全体 = 3,
        自身 = 4
    }
}