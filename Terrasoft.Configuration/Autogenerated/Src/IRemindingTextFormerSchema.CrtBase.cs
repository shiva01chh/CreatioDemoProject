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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,197,82,77,79,195,48,12,61,111,210,254,131,53,46,32,161,246,14,165,7,190,166,221,38,232,31,72,91,119,24,53,73,229,164,192,132,248,239,56,41,29,133,113,128,19,185,217,126,126,239,217,142,81,26,93,167,42,132,2,153,149,179,141,79,174,172,105,104,219,179,242,100,13,44,230,175,139,249,172,119,100,182,112,191,115,30,181,0,218,22,171,80,117,201,10,13,50,85,231,123,204,148,135,49,185,49,158,60,161,19,128,64,142,24,183,129,116,109,60,114,35,178,103,176,190,67,77,166,150,214,2,95,252,173,101,141,28,177,105,154,66,230,122,173,21,239,242,143,120,195,246,137,106,116,64,35,1,52,150,129,71,10,240,194,17,82,66,226,146,145,36,157,176,116,125,217,82,53,233,255,89,127,22,134,62,176,16,19,43,244,19,193,210,214,187,168,154,192,190,35,253,222,146,117,138,149,6,35,203,190,88,6,119,155,16,163,88,112,203,252,154,226,42,5,15,207,228,31,162,251,192,220,237,49,73,150,198,32,242,57,207,161,42,46,46,69,250,120,253,217,158,13,165,83,176,229,163,156,39,135,175,74,39,225,70,179,95,142,37,71,107,241,159,230,42,130,246,95,7,123,27,254,23,154,122,248,98,139,185,100,166,239,29,143,117,16,117,234,2,0,0 };
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

