using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;

namespace PhotoProps
{
    public partial class Photo
    {
        public bool AddPhoto()
        {
            using (ModelPhotoPropsContainer ctx = new ModelPhotoPropsContainer())
            {
                bool bResult = false;
                if (this.Photo_Id == 0)
                {
                    var it = ctx.Entry<Photo>(this).State = EntityState.Added;
                    ctx.SaveChanges();
                    bResult = true;
                }
                return bResult;
            }
        }
        public Photo UpdatePhoto(Photo newPhoto)
        {
            using (ModelPhotoPropsContainer ctx = new ModelPhotoPropsContainer())
            {
                Photo oldPhoto = ctx.Photos.Find(newPhoto.Photo_Id);
                if (oldPhoto == null) // nu exista in bd
                {
                    return null;
                }
                oldPhoto.Photo_Path = newPhoto.Photo_Path;
                oldPhoto.Photo_Date = newPhoto.Photo_Date;
                ctx.SaveChanges();
                return oldPhoto;
            }
        }
        public int DeletePhoto(int id)
        {
            using (ModelPhotoPropsContainer ctx = new ModelPhotoPropsContainer())
            {
                return ctx.Database.ExecuteSqlCommand("Delete From Photos where Photo_Id =@p0", id);
            }
        }
        public Photo GetPhotoById(int id)
        {
            using (ModelPhotoPropsContainer ctx = new ModelPhotoPropsContainer())
            {
                var items = from p in ctx.Photos where (p.Photo_Id == id) select p;
                if (items != null)
                    return items.Include(c => c.Props).SingleOrDefault();
                return null; // trebuie verificat in apelant
            }
        }
        public List<Photo> GetAllPhotos()
        {
            using (ModelPhotoPropsContainer ctx = new ModelPhotoPropsContainer())
            {
                return ctx.Photos.Include("Props").ToList<Photo>();
                // Obligatoriu de verificat in apelant rezultatul primit.
            }
        }

    }
}
