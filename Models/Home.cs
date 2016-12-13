using System.ComponentModel.DataAnnotations;

namespace Hackatwitchthon.Models{
    public abstract class BaseEntity{}
public class Twitchgame : BaseEntity{

        [Key]
        public int Id {get; set;}
        public string game {get; set;}        
        public string img{get; set;}
        public string created_at {get;set;}
        public int viewers {get;set;}
    }

}