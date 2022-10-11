﻿namespace MaisZeroCursosWebApi.Repository.Interface
{
    public interface IRepositoryBase<T> where T : class
    {
        List<T> CarregarTudo();
    }
}
