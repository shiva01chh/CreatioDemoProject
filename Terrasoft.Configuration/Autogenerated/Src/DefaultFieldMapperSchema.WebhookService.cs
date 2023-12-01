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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,145,77,107,195,48,12,134,207,9,244,63,136,238,210,66,73,238,253,130,209,117,35,176,110,131,13,118,118,98,165,241,230,216,193,118,90,74,233,127,159,18,183,37,41,133,229,96,227,87,143,94,41,146,98,37,218,138,101,8,95,104,12,179,58,119,209,74,171,92,108,107,195,156,208,106,16,30,7,97,80,91,161,182,240,121,176,14,75,138,75,137,89,19,180,209,11,42,52,34,155,13,66,162,30,12,110,73,133,149,100,214,78,225,9,115,86,75,247,44,80,242,13,171,42,52,45,21,199,49,204,133,42,40,207,113,157,65,102,48,95,12,147,14,54,140,151,196,85,117,42,5,133,27,179,59,94,48,133,164,103,29,28,91,251,107,23,27,116,133,230,212,199,71,107,228,131,255,23,143,232,106,159,214,183,113,233,99,167,5,135,107,108,148,172,85,93,162,97,169,196,185,117,134,198,179,132,61,166,133,214,191,158,152,192,171,176,110,254,237,53,154,89,93,42,74,95,66,217,148,225,30,26,67,51,221,32,200,181,65,150,21,48,242,86,61,39,16,170,239,124,73,10,118,204,52,110,239,233,15,173,3,22,160,112,15,183,245,46,108,176,86,78,184,131,215,223,104,235,196,119,93,39,103,172,151,127,135,243,216,105,230,239,238,191,68,143,156,143,174,237,140,61,113,106,206,211,121,49,168,184,223,77,251,246,106,95,108,53,250,254,0,190,180,106,200,151,2,0,0 };
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

