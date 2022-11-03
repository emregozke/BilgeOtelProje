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
    public class RoomPictureService : IRoomPictureService
    {
        private readonly IRepository<RoomPicture> roomPictureRepository;

        public RoomPictureService(IRepository<RoomPicture>roomPictureRepository)
        {
            this.roomPictureRepository = roomPictureRepository;
        }
        
        public void Create(RoomPicture roomPicture)
        {
            roomPictureRepository.Create(roomPicture);
        }

        public void Delete(RoomPicture roomPicture)
        {
            roomPictureRepository.Delete(roomPicture);
        }

        public RoomPicture Get(int id)
        {
            return roomPictureRepository.Get(id);
        }

        public IEnumerable<RoomPicture> GetAll()
        {
            return roomPictureRepository.GetAll().ToList();
        }

        public void Update(RoomPicture roomPicture)
        {
            roomPictureRepository.Update(roomPicture);
        }
    }
}
