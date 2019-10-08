using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    public class Translator : IMultiLanguage
    {
        Dictionary<string, string> ruDict = new Dictionary<string, string>() { {"Hello", "Привет" }, { "John", "Джон"} };
        Dictionary<string, string> enDict = new Dictionary<string, string>() { { "Hello", "Hello" }, { "John", "John" } };
        public string GetWorld(string lang, string word)
        {
            if (lang == "ru")
            {
                return ruDict[word];
            }
            else {
                return enDict[word];
            }
        }
    }
}
