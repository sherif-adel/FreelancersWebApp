using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FreeLancers.Models;
using FreeLancers.Service.Contracts;

namespace FreeLancers.Service.Translators
{
	public static class StatusTranslator
	{
		#region ToEntity

		public static Status ConvertToStatusEntity(StatusContract status)
		{
			Status entityStatus = new Status()
			{
				Name = status.Name,
				RoleID = status.RoleID,
				StatusID = status.StatusID,
				Requests = RequestTranslator.ConvertToRequestEntity(status.Requests.ToList()),
				Role = RolesTranslator.ConvertToRoleEntity(status.Role)
			};
			return entityStatus;
		}

		public static List<Status> ConvertToStatusEntity(List<StatusContract> statuses)
		{
			List<Status> newStatuses = new List<Status>();
			foreach (var status in statuses)
			{
				newStatuses.Add(ConvertToStatusEntity(status));
			}
			return newStatuses;
		}

		#endregion

		#region ToContract

		public static StatusContract ConvertToStatusContract(Status status)
		{
			StatusContract statusContract = new StatusContract()
			{
				Name = status.Name,
				RoleID = status.RoleID,
				StatusID = status.StatusID,
                Requests = RequestTranslator.ConvertToRequestContract(status.Requests.ToList()),
				Role = RolesTranslator.ConvertToRoleContract(status.Role)
			};
			return statusContract;
		}

		public static List<StatusContract> ConvertToStatusContract(List<Status> statuses)
		{
			List<StatusContract> newStatuses = new List<StatusContract>();
			foreach (var status in statuses)
			{
				newStatuses.Add(ConvertToStatusContract(status));
			}
			return newStatuses;
		}

		#endregion
	}
}