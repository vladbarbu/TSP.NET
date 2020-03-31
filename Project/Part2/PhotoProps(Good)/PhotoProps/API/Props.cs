using System.Linq;
using System.Data.Entity;

namespace PhotoProps
{
    public partial class Props
    {
        public bool AddProp()
        {
            using (ModelPhotoPropsContainer ctx = new ModelPhotoPropsContainer())
            {
                bool bResult = false;
                if (this == null || this.PhotoPhoto_Id == 0)
                    return bResult;
                if (this.Property_Id == 0)
                {
                    ctx.Entry<Props>(this).State = EntityState.Added;
                    Photo p = ctx.Photos.Find(this.PhotoPhoto_Id);
                    ctx.Entry<Photo>(p).State = EntityState.Unchanged;
                    ctx.SaveChanges();
                    bResult = true;
                }
                return bResult;
            }
        }
        public Props UpdateProp(Props newProp)
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
        public Props GetPropById(int id)
        {
            using (ModelPhotoPropsContainer ctx = new ModelPhotoPropsContainer())
            {
                var items = from c in ctx.Props where (c.Property_Id == id) select c;
                return items.Include(p => p.Photo).SingleOrDefault();
            }
        }

    }
}
