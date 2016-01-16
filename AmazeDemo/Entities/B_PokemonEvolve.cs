using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AmazeDemo.Entities
{
    /// <summary>
    /// 进化
    /// </summary>
    public class B_PokemonEvolve
    {
        public long Id { get; set; }
        public long PokId { get; set; }
        public B_EvolveType EvolveType { get; set; }
        public int Condition { get; set; }
        public string SpecialCondition { get; set; }
        public long TargetPokId { get; set; }
    }
}