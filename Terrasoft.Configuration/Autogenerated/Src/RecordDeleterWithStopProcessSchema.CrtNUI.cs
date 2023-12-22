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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,83,203,110,194,48,16,60,7,169,255,96,169,23,42,85,249,128,130,122,40,160,170,18,8,212,135,122,172,140,179,5,87,193,78,215,27,212,168,226,223,187,182,147,66,160,161,156,236,245,100,118,103,118,48,114,3,174,144,10,196,51,32,74,103,223,41,29,89,243,174,87,37,74,210,214,136,239,139,94,82,58,109,86,226,169,114,4,155,193,209,157,225,121,14,202,99,93,122,15,6,80,171,179,152,249,242,131,143,51,155,65,190,199,29,118,71,232,170,167,19,67,154,52,184,78,192,248,174,243,105,129,86,129,235,248,116,179,177,230,100,234,169,54,159,157,116,45,151,24,197,184,75,132,149,183,108,148,75,231,110,196,35,40,139,217,24,114,32,192,87,77,235,39,178,69,61,69,192,23,229,50,215,74,40,15,63,139,22,71,100,126,41,252,253,190,33,251,74,88,42,178,200,125,23,129,54,34,234,22,231,200,251,47,14,144,25,76,92,144,40,91,215,107,207,146,36,15,99,29,174,18,171,33,183,98,63,174,133,13,139,188,21,133,68,78,17,19,187,43,30,116,41,29,244,143,56,90,16,31,168,100,87,11,0,147,69,13,109,65,51,160,181,205,188,22,212,91,73,224,223,130,156,120,21,91,171,51,17,229,120,53,35,105,20,228,147,47,80,165,239,215,8,219,167,110,88,151,166,154,23,203,17,229,161,219,133,102,174,164,6,78,204,74,27,120,33,157,135,188,165,177,195,66,34,24,106,232,223,78,84,30,115,14,2,165,119,36,141,195,206,11,136,129,233,199,183,93,35,236,127,35,234,165,54,62,88,226,174,144,9,187,229,88,234,172,101,201,65,151,90,21,97,85,159,206,77,147,236,132,146,164,214,162,31,254,103,21,7,35,187,171,26,71,190,20,20,33,32,208,156,26,246,228,223,77,252,126,146,46,254,246,104,215,17,138,32,55,214,91,229,139,30,23,15,127,63,74,63,13,200,201,4,0,0 };
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

