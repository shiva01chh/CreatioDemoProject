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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,146,77,110,194,48,16,133,215,32,113,135,17,221,180,155,100,15,41,27,84,33,22,149,16,112,1,147,76,18,75,137,77,103,198,84,17,234,221,107,76,194,95,161,85,179,178,103,38,223,123,207,182,81,53,242,86,165,8,107,36,82,108,115,137,166,214,228,186,112,164,68,91,51,232,239,7,253,158,99,109,138,71,35,209,244,109,181,244,20,107,24,121,60,232,251,249,39,194,194,119,96,110,4,41,247,248,17,204,215,37,89,145,202,131,86,105,137,153,171,144,23,100,119,58,67,10,255,196,113,12,9,187,186,86,212,76,218,125,59,192,144,59,147,30,180,84,165,165,1,177,80,160,128,156,136,192,29,18,114,75,144,58,34,52,2,142,145,162,14,29,95,176,183,110,83,233,20,116,103,239,15,119,189,125,112,120,138,245,142,82,218,140,71,176,8,156,99,243,214,127,40,204,80,248,177,79,41,241,202,43,108,154,80,35,252,112,154,48,3,22,127,196,88,52,209,73,32,190,85,72,182,138,84,13,198,95,228,235,208,159,202,207,32,75,79,67,150,225,164,93,248,216,44,202,248,212,159,90,202,27,65,164,157,246,29,157,69,73,28,200,103,33,66,113,100,120,114,86,248,103,136,36,238,16,7,230,236,158,87,238,30,18,220,111,63,223,45,119,193,126,139,255,50,110,239,16,77,118,188,198,176,255,58,190,215,171,98,168,93,126,223,67,60,170,138,38,3,0,0 };
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

