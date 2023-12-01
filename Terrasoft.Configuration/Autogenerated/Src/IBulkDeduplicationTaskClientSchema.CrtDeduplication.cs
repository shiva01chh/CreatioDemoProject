namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IBulkDeduplicationTaskClientSchema

	/// <exclude/>
	public class IBulkDeduplicationTaskClientSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IBulkDeduplicationTaskClientSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IBulkDeduplicationTaskClientSchema(IBulkDeduplicationTaskClientSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("fef75578-f348-4491-a5ba-51e5ae6801c5");
			Name = "IBulkDeduplicationTaskClient";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("4c53ad23-c903-414d-89cd-b08703861304");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,229,147,77,79,195,48,12,134,207,32,241,31,44,184,128,132,218,59,31,67,131,33,180,11,66,128,196,217,91,221,17,173,77,170,216,153,54,33,254,59,110,218,178,141,242,121,166,167,218,241,99,191,177,99,139,37,113,133,83,130,71,242,30,217,229,146,92,57,155,155,89,240,40,198,217,100,68,89,168,10,51,141,214,222,238,203,222,238,78,96,99,103,176,117,112,93,32,139,153,38,35,87,162,249,0,37,143,200,243,211,239,185,39,154,12,43,83,151,22,143,83,225,228,94,101,57,203,164,156,146,7,158,102,26,13,99,43,228,115,149,123,2,227,203,80,204,183,114,213,101,174,10,67,86,34,147,166,41,156,113,40,75,244,171,65,107,223,121,183,48,25,49,32,48,9,184,28,178,205,12,32,154,130,161,68,139,51,42,53,17,148,36,207,46,227,4,186,132,233,70,198,42,76,148,4,211,137,250,65,211,206,75,212,213,19,22,29,247,36,222,208,66,165,213,26,128,5,37,48,76,86,160,168,145,21,88,29,20,160,205,180,90,70,203,104,38,29,59,206,27,40,115,138,91,39,64,75,195,194,224,73,130,183,234,10,69,241,30,188,117,131,198,83,161,199,50,166,60,223,111,202,221,234,255,254,224,122,93,58,57,75,99,212,231,80,212,212,48,227,181,188,30,210,234,25,140,122,61,111,239,171,72,23,83,67,189,78,62,196,168,11,184,33,249,226,236,144,181,141,250,200,214,215,56,134,214,245,46,242,232,244,87,115,208,103,24,176,104,228,253,155,57,248,118,237,126,154,68,183,158,245,40,134,177,81,189,144,63,140,226,181,89,114,178,89,179,231,181,169,62,253,222,0,204,216,159,32,160,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("fef75578-f348-4491-a5ba-51e5ae6801c5"));
		}

		#endregion

	}

	#endregion

}

