using System.Security.Cryptography;
using System.Text;
using Core.Helper.Common;

namespace Core.Helper.Helper;

public static class StringHelper
{
    public static string GetStringFromDateNow()
        => DateTimeOffset.UtcNow.ToString("yyyyMMddHHmmss");
    public static Guid GetGuidKeyId() => Guid.NewGuid();
    public static string MakeKeyId(params string[] code) 
        => string.Concat(string.Join("_",code),"_",GetStringFromDateNow());
    public static string GeneratorStringBase64(int bytes)
    {
        // one character in base 64 equals 6 bits , one byte = 8 bits
        var rands = new byte[bytes];
        using (var random = RandomNumberGenerator.Create())
        {
            random.GetBytes(rands);
        }
        return Convert.ToBase64String(rands);
    }
    public static char GeneratorCharacter(CharacterType type)
    {
        var rand = new Random();
        // have 4 container have special character in asscii :)
        var containerSpecialCharacter = new List<(int, int)>{(33, 48), (58, 65),(91,97),(123,127)};
        // min <= random < max 
        var (start, end) = type switch
        {
            CharacterType.UpperCase => (65, 91),
            CharacterType.LowerCase => (97, 123),
            CharacterType.Number => (48, 58),
            CharacterType.SpecialCharacter => containerSpecialCharacter.ElementAt(rand.Next(0,3)),
            _ => throw new ArgumentException("Don't support character in random"),
        };
        return Convert.ToChar(rand.Next(start, end));
    }
    public static string GeneratorRandomPassword(int minLength = 8, bool isUpper = true,
        bool isLower = true, bool isNumber = true, bool isSpecial = true)
    {
        // random index and pass index in return value in element at :)
        var charTypes = new List<CharacterType>();
        if (isUpper) charTypes.Add(CharacterType.UpperCase);
        if (isLower) charTypes.Add(CharacterType.LowerCase);
        if(isNumber) charTypes.Add(CharacterType.Number);
        if(isSpecial) charTypes.Add(CharacterType.SpecialCharacter);
        var typeLength = charTypes.Count;
        if (typeLength == 0) return ":)) my name is ninh";
        var flags = new HashSet<int>();
        var random = new Random();
        var password = new StringBuilder();
        // flags check has random character
        for (int i = 0; i < minLength; i++)
        {
            var randType = random.Next(0, typeLength);
            flags.Add(randType);
            password.Append(StringHelper.GeneratorCharacter(charTypes[randType]));
        }

        if (flags.Count != typeLength)
        {
            for (var i = 0; i < typeLength; i++)
            {
                if (!flags.Contains(i))
                {
                    password.Append(StringHelper.GeneratorCharacter(charTypes[i]));
                }
            }
        }
        return password.ToString();
    }
}