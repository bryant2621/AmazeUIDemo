using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AmazeDemo.Entities
{
    public class B_PokemonInfo
    {
        public long Id { get; set; }
        public string HandbookId { get; set; }
        public string ChName { get; set; }
        public string EnName { get; set; }
        public string JpName { get; set; }
        public string PokCategoryName { get; set; }
        public B_Type PokType1 { get; set; }
        public B_Type PokType2 { get; set; }
        public string PokFeature1 { get; set; }
        public string PokFeature2 { get; set; }
        public string PokHiddenFeature { get; set; }
        public string PokHeight { get; set; }
        public string PokWeight { get; set; }
        public string HandbookMemo { get; set; }
        public string HandbookImage { get; set; }
        public string NormalImage { get; set; }
        public string FightImage { get; set; }
        public string FlashNormalImage { get; set; }
        public string FlashFightImage { get; set; }
    }
}