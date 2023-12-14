namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: TextColumnHelperSchema

	/// <exclude/>
	public class TextColumnHelperSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public TextColumnHelperSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public TextColumnHelperSchema(TextColumnHelperSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("a1a85a55-168d-4a14-be59-272acc0d963d");
			Name = "TextColumnHelper";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("7e188b25-9774-4cd9-86fe-ed132c1bc48f");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,109,146,81,107,194,48,16,199,159,43,248,29,110,14,164,3,105,247,60,181,47,202,152,48,65,80,246,30,219,211,6,218,180,36,151,161,19,191,251,174,105,116,214,217,135,194,93,254,191,251,223,93,162,68,137,166,22,41,194,6,181,22,166,218,81,52,171,212,78,238,173,22,36,43,21,189,203,2,23,101,93,105,234,247,78,253,94,96,141,84,251,142,90,227,184,223,227,147,103,141,123,38,96,86,8,99,222,88,114,160,89,85,216,82,125,96,81,163,118,154,56,142,97,98,108,89,10,125,76,124,204,126,36,164,50,64,76,64,234,16,3,150,100,33,233,8,37,82,94,101,38,186,192,241,13,93,219,109,33,83,48,196,173,166,144,54,190,15,108,131,147,179,190,246,183,108,43,190,193,202,225,237,225,125,99,46,177,210,88,11,141,157,206,224,91,20,22,35,88,231,188,18,228,70,93,12,114,7,146,32,171,88,172,42,130,29,7,148,163,103,162,171,67,124,111,49,97,3,81,130,226,123,152,14,50,65,226,171,41,183,57,214,56,72,230,28,250,242,196,137,104,18,59,241,99,214,233,6,201,236,182,201,127,128,70,178,90,153,196,15,150,61,24,108,18,95,68,13,213,221,176,33,221,92,190,167,255,54,237,122,14,155,120,126,59,1,116,230,25,93,112,231,243,2,205,99,10,2,222,91,248,212,209,69,11,179,20,135,181,252,65,24,14,125,83,159,168,246,148,67,210,173,24,53,162,75,161,160,93,212,212,19,107,187,109,237,194,215,209,35,106,236,160,179,251,183,3,123,112,163,101,25,182,199,103,255,110,80,101,237,211,113,113,155,237,38,57,199,223,47,199,142,171,3,77,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a1a85a55-168d-4a14-be59-272acc0d963d"));
		}

		#endregion

	}

	#endregion

}

