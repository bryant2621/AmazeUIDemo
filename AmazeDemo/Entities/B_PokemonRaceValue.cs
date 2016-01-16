using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AmazeDemo.Entities
{
    /// <summary>
    /// 种族值
    /// </summary>
    public class B_PokemonRaceValue
    {
        public long Id { get; set; }
        public long PokId { get; set; }
        public int HP { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int SpecialAttack { get; set; }
        public int SpecialDefense { get; set; }
        public int Speed { get; set; }
    }
}