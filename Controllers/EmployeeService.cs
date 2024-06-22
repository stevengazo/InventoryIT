﻿using InventoryIT.Contracts;
using InventoryIT.Model;
using InventoryIT.Data;
using Microsoft.EntityFrameworkCore;

namespace InventoryIT.Controllers
{
    public class EmployeeService : IControllerServices<Employee>
    {
        private readonly InventoryDbContext _InventoryDB;
        public EmployeeService(InventoryDbContext inventoryDbContext)
        {
            _InventoryDB = inventoryDbContext;  
        }

        public void Add(Employee entity)
        {
            _InventoryDB.Employee.Add(entity);
            _InventoryDB.SaveChanges();
        }

        public void Delete(Employee entity)
        {
            throw new NotImplementedException();
        }

        public List<Employee> GetAll()
        {
            return _InventoryDB.Employee.ToList();
        }

        public Employee GetById(int id)
        {
            return _InventoryDB.Employee.FirstOrDefault(i => i.EmployeeId == id);
        }

        public List<Employee> Search(string value)
        {
            throw new NotImplementedException();
        }

        public void Update(Employee entity)
        {
            _InventoryDB.Employee.Update(entity);
            _InventoryDB.SaveChanges();
        }
    }
}