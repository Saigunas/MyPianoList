using System.ComponentModel.DataAnnotations;

namespace MyPianoList.Domain;

public class Tag
{
    public int Id { get; set; }

    [Required]
    [MaxLength(50)]
    public string TagName { get; set; }

    public ICollection<PianoSheetTag> PianoSheetTags { get; set; } = new List<PianoSheetTag>();
}
