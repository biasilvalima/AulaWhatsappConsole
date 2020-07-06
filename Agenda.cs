using System.Collections.Generic;
using System.IO;

namespace AulaWhatsapp
{
    public class Agenda : IAgenda
    {
        List<Contato> contatos = new List<Contato>();

        private const string PATH = "Database/Contato.csv";

        public Agenda()
        {
            string pasta = PATH.Split('/')[0];
            if(Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }

            if(!File.Exists(PATH))
            {
                File.Create(PATH).Close();
            }

        }

        public void CadastrarContato(Contato cont)
        {
            throw new System.NotImplementedException();
        }

        public void ExcluirContato(Contato cont)
        {
            throw new System.NotImplementedException();
        }

        public void Listar()
        {
            throw new System.NotImplementedException();
        }
    }
}