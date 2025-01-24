namespace ConversorDeMoedas
{
    
    // Representa uma moeda com seu código e taxa de conversão em relação ao BRL.
    
    public class Moeda
    {
        public string Codigo { get; set; }   // Código da moeda (ex: USD, EUR)
        public decimal Taxa { get; set; }    // Taxa de conversão para BRL

        
        // Construtor da classe Moeda.
        
        public Moeda(string codigo, decimal taxa)
        {
            Codigo = codigo;
            Taxa = taxa;
        }
    }
}