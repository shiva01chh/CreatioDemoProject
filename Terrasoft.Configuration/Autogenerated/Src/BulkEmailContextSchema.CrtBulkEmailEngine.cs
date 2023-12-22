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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,146,205,110,194,48,16,132,207,32,241,14,43,184,39,247,210,34,209,8,85,57,84,66,165,61,85,61,24,103,147,90,77,236,200,107,87,69,168,239,222,141,67,40,65,252,229,16,101,215,51,254,38,107,107,81,33,213,66,34,188,162,181,130,76,238,162,196,232,92,21,222,10,167,140,30,13,183,163,225,192,147,210,5,172,54,228,176,154,238,235,51,150,40,89,172,78,139,44,114,159,87,38,22,11,22,66,82,10,162,59,120,244,229,215,162,18,170,228,109,28,254,184,160,137,227,24,238,201,87,149,176,155,217,174,78,117,110,108,21,32,32,214,198,59,88,179,21,176,241,118,150,248,192,83,251,117,169,36,200,6,115,130,50,216,6,210,62,206,210,154,26,173,83,200,153,150,193,218,174,31,71,217,101,33,39,52,15,206,228,224,62,145,5,136,32,45,230,15,227,254,47,71,111,132,150,153,26,101,19,124,28,207,192,109,106,140,246,59,31,38,238,34,247,61,199,229,22,10,116,83,160,230,245,123,49,163,179,38,243,18,9,230,203,20,120,120,60,114,227,51,8,115,128,21,218,111,37,175,36,73,249,52,231,181,234,196,205,231,173,248,196,148,229,46,49,15,137,47,26,137,2,65,101,4,74,247,79,238,60,254,201,171,236,253,3,158,91,115,202,222,219,233,94,187,6,252,79,2,139,82,213,10,181,163,139,80,197,198,151,78,218,238,115,130,58,65,157,181,55,39,212,109,183,223,12,189,195,231,15,92,220,168,118,112,3,0,0 };
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

