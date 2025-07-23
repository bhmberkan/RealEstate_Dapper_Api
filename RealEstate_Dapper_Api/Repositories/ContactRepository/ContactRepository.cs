using Dapper;
using RealEstate_Dapper_Api.Dtos.ContactDtos;
using RealEstate_Dapper_Api.Models.DapperContext;
using System.Reflection.Metadata;

namespace RealEstate_Dapper_Api.Repositories.ContactRepository
{
    public class ContactRepository : IContactRepository
    {
        private readonly Context _context;

        public ContactRepository(Context context)
        {
            _context = context;
        }

        public async void CreateContact(CreateContactDto createContactDto)
        {
            string query = "insert into Contact (Name,Email,Phone,Subject,Message,SendDate) values (@name,@email,@phone,@subject,@message,@senddate)";
            var paramaters = new DynamicParameters();
            paramaters.Add("@name", createContactDto.Name);
            paramaters.Add("@email", createContactDto.Email);
            paramaters.Add("@phone", createContactDto.Phone);
    
            paramaters.Add("@subject", createContactDto.Subject);
            paramaters.Add("@message", createContactDto.Message);
            paramaters.Add("@senddate", DateTime.Now);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, paramaters);
            }
        }

        public async void DeleteContact(int id)
        {

            string query = "Delete From Contact Where ContactID=@contactID";
            var parameters = new DynamicParameters();
            parameters.Add("@contactID", id);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task<List<ResultContactDto>> GetAllContactAsync()
        {
            string query = "Select * From Contact";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultContactDto>(query);
                return values.ToList();
            }
        }

        public async Task<GetByIdContactDto> GetContact(int id)
        {
            string query = "Select * From Contact Where ContactID=@contactID";
            var parameters = new DynamicParameters();
            parameters.Add("@contactID", id);
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryFirstOrDefaultAsync<GetByIdContactDto>(query, parameters);
                return values;
            }
        }

        public async Task<List<Last4ContactResultDto>> GetLast4Contact()
        {
            string query = "select top(4) * from Contact order by ContactID desc";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<Last4ContactResultDto>(query);
                return values.ToList();
            }
        }

        public async void UpdateContact(UpdateContactDto updateContactDto)
        {
            string query = "Update Contact Set Name=@name,Email=@email,Phone=@phone,  Subject=@subject, Message=@message, SendDate=@senddate Where ContactID=@contactID";
            var parameters = new DynamicParameters();
            parameters.Add("@contactID", updateContactDto.ContactID);
            parameters.Add("@name", updateContactDto.Name);
            parameters.Add("@email", updateContactDto.Email);
            parameters.Add("@phone", updateContactDto.Phone);
       
            parameters.Add("@subject", updateContactDto.Subject);
            parameters.Add("@message", updateContactDto.Message);
            parameters.Add("@senddate", DateTime.Now);

            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }
    }
}
