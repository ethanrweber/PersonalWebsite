using System.Collections.Generic;
using System.Linq;

namespace PersonalWebsite.Other.HelperClasses
{
    public static class NavbarConstants
    {
        public enum NavbarKeys
        {
            Privacy,
            Home,
            About,
        }
        public static readonly Dictionary<string, string> NavbarValues = new()
        {
            { NavbarKeys.Privacy.ToString(), "/Privacy" },
            { NavbarKeys.Home.ToString(), "/Index" },
            { NavbarKeys.About.ToString(), "/About" }
        };

        public static (Dictionary<string, string>, string, string) GetPagerValues(string key)
        {
            if(NavbarValues.ContainsKey(key))
            {
                List<string> keyValues = NavbarValues.Keys.ToList();
                int index = keyValues.IndexOf(key);

                int leftIndex = index - 1;
                if (leftIndex < 0) leftIndex = keyValues.Count - 1;
                int rightIndex = index + 1;
                if (rightIndex >= keyValues.Count) rightIndex = 0;

                var leftKey = keyValues[leftIndex];
                var rightKey = keyValues[rightIndex];

                return (NavbarValues, leftKey, rightKey);
            }

            // default pager values
            return (NavbarValues, "Privacy", "Home");
        }
    }
}
