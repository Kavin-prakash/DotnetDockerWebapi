using System.ComponentModel.DataAnnotations;

namespace FetchWebapi.Model{
public class LaptopDetails{
    [Key] 
    public int LaptopId{get;set;} 
    [Required]
    public string? LaptopName{get;set;}
}
}
