using System.ComponentModel.DataAnnotations;
namespace testtest.Models;
public class Lophoc
{
    [Key]
    [Display(Name = "ma lop")]
    public string Malop {get;set;}
    [Display(Name = "ten lop")]
    public string Tenlop {get;set;}
     [Display(Name = "si so")]
    public string Siso {get;set;}
    [Display(Name = "so lop")]
    public string solop {get;set;}


}