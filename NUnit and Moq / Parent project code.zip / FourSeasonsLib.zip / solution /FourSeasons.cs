using System;

namespace FourSeasonsLib
{
    public class FourSeasons
    {
        public string GetSeason(string month)
        {
            if (string.IsNullOrWhiteSpace(month))
                throw new ArgumentException("Month cannot be empty.");

            month = month.Trim().ToLower();

            switch (month)
            {
                case "february":
                case "march":
                    return "Spring";

                case "april":
                case "may":
                case "june":
                    return "Summer";

                case "july":
                case "august":
                    return "Monsoon";

                case "september":
                case "october":
                case "november":
                    return "Autumn";

                case "december":
                case "january":
                    return "Winter";

                default:
                    throw new ArgumentException("Invalid month.");
            }
        }
    }
}
