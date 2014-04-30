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

        public static Request ConverToRequestEntity(RequestContract request)
        {
            Request entityRequest = new Request()
            {
                AverageCost = request.AverageCost,
                Description = request.Description,
                EndDate = request.EndDate,
                FreelancerID = request.FreelancerID,
                RequestID = request.RequestID,
                StartDate = request.StartDate,
                Status = StatusTranslator.ConverToStatusEntity(request.Status),
                StatusID = request.StatusID,
                User = UsersTranslator.ConverToUserEntity(request.User),
                UserID = request.UserID
            };
            return entityRequest;
        }

        public static List<Request> ConverToRequestEntity(List<RequestContract> requests)
        {
            List<Request> newRequests = new List<Request>();
            foreach (var request in requests)
            {
                newRequests.Add(ConverToRequestEntity(request));
            }
            return newRequests;
        }

        public static RequestContract ConverToRequestContract(Request request)
        {
            RequestContract contractRequest = new RequestContract()
            {
                AverageCost = request.AverageCost,
                Description = request.Description,
                EndDate = request.EndDate,
                FreelancerID = request.FreelancerID,
                RequestID = request.RequestID,
                StartDate = request.StartDate,
                Status = StatusTranslator.ConverToStatusContract(request.Status),
                StatusID = request.StatusID,
                User = UsersTranslator.ConverToUserContract(request.User),
                UserID = request.UserID
            };
            return contractRequest;
        }

        public static List<RequestContract> ConverToRequestContract(List<Request> requests)
        {
            List<RequestContract> newRequests = new List<RequestContract>();
            foreach (var request in requests)
            {
                newRequests.Add(ConverToRequestContract(request));
            }
            return newRequests;
        }

        #endregion
    }
}
