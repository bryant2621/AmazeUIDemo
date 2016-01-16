using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AmazeDemo.Entities
{
    /// <summary>
    /// 培育
    /// </summary>
    public class B_PokemonCultivate
    {
        public long Id { get; set; }
        public long PokId { get; set; }
        public string EggGroup1 { get; set; }
        public string EggGroup2 { get; set; }
        /// <summary>
        /// 孵化步数
        /// </summary>
        public string HatchStep { get; set; }
        public decimal SexRatio { get; set; }
        /// <summary>
        /// 捕获度
        /// </summary>
        public int CaptureRatio { get; set; }
        /// <summary>
        /// 初始亲密度
        /// </summary>
        public int Cohesion { get; set; }
        public string MaxExp { get; set; }
        public string ExpGroup { get; set; }
        public string EffortValue { get; set; }
        public string BeatExp { get; set; }
        public string VSBeatExp { get; set; }
    }
}