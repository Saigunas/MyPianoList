using MyPianoList.Domain.AuthorizationModels;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyPianoList.Domain;

public class PianoSheetTag
{

    public int Id { get; set; }

    [Required]
    [Column(Order = 1)]
    [ForeignKey("PianoSheet")]
    public int PianoSheetId { get; set; }

    [Required]
    [Column(Order = 2)]
    [ForeignKey("Tag")]
    public int TagId { get; set; }


    // Virtual enables lazy loading
    [Required]
    public virtual PianoSheet PianoSheet { get; set; }
    [Required]
    public virtual Tag Tag { get; set; }
}
