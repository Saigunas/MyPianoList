using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyPianoList.Domain;

public class Tag
{
    public int Id { get; set; }

    [Required]
    [Column(TypeName = "NVARCHAR(50)")]
    public string TagName { get; set; }
}
