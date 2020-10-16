namespace Nerator.CS
{
    public class Character
    {
        public enum AlphabeticType
        {
            JB,
            JS,
            BS
        }

        public static AlphabeticType GetAlphabeticMode(string Type)
        {
            switch (Type)
            {
                case "JB":
                    return AlphabeticType.JB;
                case "JS":
                    return AlphabeticType.JS;
                default:
                    return AlphabeticType.BS;
            }
        }

        public static string GetAlphabeticMode(AlphabeticType Type)
        {
            switch (Type)
            {
                case AlphabeticType.JB:
                    return "JB";
                case AlphabeticType.JS:
                    return "JS";
                default:
                    return "BS";
            }
        }

        public enum SpecialType
        {
            JN,
            JS,
            NS
        }

        public static SpecialType GetSpecialMode(string Type)
        {
            switch (Type)
            {
                case "JN":
                    return SpecialType.JN;
                case "JS":
                    return SpecialType.JS;
                default:
                    return SpecialType.NS;
            }
        }

        public static string GetSpecialMode(SpecialType Type)
        {
            switch (Type)
            {
                case SpecialType.JN:
                    return "JN";
                case SpecialType.JS:
                    return "JS";
                default:
                    return "NS";
            }
        }
    }
}