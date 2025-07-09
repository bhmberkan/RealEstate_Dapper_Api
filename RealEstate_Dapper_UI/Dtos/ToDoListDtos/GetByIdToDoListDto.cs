namespace RealEstate_Dapper_UI.Dtos.ToDoListDtos
{
    public class GetByIdToDoListDto
    {
        public int ToDoListID { get; set; }
        public string Description { get; set; }
        public bool ToDoListStatus { get; set; }
    }
}
