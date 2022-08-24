using DataAccessLayer;
using LogicLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Drawing.Imaging;

namespace ZooBazzarWebApp.Pages
{
    public class MyTicketsModel : PageModel
    {
        public TicketManager tm = new TicketManager(new TicketsDB(), new TicketsDB());
        public CustomerManager cm = new CustomerManager(new CustomerDB());
        public Image img;
        Zen.Barcode.Code128BarcodeDraw brCode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;

        public void OnGet()
        {
        }

        public string ConvertImageToUrl(int id)
        {
            try
            {
                img = (Image)brCode.Draw(id.ToString(), 60);
                if (img != null)
                {
                    MemoryStream ms = new MemoryStream();
                    img.Save(ms, ImageFormat.Bmp);
                    string base64 = Convert.ToBase64String(ms.ToArray());

                    string fs = string.Format("data:image/jpg;base64,{0}", base64);
                    return fs;
                }
                return null;
            }
            catch (Exception ex )
            {

                throw ex;
            }
            
        }
    }
}
