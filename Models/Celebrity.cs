using System.ComponentModel.DataAnnotations;

namespace MyMvcApp.Models;

public class Celebrity
{
    public int Id { get; set; }
    public string Name { get; set; }
    [Display(Name = "Birth Day")]
    [DataType(DataType.Date)]
    public DateTime BirthDate { get; set; }

    public int Age => CalculateAge();
    [Display(Name = "Movies")]
    public ICollection<Movie>? Movies { get; set; }

    private int CalculateAge()
    {
        DateTime today = DateTime.Today;
        int age = today.Year - BirthDate.Year;
        if (BirthDate.Date > today.AddYears(-age))
            age--;
        return age;
    }
}