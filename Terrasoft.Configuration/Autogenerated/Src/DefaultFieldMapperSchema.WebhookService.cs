namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: DefaultFieldMapperSchema

	/// <exclude/>
	public class DefaultFieldMapperSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public DefaultFieldMapperSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public DefaultFieldMapperSchema(DefaultFieldMapperSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("dd14c32f-0ced-492a-9501-56c2b7f9064c");
			Name = "DefaultFieldMapper";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("fe674b36-6b4e-4761-be68-f76112863a49");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,145,77,107,195,48,12,134,207,9,244,63,136,238,210,66,73,238,253,130,209,117,163,176,110,131,13,118,118,98,37,241,230,216,193,118,90,74,233,127,159,18,183,37,41,133,229,96,227,87,143,94,41,146,98,37,218,138,165,8,95,104,12,179,58,115,209,74,171,76,228,181,97,78,104,53,8,143,131,48,168,173,80,57,124,30,172,195,146,226,82,98,218,4,109,244,130,10,141,72,103,131,144,168,7,131,57,169,176,146,204,218,41,60,97,198,106,233,158,5,74,190,101,85,133,166,165,226,56,134,185,80,5,229,57,174,83,72,13,102,139,225,166,131,13,227,37,113,85,157,72,65,225,198,236,142,23,76,97,211,179,14,142,173,253,181,139,45,186,66,115,234,227,163,53,242,193,255,139,71,116,181,79,235,219,184,244,177,211,130,195,53,54,218,172,85,93,162,97,137,196,185,117,134,198,179,132,61,38,133,214,191,158,152,192,171,176,110,254,237,53,154,89,93,42,74,95,66,217,148,225,30,26,67,51,221,32,200,180,65,150,22,48,242,86,61,39,16,170,239,124,73,10,118,204,52,110,239,201,15,173,3,22,160,112,15,183,245,46,108,176,86,78,184,131,215,223,104,235,196,119,93,39,103,172,151,127,135,243,216,105,230,239,238,191,68,143,156,143,174,237,140,61,113,106,206,211,121,49,168,184,223,77,251,246,106,95,108,181,238,247,7,119,206,203,213,160,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("dd14c32f-0ced-492a-9501-56c2b7f9064c"));
		}

		#endregion

	}

	#endregion

}

