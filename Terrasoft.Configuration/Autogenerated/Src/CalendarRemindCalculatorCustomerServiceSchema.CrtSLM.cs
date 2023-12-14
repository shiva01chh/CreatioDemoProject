namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CalendarRemindCalculatorCustomerServiceSchema

	/// <exclude/>
	public class CalendarRemindCalculatorCustomerServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CalendarRemindCalculatorCustomerServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CalendarRemindCalculatorCustomerServiceSchema(CalendarRemindCalculatorCustomerServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("edcd46c2-7ae7-4652-8fc1-4857d18db187");
			Name = "CalendarRemindCalculatorCustomerService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("50529f8b-8504-4b8d-9a81-5bda32bd1be4");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,82,193,106,194,64,16,61,71,240,31,6,189,68,16,63,64,241,20,74,201,161,80,106,123,42,61,172,155,49,93,72,54,97,118,87,17,205,191,119,118,19,107,180,8,105,14,11,111,118,223,188,247,102,226,140,210,57,108,142,198,98,185,26,143,92,128,239,72,36,76,181,179,139,164,34,228,242,120,164,69,137,166,22,18,111,46,245,78,229,142,132,85,149,30,143,78,254,93,52,37,204,25,66,82,8,99,150,144,136,2,117,38,232,13,75,165,51,70,210,21,194,86,148,56,99,171,18,105,131,180,87,18,3,181,118,219,66,73,144,158,57,148,8,143,37,184,35,91,138,174,142,42,109,44,57,201,87,108,236,149,212,94,216,86,56,170,91,48,84,52,254,48,72,220,78,163,244,209,193,221,192,153,239,24,45,97,43,12,198,119,87,16,28,53,173,234,148,181,90,111,29,238,140,190,160,253,174,50,239,49,12,164,179,216,14,199,88,158,182,28,60,157,132,144,115,165,28,92,104,137,255,138,49,135,103,167,50,144,156,34,205,58,227,209,94,80,168,60,105,171,236,17,214,144,163,77,126,113,124,223,161,37,207,65,227,225,243,11,78,48,233,148,83,254,219,210,108,50,135,9,175,161,34,166,50,130,102,182,10,34,106,23,247,53,214,160,93,81,192,249,220,83,94,92,121,254,129,119,186,120,42,107,123,188,24,141,8,173,35,29,168,109,215,38,156,151,50,30,6,47,251,207,10,193,39,230,236,61,147,205,234,193,94,187,90,191,196,21,255,253,0,227,32,51,204,122,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("edcd46c2-7ae7-4652-8fc1-4857d18db187"));
		}

		#endregion

	}

	#endregion

}

