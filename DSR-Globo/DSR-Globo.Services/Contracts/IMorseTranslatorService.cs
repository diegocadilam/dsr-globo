using System;
using System.Collections.Generic;
using System.Text;

namespace DSR_Globo.Services.Contracts
{
    public interface IMorseTranslatorService
    {
        string Translate(string morseCode);
    }
}
