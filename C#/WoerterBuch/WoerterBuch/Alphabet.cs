using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoerterBuch
{
    class Alphabet
    {
        private List<string> alphabetList  = new List<string>();
        public List<string> AlphabetList
        {
            get
            {
                return alphabetList;
            } 
        }

      
        public void fillAlphabetList()
        {
            alphabetList.Add("A");
            alphabetList.Add("B");
            alphabetList.Add("C");
            alphabetList.Add("D");
            alphabetList.Add("E");
            alphabetList.Add("F");
            alphabetList.Add("G");
            alphabetList.Add("H");
            alphabetList.Add("I");
            alphabetList.Add("J");
            alphabetList.Add("K");
            alphabetList.Add("L");
            alphabetList.Add("M");
            alphabetList.Add("N");
            alphabetList.Add("O");
            alphabetList.Add("P");
            alphabetList.Add("Q");
            alphabetList.Add("R");
            alphabetList.Add("S");
            alphabetList.Add("T");
            alphabetList.Add("U");
            alphabetList.Add("V");
            alphabetList.Add("W");
            alphabetList.Add("X");
            alphabetList.Add("Y");
            alphabetList.Add("Z");
        }
    }
}
