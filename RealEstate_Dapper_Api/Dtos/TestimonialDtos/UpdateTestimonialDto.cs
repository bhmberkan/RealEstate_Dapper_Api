namespace RealEstate_Dapper_Api.Dtos.TestimonialDtos
{
    public class UpdateTestimonialDto
    {
        public int TestimonialID { get; set; }
        public string NameSurname { get; set; }
        public string Title { get; set; }
        public string Comment { get; set; }
        public bool Status { get; set; }
    }
}
