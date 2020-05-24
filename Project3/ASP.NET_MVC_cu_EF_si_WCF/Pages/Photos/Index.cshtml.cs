using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP.NET_MVC_cu_EF_si_WCF.Models;
using ASP.NET_MVC_cu_EF_si_WCF.Data;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ServiceReferencePhotosProps;
using Microsoft.AspNetCore.Mvc;
namespace ASP.NET_MVC_cu_EF_si_WCF.Pages.Photos
{
    public class IndexModel : PageModel
    {
        PhotoPropsClient pcc = new PhotoPropsClient();
        public List<PhotoDTO> Photos { get; set; }

        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }

        [BindProperty(SupportsGet = true)]
        public int NumberOfFiles { get; set; }

        public IndexModel()
        {
            Photos = new List<PhotoDTO>();
        }
        public async Task OnGetAsync()
        {
            var photos = await pcc.GetPhotosAsync();
            NumberOfFiles = 0;
            foreach (var item in photos)
            {
                // Trebuia folosit AutoMapper. Transform Photo in PhotoDTO
                PhotoDTO pd = new PhotoDTO();
                pd.Photo_Id = item.Photo_Id;
                pd.Photo_Date = item.Photo_Date;
                pd.Photo_Path = item.Photo_Path;
                var flag = false;
                foreach (var cc in item.Props)
                {
                    PropsDTO cdto = new PropsDTO();
                    cdto.PhotoPhoto_Id = cc.PhotoPhoto_Id;
                    cdto.Property_Id = cc.Property_Id;
                    cdto.Property_Name = cc.Property_Name;
                    cdto.Property_Description = cc.Property_Description;
                    if (!string.IsNullOrEmpty(SearchString))
                    {
                        if (cdto.Property_Description.Contains(SearchString) ||
                           cdto.Property_Name.Contains(SearchString))
                        {
                            pd.Props.Add(cdto);
                            flag = true;
                        }
                    }
                }
                if (!string.IsNullOrEmpty(SearchString))
                {
                    if (flag)
                    {
                        Photos.Add(pd);
                        NumberOfFiles += 1;
                    }
                }
                else
                {
                    Photos.Add(pd);
                    NumberOfFiles += 1;
                }
            }
            Photos = Photos.OrderBy(x => x.Photo_Path).ToList();
        }

    }
}