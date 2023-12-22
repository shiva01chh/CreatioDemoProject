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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,82,77,79,194,64,16,61,99,194,127,152,224,69,46,237,29,144,11,70,195,1,99,180,122,49,30,134,118,90,55,182,91,178,59,37,65,227,127,119,118,251,65,5,193,158,186,111,223,188,121,251,102,52,22,100,55,24,19,68,100,12,218,50,229,96,81,234,84,101,149,65,86,165,30,94,124,13,47,6,149,85,58,131,167,157,101,42,166,7,231,224,177,210,172,10,10,158,200,40,204,213,167,175,219,179,22,152,147,78,208,68,194,121,214,138,225,250,84,175,160,165,218,160,37,139,140,8,93,26,202,228,30,22,57,90,59,1,119,41,18,133,191,11,195,16,102,182,42,10,52,187,121,115,246,60,136,75,205,168,52,25,72,75,3,252,78,224,108,130,210,76,102,139,121,91,27,246,138,95,187,55,172,115,122,115,192,13,50,138,73,54,24,179,3,54,213,58,87,49,196,190,195,222,200,192,165,212,249,188,85,148,39,98,244,193,147,189,205,90,105,69,197,154,204,213,189,164,46,49,140,120,183,161,209,216,201,182,186,71,97,69,66,1,47,62,200,200,197,33,63,182,249,249,62,173,44,239,171,14,164,229,221,240,226,224,179,114,189,130,187,74,37,157,161,101,242,143,139,166,168,141,4,238,101,164,91,234,142,231,139,47,165,71,157,157,156,106,172,15,245,86,96,233,166,151,202,194,78,96,233,132,151,221,52,79,236,66,87,0,101,10,236,172,180,11,80,15,49,248,107,15,246,145,53,181,191,122,205,162,121,59,241,195,142,30,88,17,191,151,137,108,28,50,24,226,202,104,91,119,78,115,204,124,195,227,142,53,210,176,231,209,158,61,11,91,208,177,34,184,35,94,161,253,184,26,79,235,168,14,130,18,164,255,253,0,206,152,250,142,224,3,0,0 };
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

