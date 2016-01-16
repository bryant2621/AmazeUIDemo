using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AmazeDemo.Entities
{
    /// <summary>
    /// 属性相克表
    /// </summary>
    public class B_TypeRestrain
    {
        public long Id { get; set; }
        public B_Type Type { get; set; }
        public B_Type FightType { get; set; }
        public decimal RestrainValue { get; set; }
    }
}