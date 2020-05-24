using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ServiceReferencePhotosProps;

namespace ASP.NET_MVC_cu_EF_si_WCF.Pages.Properties
{
    public class ListModel : PageModel
    {
        PhotoPropsClient pcc = new PhotoPropsClient();
        public List<Props> Props { get; set; }
        public ListModel()
        {
            Props = new List<Props>();
        }
        public async Task OnGetAsync(int? id)
        {
            if (!id.HasValue)
                return;
            var item = await pcc.GetPhotoByIdAsync(id.Value);
            ViewData["Photo"] = item.Photo_Id.ToString() + " : " + item.Photo_Path.Trim();
            foreach (var cc in item.Props)
            {
                Props cdto = new Props();
                cdto.PhotoPhoto_Id = cc.PhotoPhoto_Id;
                cdto.Property_Description = cc.Property_Description;
                cdto.Property_Id = cc.Property_Id;
                cdto.Property_Name = cc.Property_Name;
                Props.Add(cdto);
            }
            Props = Props.OrderBy(x => x.Property_Name).ToList();

        }
    }
}