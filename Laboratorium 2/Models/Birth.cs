namespace Laboratorium_2.Models
{
    public class Birth
    {
        public String? a { get; set; }
        public DateTime? b { get; set; }

        public bool IsValid()
        {
            return a != null && b != null && b < DateTime.Now;
        }

        public int CalculateBirth()
        {
            return DateTime.Now.Year - b.Value.Year;
        }
    }
}
