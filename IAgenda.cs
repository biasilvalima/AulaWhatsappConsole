namespace AulaWhatsapp
{
    public interface IAgenda
    {
         void CadastrarContato(Contato cont);
         void ExcluirContato(Contato cont);
         void Listar();

    }
}