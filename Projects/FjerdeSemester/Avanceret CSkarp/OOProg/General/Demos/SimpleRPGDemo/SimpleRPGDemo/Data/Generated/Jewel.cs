﻿namespace SimpleRPGDemo.Data
{
    public partial class Jewel
    {
        public override int Id { get; set; }
        public int JewelModelId { get; set; }
        public int? WeaponId { get; set; }
        public int CutQualityId { get; set; }

        public JewelCutQuality CutQuality { get; set; }
        public JewelModel JewelModel { get; set; }
        public Weapon Weapon { get; set; }
    }
}
