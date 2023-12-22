namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ColumnValuesIteratorElementSchema

	/// <exclude/>
	public class ColumnValuesIteratorElementSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ColumnValuesIteratorElementSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ColumnValuesIteratorElementSchema(ColumnValuesIteratorElementSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("940b6f42-9d5c-4d59-8253-b8b8e250727e");
			Name = "ColumnValuesIteratorElement";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6c038aa0-46cd-4697-bc93-5c682e364aef");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,145,77,79,195,48,12,134,207,171,180,255,96,149,11,92,154,59,116,149,80,197,129,195,164,29,16,119,47,117,187,104,77,82,197,233,0,33,254,59,89,210,78,163,154,200,41,254,122,108,191,54,168,137,7,148,4,111,228,28,178,109,125,81,91,211,170,110,116,232,149,53,69,141,122,64,213,25,94,103,223,235,108,157,173,238,28,117,33,0,117,143,204,143,80,219,126,212,230,29,251,145,248,213,83,168,178,238,165,39,77,198,199,116,33,4,148,60,106,141,238,171,154,236,231,61,123,135,210,3,165,68,104,173,11,73,68,32,29,181,155,252,22,51,23,85,49,227,196,21,111,24,247,189,146,128,51,82,158,199,250,127,170,85,90,228,178,201,150,252,193,54,97,151,93,100,165,224,114,238,232,216,226,145,24,66,155,115,217,135,242,7,208,40,157,101,56,197,78,128,166,1,25,91,79,158,226,130,18,75,86,57,160,67,13,38,92,96,147,75,107,60,125,250,188,170,211,39,42,50,56,43,137,89,153,110,22,138,139,82,196,178,72,89,174,126,178,170,129,93,42,186,191,165,192,12,159,186,61,60,77,58,144,105,146,20,209,254,73,103,254,227,12,190,235,247,11,193,242,91,185,55,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("940b6f42-9d5c-4d59-8253-b8b8e250727e"));
		}

		#endregion

	}

	#endregion

}

