using Freelancers.BLL;
using FreeLancers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FreeLancers.UI.Common
{
    /// <summary>
    /// Summary description for ImageHandler
    /// </summary>
    public class ImageHandler : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            string imageID = null;
            imageID = context.Request.QueryString["imageID"];
            if (!string.IsNullOrEmpty(imageID))
            {
                context.Response.Clear();
                context.Response.ContentType = "image/jpeg";
                FreeLancersEntities entitites = new FreeLancersEntities();
                ImageManager imageManager = new ImageManager(entitites);
                var image = imageManager.GetById(int.Parse(imageID));
                byte[] buffer = image.FileData;
                context.Response.OutputStream.Write(buffer, 0, buffer.Length);
                context.Response.End();
            }
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}