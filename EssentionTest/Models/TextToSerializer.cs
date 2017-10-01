using System.ComponentModel.DataAnnotations;

namespace EssentionTest.Model
{
    public class TextToSerializer
    {
        [Required]
        [MaxLength(2000)]
        public string Text { get; set; }
        [Required]
        [MaxLength(10)]
        public string FormatType { get; set; }
        [MaxLength(10)]
        public string SeparatorCvs { get; set; }
    }
}
