namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: DefaultLanguageIteratorSchema

	/// <exclude/>
	public class DefaultLanguageIteratorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public DefaultLanguageIteratorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public DefaultLanguageIteratorSchema(DefaultLanguageIteratorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("aeeb29af-e2e5-4dd2-b9f3-3255567cf2c9");
			Name = "DefaultLanguageIterator";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("2659875a-4670-491c-9c1f-f4641a7bae64");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,146,77,79,195,48,12,134,207,157,180,255,96,149,11,147,170,245,62,182,29,128,203,36,132,16,31,39,196,193,203,220,18,169,77,166,124,128,0,241,223,113,210,140,181,27,163,151,38,206,107,251,241,155,40,108,201,110,81,16,60,146,49,104,117,229,166,87,90,85,178,246,6,157,212,106,60,250,26,143,50,111,165,170,7,18,67,23,227,17,159,156,25,170,89,6,87,13,90,59,131,107,170,208,55,238,6,85,237,177,166,149,35,46,163,77,148,150,101,9,115,235,219,22,205,199,50,237,147,30,154,148,0,50,101,20,224,94,209,193,214,232,55,185,161,253,121,101,116,11,66,43,135,194,117,18,75,14,164,2,43,94,169,197,233,174,79,217,107,180,245,235,70,10,16,1,241,20,33,204,224,18,45,29,131,103,97,254,253,152,90,89,103,188,224,35,158,246,46,22,142,195,29,77,23,3,43,37,157,196,70,126,146,5,69,239,204,105,29,42,118,91,87,44,38,2,97,168,90,228,39,152,242,114,57,253,45,93,30,214,158,111,209,96,11,138,111,112,145,123,75,134,217,20,137,112,105,249,242,137,247,193,166,20,152,206,203,168,254,59,185,179,238,150,215,249,242,33,174,139,206,98,198,13,19,7,175,7,21,146,161,39,176,207,159,6,48,48,100,43,128,13,12,175,105,223,117,18,106,102,51,88,243,5,156,15,213,19,136,246,103,187,30,247,190,97,43,23,209,204,85,63,248,252,146,148,89,56,74,100,137,189,175,59,128,43,250,24,197,81,129,127,50,59,232,239,139,240,251,238,158,192,25,169,77,247,78,226,190,139,14,131,28,235,127,63,186,169,170,23,127,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("aeeb29af-e2e5-4dd2-b9f3-3255567cf2c9"));
		}

		#endregion

	}

	#endregion

}

