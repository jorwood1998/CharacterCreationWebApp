using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EarthKingdomCharacterCreationApp
{
    public class Attributes
    {
        public Strength _strength { get; set; }
        public Dexterity _dexterity { get; set; }
        public Constitution _constitution { get; set; }
        public Intelligence _intelligence { get; set; }
        public Wisdom _wisdom { get; set; }
        public Charisma _charisma { get; set; }

        public Attributes(Strength strength, Dexterity dexterity, Constitution constitution, Intelligence intelligence, Wisdom wisdom, Charisma charisma)
        {
            _strength = strength;
            _dexterity = dexterity;
            _constitution = constitution;
            _intelligence = intelligence;
            _wisdom = wisdom;
            _charisma = charisma;
        }
        public enum Strength
        {
            _6,
            _7,
            _8,
            _9,
            _10,
            _11,
            _12,
            _13,
            _14,
            _15,
            _16,
            _17,
            _18,
            _19,
            _20,
        }

        public enum Dexterity
        {
            _6,
            _7,
            _8,
            _9,
            _10,
            _11,
            _12,
            _13,
            _14,
            _15,
            _16,
            _17,
            _18,
            _19,
            _20,
        }

        public enum Constitution
        {
            _6,
            _7,
            _8,
            _9,
            _10,
            _11,
            _12,
            _13,
            _14,
            _15,
            _16,
            _17,
            _18,
            _19,
            _20,
        }

        public enum Intelligence
        {
            _6,
            _7,
            _8,
            _9,
            _10,
            _11,
            _12,
            _13,
            _14,
            _15,
            _16,
            _17,
            _18,
            _19,
            _20,
        }

        public enum Wisdom
        {
            _6,
            _7,
            _8,
            _9,
            _10,
            _11,
            _12,
            _13,
            _14,
            _15,
            _16,
            _17,
            _18,
            _19,
            _20,
        }
        public enum Charisma
        {
            _6,
            _7,
            _8,
            _9,
            _10,
            _11,
            _12,
            _13,
            _14,
            _15,
            _16,
            _17,
            _18,
            _19,
            _20,
        }

    }
}