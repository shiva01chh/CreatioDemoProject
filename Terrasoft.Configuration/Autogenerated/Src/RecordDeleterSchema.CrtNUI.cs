namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: RecordDeleterSchema

	/// <exclude/>
	public class RecordDeleterSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public RecordDeleterSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public RecordDeleterSchema(RecordDeleterSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("a61c9bf9-deb2-46d9-9e0b-bc4b5a27b8cc");
			Name = "RecordDeleter";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("edbaf284-b37c-4101-84cb-76a44645334f");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,117,81,93,79,194,64,16,124,62,18,255,195,6,95,32,33,253,1,160,62,240,161,49,17,37,160,241,249,184,46,237,153,114,215,236,93,9,132,248,223,221,222,85,108,77,232,83,187,179,51,59,51,53,114,143,174,148,10,225,29,137,164,179,59,159,204,172,217,233,172,34,233,181,53,112,190,233,137,202,105,147,193,230,228,60,238,25,46,10,84,53,230,146,39,52,72,90,77,46,59,109,21,194,107,243,100,62,101,136,193,91,194,172,62,50,43,164,115,99,88,163,178,148,206,177,64,143,20,22,202,106,91,104,5,170,198,187,48,140,97,42,29,198,217,226,136,170,242,150,57,226,28,120,127,202,108,211,83,165,24,228,3,171,32,23,55,26,233,142,232,224,195,33,49,197,196,128,80,117,62,71,240,60,215,225,77,210,233,142,101,57,217,8,236,246,139,225,7,40,37,113,153,44,226,134,181,188,16,99,216,178,193,193,127,141,214,94,40,87,136,104,97,173,179,220,191,149,216,244,126,15,27,149,227,94,182,192,23,60,96,225,146,153,52,209,238,36,178,107,104,113,84,88,214,188,37,58,39,51,100,122,127,97,188,246,167,168,146,92,22,146,87,27,24,143,150,146,40,211,15,58,223,77,111,104,210,88,93,183,199,37,250,220,166,173,10,133,8,37,146,245,28,12,83,176,7,254,197,58,69,56,88,157,66,84,190,164,25,252,70,141,158,154,195,159,218,231,28,70,97,177,34,171,216,248,96,120,205,74,184,22,231,157,241,77,143,135,252,252,0,233,251,207,182,200,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a61c9bf9-deb2-46d9-9e0b-bc4b5a27b8cc"));
		}

		#endregion

	}

	#endregion

}

