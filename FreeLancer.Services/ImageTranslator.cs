//------------------------------------------------------------------------------
//------------------------------------------------------------------------------

namespace FreeLancer.Services
{
    using System;
    using System.Collections.Generic;using System.Linq;using System.Text;using System.Threading.Tasks;using FreeLancers.Models;using FreeLancers.Service.Contracts;
    
    public partial class ImagesTranslator
    {
        #region Convert to Entities
    public static Image ConvertToImageEntity(ImageContract image){
    
    if(image == null)
    	return null;
    Image entityImage = new Image(){
    	
        ImageID=image.ImageID,
        GUID=image.GUID,
        Name=image.Name,
        FileData=image.FileData,
        ProfileID=image.ProfileID,
         };
    return entityImage;}
    public static ICollection<Image> ConvertToImageEntity(List<ImageContract> images)
    {
    		if(images == null)
    			return null;
    
           List<Image> newImages = new List<Image>();
    		foreach (var image in images)
    		{
    			newImages.Add(ConvertToImageEntity(image));
    		}
    		return newImages;
    }

        #endregion

        #region Convert to Contracts
    public static ImageContract ConvertToImageContract(Image image){
    
    		if(image == null)
    			return null;
    
    		ImageContract contractImage = new ImageContract(){
    
            ImageID=image.ImageID,GUID=image.GUID,Name=image.Name,FileData=image.FileData,ProfileID=image.ProfileID,};
    return contractImage;}
    public static List<ImageContract> ConvertToImageContract(ICollection<Image> images){
    
    		if(images == null)
    			return null;
           List<ImageContract> newImages = new List<ImageContract>();
    			foreach (var image in images)
    			{
    				newImages.Add(ConvertToImageContract(image));
    			}
    			return newImages;
    	}
        #endregion

    	
    
}}
