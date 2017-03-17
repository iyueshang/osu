﻿// Copyright (c) 2007-2017 ppy Pty Ltd <contact@ppy.sh>.
// Licensed under the MIT Licence - https://raw.githubusercontent.com/ppy/osu/master/LICENCE

namespace osu.Game.Beatmaps.Legacy
{
    /// <summary>
    /// A type of Beatmap loaded from a legacy .osu beatmap file (version &lt;=15).
    /// </summary>
    internal class LegacyBeatmap : Beatmap, IIsLegacy
    {
        /// <summary>
        /// Constructs a new beatmap.
        /// </summary>
        /// <param name="original">The original beatmap to use the parameters of.</param>
        public LegacyBeatmap(Beatmap original = null)
            : base(original)
        {
        }
    }
}
