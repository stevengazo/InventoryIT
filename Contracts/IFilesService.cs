﻿using InventoryIT.Model;

namespace InventoryIT.Contracts
{
    public interface IFilesService
    {
        Task SaveFileAsync(FileModel file);
        Task<FileModel> GetFileByIdAsync(int id);
        Task<List<FileModel>> GetAllFilesComputerAsync(int id);
        Task<List<FileModel>> GetAllFilesSmartPhoneAsync(int id);
        Task<List<FileModel>> GetAllPhoneAsync(int id);
        Task<List<FileModel>> GetAllPeripheralsAsync(int id);
        Task Delete(FileModel e);

    }
}
