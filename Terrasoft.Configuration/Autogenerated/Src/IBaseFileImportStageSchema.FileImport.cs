namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IBaseFileImportStageSchema

	/// <exclude/>
	public class IBaseFileImportStageSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IBaseFileImportStageSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IBaseFileImportStageSchema(IBaseFileImportStageSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("2e54df01-9a20-4cc1-b98f-462bb7d75af3");
			Name = "IBaseFileImportStage";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("a83ae89b-1206-453d-b626-f37ab41fffbf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,145,77,78,195,48,16,133,215,137,212,59,140,210,13,108,234,125,75,89,128,138,148,5,82,36,184,128,177,39,193,82,252,163,25,7,129,42,238,78,98,183,13,148,34,225,149,103,252,205,243,243,179,147,22,57,72,133,240,140,68,146,125,27,87,247,222,181,166,27,72,70,227,221,234,193,244,88,219,224,41,46,202,253,162,92,148,197,146,176,27,79,0,106,23,145,218,113,120,13,245,157,100,156,209,167,40,59,76,112,24,94,122,163,192,28,209,63,200,98,148,46,78,202,13,249,128,20,13,242,26,154,36,144,180,10,33,4,220,240,96,173,164,143,219,99,35,41,128,209,39,64,124,39,206,110,226,157,27,108,30,169,53,236,161,195,184,129,207,172,190,68,167,179,129,67,125,112,243,136,241,213,235,255,88,217,189,163,26,34,66,32,175,144,25,56,91,115,160,145,204,27,106,80,189,100,70,190,108,53,117,130,36,105,193,141,223,178,173,210,30,199,224,184,154,1,70,4,69,216,110,171,252,172,102,134,196,76,137,52,155,234,75,129,79,9,79,14,83,113,117,46,4,243,197,215,155,223,217,20,57,175,159,113,165,222,180,190,0,117,10,73,15,82,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("2e54df01-9a20-4cc1-b98f-462bb7d75af3"));
		}

		#endregion

	}

	#endregion

}

