﻿// <copyright file="night_stalker_crippling_fear.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.Abilities.npc_dota_hero_night_stalker
{
    public class night_stalker_crippling_fear : RangedAbility, IHasTargetModifier
    {
        public night_stalker_crippling_fear(Ability ability)
            : base(ability)
        {
        }

        public string TargetModifierName { get; } = "modifier_night_stalker_crippling_fear";
    }
}