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

		public static Status ConverToStatusEntity(StatusContract status)
		{
			Status entityStatus = new Status()
			{
				Name = status.Name,
				RoleID = status.RoleID,
				StatusID = status.StatusID,
				Requests = RequestTranslator.ConverToRequestEntity(status.Requests.ToList()),
				Role = RolesTranslator.ConverToRoleEntity(status.Role)
			};
			return entityStatus;
		}

		public static List<Status> ConverToStatusEntity(List<StatusContract> statuses)
		{
			List<Status> newStatuses = new List<Status>();
			foreach (var status in statuses)
			{
				newStatuses.Add(ConverToStatusEntity(status));
			}
			return newStatuses;
		}

		#endregion

		#region ToContract

		public static StatusContract ConverToStatusContract(Status status)
		{
			StatusContract statusContract = new StatusContract()
			{
				Name = status.Name,
				RoleID = status.RoleID,
				StatusID = status.StatusID,
                Requests = RequestTranslator.ConverToRequestContract(status.Requests.ToList()),
				Role = RolesTranslator.ConverToRoleContract(status.Role)
			};
			return statusContract;
		}

		public static List<StatusContract> ConverToStatusContract(List<Status> statuses)
		{
			List<StatusContract> newStatuses = new List<StatusContract>();
			foreach (var status in statuses)
			{
				newStatuses.Add(ConverToStatusContract(status));
			}
			return newStatuses;
		}

		#endregion
	}
}