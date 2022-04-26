using System;
using System.ComponentModel.DataAnnotations;
using MoviesApp.Filtres;

namespace MoviesApp.Services.Dto
{
    public class ActorDto
    {
        public int? ID { get; set; }

        [Required]
        [LittleName(4)]
        public string Name { get; set; }

        [Required]
        [LittleSurname(4)]
        public string Surname { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [VeryOldOrVeryYoungActor(1922, 2014)]
        public DateTime Birth { get; set; }
    }
}