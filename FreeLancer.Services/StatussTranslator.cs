
//------------------------------------------------------------------------------
//------------------------------------------------------------------------------


namespace FreeLancer.Services
{

using System;
    using System.Collections.Generic;using System.Linq;using System.Text;using System.Threading.Tasks;using FreeLancers.Models;using FreeLancers.Service.Contracts;
    
public partial class StatussTranslator
{

    #region Convert to Entities
    
public static Status ConvertToStatusEntity(StatusContract status){

Status entityStatus = new Status(){

    StatusID=status.StatusID,
    Name=status.Name,
    RoleID=status.RoleID,
    


        Requests=RequestsTranslator.ConvertToRequestEntity(status.Requests),
    Role=RolesTranslator.ConvertToRoleEntity(status.Role),
    
 };
return entityStatus;}

public static ICollection<Status> ConvertToStatusEntity(ICollection<StatusContract> statuss){

       List<Status> newStatuss = new List<Status>();
    			foreach (var status in statuss)
    			{
    				newStatuss.Add(ConvertToStatusEntity(status));
    			}
    			return newStatuss;
    		}

        #endregion

    
    #region Convert to Contracts
    
public static StatusContract ConvertToStatusContract(Status status){

StatusContract contractStatus = new StatusContract(){

            StatusID=status.StatusID,Name=status.Name,RoleID=status.RoleID,
                Requests=RequestsTranslator.ConvertToRequestContract(status.Requests),
                Role=RolesTranslator.ConvertToRoleContract(status.Role),};
return contractStatus;}

public static ICollection<StatusContract> ConvertToStatusContract(ICollection<Status> statuss){

       List<StatusContract> newStatuss = new List<StatusContract>();
    			foreach (var status in statuss)
    			{
    				newStatuss.Add(ConvertToStatusContract(status));
    			}
    			return newStatuss;
    	}
        #endregion

    	


}}
