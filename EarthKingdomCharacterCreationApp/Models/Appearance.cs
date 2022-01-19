using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EarthKingdomCharacterCreationApp
{
    public class Appearance
    {

        public string SpecialCharacteristics { get; set; }

        public Appearance(int height, string build, string hairStyle, string hairColor, string eyeColor, string skinColor, string specialCharacteristics)
        {
                 
        }
        public enum Height { _60,_61 , _62, _63, _64, _65, _66, _67, _68, _69, _70, _71, _72, _73, _74, _75, _76, _77, _78 }
        public enum Build { Skinny, Strong, Athletic, Normal, Heavy, Overweight, Obese}
        public enum HairStyle { Afro,Afropuffs,Asymmetric_cut, Bald, Bangs, Beehive, Bighair, Blowout, Bob_cut,Bouffant,Bowlcut,Braid,Brush_cut,Bun, Bunches,Burr,Businessman_cut,Butch_cut,Buzz_cut,Caesar_cut, Chignon, Chonmage, Chupryna, Combover, Conk, Cornrows, Crewcut,Crochetbraids,Croydonfacelift,Curlyhair,Curtained_hair,Devilock,Didoflip, Digital, perm, Dreadlocks, Ducksass,Etoncrop, Extensions, Feathered_hair , Fingerwave , Flattop,Fontange, Frenchbraid, Frenchtwist, Fringe, Frostedtips, Haircrimping, Harvardclip, High, Hi_topfade, Inductioncut, Ivy, League,Jewfro, Jhericurl,Kisscurl,Layered_hair,Liberty_spikes, Longhair ,Lobcut ,Marcelling, Mod_cut, Mohawk, Mullet, Pageboy, Part, Payot,Pigtail,Pixie_cut,Polish_half_shaven_head,Pompadour,Ponytail,Punch_perm,Princeton,Professional_cut,Queue,Quiff,Rattail,Razor_cut,Regular_haircut, Ringlets, ShagShape_Up, Shimada, Short_back_and_sides, Short_brush_cut, Short_hair, Spiky_hair, Straight_hair, Standard_haircut, Surfer_hair, Taper_cut,Temple, Fade,Tonsure, UpdoUndercut, Victory_rolls, WavesWidows_peak, Wings}
        public enum HairColor {Auburn, Red, Blond, Gray, White, Black, Brown, Stawberry_Blond, Dirty_Blond, Copper, Platinum_Blond, Chestnut_Brown  }
        public enum EyeColor { Amber, Blue, Brown, Gray, Green, Hazel, Violet, Black}
        public enum SkinColor { White, Pale, Fair, Light_Brown, Brown, Dark_Brown}

    }
}