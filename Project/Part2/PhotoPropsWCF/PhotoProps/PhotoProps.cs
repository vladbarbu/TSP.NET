using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelApi;
namespace ObjectWCF
{
    class PhotoProps : IPhotoProps
    {
        bool InterfacePhoto.AddPictures(string path)
        {
            return true;
        }

        List<Tuple<string, int>> GetAllImages()
        {
            return null;
        }

        bool RemoveImage(int img_id)
        {
            return true;
        }
        List<Tuple<string, string, int>> GetDetailsForImage(int img_id)
        {
            return null;
        }

        List<Tuple<string, int>> GetFilteredImages(List<string> filter)
        {
            return null;
        }




    }
}
