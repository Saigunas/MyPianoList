using System.ComponentModel.DataAnnotations;

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
    public int UserId { get; set; } // Foreign key to User

    [Required]
    public int SheetId { get; set; } // Foreign key to PianoSheet

    [Required]
    [EnumDataType(typeof(RatingType))]
    public RatingType RatingValue { get; set; }

    [Required]
    public DateTime RatingDate { get; set; }

    public PianoSheet PianoSheet { get; set; }
}
