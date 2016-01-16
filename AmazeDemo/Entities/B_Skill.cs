using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AmazeDemo.Entities
{
    public class B_Skill
    {
        public long Id { get; set; }
        public string SkillName { get; set; }
        public B_SkillCategory SkillCategory { get; set; }
        public B_Type SkillType { get; set; }
        public int Power { get; set; }
        public int HitRate { get; set; }
        public int PP { get; set; }
        /// <summary>
        /// 优先级
        /// </summary>
        public int PriorityRate { get; set; }
        /// <summary>
        /// 会心一击等级
        /// </summary>
        public int CritRate { get; set; }
        public B_Target SkillTarget { get; set; }
        public B_Target AdditionalTarget { get; set; }
        public string Memo { get; set; }
    }
}