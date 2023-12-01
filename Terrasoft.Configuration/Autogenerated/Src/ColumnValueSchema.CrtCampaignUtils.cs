namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ColumnValueSchema

	/// <exclude/>
	public class ColumnValueSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ColumnValueSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ColumnValueSchema(ColumnValueSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("3acab525-0700-4166-92ec-120c1b6f08ac");
			Name = "ColumnValue";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6c038aa0-46cd-4697-bc93-5c682e364aef");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,173,84,205,110,218,64,16,62,19,41,239,48,74,238,248,94,8,135,82,181,141,212,72,145,234,244,62,216,99,123,27,123,215,221,157,109,139,72,223,189,179,107,155,6,40,22,17,112,0,237,204,124,127,99,47,26,27,114,45,102,4,41,89,139,206,20,60,93,26,93,168,210,91,100,101,244,116,137,77,139,170,212,238,250,106,115,125,53,241,78,233,18,190,174,29,83,51,219,158,95,131,45,73,93,58,183,150,74,33,128,101,141,206,189,131,165,169,125,163,191,97,237,41,182,147,36,129,185,243,77,131,118,189,232,207,162,204,168,180,3,165,11,99,155,104,0,112,101,60,195,207,0,4,169,2,105,86,188,134,44,242,77,7,166,228,21,85,235,87,181,202,32,11,194,187,186,147,77,212,222,122,123,180,166,37,203,138,196,224,99,68,117,253,125,115,177,240,164,213,15,241,160,242,224,160,80,100,193,20,135,110,14,237,12,126,62,121,149,247,118,158,238,115,216,64,73,60,3,23,190,254,140,200,70,235,65,202,81,77,25,83,126,146,152,89,125,151,225,30,124,170,212,199,26,75,96,35,235,207,85,134,76,192,21,14,171,175,208,65,131,153,53,110,92,120,101,76,13,159,209,61,196,217,183,233,207,29,17,100,150,138,187,155,15,200,24,193,233,186,165,155,100,241,198,93,239,192,247,78,167,186,89,86,148,61,59,248,85,17,87,242,176,59,217,126,27,185,48,2,7,54,229,128,233,55,31,177,19,43,150,216,91,237,22,169,21,164,208,29,39,153,39,195,236,254,70,239,93,42,3,221,219,3,119,139,189,72,130,15,237,157,226,236,18,209,132,145,82,213,208,217,241,182,68,99,17,135,161,35,49,167,255,38,46,18,174,148,11,121,118,176,72,50,22,42,92,251,227,129,190,24,243,236,219,128,154,188,188,28,116,31,124,205,106,100,36,24,8,252,151,127,240,193,252,217,187,137,36,99,187,121,47,63,132,122,228,181,238,39,254,23,240,150,116,222,253,143,199,115,119,149,119,139,82,147,207,95,104,53,23,183,229,6,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("3acab525-0700-4166-92ec-120c1b6f08ac"));
		}

		#endregion

	}

	#endregion

}

