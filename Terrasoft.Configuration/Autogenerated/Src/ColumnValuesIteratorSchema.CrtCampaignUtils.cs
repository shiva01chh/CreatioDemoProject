namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ColumnValuesIteratorSchema

	/// <exclude/>
	public class ColumnValuesIteratorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ColumnValuesIteratorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ColumnValuesIteratorSchema(ColumnValuesIteratorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f924bc20-2aaa-439a-84e8-9d39b2eb7fb7");
			Name = "ColumnValuesIterator";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6c038aa0-46cd-4697-bc93-5c682e364aef");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,84,75,111,219,48,12,62,59,64,254,3,145,93,210,139,125,95,30,192,144,14,67,128,21,24,182,97,119,85,166,29,1,178,100,72,114,186,44,200,127,31,173,135,235,118,137,219,229,16,216,20,73,125,15,210,138,53,104,91,198,17,126,162,49,204,234,202,229,59,173,42,81,119,134,57,161,85,190,99,77,203,68,173,236,124,118,158,207,178,206,10,85,195,143,147,117,216,80,166,148,200,251,52,155,127,65,133,70,240,213,124,70,89,31,12,214,20,133,157,100,214,126,4,202,235,26,245,139,201,14,237,222,33,117,214,198,231,21,69,1,107,219,53,13,51,167,109,124,15,9,104,225,241,68,103,136,192,13,86,155,197,181,30,159,37,54,168,220,162,216,230,169,89,49,234,214,118,143,82,112,224,61,136,27,24,178,179,199,49,0,254,102,116,139,198,9,36,212,244,236,136,29,150,33,229,53,86,31,136,8,44,240,65,10,168,180,1,17,72,228,67,225,24,87,214,166,206,240,85,88,183,158,160,182,125,190,225,12,53,186,21,216,254,239,2,27,80,248,244,118,249,242,110,21,9,162,42,3,199,151,132,201,108,235,76,199,169,166,167,236,21,155,224,123,143,21,235,164,35,186,67,25,60,29,4,63,128,80,194,9,38,197,31,140,228,233,228,89,148,91,66,4,135,174,49,88,222,65,63,111,89,182,167,198,158,70,150,93,166,185,60,160,59,232,242,157,206,237,7,188,229,216,60,93,1,38,197,71,211,151,92,136,163,54,233,233,81,24,215,49,9,71,45,74,8,232,35,149,212,37,255,84,150,203,222,191,49,241,123,180,180,64,30,17,145,15,132,255,173,120,96,220,104,95,240,29,91,73,139,59,149,75,78,9,95,96,175,86,188,91,206,183,166,130,244,230,72,59,134,140,6,33,202,7,149,209,205,255,73,232,35,45,51,172,1,69,223,165,205,130,166,204,225,111,183,216,238,194,131,95,173,54,92,214,127,134,146,83,249,186,240,101,227,153,242,234,71,96,203,107,3,150,122,198,75,146,71,116,133,167,177,60,50,51,112,17,106,216,195,148,151,197,179,60,221,145,250,4,51,46,183,5,14,209,151,65,138,141,127,127,1,118,93,92,171,151,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f924bc20-2aaa-439a-84e8-9d39b2eb7fb7"));
		}

		#endregion

	}

	#endregion

}

