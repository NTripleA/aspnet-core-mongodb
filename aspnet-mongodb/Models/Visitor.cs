using System.ComponentModel.DataAnnotations;

namespace aspnetmongodb.Models
{
    public class Visitor
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
