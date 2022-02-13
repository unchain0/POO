namespace System
{
    internal static class StringExtensions
    {
        public static string Cut(this string thisObj, int count)
        {
            if (thisObj.Length < count)
            {
                // throw new Exception("Count larger than string.");
                return "Count larger than string.";
            }
            else if (thisObj.Length == count)
            {
                return thisObj;
            }
            else
            {
                return thisObj[..count] + "...";
            }
        }
    }
}
