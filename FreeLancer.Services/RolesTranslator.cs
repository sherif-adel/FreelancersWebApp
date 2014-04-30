
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

Role entityRole = new Role(){

    RoleID=role.RoleID,
    RoleName=role.RoleName,
    


        Status=StatussTranslator.ConvertToStatusEntity(role.Status),
    Users=UsersTranslator.ConvertToUserEntity(role.Users),
    
 };
return entityRole;}

public static ICollection<Role> ConvertToRoleEntity(ICollection<RoleContract> roles){

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

RoleContract contractRole = new RoleContract(){

            RoleID=role.RoleID,RoleName=role.RoleName,
                Status=StatussTranslator.ConvertToStatusContract(role.Status),
                Users=UsersTranslator.ConvertToUserContract(role.Users),};
return contractRole;}

public static ICollection<RoleContract> ConvertToRoleContract(ICollection<Role> roles){

       List<RoleContract> newRoles = new List<RoleContract>();
    			foreach (var role in roles)
    			{
    				newRoles.Add(ConvertToRoleContract(role));
    			}
    			return newRoles;
    	}
        #endregion

    	


}}
