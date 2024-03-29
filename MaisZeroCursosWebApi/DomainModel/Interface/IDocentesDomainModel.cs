﻿using MaisZeroCursos.DTO.Model;

namespace MaisZeroCursosWebApi.DomainModel.Interface
{
    public interface IDocentesDomainModel : IDomainModelBase<DocentesModel>
    {
        List<DocentesModel> PesquisarNome(string nomeDoscente);
    }
}
