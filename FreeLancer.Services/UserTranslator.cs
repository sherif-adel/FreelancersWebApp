//------------------------------------------------------------------------------
//------------------------------------------------------------------------------

namespace FreeLancer.Services
{
    using System;
    using System.Collections.Generic;using System.Linq;using System.Text;using System.Threading.Tasks;using FreeLancers.Models;using FreeLancers.Service.Contracts;
    
    public partial class UsersTranslator
    {
        #region Convert to Entities
    public static User ConvertToUserEntity(UserContract user){
    
    if(user == null)
    	return null;
    User entityUser = new User(){
    	
        UserID=user.UserID,
        FullName=user.FullName,
        Email=user.Email,
        Password=user.Password,
        Mobile=user.Mobile,
        RoleID=user.RoleID,
        CityID=user.CityID,
         };
    return entityUser;}
    public static ICollection<User> ConvertToUserEntity(List<UserContract> users)
    {
    		if(users == null)
    			return null;
    
           List<User> newUsers = new List<User>();
    		foreach (var user in users)
    		{
    			newUsers.Add(ConvertToUserEntity(user));
    		}
    		return newUsers;
    }

        #endregion

        #region Convert to Contracts
    public static UserContract ConvertToUserContract(User user){
    
    		if(user == null)
    			return null;
    
    		UserContract contractUser = new UserContract(){
    
            UserID=user.UserID,FullName=user.FullName,Email=user.Email,Password=user.Password,Mobile=user.Mobile,RoleID=user.RoleID,CityID=user.CityID,};
    return contractUser;}
    public static List<UserContract> ConvertToUserContract(ICollection<User> users){
    
    		if(users == null)
    			return null;
           List<UserContract> newUsers = new List<UserContract>();
    			foreach (var user in users)
    			{
    				newUsers.Add(ConvertToUserContract(user));
    			}
    			return newUsers;
    	}
        #endregion

    	
    
}}
