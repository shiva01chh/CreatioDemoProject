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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,145,223,107,194,48,16,199,159,43,248,63,28,238,69,65,218,119,127,193,112,110,8,115,27,108,176,231,180,185,218,108,105,82,146,84,17,241,127,223,165,81,105,69,88,31,18,242,189,207,125,239,122,167,88,137,182,98,25,194,23,26,195,172,206,93,188,212,42,23,219,218,48,39,180,234,247,142,253,94,84,91,161,182,240,121,176,14,75,138,75,137,153,15,218,248,5,21,26,145,77,251,61,162,30,12,110,73,133,165,100,214,78,224,9,115,86,75,247,44,80,242,13,171,42,52,13,149,36,9,204,132,42,40,207,113,157,65,102,48,159,15,214,45,108,144,44,136,171,234,84,10,10,123,179,59,94,48,129,117,199,58,58,54,246,215,46,54,232,10,205,169,143,143,198,40,4,255,47,30,211,213,60,109,104,227,210,199,78,11,14,215,216,112,189,82,117,137,134,165,18,103,214,25,26,207,2,246,152,22,90,255,6,98,12,175,194,186,217,119,208,104,102,117,169,40,125,1,165,47,195,3,52,2,63,221,40,202,181,65,150,21,48,12,86,29,39,16,170,235,124,73,138,118,204,120,183,247,244,135,214,1,115,80,184,135,219,122,23,54,90,41,39,220,33,232,111,180,117,226,219,174,227,51,214,201,191,195,5,236,52,13,119,251,95,226,71,206,135,215,118,70,129,56,249,243,116,94,12,42,30,118,211,188,131,218,21,27,205,127,127,172,242,198,30,152,2,0,0 };
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

