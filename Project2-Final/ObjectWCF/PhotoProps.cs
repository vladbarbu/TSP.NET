using System;
using System.Collections.Generic;
using PhotoProps;
using PhotoProps.APIStatic;


namespace ObjectWCF
{
    public class PhotoProps : IPhotoProps
    {
        bool InterfaceProps.AddProp(Props prop)
        {
            return prop.AddProp();
        }
        bool InterfacePhotos.AddPhoto(Photo photo)
        {
            return photo.AddPhoto();
            //return API.AddPost(post);
        }
        int InterfacePhotos.DeletePhoto(int id)
        {
            Photo photo = new Photo();
            return photo.DeletePhoto(id);
            // static
            //return API.DeletePhoto(id);
        }

        int InterfaceProps.DeleteProp(int id)
        {
            Props prop = new Props();
            return prop.DeleteProp(id);
            // static
            //return API.DeletePhoto(id);
        }

        Props InterfaceProps.GetPropById(int id)
        {
            Props prop = new Props();
            return prop.GetPropById(id);
        }
        Photo InterfacePhotos.GetPhotoById(int id)
        {
            // E nevoie de ac instanta. Metodele din API sunt metode ale instantei.
            Photo photo = new Photo();
            // Mesaj ce apare in server CUI. Nu e necesar.
            Console.WriteLine("GetPhotoById. Id = {0}", id);
            photo = photo.GetPhotoById(id); // Neclar acest cod.
            Console.WriteLine("Photo returnat. Id = {0} , Path = {1}, Date = {2}",
            photo.Photo_Id, photo.Photo_Path, photo.Photo_Date);
            return photo;
        }
        List<Photo> InterfacePhotos.GetPhotos()
        {
            Photo photo = new Photo();
            return photo.GetAllPhotos();
        }
        Props InterfaceProps.UpdateProp(Props newProp)
        {
            return newProp.UpdateProp(newProp);
        }
        Photo InterfacePhotos.UpdatePhoto(Photo photo)
        {
            return photo.UpdatePhoto(photo);
        }
    }

}
