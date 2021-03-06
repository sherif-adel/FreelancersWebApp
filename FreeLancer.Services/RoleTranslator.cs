//------------------------------------------------------------------------------
//------------------------------------------------------------------------------

namespace FreeLancer.Services
{
    using System;
    using System.Collections.Generic;using System.Linq;using System.Text;using System.Threading.Tasks;using FreeLancers.Models;using FreeLancers.Service.Contracts;
    
    public partial class RolesTranslator
    {
        #region Convert to Entities
    public static Role ConvertToRoleEntity(RoleContract role){
    
    if(role == null)
    	return null;
    Role entityRole = new Role(){
    	
        RoleID=role.RoleID,
        RoleName=role.RoleName,
         };
    return entityRole;}
    public static ICollection<Role> ConvertToRoleEntity(List<RoleContract> roles)
    {
    		if(roles == null)
    			return null;
    
           List<Role> newRoles = new List<Role>();
    		foreach (var role in roles)
    		{
    			newRoles.Add(ConvertToRoleEntity(role));
    		}
    		return newRoles;
    }

        #endregion

        #region Convert to Contracts
    public static RoleContract ConvertToRoleContract(Role role){
    
    		if(role == null)
    			return null;
    
    		RoleContract contractRole = new RoleContract(){
    
            RoleID=role.RoleID,RoleName=role.RoleName,};
    return contractRole;}
    public static List<RoleContract> ConvertToRoleContract(ICollection<Role> roles){
    
    		if(roles == null)
    			return null;
           List<RoleContract> newRoles = new List<RoleContract>();
    			foreach (var role in roles)
    			{
    				newRoles.Add(ConvertToRoleContract(role));
    			}
    			return newRoles;
    	}
        #endregion

    	
    
}}
