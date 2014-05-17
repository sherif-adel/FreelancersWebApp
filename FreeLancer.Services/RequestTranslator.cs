//------------------------------------------------------------------------------
//------------------------------------------------------------------------------

namespace FreeLancer.Services
{
    using System;
    using System.Collections.Generic;using System.Linq;using System.Text;using System.Threading.Tasks;using FreeLancers.Models;using FreeLancers.Service.Contracts;
    
    public partial class RequestsTranslator
    {
        #region Convert to Entities
    public static Request ConvertToRequestEntity(RequestContract request){
    
    if(request == null)
    	return null;
    Request entityRequest = new Request(){
    	
        RequestID=request.RequestID,
        UserID=request.UserID,
        FreelancerID=request.FreelancerID,
        Description=request.Description,
        StatusID=request.StatusID,
        StartDate=request.StartDate,
        EndDate=request.EndDate,
        AverageCost=request.AverageCost,
         };
    return entityRequest;}
    public static ICollection<Request> ConvertToRequestEntity(List<RequestContract> requests)
    {
    		if(requests == null)
    			return null;
    
           List<Request> newRequests = new List<Request>();
    		foreach (var request in requests)
    		{
    			newRequests.Add(ConvertToRequestEntity(request));
    		}
    		return newRequests;
    }

        #endregion

        #region Convert to Contracts
    public static RequestContract ConvertToRequestContract(Request request){
    
    		if(request == null)
    			return null;
    
    		RequestContract contractRequest = new RequestContract(){
    
            RequestID=request.RequestID,UserID=request.UserID,FreelancerID=request.FreelancerID,Description=request.Description,StatusID=request.StatusID,StartDate=request.StartDate,EndDate=request.EndDate,AverageCost=request.AverageCost,};
    return contractRequest;}
    public static List<RequestContract> ConvertToRequestContract(ICollection<Request> requests){
    
    		if(requests == null)
    			return null;
           List<RequestContract> newRequests = new List<RequestContract>();
    			foreach (var request in requests)
    			{
    				newRequests.Add(ConvertToRequestContract(request));
    			}
    			return newRequests;
    	}
        #endregion

    	
    
}}
