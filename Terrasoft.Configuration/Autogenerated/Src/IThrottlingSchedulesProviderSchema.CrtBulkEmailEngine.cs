namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IThrottlingSchedulesProviderSchema

	/// <exclude/>
	public class IThrottlingSchedulesProviderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IThrottlingSchedulesProviderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IThrottlingSchedulesProviderSchema(IThrottlingSchedulesProviderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d9ef08c3-4687-47dc-a929-945b22c2edc9");
			Name = "IThrottlingSchedulesProvider";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("c3e4ee87-43fa-403d-acda-7e0e57f41b53");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,146,193,110,194,48,12,134,207,32,241,14,22,187,108,151,246,14,29,23,52,33,14,147,16,240,2,161,117,219,72,109,194,108,135,169,66,123,247,133,208,194,96,48,180,158,18,219,253,254,255,79,98,84,141,188,85,41,194,26,137,20,219,92,162,169,53,185,46,28,41,209,214,12,250,251,65,191,231,88,155,226,222,72,52,125,91,45,61,197,26,70,30,15,250,126,254,137,176,240,29,152,27,65,202,61,126,4,243,117,73,86,164,242,160,85,90,98,230,42,228,5,217,157,206,144,194,63,113,28,67,194,174,174,21,53,147,118,223,14,48,228,206,164,7,45,85,105,105,64,44,20,40,32,39,34,112,135,132,220,18,164,142,8,141,128,99,164,168,67,199,63,216,91,183,169,116,10,186,179,247,192,93,111,31,28,158,98,189,163,148,54,227,17,44,2,231,216,188,246,31,10,51,20,190,239,83,74,188,240,10,155,38,212,8,63,156,38,204,128,197,31,49,22,77,116,18,136,175,21,146,173,34,85,131,241,23,249,58,244,167,242,59,200,210,211,144,101,56,105,23,62,54,139,50,62,245,167,150,242,74,16,105,167,125,71,103,81,18,7,242,89,136,80,28,25,158,156,21,254,25,34,137,59,196,129,57,187,229,149,187,135,4,183,219,207,55,203,93,176,191,226,191,140,219,59,68,147,29,175,49,236,191,142,239,245,162,24,106,135,239,27,168,185,42,63,30,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d9ef08c3-4687-47dc-a929-945b22c2edc9"));
		}

		#endregion

	}

	#endregion

}

