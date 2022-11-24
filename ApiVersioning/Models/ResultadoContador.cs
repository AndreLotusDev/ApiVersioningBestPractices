using Microsoft.Extensions.Primitives;

namespace ApiVersioning.Models
{
    public class ResultadoContador
    {
        public int ValorAtual { get; set; }
        public string Local { get; set; }
        public string Kernel { get; set; }
        public string TargetFramework { get; set; }
        public object Mensagem { get; set; }
        public string Versao { get; set; }
    }
}
