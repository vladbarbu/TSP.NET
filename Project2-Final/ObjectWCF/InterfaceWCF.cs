using System;
using System.Collections.Generic;
using System.ServiceModel;
using PhotoProps;

namespace ObjectWCF
{
    [ServiceContract]
    interface InterfacePhotos
    {
        [OperationContract]
        bool AddPhoto(Photo photo);
        [OperationContract]
        Photo UpdatePhoto(Photo photo);
        [OperationContract]
        int DeletePhoto(int id);
        [OperationContract]
        Photo GetPhotoById(int id);
        [OperationContract]
        List<Photo> GetPhotos();
    }
    [ServiceContract]
    interface InterfaceProps
    {
        [OperationContract]
        bool AddProp(Props prop);
        [OperationContract]
        Props UpdateProp(Props newProp);
        [OperationContract]
        Props GetPropById(int id);
        [OperationContract]
        int DeleteProp(int id);
    }
    [ServiceContract]
    interface IPhotoProps : InterfacePhotos, InterfaceProps
    {
    }

}
