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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,82,219,106,3,33,16,125,54,144,127,24,232,203,6,194,126,64,211,20,74,218,66,30,10,129,150,190,91,119,54,25,112,117,241,82,8,33,255,94,87,119,19,77,75,125,112,116,60,231,204,77,197,59,180,61,23,8,31,104,12,183,186,117,245,70,171,150,246,222,112,71,90,213,175,36,113,219,245,218,184,249,236,52,159,49,111,73,237,225,253,104,29,118,171,249,44,120,238,12,238,3,18,54,146,91,123,15,9,188,227,38,72,59,52,118,27,54,238,180,137,216,222,127,73,18,96,93,16,23,32,6,198,63,4,118,138,164,75,132,55,116,7,221,132,24,187,40,147,30,75,201,111,77,13,36,5,172,110,149,161,191,28,151,3,149,177,39,49,20,249,144,128,47,202,145,59,46,199,132,54,90,250,78,149,183,79,46,61,150,174,103,180,142,84,236,213,35,208,152,250,2,78,81,191,213,6,185,56,64,149,7,0,42,46,42,203,170,142,78,66,59,9,220,42,164,152,32,146,41,185,233,237,74,101,191,50,31,121,233,188,46,242,8,115,86,77,6,173,18,116,177,26,181,168,133,170,96,175,65,121,41,175,193,152,208,65,72,121,156,24,231,209,254,89,65,214,53,104,178,51,77,181,213,25,34,43,137,77,29,174,168,24,153,24,135,37,242,49,101,194,139,155,172,146,137,251,121,252,99,168,154,244,205,226,61,121,75,103,240,13,235,7,74,50,213,162,52,3,0,0 };
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

