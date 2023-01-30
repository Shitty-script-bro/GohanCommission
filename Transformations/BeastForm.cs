using Microsoft.Xna.Framework;
using Terraria;
using DBZGoatLib.Model;
using Microsoft.Xna.Framework.Graphics;
using DBZGoatLib;
using DBZGoatLib.Handlers;
using Terraria.ModLoader;

namespace GohanFormPack.Transformations
{
    public class BeastForm : Transformation
    {
        public override AuraData AuraData() => new AuraData("GohanFormPack/Assets/BaseAura", 4, BlendState.AlphaBlend, new Color(145, 50, 255)); //145,50,255

        public override bool CanTransform(Player player)
        {
            return player.GetModPlayer<GPlayer>().Trait == "Prodigy" && player.GetModPlayer<GPlayer>().GetMastery(ModContent.BuffType<Transformations.UltimateForm>()) >= 1;

        }

        public override string FormName() => "Beast";

        public override string HairTexturePath() => "GohanFormPack/Assets/BeastHair";

        public override Gradient KiBarGradient() => new Gradient(new Color(126,37,244)).AddStop(1f, new Color(255,130,145));

        public override void OnTransform(Player player) {
            TransformationHandler.Transform(player, (TransformationInfo)TransformationHandler.GetTransformation(ModContent.BuffType<Transformations.AuraStack>()));

        }

        public override void PostTransform(Player player) {
            TransformationHandler.ClearTransformations(player);
        }

        public override bool SaiyanSparks() => true;

        public override SoundData SoundData() => new SoundData("DBZMODPORT/Sounds/SSJAscension", "DBZMODPORT/Sounds/SSG", 260);

        public override bool Stackable() => false;

        public override Color TextColor() => Color.Lavender;

        public override void SetStaticDefaults()
        {
            damageMulti = 2f; 
            speedMulti = 1.4f; 

            kiDrainRate = 3f;
            kiDrainRateWithMastery = 1f;

            attackDrainMulti = 1.75f; 
            baseDefenceBonus = 30;

            base.SetStaticDefaults(); // ALWAYS call this somewhere in your SetStaticDefaults()!
        }
    }
}
