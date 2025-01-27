﻿using Avalonia.Media;

using System;

namespace AvaloniaEdit.AvaloniaMocks
{
    public class MockGlyphTypeface : IGlyphTypeface
    {
        public FontMetrics Metrics => new FontMetrics
        {
            DesignEmHeight = 10,
            Ascent = 2,
            Descent = 10,
            IsFixedPitch = true
        };

        public FontStretch Stretch { get; }
        public int GlyphCount => 1337;

        public FontSimulations FontSimulations => throw new NotImplementedException();

        public ushort GetGlyph(uint codepoint)
        {
            return (ushort)codepoint;
        }

        public ushort[] GetGlyphs(ReadOnlySpan<uint> codepoints)
        {
            return new ushort[codepoints.Length];
        }

        public int GetGlyphAdvance(ushort glyph)
        {
            return 8;
        }

        public bool TryGetGlyph(uint codepoint, out ushort glyph)
        {
            glyph = 8;

            return true;
        }

        public static int GlyphAdvance => 8;

        public int[] GetGlyphAdvances(ReadOnlySpan<ushort> glyphs)
        {
            var advances = new int[glyphs.Length];

            for (var i = 0; i < advances.Length; i++)
            {
                advances[i] = GlyphAdvance;
            }

            return advances;
        }

        public void Dispose() { }

        public bool TryGetTable(uint tag, out byte[] table)
        {
            table = null;
            return false;
        }

        public string FamilyName => "";
        public FontWeight Weight => FontWeight.Normal;
        public FontStyle Style => FontStyle.Normal;

        public bool TryGetGlyphMetrics(ushort glyph, out GlyphMetrics metrics)
        {
            metrics = new GlyphMetrics
            {
                Width = 10,
                Height = 10
            };

            return true;
        }
    }
}
