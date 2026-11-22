
using System.ComponentModel.DataAnnotations;

namespace win_Project_dating_site.Models;

public class Interest
{
    public int Id { get; set; }

    [Required]
    public string Name { get; set; } = "";

    public List<UserInterest> UserInterests { get; set; } = new();
}
