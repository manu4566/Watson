using Newtonsoft.Json;

namespace Exercicio.Application.DTOs
{
    public class MensagemEnviada
    {
        [JsonProperty("contexto")]       
        public string Contexto { get; set; }
    }
}
