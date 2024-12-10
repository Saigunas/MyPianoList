using MyPianoList.Domain.AuthorizationModels;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyPianoList.Domain;

public enum RatingType
{
    Like,
    Dislike
}

public class Rating
{
    public int Id { get; set; }

    [Required]
    [ForeignKey("ApplicationUser")]
    public string UserId { get; set; }

    [Required]
    [ForeignKey("PianoSheet")]
    public int PianoSheetId { get; set; }

    [Required]
    [EnumDataType(typeof(RatingType))]
    public RatingType RatingValue { get; set; }

    // Virtual enables lazy loading
    public virtual ApplicationUser ApplicationUser { get; set; }
    public virtual PianoSheet PianoSheet { get; set; }
}
