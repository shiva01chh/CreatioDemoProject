namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IESEmailManagerSchema

	/// <exclude/>
	public class IESEmailManagerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IESEmailManagerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IESEmailManagerSchema(IESEmailManagerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("0f0a3bfc-dd1a-49ca-91a0-daff393823fe");
			Name = "IESEmailManager";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("92df5372-6a61-42f2-95f4-67c9e246a93f");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,82,77,79,2,49,16,61,75,194,127,152,224,69,19,178,235,25,150,189,32,49,36,18,137,248,7,202,50,187,52,217,109,177,211,98,8,241,191,59,253,0,21,53,238,101,211,215,247,222,204,155,169,18,29,210,78,84,8,47,104,140,32,93,219,108,170,85,45,27,103,132,149,90,101,179,78,200,150,86,40,76,181,237,247,142,253,222,149,35,169,26,88,29,200,98,199,228,182,197,202,51,41,123,64,133,70,86,227,126,143,89,215,6,27,70,97,174,44,154,154,43,140,96,62,91,5,183,133,80,162,65,19,104,121,158,67,65,174,235,132,57,148,233,188,52,122,47,55,72,208,161,221,234,13,65,173,13,160,87,2,133,62,184,126,118,210,230,95,196,59,183,110,101,5,242,84,242,103,197,171,99,168,122,238,110,17,43,140,96,25,164,241,242,178,167,0,196,9,196,54,40,59,211,242,75,94,177,19,70,116,160,120,176,147,129,193,87,135,100,7,229,163,36,11,186,78,253,3,89,195,25,40,43,242,192,254,67,172,223,166,218,41,86,135,159,151,51,68,28,15,12,90,103,20,236,69,235,240,95,19,122,170,107,66,182,121,246,106,29,14,222,164,241,235,18,45,155,209,142,215,247,139,81,44,67,229,189,12,27,230,152,190,137,52,130,34,63,93,123,254,124,166,92,199,118,235,22,139,79,122,17,131,14,83,224,178,76,99,140,143,234,198,79,37,81,74,72,179,26,250,245,193,41,59,76,224,238,140,164,32,30,187,29,167,61,162,218,196,85,134,243,123,124,122,223,64,198,248,251,0,50,241,243,179,233,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("0f0a3bfc-dd1a-49ca-91a0-daff393823fe"));
		}

		#endregion

	}

	#endregion

}

