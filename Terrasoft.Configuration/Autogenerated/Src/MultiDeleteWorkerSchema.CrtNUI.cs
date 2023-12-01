namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MultiDeleteWorkerSchema

	/// <exclude/>
	public class MultiDeleteWorkerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MultiDeleteWorkerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MultiDeleteWorkerSchema(MultiDeleteWorkerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("fec963bc-4f40-4b98-bb72-921691cdead0");
			Name = "MultiDeleteWorker";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("db43ba5c-9334-4bce-a1f8-d5a6f72577ed");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,82,193,78,219,64,16,61,27,137,127,24,129,132,28,9,229,3,146,166,135,6,132,16,66,68,208,138,3,234,97,179,126,9,219,154,93,107,118,221,18,33,254,189,179,107,155,216,88,84,173,15,182,103,230,237,123,51,111,214,170,39,248,74,105,208,87,48,43,239,54,97,186,116,118,99,182,53,171,96,156,165,151,195,131,172,246,198,110,233,110,231,3,158,230,239,98,129,151,37,116,196,250,233,5,44,216,232,61,166,207,202,248,40,63,61,183,193,4,3,47,0,129,28,51,182,81,122,89,42,239,103,116,93,151,193,156,161,68,192,189,227,159,224,4,170,234,117,105,52,233,136,25,67,104,70,95,148,199,45,180,227,194,223,84,104,166,105,139,113,166,44,139,175,55,41,233,62,112,173,131,99,81,92,37,238,36,211,233,140,20,242,111,30,44,199,108,51,59,213,131,240,148,46,207,76,250,83,188,251,36,212,50,244,41,185,245,15,41,127,166,74,177,248,30,192,126,146,58,201,102,180,150,110,243,247,28,61,92,219,179,217,80,190,207,198,85,5,101,172,191,194,46,63,186,244,75,229,181,42,112,52,161,147,19,202,215,206,149,147,61,248,161,7,248,78,139,5,201,188,232,120,179,55,139,206,159,161,107,177,129,22,100,241,155,26,7,155,193,249,222,132,199,187,224,170,21,59,13,239,255,214,239,60,209,190,18,74,143,255,210,248,7,210,248,126,109,182,115,12,91,52,43,140,81,127,163,215,8,143,174,136,203,100,23,132,11,69,135,168,186,4,185,95,114,13,77,1,74,247,111,71,23,8,43,134,8,162,104,50,121,91,64,250,116,102,49,66,205,182,77,206,219,110,62,230,126,214,168,210,21,17,250,158,5,109,54,239,88,7,46,16,15,162,5,229,131,242,100,100,229,188,223,217,224,240,116,172,57,236,121,228,97,227,237,32,125,120,144,146,242,252,1,12,86,171,5,50,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("fec963bc-4f40-4b98-bb72-921691cdead0"));
		}

		#endregion

	}

	#endregion

}

