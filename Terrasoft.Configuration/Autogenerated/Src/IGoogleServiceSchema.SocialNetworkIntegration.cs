namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IGoogleServiceSchema

	/// <exclude/>
	public class IGoogleServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IGoogleServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IGoogleServiceSchema(IGoogleServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("956a9445-e36a-4d6f-9741-e5836ee6b58c");
			Name = "IGoogleService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,146,209,107,194,48,16,198,159,21,252,31,14,247,162,32,237,187,58,97,19,38,29,56,101,21,124,16,31,98,122,173,97,109,210,37,169,80,100,255,251,174,137,149,185,13,251,150,239,190,252,114,223,93,37,43,208,148,140,35,108,80,107,102,84,106,131,185,146,169,200,42,205,172,80,50,136,21,23,44,239,117,207,189,110,167,50,66,102,16,215,198,98,17,196,168,79,130,227,82,37,152,79,238,21,131,39,110,197,201,209,238,251,182,120,32,3,89,30,52,102,228,134,72,90,212,41,117,55,134,104,161,84,150,227,197,239,92,187,203,129,250,181,154,113,59,120,163,48,240,8,253,27,107,127,184,39,111,89,29,114,193,65,180,192,63,188,206,217,49,175,79,47,209,30,85,98,198,176,118,55,125,49,12,67,152,154,170,40,152,174,103,173,240,142,182,210,210,0,87,146,74,168,233,145,84,233,194,229,5,118,80,149,133,204,189,5,230,200,52,38,192,202,146,136,126,186,87,106,248,27,59,213,158,59,155,255,195,13,166,97,91,110,252,187,85,137,126,93,237,44,246,78,166,129,70,242,164,62,112,224,227,52,195,89,175,226,77,127,68,93,127,86,104,236,139,35,146,78,214,37,26,195,50,244,82,240,106,148,28,193,179,74,234,216,214,57,222,88,174,106,176,213,148,6,147,134,103,74,106,20,239,3,221,46,58,126,244,109,174,136,98,181,183,97,129,246,167,62,24,78,46,107,65,153,248,205,184,243,151,255,77,110,68,210,154,239,27,216,112,158,115,210,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("956a9445-e36a-4d6f-9741-e5836ee6b58c"));
		}

		#endregion

	}

	#endregion

}

