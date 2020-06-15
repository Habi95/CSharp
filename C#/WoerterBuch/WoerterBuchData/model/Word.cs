using System;
using System.Collections.Generic;
using System.Text;

namespace WoerterBuchData.model
{
   public class Word
    {
        public int? Id { get; set; }
        public string WordName { get; set; }

        public string NationalCode { get; set; }

        public Word(int? id, string wordName, string nationalCode)
        {
            Id = id;
            WordName = wordName;
            NationalCode = nationalCode;
        }
    }

}
