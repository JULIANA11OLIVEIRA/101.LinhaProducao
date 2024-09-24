using Application.Contracts.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public  class FabricaService: IFabricaService
    {
        public string BuscarPorFiltro(string maquina, string tipo)
        {
            return $"Listando da linha de produção, a máquina {maquina} do tipo {tipo}";
                }

        public string BuscarPorMaquina(string maquina)
        {
            return $"Listando da linha de produção, a máquina {maquina}";
        }
    }
}
