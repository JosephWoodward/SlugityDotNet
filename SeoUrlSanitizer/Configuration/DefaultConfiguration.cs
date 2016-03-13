﻿namespace SeoUrlSanitizer.Configuration
{
    public abstract class DefaultConfiguration : IConfiguration
    {
        protected DefaultConfiguration()
        {
            TextCase = TextCase.LowerCase;
            StringSeparator = "-";
            MaxLength = null;
        }

        public TextCase TextCase { get; set; }

        public string StringSeparator { get; set; }

        public int? MaxLength { get; set; }
    }
}