using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GraphQL_Practise.Models
{
    public class Categorys
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CategoryKey { get; set; }

        [Required]
       public string CategoryName { get; set; }

       public DateTime? CreatedOn { get; set; }
       public DateTime? UpdatedOn { get; set; }

    }
}
