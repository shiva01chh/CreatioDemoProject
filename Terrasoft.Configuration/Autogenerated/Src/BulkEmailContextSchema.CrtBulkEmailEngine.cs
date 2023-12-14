namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BulkEmailContextSchema

	/// <exclude/>
	public class BulkEmailContextSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BulkEmailContextSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BulkEmailContextSchema(BulkEmailContextSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("20559898-5818-4bc5-ac24-30a5cda72c44");
			Name = "BulkEmailContext";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("bbfdb6d8-67aa-4e5b-af46-39321e13789f");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,146,205,110,194,48,16,132,207,32,241,14,43,184,39,247,210,34,209,8,85,57,84,66,165,61,85,61,24,103,147,90,77,236,200,107,87,69,168,239,222,117,66,40,65,252,229,16,101,215,51,254,38,107,107,81,33,213,66,34,188,162,181,130,76,238,162,196,232,92,21,222,10,167,140,30,13,183,163,225,192,147,210,5,172,54,228,176,154,238,235,51,150,40,89,172,78,139,44,114,159,87,38,22,11,22,66,82,10,162,59,120,244,229,215,162,18,170,228,109,28,254,184,70,19,199,49,220,147,175,42,97,55,179,93,157,234,220,216,170,129,128,88,27,239,96,205,86,192,224,237,44,241,129,167,246,235,82,73,144,1,115,130,50,216,54,164,125,156,165,53,53,90,167,144,51,45,27,107,187,126,28,101,151,133,156,208,60,56,147,131,251,68,22,32,130,180,152,63,140,251,191,28,189,17,90,102,106,148,33,248,56,158,129,219,212,24,237,119,62,76,220,69,238,123,142,203,45,20,232,166,64,225,245,123,49,163,179,38,243,18,9,230,203,20,120,120,60,114,227,51,104,230,0,43,180,223,74,94,73,146,242,105,206,107,213,137,195,231,173,248,196,148,229,46,49,15,137,47,26,137,2,65,101,4,74,247,79,238,60,254,201,171,236,253,3,158,91,115,202,222,219,233,94,187,0,254,39,129,69,169,106,133,218,209,69,168,98,227,75,39,109,247,57,65,157,160,206,218,155,211,212,109,183,223,108,122,225,249,3,221,38,69,50,104,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("20559898-5818-4bc5-ac24-30a5cda72c44"));
		}

		#endregion

	}

	#endregion

}

