namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IFileProcessorSchema

	/// <exclude/>
	public class IFileProcessorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IFileProcessorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IFileProcessorSchema(IFileProcessorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("4e8d1b4d-9296-459a-b005-ca3460aef8ac");
			Name = "IFileProcessor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("79cdeed7-eef0-4dd8-9765-07d140cf1035");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,146,65,75,195,64,16,133,207,45,244,63,12,237,165,130,36,247,182,6,68,80,115,16,139,85,60,111,146,73,58,210,236,198,217,73,165,20,255,187,187,219,164,165,138,160,185,189,153,111,222,238,188,141,86,53,218,70,229,8,207,200,172,172,41,37,186,49,186,164,170,101,37,100,116,116,75,27,76,235,198,176,140,134,251,209,112,208,90,210,21,172,118,86,176,158,31,245,105,250,21,179,232,94,164,137,174,51,43,172,114,111,98,29,232,208,9,99,229,20,164,90,144,75,119,232,12,82,111,191,100,147,163,181,134,3,213,180,217,134,114,160,30,250,193,12,246,129,59,218,61,160,172,77,97,103,176,12,147,135,102,28,199,176,176,109,93,43,222,37,125,161,51,65,11,21,109,81,67,233,140,163,35,29,127,199,23,141,98,85,131,118,25,93,141,61,59,78,252,85,162,69,28,26,129,219,26,42,122,95,223,156,250,221,151,198,165,83,120,25,142,184,152,255,227,78,38,123,195,92,46,33,119,177,81,129,236,211,37,241,82,20,105,11,133,18,5,166,4,212,66,178,3,155,175,177,86,189,217,7,201,26,90,77,239,45,130,27,118,72,73,200,221,34,140,101,183,11,27,35,171,48,248,146,22,227,56,249,107,6,231,115,201,147,147,221,5,192,21,126,205,229,49,172,52,189,107,93,233,204,162,15,102,130,186,56,60,102,208,159,135,191,229,172,24,106,238,251,2,237,42,206,117,177,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("4e8d1b4d-9296-459a-b005-ca3460aef8ac"));
		}

		#endregion

	}

	#endregion

}

