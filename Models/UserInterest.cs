
namespace win_Project_dating_site.Models;

public class UserInterest
{
    public int UserId { get; set; }

    public User User { get; set; } = null!;

    public int InterestId { get; set; }

    public Interest Interest { get; set; } = null!;
}
