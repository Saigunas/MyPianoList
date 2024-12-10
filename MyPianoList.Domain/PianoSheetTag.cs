using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyPianoList.Domain;

public class PianoSheetTag
{
    [Key]
    [Column(Order = 1)]
    public int SheetId { get; set; }

    [Key]
    [Column(Order = 2)]
    public int TagId { get; set; }

    public PianoSheet PianoSheet { get; set; }
    public Tag Tag { get; set; }
}
