using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace testtest.Models;
public class Sinhvien
{
    [Key]
    [Display(Name = "ma sinh vien")]
    public string Masinhvien{get;set;}
    [Display(Name = "Ten sinh vien")]
     public string Tensinhvien{get;set;}
     [Display(Name = "ten lop")]
     public string Tenlop {get;set;}
     [ForeignKey("Tenlop")]
     public Lophoc?lophoc {get;set;}
     
}