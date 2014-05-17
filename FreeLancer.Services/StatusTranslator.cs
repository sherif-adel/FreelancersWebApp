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
    
    if(status == null)
    	return null;
    Status entityStatus = new Status(){
    	
        StatusID=status.StatusID,
        Name=status.Name,
        RoleID=status.RoleID,
         };
    return entityStatus;}
    public static ICollection<Status> ConvertToStatusEntity(List<StatusContract> statuss)
    {
    		if(statuss == null)
    			return null;
    
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
    
    		if(status == null)
    			return null;
    
    		StatusContract contractStatus = new StatusContract(){
    
            StatusID=status.StatusID,Name=status.Name,RoleID=status.RoleID,};
    return contractStatus;}
    public static List<StatusContract> ConvertToStatusContract(ICollection<Status> statuss){
    
    		if(statuss == null)
    			return null;
           List<StatusContract> newStatuss = new List<StatusContract>();
    			foreach (var status in statuss)
    			{
    				newStatuss.Add(ConvertToStatusContract(status));
    			}
    			return newStatuss;
    	}
        #endregion

    	
    
}}
