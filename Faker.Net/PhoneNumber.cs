using System;
using Faker.Extensions;

namespace Faker
{
    public static class PhoneNumber
    {
        public static string GetPhoneNumber(string[] PhoneNumbers)
        {
            return PhoneNumbers.Rand().Numerify();
        }

        public static string GetAusPhoneNumber()
        {
            return GetPhoneNumber(AusPhoneNumberFormats);
        }

        public static string GetUSPhoneNumber()
        {
            return GetPhoneNumber(USPhoneNumberFormats);
        }

        public static string GetShortPhoneNumber()
        {
            return "###-###-####".Numerify();
        }

        static readonly string[] AusPhoneNumberFormats = new[]
        {
            "04########",
            "0#########",
            "+(61)4########",
            "+(61)#########",
            "+614########",
            "+61#########"
        };

        static readonly string[] USPhoneNumberFormats = new[]
        {
            "###-###-#### x#####",
            "###-###-#### x####",
            "###-###-#### x###",
            "###-###-####",
            "###.###.#### x#####",
            "###.###.#### x####",
            "###.###.#### x###",
            "###.###.####",
            "(###)###-#### x#####",
            "(###)###-#### x####",
            "(###)###-#### x###",
            "(###)###-####",
            "1-###-###-#### x#####",
            "1-###-###-#### x####",
            "1-###-###-#### x###",
            "1-###-###-####"
        };
        
		[Obsolete]
        public static string ShortPhoneNumber()
        {
			return GetShortPhoneNumber();
        }
    }
}
