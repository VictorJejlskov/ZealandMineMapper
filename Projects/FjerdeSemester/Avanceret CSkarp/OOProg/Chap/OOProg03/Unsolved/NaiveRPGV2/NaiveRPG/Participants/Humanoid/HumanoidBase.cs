﻿namespace NaiveRPG.Participants.Humanoid
{
    /// <summary>
    /// Base class for Humanoid participants.
    /// These participants always start with at most
    /// 50 gold and four items
    /// </summary>
    public class HumanoidBase : ParticipantBase
    {
        public const int MaxInitialGold = 50;
        public const int MaxInitialItems = 4;


        public HumanoidBase(string name, int maxInitialHealthPoints, double maxDamage) 
            : base(name, maxInitialHealthPoints, MaxInitialGold, MaxInitialItems, maxDamage)
        {
        }
    }
}