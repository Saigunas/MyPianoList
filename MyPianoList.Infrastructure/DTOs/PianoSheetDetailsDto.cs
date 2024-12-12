using MyPianoList.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPianoList.Infrastructure.DTOs
{
    public class PianoSheetDetailsDto
    {
        public int Id { get; set; }
        public string Title { get; set; } = "";
        public List<string> Tags { get; set; } = new();
        public int CurrentRating { get; set; }
        public Rating? UserRating { get; set; }
        public Status? UserStatus { get; set; }
    }

}
