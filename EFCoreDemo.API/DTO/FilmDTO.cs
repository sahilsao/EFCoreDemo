using Microsoft.EntityFrameworkCore;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreDemo.API.DTO
{
    public class FilmDTO
    {
        public int FilmId {get; set;}
        public string Title {get; set;}
        public string Description {get; set;}
        public int? ReleaseYear {get; set;}
        public int LanguageId {get; set;}
        public int? OriginalLanguageId {get; set;}
        public short RentalDuration {get; set;}
        public decimal RentalRate {get; set;}
        public short? Length {get; set;}
        public decimal ReplacementCost {get; set;}
        public DateTime LastUpdate {get; set;}
        public List<string> SpecialFeatures {get; set;}
        public NpgsqlTsVector Fulltext {get; set;}
    }
}
