using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

using DBZGoatLib;
using DBZGoatLib.Model;

namespace GohanFormPack
{
    public class PanelHandler : TransformationTree
    {
        public override bool Complete()
        {
            return false;
        }

        public override bool Condition(Player player) => true;

        public override string Name()
        {
            return "Hello";
        }

        public bool UnlockCondition(Player player)
        {
            return player.GetModPlayer<GPlayer>().Trait == "Prodigy";
        }

        public bool UnlockCondition2(Player player)
        {
            return player.GetModPlayer<GPlayer>().Trait == "Prodigy" && player.GetModPlayer<GPlayer>().GetMastery(ModContent.BuffType<Transformations.UltimateForm>()) >= 1;
        }

        public bool DiscoverCondition(Player player)
        {
            return true;
        }

        public override Node[] Nodes() => new Node[]
        {
            new Node(5, 0, "UltimateForm", "GohanFormPack/Transformations/UltimateForm", "Only people of prodigy may achieve this power.", UnlockCondition, DiscoverCondition),
            new Node(6, 0, "BeastForm", "GohanFormPack/Transformations/BeastForm", "Only people of prodigy may achieve this power.", UnlockCondition2, DiscoverCondition)

        };

        public override Connection[] Connections() => new Connection[]
        {
            new Connection(5,0,1,false,new Gradient(Color.WhiteSmoke).AddStop(0.65f, new Color(180, 76, 255)))
        };


    }
}
