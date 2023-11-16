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
        Activision,
        Bethesda,
        Blizzard,
        Bluehole,
        Capcom,
        CdProjekt,
        Crystal,
        ElectronicArts,
        EpicGames,
        FiraxisGames,
        InsomniacGames,
        Microsoft,
        Mojang,
        Nintendo,
        ParadoxInteractive,
        RemedyEntertainment,
        RockstarGames,
        Sega,
        Sony,
        SquareEnix,
        Ubisoft,
        Valve
    }

    public class Studios
    {
        static string _path = "~/logos_in_svg/";

        [Key]
        public StudioName StudioId { get; private set; }
        [Required]
        [StringLength(200)]
        public string Name { get; private set; }
        public string? LogoSvg { get; private set; }

        [NotMapped]
        public virtual ICollection<Game> GamesOwned { get; set; }
        public Studios(StudioName id, string name, string logoSvg)
        {
            StudioId = id;
            Name = name;
            LogoSvg =  _path + logoSvg;
        }

        public Studios(int id)
        {
            StudioId = (StudioName)Enum.Parse(typeof(StudioName), id.ToString());
            Name = InsertSpaces(id.ToString());
            LogoSvg = _path + ConvertToLowercaseAndReplaceSpaces(Name);
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
