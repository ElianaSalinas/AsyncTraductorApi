using System;
using System.Collections.Generic;
namespace AsyncTraductorApi.Models
{
    public class TranslationResult
    {
        public string OriginalText { get; set; }
        public string TranslatedText { get; set; }
        public string SourceLanguage { get; set; }
        public string TargetLanguage { get; set; }
        public double ProcessingTimeSeconds { get; set; }
    }
}
    
