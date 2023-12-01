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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,213,84,219,106,219,64,16,125,142,193,255,48,248,41,133,34,125,64,20,65,113,74,49,148,36,164,110,251,80,242,176,146,70,238,210,189,136,189,184,136,210,127,239,140,172,181,82,187,198,166,208,135,26,129,217,101,230,204,57,71,103,100,132,70,223,137,26,97,141,206,9,111,219,144,45,173,105,229,38,58,17,164,53,217,82,40,52,141,112,126,62,251,49,159,93,69,47,205,6,62,244,62,160,190,57,56,83,167,82,88,115,155,207,222,161,65,39,235,169,230,196,128,169,32,77,90,75,141,31,141,12,112,123,158,84,150,138,9,134,128,242,60,135,194,71,173,133,235,203,241,252,132,157,67,143,38,120,16,80,143,141,96,59,220,97,65,231,236,86,54,232,178,212,159,191,0,232,98,165,100,13,210,4,116,45,219,180,74,163,31,18,192,227,216,79,213,108,208,17,135,225,226,77,211,208,244,173,80,17,193,182,16,136,53,68,162,237,33,88,104,68,64,214,1,85,63,17,148,166,181,78,239,228,238,97,243,67,220,162,19,78,104,48,244,26,111,23,9,103,81,38,146,195,160,172,200,135,170,63,55,13,156,22,229,39,254,59,174,116,24,162,51,254,8,48,221,115,225,93,162,79,34,175,247,135,68,230,53,155,183,83,254,106,247,146,254,55,135,194,24,177,69,185,78,164,254,181,165,95,30,42,111,21,6,124,190,196,224,163,197,73,140,47,245,126,216,85,130,155,188,109,68,239,127,51,251,59,226,55,160,29,239,20,213,253,149,221,117,84,227,194,201,173,61,227,32,79,243,75,27,13,153,126,31,117,133,142,51,49,220,114,28,54,35,223,11,204,101,33,7,230,190,151,62,20,251,61,190,19,125,185,55,224,51,79,56,149,225,137,212,25,51,57,179,95,241,69,132,47,245,139,62,41,210,54,158,130,70,237,227,225,180,198,245,180,34,53,179,58,144,201,148,137,75,10,133,191,94,189,53,81,147,204,74,97,145,36,174,248,195,70,1,41,211,56,150,118,245,115,62,163,135,126,191,0,164,245,102,26,31,6,0,0 };
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

