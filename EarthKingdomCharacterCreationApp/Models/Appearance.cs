using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EarthKingdomCharacterCreationApp
{
    public class Appearance
    {
        public int Height { get; set; }
        public string Build { get; set; }
        public string HairStyle { get; set; }
        public string HairColor { get; set; }
        public string EyeColor { get; set; }
        public string SkinColor { get; set; }
        public string SpecialCharacteristics { get; set; }

        public Appearance(int height, string build, string hairStyle, string hairColor, string eyeColor, string skinColor, string specialCharacteristics)
        {
            height = Height;
            build = Build;
            hairStyle = HairStyle;
            hairColor = HairColor;
            eyeColor = EyeColor;
            skinColor = SkinColor;
            specialCharacteristics = SpecialCharacteristics;     
        }
        public enum Height { _60,_61 , _62, _63, _64, _65, _66, _67, _68, _69, _70, _71, _72, _73, _74, _75, _76, _77, _78 }
        public enum Build { Skinny, Strong, Athletic, Normal, Heavy, Overweight, Obese}
        public enum HairStyle { Afro,Afropuffs,Asymmetric cut,Bald,Bangs,Beehive,Bighair,Blowout,Bob cut,Bouffant,Bowlcut,Braid,Brush cut,Bun, Bunches,Burr,Businessman cut,Butch cut,Buzz cut,Caesar cut,Chignon,Chonmage,Chupryna,Combover,Conk,Cornrows,Crewcut,Crochetbraids,Croydonfacelift,Curlyhair,Curtained hair,Devilock,Didoflip, Digital, perm, Dreadlocks, Ducksass,Etoncrop, Extensions, Feathered hair , Fingerwave , Flattop,Fontange, Frenchbraid, Frenchtwist, Fringe, Frostedtips, Haircrimping, Harvardclip, High, Hi-topfade, Inductioncut, Ivy, League,Jewfro, Jhericurl,Kisscurl,Layered hair,Liberty spikes, Longhair ,Lobcut ,Marcelling, Mod cut, Mohawk, Mullet, Pageboy,Part,Payot,Pigtail,Pixie cut,Polish half shaven head,Pompadour,Ponytail,Punch perm,Princeton,Professional cut,Queue,Quiff,Rattail,Razor cut,Regular haircut, Ringlets, ShagShape-Up, Shimada, Short back and sides, Short brush cut, Short hair, Spiky hair, Straight hair, Standard haircut, Surfer hair, Taper cut,Temple, Fade,Tonsure, UpdoUndercut, Victory rolls, WavesWidows peak, Wings}
        public enum HairColor {Auburn, Red, Blond, Gray, White, Black, Brown, Stawberry Blond, Dirty Blond, Copper, Platinum Blond, Chestnut Brown  }
        public enum EyeColor { Amber, Blue, Brown, Gray, Green, Hazel, Violet, Black}
        public enum SkinColor { White, Pale, Fair, Light Brown, Brown, Dark Brown}

    }
}