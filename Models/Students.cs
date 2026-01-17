using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EfcorePractice.Models
{

    [Table("students_details")]
    public class Students
    {
        [Key]
        [Column("students_id")]
        public int Id { get; set; }
        [Column("studenst_name")]
        public  string Name { get; set; }
        [Column ("course")]
        public string domain { get; set; }
    }
}
