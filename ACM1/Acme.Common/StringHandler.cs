using System;

namespace Lacon.Common
{
    public static class StringHandler
    {
        public static string InsertSpaces(this string source)
        {
            string result = string.Empty;

            if (!string.IsNullOrEmpty(source))
            {
                foreach (char item in source)
                {
                    if (char.IsUpper(item))
                    {
                        result += " ";
                    }

                    result += item;
                }
            }

            result = result.Trim();
            return result;
        }
    }
}