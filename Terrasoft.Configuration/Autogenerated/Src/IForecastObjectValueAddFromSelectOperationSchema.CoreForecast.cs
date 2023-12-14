namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IForecastObjectValueAddFromSelectOperationSchema

	/// <exclude/>
	public class IForecastObjectValueAddFromSelectOperationSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IForecastObjectValueAddFromSelectOperationSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IForecastObjectValueAddFromSelectOperationSchema(IForecastObjectValueAddFromSelectOperationSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("215656b7-d84b-1549-3dd0-2a8672dc7856");
			Name = "IForecastObjectValueAddFromSelectOperation";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e0b9d996-6f7e-4520-a678-da960c79be39");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,117,145,75,75,195,64,16,128,207,6,242,31,134,156,20,74,2,94,141,1,171,22,122,42,24,233,125,155,157,180,171,251,136,251,168,150,226,127,119,31,77,168,21,151,189,204,204,206,55,223,238,74,34,208,12,164,67,120,69,173,137,81,189,45,31,149,236,217,214,105,98,153,146,229,66,105,236,136,177,235,219,60,59,230,217,149,51,76,110,161,61,24,139,226,110,138,207,187,53,150,79,115,95,242,197,170,170,160,54,78,8,162,15,205,41,94,74,139,186,15,35,123,165,129,80,26,250,251,211,20,80,155,55,236,44,236,9,119,8,62,167,52,53,229,72,170,206,80,131,219,112,214,1,155,104,203,209,116,21,17,235,64,120,160,116,161,149,104,145,251,204,106,192,116,39,223,125,140,122,127,252,98,2,158,191,176,115,22,131,219,168,0,86,193,25,63,194,95,98,169,156,56,213,37,168,30,136,38,2,164,127,227,251,194,236,16,109,209,140,16,136,113,89,87,241,204,63,45,81,187,104,146,254,12,62,153,221,1,225,220,75,125,56,166,145,66,167,184,19,210,252,194,236,21,163,48,119,252,221,95,62,41,154,235,54,12,75,35,103,144,112,144,232,55,225,15,191,243,204,239,176,126,0,243,176,227,83,16,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("215656b7-d84b-1549-3dd0-2a8672dc7856"));
		}

		#endregion

	}

	#endregion

}

