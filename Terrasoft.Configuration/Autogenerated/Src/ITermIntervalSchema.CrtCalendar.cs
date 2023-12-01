namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ITermIntervalSchema

	/// <exclude/>
	public class ITermIntervalSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ITermIntervalSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ITermIntervalSchema(ITermIntervalSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("a8612d32-9e85-4a58-a2a0-2c095913c7e1");
			Name = "ITermInterval";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f69a32ba-7e77-47bd-be6b-d095bbdc629a");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,82,77,79,194,64,16,61,67,194,127,152,224,69,47,237,29,144,11,70,194,1,98,180,122,49,30,134,118,90,54,182,91,178,59,37,65,227,127,119,118,251,1,162,96,79,221,183,111,222,188,125,51,26,11,178,91,140,9,34,50,6,109,153,114,48,43,117,170,178,202,32,171,82,15,250,159,131,126,175,178,74,103,240,180,183,76,197,248,228,28,60,86,154,85,65,193,19,25,133,185,250,240,117,7,214,12,115,210,9,154,72,56,207,90,49,220,158,235,21,180,84,27,180,100,145,17,161,43,67,153,220,195,44,71,107,71,224,46,69,162,240,119,97,24,194,196,86,69,129,102,63,109,206,158,7,113,169,25,149,38,3,105,105,128,55,4,206,38,40,205,100,118,152,183,181,225,81,241,107,247,134,117,78,111,14,184,67,70,49,201,6,99,118,192,182,90,231,42,134,216,119,56,24,233,185,148,58,159,247,138,242,68,140,62,120,178,183,89,43,45,169,88,147,185,94,73,234,18,195,144,247,91,26,222,56,217,86,247,87,88,145,80,192,139,247,50,114,113,200,143,109,126,190,206,43,203,251,170,19,105,121,55,188,56,248,162,220,81,193,188,82,73,103,104,145,252,227,162,41,106,35,129,149,140,116,71,221,241,114,241,149,244,168,179,147,83,141,29,67,71,43,176,112,211,75,101,97,71,176,112,194,139,110,154,103,118,161,43,128,50,5,118,86,218,5,168,135,24,252,181,7,135,200,154,218,31,189,38,209,180,157,248,105,71,15,44,137,55,101,34,27,135,12,134,184,50,218,214,157,211,28,51,223,240,119,199,26,105,216,211,232,192,158,132,45,232,88,17,204,137,151,104,223,175,111,198,117,84,39,65,9,34,223,55,75,17,207,228,215,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a8612d32-9e85-4a58-a2a0-2c095913c7e1"));
		}

		#endregion

	}

	#endregion

}

