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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,197,82,77,79,195,48,12,61,119,82,255,131,53,46,32,161,230,14,101,7,190,166,221,38,216,31,72,91,119,24,53,73,229,164,192,132,248,239,56,25,27,133,113,128,19,185,217,126,126,239,217,142,213,6,125,175,107,132,21,50,107,239,218,80,92,57,219,210,122,96,29,200,89,200,39,175,249,36,27,60,217,53,220,111,124,64,35,128,174,195,58,86,125,49,71,139,76,245,249,30,51,230,97,44,110,108,160,64,232,5,32,144,35,198,117,36,93,216,128,220,138,236,25,44,238,208,144,109,164,117,133,47,225,214,177,65,78,88,165,20,148,126,48,70,243,102,246,17,47,217,61,81,131,30,104,71,0,173,99,224,29,5,4,225,136,41,33,241,197,142,68,141,88,250,161,234,168,30,245,255,172,159,197,161,15,44,164,196,28,195,72,176,114,205,38,169,22,176,239,80,223,91,202,94,179,54,96,101,217,23,211,232,110,25,99,20,11,126,58,187,166,180,74,193,195,51,133,135,228,62,50,247,123,76,81,170,20,36,62,31,56,86,197,197,165,72,31,47,62,219,203,109,233,20,92,245,40,231,153,193,87,165,147,120,163,236,151,99,201,209,58,252,167,185,86,81,251,175,131,189,109,255,23,218,102,251,197,242,137,100,226,123,7,247,13,38,210,226,2,0,0 };
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

