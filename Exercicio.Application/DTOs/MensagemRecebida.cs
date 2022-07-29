using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Exercicio.Application.DTOs
{
    public class MensagemRecebida
    {
        [JsonProperty("contexto")]
        [Required]
        public string Contexto { get; set; }
    }
}
