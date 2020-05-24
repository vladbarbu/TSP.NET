using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ServiceReferencePhotosProps;

namespace ASP.NET_MVC_cu_EF_si_WCF.Pages.Photos
{
    public class DeleteModel : PageModel
    {
        PhotoPropsClient pcc = new PhotoPropsClient();
        [BindProperty]
        public Photo PhotoDTO { get; set; }
        public DeleteModel()
        {
        }
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
                return NotFound();
            var post = await pcc.GetPhotoByIdAsync(id.Value);
            if (post != null)
            {
                PhotoDTO = new Photo();
                PhotoDTO.Photo_Id = post.Photo_Id;
                PhotoDTO.Photo_Path = post.Photo_Path;
                PhotoDTO.Photo_Date = post.Photo_Date;
                return Page();
            }
            else
                return NotFound();
        }
        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            int result = 0;
            // Nu pot fi sterse inregistrari parinte daca exista descendenti (cheie FK activa)
 // "Prind" exceptia si afisez o pagina cu eroare. Nu e finisat aici...
 try
            {
                result = await pcc.DeletePhotoAsync(id.Value);
                // result ar trebui valorificat mai departe in cod...
            }
            catch (Exception ex)
            {
                return RedirectToPage("/Error");
            }

            return RedirectToPage("./Index");
        }
    }
}