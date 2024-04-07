using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Experience{
    
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ID {get;set;}
    public string role {get;set;}
    public string nameOfCompany {get;set;}
    public string shortDescription {get;set;}
    public string longDescription {get;set;}
    public string period  {get;set;}
    public string type {get;set;}
    public string image {get;set;}
    public string highlightSkills { get;set;}

}