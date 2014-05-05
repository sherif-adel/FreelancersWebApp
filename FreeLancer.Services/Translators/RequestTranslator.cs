using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FreeLancers.Models;
using FreeLancers.Service.Contracts;

namespace FreeLancers.Service.Translators
{
    public static class RequestTranslator
    {
        #region Request

        public static Request ConvertToRequestEntity(RequestContract request)
        {
            Request entityRequest = new Request()
            {
                AverageCost = request.AverageCost,
                Description = request.Description,
                EndDate = request.EndDate,
                FreelancerID = request.FreelancerID,
                RequestID = request.RequestID,
                StartDate = request.StartDate,
                Status = StatusTranslator.ConvertToStatusEntity(request.Status),
                StatusID = request.StatusID,
                User = UsersTranslator.ConvertToUserEntity(request.User),
                UserID = request.UserID
            };
            return entityRequest;
        }

        public static List<Request> ConvertToRequestEntity(List<RequestContract> requests)
        {
            List<Request> newRequests = new List<Request>();
            foreach (var request in requests)
            {
                newRequests.Add(ConvertToRequestEntity(request));
            }
            return newRequests;
        }

        public static RequestContract ConvertToRequestContract(Request request)
        {
            RequestContract contractRequest = new RequestContract()
            {
                AverageCost = request.AverageCost,
                Description = request.Description,
                EndDate = request.EndDate,
                FreelancerID = request.FreelancerID,
                RequestID = request.RequestID,
                StartDate = request.StartDate,
                Status = StatusTranslator.ConvertToStatusContract(request.Status),
                StatusID = request.StatusID,
                User = UsersTranslator.ConvertToUserContract(request.User),
                UserID = request.UserID
            };
            return contractRequest;
        }

        public static List<RequestContract> ConvertToRequestContract(List<Request> requests)
        {
            List<RequestContract> newRequests = new List<RequestContract>();
            foreach (var request in requests)
            {
                newRequests.Add(ConvertToRequestContract(request));
            }
            return newRequests;
        }

        #endregion
    }
}
