using System.Resources;
using Domain.Interface;

namespace Infrastructure.Queries
{
    public class ConsultaSQL: IConsultaSQL
    {
        private readonly ResourceManager _resourceManager;
        public ConsultaSQL()
        {
            _resourceManager = new ResourceManager("Infrastructure.Queries.ConsultaSQLResource", typeof(ConsultaSQL).Assembly); 
        }
        public string ObterConsulta(string nomeConsulta)
        {
            try
            {
                return _resourceManager.GetString(nomeConsulta);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao obter consulta '{nomeConsulta}' do arquivo de recursos.", ex);
            }
        }
    }
}
