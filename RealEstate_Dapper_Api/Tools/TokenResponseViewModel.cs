namespace RealEstate_Dapper_Api.Tools
{
    public class TokenResponseViewModel
    {
        public TokenResponseViewModel(string token, DateTime exprieDate)
        {
            Token = token;
            ExprieDate = exprieDate;
        }

        public string Token { get; set; }
        public DateTime ExprieDate { get; set; }
    }
}
