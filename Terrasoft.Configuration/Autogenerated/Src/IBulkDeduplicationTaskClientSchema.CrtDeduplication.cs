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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,229,147,77,79,195,48,12,134,207,32,241,31,44,184,128,132,218,59,131,33,96,8,237,130,208,64,226,236,173,238,136,104,147,42,118,166,77,136,255,142,155,182,108,163,124,158,233,169,118,252,216,111,236,216,98,73,92,225,140,224,129,188,71,118,185,36,87,206,230,102,30,60,138,113,54,25,81,22,170,194,204,162,181,183,251,178,183,187,19,216,216,57,108,29,92,23,200,98,102,201,200,149,104,62,64,201,3,242,243,224,123,238,145,166,23,149,169,75,139,199,153,112,50,81,89,206,50,41,167,228,129,167,185,70,195,216,10,249,92,229,158,192,248,50,20,207,91,185,234,50,87,133,33,43,145,73,211,20,78,57,148,37,250,213,176,181,239,188,91,152,140,24,16,152,4,92,14,217,102,6,16,77,193,80,162,197,57,149,154,8,74,146,39,151,113,2,93,194,116,35,99,21,166,74,130,233,68,253,160,105,231,37,234,234,9,139,142,9,137,55,180,80,105,181,6,96,65,9,12,211,21,40,106,100,5,86,7,5,104,51,173,150,209,50,154,73,199,142,243,6,202,156,226,214,9,208,210,176,48,120,146,224,173,186,66,81,188,7,111,221,160,241,84,232,177,140,41,207,246,155,114,183,250,191,63,188,94,151,78,78,211,24,245,57,20,53,53,204,120,45,175,135,180,122,134,163,94,207,219,251,42,210,197,212,80,175,147,247,49,234,28,110,72,190,56,59,100,109,163,62,178,245,53,142,161,117,189,139,60,26,252,106,14,250,12,3,22,141,188,127,51,7,223,174,221,79,147,232,214,179,30,197,69,108,84,47,228,15,163,120,109,150,156,108,214,236,121,109,170,111,243,123,3,65,28,139,64,169,4,0,0 };
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

