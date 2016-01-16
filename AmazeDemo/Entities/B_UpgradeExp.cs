using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AmazeDemo.Entities
{
    public class B_UpgradeExp
    {
        public long Id { get; set; }
        public int Level { get; set; }
        public string ExpGroup { get; set; }
        public string ExpValue { get; set; }
    }
}