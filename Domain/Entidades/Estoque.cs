namespace Domain.Entidades
{
    public class Estoque
    {
        public int produto { get; set; }
        public string documento { get; set; }       
        public int quantidade { get; set; }
        public decimal valorTotal { get; set; }
    }
}
