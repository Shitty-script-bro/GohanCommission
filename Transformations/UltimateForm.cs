using Microsoft.Xna.Framework;
using Terraria;
using DBZGoatLib.Model;
using Microsoft.Xna.Framework.Graphics;
using DBZGoatLib;
using Terraria.ModLoader;
using DBZGoatLib.Handlers;

namespace GohanFormPack.Transformations
{
    public class UltimateForm : Transformation
    {
        public override AuraData AuraData() => new AuraData("DBZModPort/Effects/Animations/Aura/BaseAura", 4, BlendState.Additive, new Color(175, 175, 180));

        public override bool CanTransform(Player player)
        {
            return true;
        }

        public override string FormName() => "Ultimate";

        public override string HairTexturePath() => "GohanFormPack/Assets/UltimateHair";

        public override Gradient KiBarGradient() => new Gradient(new Color(100, 230, 255)).AddStop(1f, new Color(220, 220, 230));


        public override void OnTransform(Player player) {
        }

        public override void PostTransform(Player player) { 
        
        }

        public override bool SaiyanSparks() => true;

        public override SoundData SoundData() => new SoundData("DBZMODPORT/Sounds/SSJAscension", "DBZMODPORT/Sounds/SSJ3", 260);

        public override bool Stackable() => true;

        public override Color TextColor() => Color.WhiteSmoke;

        public override void SetStaticDefaults()
        {
            damageMulti = 1.5f; 
            speedMulti = 1.2f; 

            kiDrainRate = 2f;
            kiDrainRateWithMastery = 0.75f;

            attackDrainMulti = 1.5f; 
            baseDefenceBonus = 24;

            base.SetStaticDefaults(); // ALWAYS call this somewhere in your SetStaticDefaults()!
        }
    }
}
