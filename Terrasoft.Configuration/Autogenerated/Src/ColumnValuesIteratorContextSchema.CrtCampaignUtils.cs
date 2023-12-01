namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ColumnValuesIteratorContextSchema

	/// <exclude/>
	public class ColumnValuesIteratorContextSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ColumnValuesIteratorContextSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ColumnValuesIteratorContextSchema(ColumnValuesIteratorContextSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("6c11e73b-d8b2-4159-8639-b9b25cb1fe29");
			Name = "ColumnValuesIteratorContext";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6c038aa0-46cd-4697-bc93-5c682e364aef");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,147,77,75,195,64,16,134,207,10,254,135,65,47,10,146,220,109,205,165,130,8,138,226,215,193,219,186,153,196,133,253,8,59,187,214,90,252,239,78,54,105,76,75,41,181,135,210,217,188,243,230,121,119,166,86,24,164,70,72,132,103,244,94,144,171,66,54,115,182,82,117,244,34,40,103,179,153,48,141,80,181,165,163,195,229,209,225,65,36,101,107,120,90,80,64,51,217,168,185,83,107,148,109,27,101,215,104,209,43,249,167,25,191,192,227,224,203,2,150,156,120,172,185,13,102,90,16,93,0,27,69,99,95,133,142,72,55,1,25,197,121,198,10,248,21,146,60,207,115,152,82,52,70,248,69,209,215,253,115,152,127,40,249,1,146,43,161,44,129,178,77,12,208,8,207,73,217,137,160,114,158,123,17,65,122,172,46,143,183,189,234,56,47,64,216,18,60,82,212,129,91,188,51,128,130,109,81,163,65,27,178,21,67,62,130,104,226,187,86,18,100,27,97,119,130,131,101,74,49,164,126,240,174,65,31,20,114,244,135,228,210,61,223,140,217,229,236,47,14,130,50,8,223,206,98,54,104,199,56,43,158,103,150,189,177,234,198,86,110,40,238,171,138,48,192,18,106,12,19,160,246,235,7,46,215,180,217,75,144,147,93,28,195,176,193,85,96,132,244,142,192,184,18,53,237,6,186,85,20,166,119,173,62,93,207,93,219,82,64,58,160,238,194,86,92,45,146,197,249,246,142,211,179,253,233,100,154,6,124,118,238,221,134,204,149,214,240,142,188,32,196,119,143,37,255,0,30,173,10,139,61,240,71,227,45,214,102,189,21,125,172,254,15,246,176,127,188,178,221,250,37,190,62,206,110,204,43,149,108,248,116,122,29,85,121,62,166,124,76,190,5,60,246,254,27,204,123,180,14,41,78,208,150,221,22,167,250,167,251,55,175,29,242,25,127,126,1,10,172,44,74,106,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6c11e73b-d8b2-4159-8639-b9b25cb1fe29"));
		}

		#endregion

	}

	#endregion

}

