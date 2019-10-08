using System;

namespace HelloWorld
{
    public class Hello
    {
        private IMultiLanguage multilang;

        public Hello(IMultiLanguage multilanguage) {
            this.multilang = multilanguage;
        }
        public string Greeting(String lang, string name) 
        {
            return this.multilang.GetWorld(lang, "Hello") + " " + this.multilang.GetWorld(lang, name);
        }
    }
}
