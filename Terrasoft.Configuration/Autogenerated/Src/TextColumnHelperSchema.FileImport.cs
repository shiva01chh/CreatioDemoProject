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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,109,146,81,107,194,48,16,199,159,91,240,59,220,28,136,3,105,247,60,181,47,149,49,97,130,160,236,61,182,167,13,180,73,73,46,67,39,126,247,165,105,116,214,245,37,112,151,255,239,254,119,151,8,86,161,174,89,134,176,69,165,152,150,123,138,82,41,246,252,96,20,35,46,69,244,206,75,92,86,181,84,52,8,207,131,48,48,154,139,67,71,173,112,58,8,237,205,179,194,131,37,32,45,153,214,111,86,114,164,84,150,166,18,31,88,214,168,156,38,142,99,152,105,83,85,76,157,18,31,91,63,98,92,104,32,75,64,230,16,13,134,120,201,233,4,21,82,33,115,29,93,225,248,142,174,205,174,228,25,104,178,173,102,144,53,190,61,182,193,217,89,223,250,91,181,21,223,96,237,240,246,242,177,49,151,88,43,172,153,194,78,103,240,205,74,131,17,108,10,187,18,180,141,186,24,248,30,56,65,46,173,88,72,130,189,13,168,64,207,68,55,135,248,209,98,102,13,88,5,194,190,195,124,152,51,98,95,77,185,237,169,198,97,178,176,161,47,79,54,17,205,98,39,238,103,157,110,152,164,247,77,254,3,20,146,81,66,39,126,176,188,103,176,89,124,21,53,84,119,195,154,84,243,248,158,254,219,180,235,121,220,196,139,251,9,160,51,207,228,138,59,159,23,104,62,83,16,216,189,141,159,58,186,104,169,87,236,184,225,63,8,163,145,111,234,19,197,129,10,72,186,21,163,70,116,45,20,180,139,154,123,98,99,118,173,221,248,117,210,71,77,29,116,113,103,59,176,7,183,138,87,227,246,250,226,255,13,138,188,253,58,46,110,179,221,164,205,133,225,47,174,187,6,18,76,3,0,0 };
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

