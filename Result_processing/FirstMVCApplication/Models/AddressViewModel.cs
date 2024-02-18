namespace FirstMVCApplication.Models
{
    public class AddressViewModel
    {
       public int Id { get; set; }
       public string Street { get; set; }
        public int ZipCode { get; set; }
        public string City { get; set; }
       public string State { get; set; }
    }
}