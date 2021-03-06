﻿using AlphaTab.Model;
using AlphaTab.Rendering.Utils;

namespace AlphaTab.Rendering.Glyphs
{
    internal class BeamGlyph : MusicFontGlyph
    {
        public BeamGlyph(float x, float y, Duration duration, BeamDirection direction, bool isGrace)
            : base(x, y, isGrace ? NoteHeadGlyph.GraceScale : 1, GetSymbol(duration, direction, isGrace))
        {
        }

        public override void DoLayout()
        {
            Width = 0;
        }

        private static MusicFontSymbol GetSymbol(Duration duration, BeamDirection direction, bool isGrace)
        {
            if (isGrace)
            {
                duration = Duration.Eighth;
            }

            if (direction == BeamDirection.Up)
            {
                switch (duration)
                {
                    case Duration.Eighth: return MusicFontSymbol.FooterUpEighth;
                    case Duration.Sixteenth: return MusicFontSymbol.FooterUpSixteenth;
                    case Duration.ThirtySecond: return MusicFontSymbol.FooterUpThirtySecond;
                    case Duration.SixtyFourth: return MusicFontSymbol.FooterUpSixtyFourth;
                    case Duration.OneHundredTwentyEighth: return MusicFontSymbol.FooterUpOneHundredTwentyEighth;
                    case Duration.TwoHundredFiftySixth: return MusicFontSymbol.FooterUpTwoHundredFiftySixth;
                    default: return MusicFontSymbol.FooterUpEighth;
                }
            }

            switch (duration)
            {
                case Duration.Eighth: return MusicFontSymbol.FooterDownEighth;
                case Duration.Sixteenth: return MusicFontSymbol.FooterDownSixteenth;
                case Duration.ThirtySecond: return MusicFontSymbol.FooterDownThirtySecond;
                case Duration.SixtyFourth: return MusicFontSymbol.FooterDownSixtyFourth;
                case Duration.OneHundredTwentyEighth: return MusicFontSymbol.FooterDownOneHundredTwentyEighth;
                case Duration.TwoHundredFiftySixth: return MusicFontSymbol.FooterDownOneHundredTwentyEighth;
                default: return MusicFontSymbol.FooterDownEighth;
            }
        }
    }
}
