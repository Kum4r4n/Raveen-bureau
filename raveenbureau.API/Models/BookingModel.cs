using raveenbureau.API.Enums;

namespace raveenbureau.API.Models
{
    public class BookingModel
    {
        public Guid? Id { get; set; }
        public Guid UserId { get; set; }
        public string BookingPersonName { get; set; }
        public Gender Gender { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public DateTime BirthDateTime { get; set; }
        public string PreferredLetters { get; set; }
        public string Note { get; set; }
        public string paymentVia { get; set; }
    }
}
