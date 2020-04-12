using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelApi;

namespace ObjectWCF
{
    class PhotoPropsWCF : IPhotoProps
    {
        bool InterfacePhoto.AddPictures(string path)
        {
            PhotosProps photo = new PhotosProps();
            return photo.AddPictures(path);
        }

        List<Tuple<string, int>> InterfacePhoto.GetAllImages()
        {
            PhotosProps photo = new PhotosProps();
            return photo.GetAllImages();
        }

        void InterfacePhoto.RemoveImage(int img_id)
        {
            PhotosProps photo = new PhotosProps();
            photo.RemoveImage(img_id);
        }
        List<Tuple<string, string, int>> InterfacePhoto.GetDetailsForImage(int img_id)
        {
            PhotosProps photo = new PhotosProps();
            return photo.GetDetailsForImage(img_id);
        }

        List<Tuple<string, int>> InterfacePhoto.GetFilteredImages(List<string> filter)
        {
            PhotosProps photo = new PhotosProps();
            return photo.GetFilteredImages(filter);
        }

        void InterfaceProps.AddProperty(string property, string description, int img_id)
        {
            PhotosProps props = new PhotosProps();
            props.AddProperty(property, description, img_id);
        }

        List<string> InterfaceProps.GetAllLabels()
        {
            PhotosProps props = new PhotosProps();
            return props.GetAllLabels();
        }

        void InterfaceProps.RemoveProperty(int prop_id)
        {
            PhotosProps props = new PhotosProps();
            props.RemoveProperty(prop_id);
        }


    }
}
