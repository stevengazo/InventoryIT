﻿namespace InventoryIT.Contracts
{
    public interface IControllerServices<T> where T : class
    {
        void Add(T entity);

        void Update(T entity);

        void Delete(T entity);

        List<T> GetAll();
        T GetById(int id);

        List<T> Search(string value);

    }
}


