using Application.Contracts.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Data.Repositories
{
    public class MaquinaRepository : IMaquinaRepository
    {
        public string BuscarMaquina(string maquina)
        {
            return $"Listando Máquina {maquina}";
        }

        public string BuscarPorFiltro(string maquina, string tipo)

        {
            return $"Listando máquina {maquina} do tipo {tipo} ";
        }
    }
}
