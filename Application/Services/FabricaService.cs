using Application.Contracts.Repositories;
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
        private readonly IMaquinaRepository _fabricaRepository;

        public FabricaService(IMaquinaRepository fabricaRepository)
        {
            _fabricaRepository = fabricaRepository;
        }

        public string BuscarPorFiltro(string maquina, string tipo)
        {
            return _fabricaRepository.BuscarPorFiltro(maquina, tipo);
                }

        public string BuscarPorMaquina(string maquina)
        {
            return  _fabricaRepository.BuscarMaquina(maquina);
        }
    }
}
