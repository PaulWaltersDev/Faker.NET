using System;
using Faker.Extensions;

namespace Faker
{
    public static class Education
    {
        public static string GetDegreeShort()
        {
            return DEGREE_SHORT_PREFIX.Rand() + " in " + GetMajor();
        }

        public static string GetDegree()
        {
            return DEGREE_PREFIX.Rand() + " in " + GetMajor();
        }

        public static string GetMajor()
        {
            return MAJOR_ADJ.Rand() + " " + MAJOR_NOUN.Rand();
        }

        public static string GetSchoolName()
        {
            return SCHOOL_PREFIX.Rand() + SCHOOL_SUFFIX.Rand();
        }

        public static string GetSchoolGenericName()
        {
            switch (FakerRandom.Rand.Next(2))
            {
                case 0: return Address.GetUSState();
                default: return GetSchoolName();

            }
        }

        public static string GetSchool()
        {
            switch (FakerRandom.Rand.Next(5))
            {
                case 0:
                case 1: return  GetSchoolName()+ " " +SCHOOL_TYPE.Rand();
                case 2: return  GetSchoolGenericName()+ " " + SCHOOL_ADJ.Rand() + " " + SCHOOL_TYPE.Rand();
                case 3: return  SCHOOL_UNI.Rand() + " of " + GetSchoolGenericName();
                default: return GetSchoolGenericName() + " " + SCHOOL_TYPE.Rand() + " of " + MAJOR_NOUN.Rand();
            }
        }

        public static string GetAusUni()
        {
            return AUS_UNI_NAME.Rand();
        }
		
		[Obsolete]
        public static string DegreeShort()
        {
			return GetDegreeShort();
        }
		
		[Obsolete]
        public static string Degree()
        {
			return GetDegree();
        }
		
		[Obsolete]
        public static string Major()
        {
			return GetMajor();
        }
		
		[Obsolete]
        public static string SchoolName()
        {
			return GetSchoolName();
        }
		
		[Obsolete]
        public static string SchoolGenericName()
        {
			return GetSchoolGenericName();
        }
		
		[Obsolete]
        public static string School()
        {
			return GetSchool();
        }

        static readonly string[] DEGREE_SHORT_PREFIX = new[] { "AB", "BS", "BSc", "MA", "MD", "DMus", "DPhil" };
        static readonly string[] DEGREE_PREFIX = new[] { "Bachelor of Science", "Bachelor of Arts", "Master of Arts", "Doctor of Medicine", "Bachelor of Music", "Doctor of Philosophy" };
        static readonly string[] MAJOR_ADJ = new[] { "Business", "Systems", "Industrial", "Medical", "Financial", "Marketing", "Political", "Social", "Human", "Resource" };
        static readonly string[] MAJOR_NOUN = new[] { "Science", "Arts", "Administration", "Engineering", "Management", "Production", "Economics", "Architecture", "Accountancy", "Education", "Development", "Philosophy", "Studies" };

        static readonly string[] SCHOOL_PREFIX = new[] { "Green", "South", "North", "Wind", "Lake", "Hill", "Lark", "River", "Red", "White" };
        static readonly string[] SCHOOL_SUFFIX = new[] { "wood", "dale", "ridge", "ville", "point", "field", "shire", "shore", "crest", "spur", "well", "side", "coast" };
        static readonly string[] SCHOOL_ADJ = new[] { "International", "Global", "Polytechnic", "National" };
        static readonly string[] SCHOOL_TYPE = new[] { "School", "University", "College", "Institution", "Academy" };
        static readonly string[] SCHOOL_UNI = new[] { "University", "College" };

        static readonly string[] AUS_UNI_NAME = new[]{
                "Australian Catholic University",
    "Australian National University",
    "Bond University",
    "Carnegie Mellon University - Australia",
    "Central Queensland University",
    "Charles Darwin University",
    "Charles Sturt University",
    "Curtin University",
    "Deakin University",
    "Edith Cowan University",
    "Federation University Australia",
    "Flinders University",
    "Griffith University",
    "James Cook University",
    "La Trobe University",
    "Macquarie University",
    "Monash University",
    "Murdoch University",
    "Queensland University of Technology",
    "Royal Melbourne Institute of Technology",
    "Southern Cross University",
    "Swinburne University of Technology",
    "Torrens University Australia",
    "University of Adelaide",
    "The University of Canberra",
    "The University of Divinity",
    "University of Melbourne",
    "University of New England",
    "University of New South Wales",
    "The University of Newcastle",
    "The University of Notre Dame Australia",
    "University of Queensland",
    "University of South Australia",
    "University of Southern Queensland",
    "University of the Sunshine Coast",
    "University of Sydney",
    "University of Tasmania",
    "University of Technology, Sydney",
    "The University of Western Australia",
    "Western Sydney University",
    "University of Wollongong",
    "Victoria University"
        };
    }
}
