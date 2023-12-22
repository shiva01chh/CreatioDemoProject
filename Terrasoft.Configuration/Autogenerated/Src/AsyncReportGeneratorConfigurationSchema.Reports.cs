namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: AsyncReportGeneratorConfigurationSchema

	/// <exclude/>
	public class AsyncReportGeneratorConfigurationSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public AsyncReportGeneratorConfigurationSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public AsyncReportGeneratorConfigurationSchema(AsyncReportGeneratorConfigurationSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("320cda9d-04b0-419a-991e-dff36d9fb757");
			Name = "AsyncReportGeneratorConfiguration";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f8ef1a6f-6619-48e3-9227-afa9b7782f83");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,144,193,110,194,48,12,134,207,32,241,14,22,187,211,59,108,72,83,15,92,118,64,104,60,64,200,156,18,45,141,43,59,149,134,170,189,251,220,180,157,24,155,88,110,191,227,223,246,247,71,83,163,52,198,34,188,34,179,17,114,105,85,82,116,190,106,217,36,79,113,49,239,22,243,217,3,99,165,2,202,96,68,214,240,44,151,104,15,216,16,167,29,70,212,78,226,27,151,154,138,162,128,71,105,235,218,240,101,59,106,53,49,10,198,36,96,0,63,18,70,233,231,146,131,116,70,237,70,4,203,232,158,150,247,166,47,139,45,56,98,48,253,25,103,166,72,173,0,103,3,84,131,67,187,86,211,9,197,213,13,77,123,10,222,130,237,57,254,199,128,53,220,167,156,117,153,244,59,159,61,83,131,156,60,106,72,251,188,106,248,191,141,34,23,118,168,41,40,134,96,78,195,154,16,78,198,190,195,241,240,146,241,34,37,239,188,29,46,209,132,44,213,77,192,73,253,201,251,27,120,34,150,196,62,86,80,142,75,142,28,160,83,115,218,244,235,55,240,57,114,96,124,27,80,178,30,170,63,139,90,187,126,95,171,114,153,149,65,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("320cda9d-04b0-419a-991e-dff36d9fb757"));
		}

		#endregion

	}

	#endregion

}

