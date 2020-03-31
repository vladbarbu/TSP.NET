using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelApi;
using System.ServiceModel;

namespace ObjectWCF
{
    [ServiceContract]
    interface InterfacePhoto
    {
        [OperationContract]
        bool AddPictures(string path);
        [OperationContract]
        List<Tuple<string, int>> GetAllImages();
        [OperationContract]
        void RemoveImage(int img_id);
        [OperationContract]
        List<Tuple<string, string, int>> GetDetailsForImage(int img_id);
        [OperationContract]
        List<Tuple<string, int>> GetFilteredImages(List<string> filter);
    }
    [ServiceContract]
    interface InterfaceProps
    {
        [OperationContract]
        void AddProperty(string property, string description, int img_id);
        [OperationContract]
        void RemoveProperty(int prop_id);
        [OperationContract]
        List<string> GetAllLabels();
    }
    [ServiceContract]
    interface IPhotoProps : InterfacePhoto, InterfaceProps
    {
    }

}
