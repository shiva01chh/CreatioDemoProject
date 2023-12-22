namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ILanguageIteratorSchema

	/// <exclude/>
	public class ILanguageIteratorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ILanguageIteratorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ILanguageIteratorSchema(ILanguageIteratorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f45065ed-3795-44ee-a8b8-acb977312744");
			Name = "ILanguageIterator";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("16e592d3-2033-426b-b620-6aa2b1f8eec0");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,109,81,203,106,195,48,16,60,39,144,127,88,210,75,123,177,238,137,155,75,41,198,208,66,105,251,3,138,189,118,23,236,149,217,149,14,38,244,223,43,63,155,134,10,124,216,241,204,206,104,196,182,69,237,108,129,240,137,34,86,93,229,147,39,199,21,213,65,172,39,199,187,237,101,183,221,4,37,174,225,163,87,143,237,241,102,142,252,166,193,98,32,107,146,33,163,80,17,57,145,117,39,88,71,20,114,246,40,85,52,57,64,254,98,185,14,182,198,60,66,214,59,25,137,198,24,72,53,180,173,149,254,52,207,239,216,9,42,178,87,176,12,52,211,161,138,95,67,234,7,255,115,15,205,188,78,147,101,141,185,218,211,133,115,67,5,208,226,255,159,253,230,50,70,88,195,190,162,255,114,165,30,224,109,20,79,63,111,3,142,64,134,49,219,26,0,144,67,59,45,77,86,137,185,213,164,157,21,219,2,199,218,31,247,130,133,147,50,47,247,167,103,246,228,123,152,0,160,50,94,155,42,66,73,82,51,10,126,245,130,62,8,107,84,44,110,224,170,171,26,82,179,48,6,73,62,211,206,13,166,89,160,242,52,132,94,58,208,251,1,130,37,197,195,113,46,2,185,156,186,24,231,239,233,41,255,128,17,187,62,63,1,68,91,215,69,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f45065ed-3795-44ee-a8b8-acb977312744"));
		}

		#endregion

	}

	#endregion

}

