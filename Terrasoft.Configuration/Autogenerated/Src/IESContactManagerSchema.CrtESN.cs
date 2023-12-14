namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IESContactManagerSchema

	/// <exclude/>
	public class IESContactManagerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IESContactManagerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IESContactManagerSchema(IESContactManagerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d67308e4-6320-4c6b-bc57-690f1d4497fe");
			Name = "IESContactManager";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f0db0304-dc6c-40c0-a3bb-97ab97632500");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,82,221,74,195,48,20,190,118,224,59,28,230,141,130,180,94,107,87,144,49,101,224,84,220,94,32,203,78,187,96,155,204,115,146,201,16,223,221,147,182,171,58,21,123,83,242,229,251,57,63,177,170,70,222,40,141,176,64,34,197,174,240,201,216,217,194,148,129,148,55,206,38,147,249,253,241,224,237,120,112,20,216,216,18,230,59,246,88,11,167,170,80,71,2,39,183,104,145,140,190,58,228,44,214,132,106,37,64,178,80,252,204,114,47,140,19,194,82,84,48,181,30,169,144,224,75,152,78,230,147,90,153,106,166,172,42,145,132,148,166,41,100,28,234,90,209,46,239,206,143,228,182,102,133,12,53,250,181,91,49,20,142,64,59,235,149,246,12,140,138,244,58,102,237,229,233,23,253,38,44,43,163,193,236,51,99,228,184,149,126,134,190,53,245,245,5,206,218,152,75,120,108,196,237,229,97,97,13,48,111,178,251,90,146,158,152,30,50,179,141,34,85,131,149,161,143,134,132,47,1,217,15,243,59,195,30,92,209,245,0,236,73,250,224,36,75,27,246,31,98,247,58,118,193,138,186,249,69,185,64,44,45,2,161,15,100,97,171,170,128,255,154,240,67,81,48,138,205,83,84,187,230,16,77,202,184,83,85,137,25,111,100,199,191,24,181,49,220,87,159,49,34,104,194,98,52,236,70,123,227,104,134,54,190,145,97,154,139,193,94,17,45,226,139,200,166,19,27,106,137,89,86,152,253,208,228,121,55,216,238,134,175,121,103,245,105,140,203,218,17,229,208,141,240,60,110,22,246,35,129,17,92,244,72,215,95,196,206,174,186,5,163,93,181,59,110,206,239,237,179,252,6,10,22,191,15,117,11,153,66,29,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d67308e4-6320-4c6b-bc57-690f1d4497fe"));
		}

		#endregion

	}

	#endregion

}

