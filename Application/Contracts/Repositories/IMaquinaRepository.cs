using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Contracts.Repositories
{
    public interface IMaquinaRepository
    {
        string BuscarMaquina(string maquina);
        string BuscarPorFiltro(string maquina, string tipo);
    }
}
