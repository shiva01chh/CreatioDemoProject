namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ColumnValueResultSchema

	/// <exclude/>
	public class ColumnValueResultSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ColumnValueResultSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ColumnValueResultSchema(ColumnValueResultSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("3673988a-b579-40b7-b4e0-255d21d4b2d7");
			Name = "ColumnValueResult";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6c038aa0-46cd-4697-bc93-5c682e364aef");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,83,201,78,195,48,16,61,167,82,255,97,20,46,112,73,238,116,185,68,21,234,173,2,202,221,117,38,193,40,177,141,151,66,169,250,239,216,206,86,218,82,200,33,138,103,121,239,205,27,135,147,26,181,36,20,225,25,149,34,90,20,38,201,4,47,88,105,21,49,76,240,36,35,181,36,172,228,122,60,218,143,71,145,213,140,151,240,180,211,6,235,201,120,228,34,55,10,75,87,8,89,69,180,190,135,76,84,182,230,47,164,178,248,136,218,86,38,20,165,105,10,83,109,235,154,168,221,188,61,55,105,16,5,208,208,3,91,223,4,140,27,84,82,161,123,67,33,20,120,194,10,219,154,164,195,74,143,192,164,221,84,140,2,245,2,46,241,71,251,160,97,80,42,184,54,202,82,35,148,19,188,10,221,77,197,169,204,16,88,114,102,24,169,216,23,186,28,58,37,10,139,89,124,198,19,167,115,167,93,27,194,41,38,61,88,122,138,54,149,68,145,26,184,51,126,22,55,67,173,151,121,60,95,115,246,238,167,207,145,27,86,48,55,188,51,198,188,246,131,79,211,208,24,112,218,129,207,36,220,62,88,150,67,15,122,7,126,99,81,148,117,1,152,13,201,137,79,29,90,99,144,231,141,55,63,141,90,41,33,81,25,134,255,177,105,225,116,155,93,183,75,199,240,139,9,173,248,32,117,80,182,135,18,205,4,164,98,91,98,16,180,63,28,174,176,101,71,87,230,58,145,216,188,33,53,16,108,234,104,254,132,119,147,83,212,225,174,227,39,69,233,127,5,96,126,33,74,124,240,235,132,139,190,97,248,186,192,123,98,122,19,253,25,116,177,227,231,27,216,228,108,160,173,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("3673988a-b579-40b7-b4e0-255d21d4b2d7"));
		}

		#endregion

	}

	#endregion

}

