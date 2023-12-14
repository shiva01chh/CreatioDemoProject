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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,173,84,205,110,218,64,16,62,19,41,239,48,74,238,248,94,8,135,82,181,141,212,72,145,234,244,62,216,99,123,27,123,215,221,153,109,139,72,223,189,187,107,155,6,40,22,17,112,0,237,204,124,127,99,47,26,27,226,22,51,130,148,172,69,54,133,76,151,70,23,170,116,22,69,25,61,93,98,211,162,42,53,95,95,109,174,175,38,142,149,46,225,235,154,133,154,217,246,252,26,108,201,215,125,231,214,82,233,9,96,89,35,243,59,88,154,218,53,250,27,214,142,98,59,73,18,152,179,107,26,180,235,69,127,246,202,130,74,51,40,93,24,219,68,3,128,43,227,4,126,6,32,248,42,144,22,37,107,200,34,223,116,96,74,94,81,181,110,85,171,12,178,32,188,171,59,217,68,237,173,183,71,107,90,178,162,200,27,124,140,168,174,191,111,46,22,158,180,250,225,61,168,60,56,40,20,89,48,197,161,155,67,59,131,159,79,78,229,189,157,167,251,28,54,80,146,204,128,195,215,159,17,217,104,61,72,49,213,148,9,229,39,137,153,213,119,63,220,131,79,149,250,88,99,9,98,252,250,115,149,161,16,72,133,195,234,43,100,104,48,179,134,199,133,87,198,212,240,25,249,33,206,190,77,127,206,68,144,89,42,238,110,62,160,96,4,167,235,150,110,146,197,27,119,189,3,223,59,157,234,102,89,81,246,204,240,171,34,169,252,195,238,100,251,109,228,158,17,36,176,41,6,161,223,114,196,78,172,88,18,103,53,47,82,235,145,158,238,56,201,60,25,102,247,55,122,207,169,31,232,222,30,184,91,236,69,242,248,208,222,41,206,46,17,205,51,82,170,26,58,59,222,150,104,44,226,48,116,36,230,244,223,196,69,194,149,254,66,158,29,44,146,140,133,10,215,254,120,160,47,198,60,187,54,160,38,47,47,7,221,7,87,139,26,25,9,6,2,255,229,31,124,48,127,246,110,34,201,216,110,222,251,31,66,61,242,90,247,19,255,11,120,75,58,239,254,199,227,185,187,202,187,69,95,11,159,191,204,248,9,113,230,6,0,0 };
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

