namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IFileImportTagManagerSchema

	/// <exclude/>
	public class IFileImportTagManagerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IFileImportTagManagerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IFileImportTagManagerSchema(IFileImportTagManagerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("ee7c80a9-3a5c-4e84-9235-9be88e7c35d7");
			Name = "IFileImportTagManager";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,205,147,193,74,196,48,16,134,207,91,232,59,12,123,81,65,218,7,176,46,172,235,10,123,208,139,235,3,204,182,147,26,105,147,146,73,11,69,124,119,147,180,213,85,42,172,183,13,57,164,225,155,191,243,255,73,20,214,196,13,230,4,123,50,6,89,11,155,108,180,18,178,108,13,90,169,85,242,32,43,218,213,141,54,54,142,222,227,104,209,180,135,74,230,32,149,37,35,124,225,238,155,216,99,249,136,10,75,50,14,244,240,34,77,83,200,184,173,107,52,253,106,218,216,24,66,75,12,22,75,78,190,168,244,55,150,53,104,176,6,229,90,188,93,50,169,130,204,114,181,237,72,89,24,190,64,31,222,40,183,73,150,6,114,190,16,77,201,83,153,91,183,181,91,240,143,146,78,203,98,236,201,25,224,203,65,117,252,199,53,220,145,208,102,52,184,85,86,90,73,252,140,29,5,201,181,83,247,178,124,117,19,71,127,26,246,184,195,170,42,88,6,167,7,132,249,43,200,32,74,5,144,215,237,207,37,139,224,46,116,52,151,199,81,18,189,39,139,127,4,113,79,21,77,39,15,82,12,190,93,158,80,104,98,117,97,199,68,206,37,136,161,221,39,109,95,152,138,185,44,214,194,189,130,19,175,198,71,28,185,121,60,62,1,61,177,158,158,125,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ee7c80a9-3a5c-4e84-9235-9be88e7c35d7"));
		}

		#endregion

	}

	#endregion

}

