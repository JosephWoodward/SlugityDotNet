﻿namespace SeoUrlSanitizer.Configuration
{
    public abstract class DefaultConfiguration : IConfiguration
    {
        protected DefaultConfiguration()
        {
            TextCase = TextCase.LowerCase;
            StringSeparator = '-';
            MaxLength = null;
            ReplacementCharacters = new CharacterReplacement();
            EnableStopWords = false;
        }

        public TextCase TextCase { get; set; }

        public char StringSeparator { get; set; }

        public int? MaxLength { get; set; }

        public CharacterReplacement ReplacementCharacters { get; set; }

        public bool EnableStopWords { get; set; }
    }
}