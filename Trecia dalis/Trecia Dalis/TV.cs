using System;
using System.Collections.Generic;
using System.Text;

namespace Pirma_dalis.Trecia_Dalis
{
    class TV
    {
        public string channel;
        public string language;

        public void changeChannel(string channel)
        {
            this.channel = channel; 
        }

        public void changeLanguage(string language)
        {
            this.language = language;
        }
    }
}
