using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace lab
{
    class SClass
    {
        public string StoredText;
        public SClass(string NString)
        {
            Regex regex=new Regex(@"[\p{Ll}]+");
            MatchCollection matchedAuthors = regex.Matches(NString);
            StoredText = "";
            foreach (Match match in matchedAuthors)
            {
                StoredText += match.Value;
            }
        }
        public int length()
        {
            return StoredText.Length;
        }
        public string sort()
        {
            return StoredText = string.Concat(StoredText.OrderBy(ch => ch));
        }
        public void outputToConsole()
        {
            Console.WriteLine(StoredText);
        }
        public override string ToString()
        {
            return StoredText;
        }
    }
}
