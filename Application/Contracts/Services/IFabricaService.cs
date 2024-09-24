using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Contracts.Services
{
    public interface IFabricaService
    {
        string BuscarPorMaquina(string máquinas);
        string BuscarPorFiltro(string máquinas, string tipoMáquinas);
    }
}
