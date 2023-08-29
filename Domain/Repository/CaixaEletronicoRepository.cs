using Domain.Model;
using Domain.Model.Notas;
using Newtonsoft.Json;

namespace Domain.Repository
{
    public class CaixaEletronicoRepository
    {
        private readonly string _dataBase;       

        public CaixaEletronicoRepository()
        {
            _dataBase = "C:\\Users\\Fadami\\source\\repos\\DesafioGeogin\\Domain\\Data\\db.json";            
        }
        public CaixaEletronico? ObterNotasDisponiveis()
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
