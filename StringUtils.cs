using System.Linq;

namespace ThirtyDaysofTDD.UnitTests
{
    class StringUtils
    {
        public int FindNumberOfOccurences(string sentenceToScan, string characterToScanFor)
        {
            var stringToCheckAsCharacterArray = sentenceToScan.ToCharArray();
            var characterToCheckFor = char.Parse(characterToScanFor);

            return stringToCheckAsCharacterArray.Count(currentchar => currentchar == characterToCheckFor);
        }
    }
}
