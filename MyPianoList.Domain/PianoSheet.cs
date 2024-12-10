using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace MyPianoList.Domain;

public class PianoSheet
{
    public int Id { get; set; }
    [Required]
    [MaxLength(255)]
    public string Title { get; set; }

    [Range(0, double.MaxValue)]
    public decimal Rating { get; set; } = 0;

    [Required]
    [MaxLength(2083)] // Standard max length for URLs
    [Url]
    [RegularExpression(@"^(https?:\/\/)?(www\.)?(imslp\.org|musescore\.com)\/.*$", ErrorMessage = "Url must be from imslp.org or musescore.com.")]
    public string Url { get; set; }

    [Required]
    [MaxLength(255)]
    public string Composer { get; set; }

    public ICollection<PianoSheetTag> PianoSheetTags { get; set; } = new List<PianoSheetTag>();
    public ICollection<Rating> Ratings { get; set; } = new List<Rating>();
    public ICollection<Status> Statuses { get; set; } = new List<Status>();
}

