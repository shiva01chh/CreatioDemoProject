namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IRemindingTextFormerSchema

	/// <exclude/>
	public class IRemindingTextFormerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IRemindingTextFormerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IRemindingTextFormerSchema(IRemindingTextFormerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("734bc083-96cd-481d-a4cd-ea2b71a900a5");
			Name = "IRemindingTextFormer";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("1a637eec-ed5e-4e5a-93be-edcf08166986");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,197,82,203,78,196,48,12,60,111,165,253,7,107,185,128,132,218,59,148,30,120,173,122,91,65,127,32,109,221,37,168,73,42,39,5,42,196,191,227,164,180,20,150,3,156,200,205,246,120,102,108,71,11,133,182,19,21,66,129,68,194,154,198,197,87,70,55,114,223,147,112,210,104,88,71,175,235,104,213,91,169,247,112,63,88,135,138,1,109,139,149,175,218,120,139,26,73,86,231,51,102,201,67,24,223,104,39,157,68,203,0,134,28,17,238,61,105,174,29,82,195,178,103,144,223,161,146,186,230,214,2,95,220,173,33,133,20,176,73,146,64,106,123,165,4,13,217,71,188,35,243,36,107,180,32,39,2,104,12,1,77,20,224,152,195,167,152,196,198,19,73,178,96,233,250,178,149,213,162,255,103,253,149,31,250,192,66,72,108,209,45,4,75,83,15,65,53,134,185,35,249,222,146,118,130,132,2,205,203,190,216,120,119,59,31,35,91,176,155,236,90,134,85,50,30,158,165,123,8,238,61,115,55,99,226,52,9,65,224,179,142,124,149,93,92,178,244,113,254,217,158,142,165,83,48,229,35,159,39,131,175,74,39,254,70,171,95,142,197,71,107,241,159,230,42,188,246,95,7,123,27,255,23,234,122,252,98,235,136,51,252,222,1,10,122,226,36,225,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("734bc083-96cd-481d-a4cd-ea2b71a900a5"));
		}

		#endregion

	}

	#endregion

}

