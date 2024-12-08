using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyPianoList.Domain;

public class PianoSheet
{
    public int Id { get; set; }
    [Required]
    [Column(TypeName = "NVARCHAR(200)")]
    public string Title { get; set; }
    [Required]
    [Column(TypeName = "NVARCHAR(200)")]
    public string Composer { get; set; }
}
