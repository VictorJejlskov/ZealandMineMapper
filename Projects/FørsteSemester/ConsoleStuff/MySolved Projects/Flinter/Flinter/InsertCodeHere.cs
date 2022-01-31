using System;

namespace Flinter
{
    public class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            Profile profile1 = new Profile(Profile.Gender.Man, Profile.EyeColor.Blue, Profile.HairColor.Brown, Profile.HeightCategory.VeryTall);
            Profile profile2 = new Profile(Profile.Gender.Man, Profile.EyeColor.Brown, Profile.HairColor.Black, Profile.HeightCategory.Medium);
            Profile profile3 = new Profile(Profile.Gender.Man, Profile.EyeColor.Green, Profile.HairColor.Blond, Profile.HeightCategory.Short);
            Profile profile4 = new Profile(Profile.Gender.Woman, Profile.EyeColor.Red, Profile.HairColor.Grey, Profile.HeightCategory.Tall);
            Profile profile5 = new Profile(Profile.Gender.Woman, Profile.EyeColor.Blue, Profile.HairColor.White, Profile.HeightCategory.VeryShort);
            Profile profile6 = new Profile(Profile.Gender.Woman, Profile.EyeColor.Green, Profile.HairColor.Brown, Profile.HeightCategory.Unknown);

            Console.WriteLine(profile1.Description);
            Console.WriteLine(profile2.Description);
            Console.WriteLine(profile3.Description);
            Console.WriteLine(profile4.Description);
            Console.WriteLine(profile5.Description);
            Console.WriteLine(profile6.Description);

            // The LAST line of code should be ABOVE this line
        }
    }
}