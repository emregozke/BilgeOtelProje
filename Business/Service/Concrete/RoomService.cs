using Business.Repository.Abstract;
using Business.Service.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Service.Concrete
{
    public class RoomService : IRoomService
    {
        private readonly IRepository<Room> roomRepository;

        public RoomService(IRepository<Room>roomRepository)
        {
            this.roomRepository = roomRepository;
        }
        public void Create(Room room)
        {
            roomRepository.Create(room);
        }

        public void Delete(Room room)
        {
            roomRepository.Delete(room);
        }

        public Room Get(int id)
        {
            return roomRepository.Get(id);
        }

        public IEnumerable<Room> GetAll()
        {
            return roomRepository.GetAll().ToList();
        }

        public void Update(Room room)
        {
            roomRepository.Update(room);
        }
    }
}
