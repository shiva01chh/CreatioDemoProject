namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SupportMailBoxBinderSchema

	/// <exclude/>
	public class SupportMailBoxBinderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SupportMailBoxBinderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SupportMailBoxBinderSchema(SupportMailBoxBinderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("bc5ec1ee-8ee0-40d6-ba02-de9f93ecefc3");
			Name = "SupportMailBoxBinder";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("33bac096-c819-4c57-86af-fe71bbb0cb56");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,117,80,209,106,2,49,16,124,86,240,31,22,251,98,161,220,189,171,21,170,180,80,168,180,212,66,159,115,185,61,27,184,203,134,77,78,60,164,255,222,245,226,21,15,53,47,33,59,147,217,153,177,170,66,239,148,70,248,66,102,229,169,8,201,138,108,97,182,53,171,96,200,142,134,135,209,112,80,123,99,183,61,10,99,242,162,116,32,54,232,103,87,24,223,152,9,171,170,200,10,42,248,29,227,86,228,96,85,42,239,167,176,169,157,35,14,107,101,202,37,237,151,198,230,200,45,47,77,83,152,251,186,170,20,55,139,211,59,194,80,16,11,132,8,154,177,120,28,191,246,53,62,209,145,55,98,168,25,167,139,164,83,74,207,164,92,157,149,70,131,62,58,184,106,0,166,240,228,220,243,14,109,120,51,62,160,69,94,42,143,242,245,208,122,251,15,177,198,240,67,185,196,248,104,37,35,120,146,167,157,116,96,114,132,29,153,28,222,173,40,110,130,226,48,233,164,165,222,128,251,0,58,222,247,112,44,120,48,200,100,83,114,70,239,224,89,139,182,181,197,194,155,228,232,118,126,51,254,3,220,66,22,147,241,101,89,113,193,239,41,32,218,60,102,108,223,113,218,31,202,76,206,31,40,9,24,87,56,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("bc5ec1ee-8ee0-40d6-ba02-de9f93ecefc3"));
		}

		#endregion

	}

	#endregion

}

