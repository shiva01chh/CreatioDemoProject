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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,173,84,75,111,219,48,12,62,167,64,255,3,209,222,227,251,146,230,48,15,235,10,172,64,129,185,187,51,54,109,171,181,36,79,162,182,5,233,254,251,36,217,206,242,88,140,20,73,14,9,68,242,123,209,86,20,74,178,45,230,4,25,25,131,86,151,60,77,181,42,69,229,12,178,208,106,154,162,108,81,84,202,94,95,173,175,175,38,206,10,85,193,183,149,101,146,179,205,121,27,108,200,215,125,231,214,80,229,9,32,109,208,218,15,144,234,198,73,245,29,27,71,177,157,36,9,204,173,147,18,205,106,209,159,189,50,163,80,22,132,42,181,145,209,0,224,82,59,134,159,1,8,190,10,164,88,240,10,242,200,55,29,152,146,45,170,214,45,27,145,67,30,132,119,117,39,235,168,189,241,246,100,116,75,134,5,121,131,79,17,213,245,247,205,197,194,179,18,63,188,7,81,4,7,165,32,3,186,60,116,115,104,103,240,115,239,68,209,219,121,126,40,96,13,21,241,12,108,248,250,51,34,27,173,7,41,75,13,229,76,197,73,98,122,249,226,135,123,240,169,82,159,27,172,128,181,95,127,33,114,100,2,174,113,88,125,141,22,36,230,70,219,113,225,165,214,13,124,65,251,24,103,223,167,63,183,68,144,27,42,239,110,62,33,99,4,103,171,150,110,146,197,59,119,189,3,223,59,157,234,38,173,41,127,181,240,171,38,174,253,195,238,100,251,109,20,158,17,56,176,9,11,76,191,249,136,157,88,49,196,206,40,187,200,140,71,122,186,227,36,243,100,152,221,223,232,131,205,252,64,247,246,192,221,98,47,146,199,135,246,78,113,118,137,104,158,145,50,33,233,236,120,27,162,177,136,195,208,145,152,211,127,19,23,9,87,249,11,121,118,176,72,50,22,42,92,251,227,129,190,106,253,234,218,128,154,188,189,29,116,31,93,195,98,100,36,24,8,252,151,127,240,193,252,217,187,137,36,99,187,249,232,127,8,213,200,107,221,79,252,47,224,45,169,162,251,31,143,231,238,42,239,22,125,109,251,243,23,127,125,140,90,238,6,0,0 };
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

