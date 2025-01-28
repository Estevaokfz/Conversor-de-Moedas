using System.Collections.Generic;

namespace ConversorDeMoedas
{
    
    // Classe responsável por realizar a conversão de moedas.
    
    public class ConversorDeMoedas
    {
        // Dicionário para armazenar moedas e suas taxas de câmbio
        private Dictionary<string, Moeda> moedas;

       
        // Construtor que inicializa as taxas de câmbio.
        
        public ConversorDeMoedas()
        {
            moedas = new Dictionary<string, Moeda>
            {
                { "USD", new Moeda("USD", 5.10m) },  // 1 USD = 5.10 BRL
                { "EUR", new Moeda("EUR", 5.55m) },  // 1 EUR = 5.55 BRL
                { "GBP", new Moeda("GBP", 6.45m) }   // 1 GBP = 6.45 BRL
            };
        }

        
        /// Converte um valor de BRL para a moeda desejada.
        
    
        public decimal ConverterPara(decimal valorEmReais, string moedaDestino)
        {
            if (moedas.ContainsKey(moedaDestino))
            {
                return valorEmReais / moedas[moedaDestino].Taxa;
            }
            else
            {
                return 0;
            }
        }
    }
}