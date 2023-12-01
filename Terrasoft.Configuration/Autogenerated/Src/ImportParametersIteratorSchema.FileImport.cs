namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ImportParametersIteratorSchema

	/// <exclude/>
	public class ImportParametersIteratorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ImportParametersIteratorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ImportParametersIteratorSchema(ImportParametersIteratorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("6a556f6f-f364-4e38-8c78-e99a9660b2e1");
			Name = "ImportParametersIterator";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("79cdeed7-eef0-4dd8-9765-07d140cf1035");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,82,219,106,3,33,16,125,54,144,127,24,232,203,6,194,126,64,211,20,74,218,66,30,10,129,150,190,91,119,118,51,224,234,226,165,16,66,254,189,70,119,19,77,75,125,112,116,60,231,204,77,197,123,180,3,23,8,31,104,12,183,186,117,245,70,171,150,58,111,184,35,173,234,87,146,184,237,7,109,220,124,118,156,207,152,183,164,58,120,63,88,135,253,106,62,11,158,59,131,93,64,194,70,114,107,239,33,129,119,220,4,105,135,198,110,195,198,157,54,17,59,248,47,73,2,172,11,226,2,196,153,241,15,129,29,35,233,18,225,13,221,94,55,33,198,46,202,164,199,82,242,91,83,3,73,1,171,91,101,24,46,199,229,153,202,216,147,56,23,249,144,128,47,202,145,59,44,199,132,54,90,250,94,149,183,79,46,61,150,174,103,180,142,84,236,213,35,208,152,250,2,142,81,191,213,6,185,216,67,149,7,0,42,46,42,203,170,142,78,66,59,9,220,42,164,152,32,146,41,185,233,237,74,101,191,50,31,121,233,188,46,242,8,115,86,77,6,173,18,116,177,26,181,168,133,170,96,175,65,121,41,175,193,152,208,65,72,121,156,24,167,209,254,89,65,214,53,104,178,51,77,181,213,25,34,43,137,77,29,174,168,24,153,24,135,37,242,49,101,194,139,155,172,146,137,251,105,252,99,168,154,244,205,226,61,121,75,103,240,133,245,3,15,72,41,189,51,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6a556f6f-f364-4e38-8c78-e99a9660b2e1"));
		}

		#endregion

	}

	#endregion

}

