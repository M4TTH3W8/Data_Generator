namespace Data_Generator.Services.DataGenerator
{
    public static class ExtensionsForString
    {
        public static string MaximumLengthOfData(this string str, int? max = null)
        {
            if (max != null && str.Length > max)
            {
                return str.Substring(0, max.Value);
            }
            return str;
        }
    }
}
