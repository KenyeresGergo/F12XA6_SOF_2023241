using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace F12XA6_SOF_2023241.Models
{
    public enum StudioName
    {
        Activision = 0,
        Bethesda = 1,
        Blizzard = 2,
        Bluehole = 3,
        Capcom = 4,
        CdProjekt = 5,
        Crystal = 6,
        ElectronicArts = 7,
        EpicGames = 8,
        FiraxisGames = 9,
        InsomniacGames = 10,
        Microsoft = 11,
        Mojang = 12,
        Nintendo = 13,
        ParadoxInteractive = 14,
        RemedyEntertainment = 15,
        RockstarGames = 16,
        Sega = 17,
        Sony = 18,
        SquareEnix = 19,
        Ubisoft = 20,
        Valve = 21
    }

    public class Studios
    {
        static string _path = "~/logos_in_svg/";

        [Key]
        public int Id { get; private set; }
        [Required]
        [StringLength(200)]
        public StudioName Name { get; private set; }
        public string? LogoSvg { get; private set; }

        private List<StudioName> StudioNames;

        [NotMapped]
        public virtual ICollection<Game> GamesOwned { get; set; }
        public Studios(int id, StudioName name, string logoSvg)
        {
            Id = id;
            Name = name;
            LogoSvg = _path + logoSvg;
        }

        public Studios(int id)
        {

            Id = id;
            Name = InsertSpaces();
            LogoSvg = _path + ConvertToLowercaseAndReplaceSpaces(Name.ToString());
        }
        static string InsertSpaces(string input)
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                char currentChar = input[i];

                if (char.IsUpper(currentChar) && i > 0)
                    result.Append(' ');

                result.Append(currentChar);
            }

            return result.ToString();
        }
        static string ConvertToLowercaseAndReplaceSpaces(string input)
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                char currentChar = input[i];

                if (char.IsWhiteSpace(currentChar))
                    result.Append('-');
                else
                    result.Append(char.ToLower(currentChar));
            }

            return result.ToString();
        }
    }

}
