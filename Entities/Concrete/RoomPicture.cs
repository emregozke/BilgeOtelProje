using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class RoomPicture  :BaseEntity
    {
        public string PictureUrl { get; set; }
        //
        public int RoomTypeId { get; set; }
        public virtual RoomType RoomType { get; set; }
    }
}
