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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,146,77,79,195,48,12,134,207,157,180,255,96,117,23,144,170,245,62,182,29,24,151,73,8,33,62,78,136,131,23,220,46,82,155,76,249,0,1,218,127,199,73,51,182,110,140,94,154,56,175,237,199,111,162,176,37,187,65,65,240,68,198,160,213,149,27,47,180,170,100,237,13,58,169,213,112,240,61,28,100,222,74,85,247,36,134,174,134,3,62,25,25,170,89,6,139,6,173,157,192,13,85,232,27,119,139,170,246,88,211,210,17,151,209,38,74,203,178,132,169,245,109,139,230,115,158,246,73,15,77,74,0,153,50,10,112,107,116,176,49,250,93,190,209,254,188,50,186,5,161,149,67,225,58,137,37,7,82,129,21,107,106,113,188,235,83,30,52,218,248,85,35,5,136,128,120,142,16,38,112,141,150,78,193,179,48,255,126,76,173,172,51,94,240,17,79,123,31,11,199,225,78,166,139,129,165,146,78,98,35,191,200,130,162,15,230,180,14,21,187,173,43,22,19,129,48,84,205,242,51,76,121,57,31,255,150,46,143,107,79,55,104,176,5,197,55,56,203,189,37,195,108,138,68,184,180,124,254,204,251,96,83,10,140,167,101,84,255,157,220,89,119,199,235,124,254,24,215,69,103,49,227,134,137,131,215,189,10,201,208,51,216,23,207,61,24,232,179,21,192,6,134,215,180,239,122,25,106,102,19,88,241,5,92,244,213,151,16,237,207,118,61,30,124,195,86,206,162,153,203,195,224,203,107,82,102,225,40,145,37,246,67,221,17,92,113,136,81,156,20,248,39,179,131,222,94,133,223,182,123,2,35,82,111,221,59,137,251,46,218,15,114,140,191,31,133,2,16,150,118,3,0,0 };
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

