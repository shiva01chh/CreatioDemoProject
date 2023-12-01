namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: RecordDeleterWithStopProcessSchema

	/// <exclude/>
	public class RecordDeleterWithStopProcessSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public RecordDeleterWithStopProcessSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public RecordDeleterWithStopProcessSchema(RecordDeleterWithStopProcessSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("c0257476-0351-4841-902a-f92f292b905b");
			Name = "RecordDeleterWithStopProcess";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("edbaf284-b37c-4101-84cb-76a44645334f");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,83,193,78,2,49,16,61,175,137,255,208,196,11,38,100,63,64,141,7,129,24,19,136,68,52,30,77,233,14,80,179,180,235,116,150,176,49,252,187,211,118,87,88,112,145,83,59,125,251,102,222,155,135,145,107,112,133,84,32,94,1,81,58,187,160,116,96,205,66,47,75,148,164,173,17,223,151,23,73,233,180,89,138,89,229,8,214,183,71,119,134,231,57,40,143,117,233,35,24,64,173,206,98,158,231,159,124,156,216,12,242,61,238,176,59,66,87,61,29,25,210,164,193,117,2,134,15,157,79,83,180,10,92,199,167,235,181,53,39,83,143,181,249,234,164,107,185,196,40,198,93,33,44,189,101,131,92,58,119,35,94,64,89,204,134,144,3,1,190,107,90,205,200,22,245,20,1,95,148,243,92,43,161,60,252,44,90,28,145,249,165,240,247,251,134,236,43,97,169,200,34,247,157,6,218,136,168,91,156,35,239,189,57,64,102,48,113,65,162,108,93,251,158,37,73,158,134,58,92,37,86,119,220,138,253,232,11,27,22,121,47,10,137,156,34,38,118,215,60,232,92,58,232,29,113,180,32,62,80,201,174,22,0,38,139,26,218,130,38,64,43,155,121,45,168,55,146,192,191,5,57,241,42,54,86,103,34,202,241,106,6,210,40,200,71,91,80,165,239,215,8,219,167,238,174,46,141,53,47,150,35,202,67,183,11,205,92,73,13,28,153,165,54,240,70,58,15,121,75,99,135,169,68,48,212,208,127,156,168,60,230,188,13,148,222,145,52,14,251,92,64,12,76,47,190,237,26,97,255,27,81,47,181,241,193,18,119,133,76,216,13,199,82,103,45,75,14,186,212,170,8,171,250,116,110,154,100,39,148,36,181,18,189,240,63,171,56,24,217,67,213,56,178,85,80,132,128,64,115,106,216,147,127,55,241,251,73,58,253,219,163,93,71,40,130,220,88,111,149,47,47,184,200,191,31,52,204,28,72,192,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c0257476-0351-4841-902a-f92f292b905b"));
		}

		#endregion

	}

	#endregion

}

