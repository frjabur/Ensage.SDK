// <copyright file="sleight_of_fist.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.Abilities.npc_dota_hero_ember_spirit
{
    public class ember_spirit_sleight_of_fist : CircleAbility, IHasModifier
    {
        public ember_spirit_sleight_of_fist(Ability ability)
            : base(ability)
        {
        }
        
        public string ModifierName { get; } = "modifier_ember_spirit_sleight_of_fist_caster";
    
            protected override float RawDamage
        {
            get
            {
                var damage = this.Ability.GetAbilitySpecialData("base_damage");

                var bonus = this.Ability.GetAbilitySpecialData("attack_factor_tooltip") / 100.0f; // 70
                damage += bonus * (this.Owner.MinimumDamage + this.Owner.BonusDamage);

                return damage;
            }
    }
}
