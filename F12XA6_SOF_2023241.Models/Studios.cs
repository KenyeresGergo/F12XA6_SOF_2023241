using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using F12XA6_SOF_2023241.Models.Interfaces;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Newtonsoft.Json;

namespace F12XA6_SOF_2023241.Models
{
    public enum StudioName
    {
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
        Valve = 21,
    }
    [Table("Studios")]
    public class Studios : IStudios, IDbEntity
    {
        [Key]
        public string Id { get; set; }

        [JsonIgnore]
        [NotMapped]
        [ValidateNever]
        public string Serial_Num { get; private set; }  //the int value of the StudioName enum

        [Required(ErrorMessage = "Content is required.")]
        [StringLength(200)]
        public StudioName Name { get; private set; } // appears as an int in the database

        public string? LogoSvg { get; private set; }

        [NotMapped]
        [ValidateNever]
        public virtual ICollection<Game> GamesOwned { get; set; }

        private string _path = "/wwwroot/logos_in_svg/";

        [JsonIgnore]
        [NotMapped]
        private StudioName temp;

        public Studios()
        {
            Id = Guid.NewGuid().ToString();
        }
        public Studios(string Serial_Num, StudioName name, string logoSvg)
        {
            Id = Guid.NewGuid().ToString();
            this.Serial_Num = Serial_Num;
            Name = name;
            LogoSvg = _path + logoSvg;
        }
        public Studios(string Serial_Num)
        {
            Id = Guid.NewGuid().ToString();
            this.Serial_Num = Serial_Num;
            Name = (StudioName)int.Parse(this.Serial_Num);
            temp = Name;
            LogoSvg = _path + ConvertToLowercaseAndReplaceSpaces(InsertSpaces(temp.ToString()));
        }
        static string InsertSpaces(string input)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                char currentChar = input[i];

                if (char.IsUpper(currentChar) && i > 0) 
                    result.Append(' ');     //Puts space infront of Upper case, if it's not first char

                result.Append(currentChar);
            }
            return result.ToString();
        }
        static string ConvertToLowercaseAndReplaceSpaces(string input)
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                char currentChar = input[i]; //Current character

                if (char.IsWhiteSpace(currentChar))
                    result.Append('-'); //Replaces space with '-'
                else
                    result.Append(char.ToLower(currentChar)); //Lowers all letters
            }
            return result.ToString();
        }
        public void CopyFrom(Studios old)
        {
            this.Id = old.Id;
            this.Name = old.Name;
            this.Serial_Num = old.Serial_Num;
            this.LogoSvg = old.LogoSvg;
            this.GamesOwned = old.GamesOwned;
        }
    }
}
