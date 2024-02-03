using System.ComponentModel.DataAnnotations;

namespace CreateWebapi.Model{
public class LaptopDetails{
    [Key] 
    public int LaptopId{get;set;} 
    [Required]
    public string? LaptopName{get;set;}
    
}
}