using System.ComponentModel.DataAnnotations.Schema;

namespace Portfolyo_AY.Entities
{
    public class Reference
    {
        public int Id { get; set; }

        public string FullName { get; set; }

        public string Major { get; set; }

        public string Massage { get; set; }
        public string Image { get; set; }

        [NotMapped]
        public IFormFile ImageFile { get; set; }
    }
}
