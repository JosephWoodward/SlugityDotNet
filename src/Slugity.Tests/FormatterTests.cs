﻿using Shouldly;
using SlugityLib.Configuration;
using Xunit;

namespace SlugityLib.Tests
{
    public class FormatterTests
    {
        [Fact]
        private void ShouldBeLowerCase()
        {
            var configuration = new SlugityConfig
            {
                TextCase = TextCase.LowerCase,
                StringSeparator = ' '
            };

            var slugity = new Slugity(configuration);

            string before = "THIS SHOULD BE LOWERCASE";
            string after = "this should be lowercase";

            string result = slugity.GenerateSlug(before);
            result.ShouldBe(after);
        }

        [Fact]
        private void ShouldBeUpperCase()
        {
            var configuration = new SlugityConfig
            {
                TextCase = TextCase.UpperCase,
                StringSeparator = ' '
            };

            var slugity = new Slugity(configuration);

            string before = "this should be UPPERCASE";
            string after = "THIS SHOULD BE UPPERCASE";

            string result = slugity.GenerateSlug(before);
            result.ShouldBe(after);
        }

        [Fact]
        private void ShouldBeSeparatedByHyphens()
        {
            var configuration = new SlugityConfig
            {
                TextCase = TextCase.LowerCase,
                StringSeparator = '-'
            };

            var slugity = new Slugity(configuration);

            string before = "this should be lowercase";
            string after = "this-should-be-lowercase";

            string result = slugity.GenerateSlug(before);
            result.ShouldBe(after);
        }

        [Fact]
        private void ShouldBeSeparatedByUnderscores()
        {
            var configuration = new SlugityConfig
            {
                TextCase = TextCase.LowerCase,
                StringSeparator = '_'
            };

            var slugity = new Slugity(configuration);

            string before = "this should be lowercase";
            string after = "this_should_be_lowercase";

            string result = slugity.GenerateSlug(before);
            result.ShouldBe(after);
        }

        [Fact]
        private void ShouldRemoveStopWords()
        {
            var configuration = new SlugityConfig
            {
                TextCase = TextCase.LowerCase,
                StringSeparator = ' ',
                StripStopWords = true
            };

            var slugity = new Slugity(configuration);

            string before = "This then that should remain";
            string after = "this should remain";

            string result = slugity.GenerateSlug(before);
            result.ShouldBe(after);
        }

        [Fact]
        private void ShouldReplaceCharacters()
        {
            var configuration = new SlugityConfig
            {
                TextCase = TextCase.Ignore,
                StringSeparator = ' '
            };

            configuration.ReplacementCharacters.Add("Hello", "Goodbye");

            var slugity = new Slugity(configuration);

            string before = "Hello World";
            string after = "Goodbye World";

            string result = slugity.GenerateSlug(before);
            result.ShouldBe(after);
        }
    }
}