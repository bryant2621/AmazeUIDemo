using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AmazeDemo.Entities
{
    public class B_PokemonSkill
    {
        public long Id { get; set; }
        public long PokId { get; set; }
        public B_PokSkillType PokSkillType { get; set; }
        public long LearnCondition { get; set; }
        public long SkillId { get; set; }
    }
}