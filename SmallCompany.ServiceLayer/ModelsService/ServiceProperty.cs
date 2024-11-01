﻿namespace SmallCompany.ServiceLayer.ModelsService
{
	public class ServiceProperty
	{
		public int Id { get; set; }
		public string Name { get; set; } = String.Empty;

		public int ServiceDateTypeId { get; set; } //např. text(string), číslo(float)..
		public ServiceDateType ServiceDateType { get; set; } = null!;
		private List<ServiceItemPropertyValue> ServiceItemPropertyValues { get; set; } = new List<ServiceItemPropertyValue>();

	}
}
