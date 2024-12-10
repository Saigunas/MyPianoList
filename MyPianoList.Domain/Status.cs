using System.ComponentModel.DataAnnotations;

namespace MyPianoList.Domain;
public enum SheetStatus
{
    Learning,
    PlannedToRead,
    Dropped,
    Completed
}
public class Status
{
    public int Id { get; set; }

    [Required]
    public int UserId { get; set; } // Foreign key to User

    [Required]
    public int SheetId { get; set; } // Foreign key to PianoSheet

    [Required]
    [EnumDataType(typeof(SheetStatus))]
    public SheetStatus SheetStatus { get; set; }

    public PianoSheet PianoSheet { get; set; }
}
