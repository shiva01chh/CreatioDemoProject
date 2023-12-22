namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ICalendarOperationProviderSchema

	/// <exclude/>
	public class ICalendarOperationProviderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ICalendarOperationProviderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ICalendarOperationProviderSchema(ICalendarOperationProviderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("612d2abe-2c2a-4f21-8270-8e0f51100801");
			Name = "ICalendarOperationProvider";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("761f835c-6644-4753-9a3e-2c2ccab7b4d0");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,213,84,93,139,211,64,20,125,222,66,255,195,208,167,21,36,249,1,102,3,210,93,164,32,174,104,213,7,217,135,73,114,83,7,231,35,204,157,169,4,241,191,123,111,154,105,106,107,105,17,124,216,18,40,51,220,123,238,57,39,231,198,74,3,216,201,26,196,26,188,151,232,218,144,45,157,109,213,38,122,25,148,179,217,82,106,176,141,244,56,159,253,156,207,110,34,42,187,17,31,123,12,96,94,29,157,169,83,107,168,185,13,179,55,96,193,171,122,170,57,51,96,42,72,147,214,202,192,39,171,130,184,187,76,42,75,197,4,67,64,121,158,139,2,163,49,210,247,229,120,254,0,157,7,4,27,80,72,81,143,141,194,117,176,195,18,157,119,91,213,128,207,82,127,126,0,208,197,74,171,90,40,27,192,183,108,211,42,141,126,76,0,239,199,126,170,102,131,78,56,12,23,175,155,134,166,111,165,142,32,92,43,2,177,22,145,104,163,8,78,52,50,0,235,16,85,63,17,84,182,117,222,236,228,238,97,243,99,220,162,147,94,26,97,233,53,222,45,18,206,162,76,36,135,65,89,145,15,85,127,111,26,56,45,202,207,252,119,90,233,33,68,111,241,4,48,221,115,225,125,162,79,34,111,247,135,68,230,37,155,183,83,254,98,247,146,158,155,67,97,140,216,162,92,39,82,255,219,210,175,143,21,58,13,1,158,174,49,248,100,113,18,227,107,189,31,118,149,224,38,111,27,217,227,31,102,255,0,248,46,104,199,59,77,117,255,100,119,29,245,184,112,106,235,46,56,200,211,112,233,162,37,211,223,69,83,129,231,76,12,183,28,135,205,200,247,10,115,89,200,145,185,111,21,134,98,191,199,247,178,47,247,6,124,225,9,231,50,60,145,186,96,38,103,246,27,28,68,248,90,191,232,147,162,92,131,20,52,106,31,15,231,53,174,167,21,169,153,213,145,76,166,76,92,82,40,240,118,245,96,163,33,153,149,134,34,73,92,241,135,141,2,82,166,113,44,237,230,215,124,70,207,225,239,55,187,19,68,145,40,6,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("612d2abe-2c2a-4f21-8270-8e0f51100801"));
		}

		#endregion

	}

	#endregion

}

