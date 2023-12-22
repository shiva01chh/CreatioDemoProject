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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,109,146,81,107,194,48,16,199,159,43,248,29,110,14,164,3,105,247,60,107,95,148,49,97,130,160,236,61,182,167,13,52,105,73,46,67,39,126,247,165,105,116,214,181,15,133,187,252,127,247,191,187,68,50,129,186,102,25,194,22,149,98,186,218,83,52,175,228,158,31,140,98,196,43,25,189,243,18,151,162,174,20,13,7,231,225,32,48,154,203,67,71,173,112,58,28,216,147,103,133,7,75,192,188,100,90,191,89,201,145,230,85,105,132,252,192,178,70,229,52,113,28,67,162,141,16,76,157,82,31,91,63,98,92,106,32,75,64,230,16,13,134,120,201,233,4,2,169,168,114,29,93,225,248,142,174,205,174,228,25,104,178,173,102,144,53,190,61,182,193,217,89,223,250,91,181,21,223,96,237,240,246,240,177,49,151,88,43,172,153,194,78,103,240,205,74,131,17,108,10,187,18,180,141,186,24,248,30,56,65,94,89,177,172,8,246,54,160,2,61,19,221,28,226,71,139,196,26,48,1,210,222,195,108,148,51,98,95,77,185,237,169,198,81,186,176,161,47,79,54,17,37,177,19,247,179,78,55,74,231,247,77,254,3,20,146,81,82,167,126,176,188,103,176,36,190,138,26,170,187,97,77,170,185,124,79,255,109,218,245,28,54,241,226,126,2,232,204,51,185,226,206,231,5,154,199,20,4,118,111,225,83,71,23,45,245,138,29,55,252,7,97,60,246,77,125,162,60,80,1,105,183,98,212,136,174,133,130,118,81,51,79,108,204,174,181,11,95,39,125,212,212,65,23,247,111,7,246,224,86,113,17,182,199,23,255,110,80,230,237,211,113,113,155,237,38,109,238,238,251,5,114,135,152,95,85,3,0,0 };
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

