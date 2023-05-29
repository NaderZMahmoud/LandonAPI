using LandonAPI2.Models;
using System;
using System.Threading.Tasks;

namespace LandonAPI2.Services
{
    public interface IRoomService
    {
        Task<Room> GetRoomAsync(Guid id);
    }
}
