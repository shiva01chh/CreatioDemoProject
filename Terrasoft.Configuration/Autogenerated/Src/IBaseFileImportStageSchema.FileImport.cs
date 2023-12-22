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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,145,77,78,195,48,16,133,215,137,212,59,140,210,13,108,234,125,75,89,128,138,148,5,82,36,184,128,177,39,169,165,248,71,51,14,2,85,220,157,212,110,155,82,138,132,87,158,241,55,207,207,207,78,90,228,32,21,194,43,18,73,246,109,92,60,122,215,154,110,32,25,141,119,139,39,211,99,109,131,167,56,43,119,179,114,86,22,115,194,110,60,1,168,93,68,106,199,225,37,212,15,146,113,66,95,162,236,48,193,97,120,235,141,2,115,68,255,32,139,81,186,56,41,55,228,3,82,52,200,75,104,146,64,210,42,132,16,112,199,131,181,146,62,239,143,141,164,0,70,159,0,113,78,92,220,196,27,55,216,60,82,107,216,65,135,113,5,95,89,125,142,78,103,3,135,250,224,230,25,227,214,235,255,88,217,124,160,26,34,66,32,175,144,25,56,91,115,160,145,204,59,106,80,189,100,70,190,110,53,117,130,36,105,193,141,223,178,174,210,30,199,224,184,154,0,70,4,69,216,174,171,252,172,102,130,196,68,137,52,155,234,107,129,239,19,222,59,76,197,205,165,16,76,23,223,174,126,103,83,228,188,126,198,149,122,231,235,27,193,207,110,41,90,2,0,0 };
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

