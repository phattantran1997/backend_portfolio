using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Publication{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ID {get;set;}
    public string name {get;set;}
    public string place {get;set;}
    public string period {get;set;}
    public string type {get;set;}
    public string longDescription {get;set;}
    public string image {get;set;}

}