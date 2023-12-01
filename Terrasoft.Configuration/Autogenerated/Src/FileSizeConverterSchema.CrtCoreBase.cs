namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: FileSizeConverterSchema

	/// <exclude/>
	public class FileSizeConverterSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public FileSizeConverterSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public FileSizeConverterSchema(FileSizeConverterSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("b9844b9b-b3bf-4414-a49f-287d942d6932");
			Name = "FileSizeConverter";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,101,80,193,78,195,48,12,61,51,105,255,96,141,203,198,97,1,196,105,116,61,48,9,137,195,36,36,246,3,110,234,141,72,77,82,57,41,210,64,252,59,78,155,22,13,162,72,177,159,223,123,177,237,208,82,104,81,19,28,136,25,131,63,198,245,206,187,163,57,117,140,209,120,7,95,243,217,124,118,117,205,116,74,217,174,193,16,54,240,108,26,122,51,159,36,212,15,226,72,44,20,185,109,87,53,70,67,136,34,213,160,19,247,63,53,59,78,150,123,138,239,190,22,211,215,94,61,20,149,82,80,132,206,90,228,115,57,2,217,2,130,216,129,17,101,5,209,79,89,117,142,20,214,147,88,253,85,23,45,50,90,112,50,241,118,145,68,47,110,95,45,202,66,245,248,47,141,41,118,236,130,20,198,40,149,46,71,171,73,27,139,141,116,112,240,79,233,223,165,113,67,95,201,116,5,219,18,150,153,179,26,81,184,129,187,219,251,135,252,60,230,37,144,171,135,61,244,249,247,176,236,11,176,199,228,252,0,202,72,11,105,171,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b9844b9b-b3bf-4414-a49f-287d942d6932"));
		}

		#endregion

	}

	#endregion

}

