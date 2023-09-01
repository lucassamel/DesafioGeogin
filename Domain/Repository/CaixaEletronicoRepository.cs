using Domain.Model;
using Domain.Model.Notas;
using Microsoft.AspNetCore.Hosting.Internal;
using Newtonsoft.Json;
using System.Net.Http;
using System.Reflection;

namespace Domain.Repository
{
    public class CaixaEletronicoRepository
    {
        private readonly string _dataBase;       

        public CaixaEletronicoRepository()
        {
            string codeBase = Environment.CurrentDirectory.ToString();
            UriBuilder uri = new UriBuilder(codeBase);
            string path = Uri.UnescapeDataString(uri.Path);
             
            _dataBase = Path.GetDirectoryName(path) + "\\Domain\\DataBase\\db.json";            
        }
        public CaixaEletronico ObterNotasDisponiveis()
        {
            string jsonString = File.ReadAllText(_dataBase);
            CaixaEletronico caixaEletronico = JsonConvert.DeserializeObject<CaixaEletronico>(jsonString)!;

            return caixaEletronico;
        }

        public void AtualizarCaixaEletronico(CaixaEletronico caixaEletronico)        {           

            string jsonString = JsonConvert.SerializeObject(caixaEletronico, Formatting.Indented);
            File.WriteAllText(_dataBase, jsonString);
        }


    }
}
