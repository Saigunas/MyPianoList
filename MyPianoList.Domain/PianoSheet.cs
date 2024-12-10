using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyPianoList.Domain;

public class PianoSheet
{
    public int Id { get; set; }
    [Required]
    [Column(TypeName = "NVARCHAR(200)")]
    public string Title { get; set; }

    public int Rating { get; set; } = 0;

    [Required]
    [Column(TypeName = "NVARCHAR(2000)")]
    [Url]
    [RegularExpression(@"^(https?:\/\/)?(www\.)?(imslp\.org|musescore\.com)\/.*$", ErrorMessage = "Url must be from imslp.org or musescore.com.")]
    public string Url { get; set; }

    [Required]
    [Column(TypeName = "NVARCHAR(200)")]
    public string Composer { get; set; }

    public ICollection<PianoSheetTag> PianoSheetTags { get; set; } = new List<PianoSheetTag>();
    public ICollection<Rating> Ratings { get; set; } = new List<Rating>();
    public ICollection<Status> Statuses { get; set; } = new List<Status>();
}

