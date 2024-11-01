﻿using SmallCompany.ClientBlazorIdentity.ModelsBlazor;
using SmallCompany.ServiceLayer.ModelsService;

namespace SmallCompany.ClientBlazorIdentity.Mappers
{
	public static class PropertyMapper
	{
		public static BlazorProperty MapServiceBlazorProperty(ServiceProperty serviceProperty)
		{
			BlazorProperty blazorProperty = new BlazorProperty();
			blazorProperty.Id = serviceProperty.Id;
			blazorProperty.Name = serviceProperty.Name;
			blazorProperty.BlazorDateTypeId = serviceProperty.ServiceDateTypeId;

			return blazorProperty;

		}

		public static ServiceProperty MapBlazorServicePorperty(BlazorProperty blazorProperty)
		{
			ServiceProperty serviceProperty = new ServiceProperty();
			serviceProperty.Id = blazorProperty.Id;
			serviceProperty.Name = blazorProperty.Name;
			serviceProperty.ServiceDateTypeId = blazorProperty.BlazorDateTypeId;

			return serviceProperty;
		}
	}
}
