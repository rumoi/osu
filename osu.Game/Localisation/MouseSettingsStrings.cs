// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;

namespace osu.Game.Localisation
{
    public static class MouseSettingsStrings
    {
        private const string prefix = @"osu.Game.Resources.Localisation.MouseSettings";

        /// <summary>
        /// "Mouse"
        /// </summary>
        public static LocalisableString Mouse => new TranslatableString(getKey(@"mouse"), @"Mouse");

        private static string getKey(string key) => $@"{prefix}:{key}";
    }
}