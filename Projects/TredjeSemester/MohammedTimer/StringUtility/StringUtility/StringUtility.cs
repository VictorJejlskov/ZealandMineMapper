namespace StringUtility
{
    public class StringUtility
    {
        public int CountOccurences(string stringToCheck, string stringToFind)
        {
            var stringAsCharArray = stringToCheck.ToLower().ToCharArray();
            var stringToCheckForAsChar = stringToFind.ToLower().ToCharArray()[0];
            var occuranceCount = 0;
            for(var characterIndex = 0; characterIndex < stringAsCharArray.Length; characterIndex++)
            {
                if (stringAsCharArray[characterIndex] == stringToCheckForAsChar)
                {
                    occuranceCount++;
                }
            }
            return occuranceCount;
        }
    }
}