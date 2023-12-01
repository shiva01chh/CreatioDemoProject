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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,117,145,221,75,195,48,16,192,159,45,244,127,56,250,164,48,18,240,213,90,112,234,96,79,3,43,123,207,154,235,22,205,71,205,199,116,12,255,119,211,116,45,115,98,200,203,221,229,126,247,75,162,153,66,215,177,6,225,21,173,101,206,180,158,60,26,221,138,109,176,204,11,163,201,194,88,108,152,243,235,219,60,59,230,217,85,112,66,111,161,62,56,143,234,110,138,207,187,45,146,167,121,44,197,34,165,20,74,23,148,98,246,80,157,226,165,246,104,219,126,100,107,44,48,206,251,254,246,52,5,204,230,13,27,15,123,38,3,66,204,25,203,29,25,73,244,12,213,133,141,20,13,136,137,182,28,77,87,9,177,238,9,15,156,47,172,81,53,202,152,89,117,56,220,41,118,31,147,222,31,191,148,128,231,47,108,130,199,222,109,84,0,111,224,140,159,224,47,169,68,38,14,189,4,149,29,179,76,129,142,111,124,95,184,29,162,47,170,17,2,41,38,37,77,103,254,105,73,218,69,53,232,207,224,83,248,29,48,41,163,212,71,16,22,57,52,70,6,165,221,47,204,222,8,14,243,32,223,227,229,7,69,119,93,247,195,134,145,51,24,112,48,208,111,250,63,252,206,179,184,227,250,1,222,179,73,95,15,2,0,0 };
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

