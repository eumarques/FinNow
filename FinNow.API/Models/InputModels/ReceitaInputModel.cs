namespace FinNow.API.Models.InputModels
{
    public class ReceitaInputModel
    {

        public int UserId { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public DateTime Data { get; set; }
        public string Categoria { get; set; }
    }
}
