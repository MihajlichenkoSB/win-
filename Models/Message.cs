
using System.ComponentModel.DataAnnotations;

namespace win_Project_dating_site.Models;

public class Message
{
    public int Id { get; set; }

    public int SenderId { get; set; }

    public User Sender { get; set; } = null!;

    public int ReceiverId { get; set; }

    public User Receiver { get; set; } = null!;

    [Required]
    public string Text { get; set; } = "";

    public DateTime SentAt { get; set; } = DateTime.UtcNow;

    public bool IsRead { get; set; }
}
