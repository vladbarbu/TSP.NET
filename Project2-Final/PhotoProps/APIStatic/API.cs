using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace PhotoProps.APIStatic
{
    public static class API
    {
        public static bool AddPhoto(Photo photo)
        {
            using (ModelPhotoPropsContainer ctx = new ModelPhotoPropsContainer())
            {
                bool bResult = false;
                if (photo.Photo_Id == 0)
                {
                    var it = ctx.Entry<Photo>(photo).State = EntityState.Added;
                    ctx.SaveChanges();
                    bResult = true;
                }
                return bResult;
            }
        }
        public static Photo UpdatePhoto(Photo newPhoto)
        {
            using (ModelPhotoPropsContainer ctx = new ModelPhotoPropsContainer())
            {
                // Ce e in bd. PK nu poate fi modificata
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
        public static int DeletePhoto(int id)
        {
            using (ModelPhotoPropsContainer ctx = new ModelPhotoPropsContainer())
            {
                return ctx.Database.ExecuteSqlCommand("Delete From Photos where Photo_Id =@p0", id);
            }
        }
        
        public static Photo GetPhotoById(int id)
        {
            using (ModelPhotoPropsContainer ctx = new ModelPhotoPropsContainer())
            {
                var items = from p in ctx.Photos where (p.Photo_Id == id) select p;
                if (items != null)
                    return items.Include(c => c.Props).SingleOrDefault();
                return null;
            }
        }
       
        public static List<Photo> GetAllPhotos()
        {
            using (ModelPhotoPropsContainer ctx = new ModelPhotoPropsContainer())
            {
                return ctx.Photos.Include("Props").ToList<Photo>();
            }
        }
        // Comment table
        public static bool AddProp(Props prop)
        {
            using (ModelPhotoPropsContainer ctx = new ModelPhotoPropsContainer())
            {
                bool bResult = false;
                if (prop == null || prop.PhotoPhoto_Id == 0)
                    return bResult;
                if (prop.Property_Id == 0)
                {
                    ctx.Entry<Props>(prop).State = EntityState.Added;
                    Photo p = ctx.Photos.Find(prop.PhotoPhoto_Id);
                    ctx.Entry<Photo>(p).State = EntityState.Unchanged;
                    ctx.SaveChanges();
                    bResult = true;
                }
                return bResult;
            }
        }
        public static Props UpdateProp(Props newProp)
        {
            using (ModelPhotoPropsContainer ctx = new ModelPhotoPropsContainer())
            {
                Props oldProp = ctx.Props.Find(newProp.Property_Id);
                if (newProp.Property_Description != null && newProp.Property_Name != null)
                {
                    oldProp.Property_Description = newProp.Property_Description;
                    oldProp.Property_Name = newProp.Property_Name;
                }
                if ((oldProp.PhotoPhoto_Id != newProp.PhotoPhoto_Id)
               && (newProp.PhotoPhoto_Id != 0))
                {
                    oldProp.PhotoPhoto_Id = newProp.PhotoPhoto_Id;
                }
                ctx.SaveChanges();
                return oldProp;
            }
        }
        public static Props GetPropById(int id)
        {
            using (ModelPhotoPropsContainer ctx = new ModelPhotoPropsContainer())
            {
                var items = from c in ctx.Props where (c.Property_Id == id) select c;
                return items.Include(p => p.Photo).SingleOrDefault();
            }
        }

        public static int DeleteProp(int id)
        {
            using (ModelPhotoPropsContainer ctx = new ModelPhotoPropsContainer())
            {
                return ctx.Database.ExecuteSqlCommand("Delete From Props where Property_Id =@p0", id);
            }
        }
    }
}
