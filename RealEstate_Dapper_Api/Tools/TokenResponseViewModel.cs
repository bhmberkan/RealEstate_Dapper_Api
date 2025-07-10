namespace RealEstate_Dapper_Api.Tools
{
    public class TokenResponseViewModel
    {
        public TokenResponseViewModel(string token, DateTime exprieDate)
        {
            Token = token;
            ExpireDate = exprieDate;
        }

        public string Token { get; set; }
        public DateTime ExpireDate { get; set; }
    }
}
