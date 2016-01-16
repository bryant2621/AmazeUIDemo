using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AmazeDemo.Entities
{
    /// <summary>
    /// 形态
    /// </summary>
    public class B_PokemonForm
    {
        public long Id { get; set; }
        public long PokId { get; set; }
        public string FormName { get; set; }
        public long FormPokId { get; set; }
    }
}