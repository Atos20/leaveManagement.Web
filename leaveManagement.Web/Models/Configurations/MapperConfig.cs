using System;
using AutoMapper;
using leaveManagement.Web.Data;

namespace leaveManagement.Web.Models.Configurations
{
	public class MapperConfig : Profile
	{
		public MapperConfig()
		{
			CreateMap<LeaveType, LeaveTypeVM>().ReverseMap();
		}
	}
}

