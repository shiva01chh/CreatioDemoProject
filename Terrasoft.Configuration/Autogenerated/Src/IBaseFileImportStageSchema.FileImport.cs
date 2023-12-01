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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,145,77,78,195,48,16,133,215,137,148,59,140,210,13,108,234,125,75,89,128,138,148,5,82,36,184,128,177,39,193,82,252,163,25,7,129,42,238,142,235,180,13,148,34,225,149,103,252,205,243,243,179,147,22,57,72,133,240,140,68,146,125,23,151,247,222,117,166,31,73,70,227,221,242,193,12,216,216,224,41,86,229,174,42,171,178,88,16,246,233,4,160,113,17,169,75,195,43,104,238,36,227,140,62,69,217,99,134,195,248,50,24,5,230,136,254,65,22,73,186,56,41,183,228,3,82,52,200,43,104,179,64,214,42,132,16,112,195,163,181,146,62,110,143,141,172,0,70,159,0,241,157,56,187,137,183,110,180,211,72,163,97,7,61,198,53,124,78,234,11,116,122,50,112,168,15,110,30,49,190,122,253,31,43,219,119,84,99,68,8,228,21,50,3,79,214,28,104,36,243,134,26,212,32,153,145,47,91,205,157,32,73,90,112,233,91,54,117,222,99,10,142,235,25,96,68,80,132,221,166,158,158,213,206,144,152,41,145,103,115,125,41,240,125,194,123,135,185,184,58,23,130,249,226,235,245,239,108,138,41,175,159,113,229,94,90,95,101,49,153,70,81,2,0,0 };
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

