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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,146,209,107,194,48,16,198,159,43,248,63,28,238,69,65,218,119,117,194,38,76,58,112,202,42,248,32,62,196,244,90,195,218,164,75,82,161,200,254,247,157,137,149,185,13,251,150,239,190,252,114,223,93,37,43,209,84,140,35,172,81,107,102,84,102,195,153,146,153,200,107,205,172,80,50,76,20,23,172,232,118,78,221,78,80,27,33,115,72,26,99,177,12,19,212,71,193,113,161,82,44,198,247,138,225,19,183,226,232,104,247,125,27,220,147,129,44,15,26,115,114,67,44,45,234,140,186,27,65,60,87,42,47,240,226,119,174,237,229,64,253,90,205,184,237,191,81,24,120,132,222,141,181,55,216,145,183,170,247,133,224,32,90,224,31,94,112,114,204,235,211,11,180,7,149,154,17,172,220,77,95,140,162,8,38,166,46,75,166,155,105,43,188,163,173,181,52,192,149,164,18,106,122,36,83,186,116,121,129,237,85,109,33,119,111,129,57,48,141,41,176,170,34,162,159,238,149,26,253,198,78,180,231,78,103,255,112,195,73,212,150,207,254,237,178,66,191,174,118,22,59,39,211,64,99,121,84,31,216,247,113,206,195,89,45,147,117,111,72,93,127,214,104,236,139,35,146,78,214,5,26,195,114,244,82,248,106,148,28,194,179,74,155,196,54,5,222,88,174,106,184,209,148,6,211,51,207,84,212,40,222,7,186,93,4,126,244,109,174,152,98,181,183,97,142,246,167,222,31,140,47,107,65,153,250,205,184,243,151,255,77,110,68,210,232,251,6,171,43,12,77,209,2,0,0 };
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

