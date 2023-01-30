using Microsoft.Xna.Framework;
using Terraria;
using DBZGoatLib.Model;
using Microsoft.Xna.Framework.Graphics;
using DBZGoatLib;
using DBZGoatLib.Handlers;
using Terraria.ModLoader;

namespace GohanFormPack.Transformations
{
    public class AuraStack : Transformation
    {
        public override AuraData AuraData() => new AuraData("DBZModPort/Effects/Animations/Aura/BaseAura", 4, BlendState.Additive, new Color(150,15,15));

        public override bool CanTransform(Player player)
        {
            return true;
        }

        public override string FormName() => "";

        public override string HairTexturePath() => "";

        public override Gradient KiBarGradient() => new Gradient(new Color(126, 37, 244)).AddStop(1f, new Color(255, 130, 145));

        public override void OnTransform(Player player) {
        }

        public override void PostTransform(Player player) {
        }

        public override bool SaiyanSparks() => false;

        public override SoundData SoundData() => new SoundData();

        public override bool Stackable() => true;

        public override Color TextColor() => Color.Black;
    }
}
