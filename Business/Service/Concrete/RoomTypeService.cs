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
    public class RoomTypeService : IRoomTypeService
    {
        private readonly IRepository<RoomType> roomTypeRepository;

        public RoomTypeService(IRepository<RoomType>roomTypeRepository)
        {
            this.roomTypeRepository = roomTypeRepository;
        }
        
        public void Create(RoomType roomType)
        {
            roomTypeRepository.Create(roomType);
        }

        public void Delete(RoomType roomType)
        {
            roomTypeRepository.Delete(roomType);
        }

        public RoomType Get(int id)
        {
            return roomTypeRepository.Get(id);
        }

        public IEnumerable<RoomType> GetAll()
        {
            return roomTypeRepository.GetAll().ToList();
        }

        public void Update(RoomType roomType)
        {
            roomTypeRepository.Update(roomType);
        }
    }
}
