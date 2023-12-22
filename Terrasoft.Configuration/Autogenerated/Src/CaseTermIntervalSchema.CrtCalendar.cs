namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CaseTermIntervalSchema

	/// <exclude/>
	public class CaseTermIntervalSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CaseTermIntervalSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CaseTermIntervalSchema(CaseTermIntervalSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("cff3d064-d73b-473d-8492-7151dcd31b07");
			Name = "CaseTermInterval";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f69a32ba-7e77-47bd-be6b-d095bbdc629a");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,84,81,107,219,48,16,126,78,161,255,225,198,160,164,208,218,93,31,219,52,48,194,54,250,208,81,150,180,47,99,15,170,115,246,68,101,201,232,228,64,182,229,191,239,36,91,137,29,135,18,106,12,150,78,247,233,190,239,211,89,90,148,72,149,200,16,22,104,173,32,147,187,100,102,116,46,139,218,10,39,141,62,61,249,123,122,50,170,73,234,2,230,107,114,88,222,110,231,51,161,80,47,133,165,133,44,241,73,75,7,119,187,88,18,131,156,207,136,143,22,11,222,14,190,232,186,188,225,44,66,46,88,206,157,112,72,188,204,111,154,166,48,161,186,44,133,93,79,219,185,207,3,199,137,32,53,127,86,66,65,102,202,74,161,67,141,68,64,1,159,68,116,218,129,255,252,170,68,65,191,252,104,142,86,10,37,255,136,23,133,62,80,213,47,74,102,128,76,101,200,196,203,29,125,55,26,89,204,213,133,159,176,31,78,72,77,63,216,41,163,201,47,124,218,95,48,106,229,227,215,28,222,52,122,217,133,70,114,79,254,76,9,162,157,254,251,86,85,200,57,100,192,103,200,60,226,50,107,74,161,133,220,88,200,6,182,28,114,160,149,25,54,24,84,132,27,184,239,206,39,125,35,166,209,137,72,252,209,154,10,173,147,200,236,31,195,198,129,243,128,116,8,68,67,28,183,64,151,226,144,99,36,233,155,197,87,143,208,48,14,4,70,5,250,22,226,1,181,131,205,219,149,155,51,122,95,233,128,61,162,246,222,233,110,93,122,64,247,219,44,143,177,232,27,58,2,127,170,168,29,148,130,94,129,121,214,152,28,166,26,34,22,93,109,53,77,31,118,217,147,52,6,59,130,250,39,233,43,121,196,248,188,213,180,18,22,44,82,173,154,223,181,155,155,248,190,111,4,203,28,198,61,67,62,220,129,174,149,130,179,179,158,81,201,98,93,161,95,92,98,46,120,207,241,224,82,56,31,64,158,61,119,152,194,85,164,52,106,249,252,27,16,218,255,247,26,114,155,46,197,109,187,244,25,198,240,241,4,183,136,247,241,243,240,46,189,230,100,90,171,223,104,158,225,125,193,183,33,7,187,207,127,36,10,213,203,167,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("cff3d064-d73b-473d-8492-7151dcd31b07"));
		}

		#endregion

	}

	#endregion

}

