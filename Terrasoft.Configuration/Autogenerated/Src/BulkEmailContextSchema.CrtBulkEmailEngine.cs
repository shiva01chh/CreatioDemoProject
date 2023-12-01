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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,146,77,107,194,64,16,134,207,10,254,135,65,239,201,189,182,130,13,82,114,40,72,109,79,165,135,117,51,73,135,38,187,97,63,74,69,250,223,59,217,24,107,196,175,28,66,102,246,125,247,121,51,187,74,84,104,107,33,17,94,209,24,97,117,238,162,68,171,156,10,111,132,35,173,70,195,237,104,56,240,150,84,1,171,141,117,88,77,247,245,25,75,148,44,86,167,69,6,185,207,43,19,131,5,11,33,41,133,181,119,240,232,203,175,69,37,168,228,109,28,254,184,160,137,227,24,238,173,175,42,97,54,179,93,157,170,92,155,42,64,64,172,181,119,176,102,43,96,227,237,44,241,129,167,246,235,146,36,200,6,115,130,50,216,6,210,62,206,210,232,26,141,35,228,76,203,96,109,215,143,163,236,178,88,39,20,15,78,231,224,62,145,5,136,32,13,230,15,227,254,47,71,111,22,13,51,21,202,38,248,56,158,129,219,212,24,237,119,62,76,220,69,238,123,142,203,45,20,232,166,96,155,215,239,197,140,206,232,204,75,180,48,95,166,192,195,227,145,107,159,65,152,3,172,208,124,147,188,146,36,229,211,156,215,212,137,155,207,91,241,137,46,203,93,98,30,18,95,52,43,10,4,202,44,144,234,159,220,121,252,147,167,236,253,3,158,91,115,202,222,219,233,94,185,6,252,79,2,131,146,106,66,229,236,69,40,177,241,165,147,182,251,156,160,78,80,101,237,205,9,117,219,237,55,67,143,159,63,0,78,32,146,103,3,0,0 };
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

