namespace AulaWhatsapp
{
    public class Mensagem
    {
        public string Texto { get; set; }
        public Contato Destinatario { get; set; }

        public string Enviar(Contato contato)
        {
            return $"Para: {contato.Nome} /n Mensagem: {Texto}";
            
        }

    }
}