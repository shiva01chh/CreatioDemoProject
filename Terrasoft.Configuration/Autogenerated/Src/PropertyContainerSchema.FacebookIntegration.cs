namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: PropertyContainerSchema

	/// <exclude/>
	public class PropertyContainerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public PropertyContainerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public PropertyContainerSchema(PropertyContainerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("593ff365-923f-4ae6-ac7a-a20ebaa261c5");
			Name = "PropertyContainer";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("34c57733-6570-402b-8e25-5c50c5be2b38");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,79,75,10,131,48,16,93,43,120,135,128,123,15,80,151,130,208,69,161,180,189,192,24,71,9,141,73,152,196,133,72,239,222,36,126,104,161,180,157,213,204,251,241,70,193,128,214,0,71,118,67,34,176,186,115,69,165,85,39,250,145,192,9,173,138,171,230,2,100,150,206,89,154,140,86,168,158,93,39,235,112,40,46,216,73,228,65,83,102,169,39,115,194,222,31,172,146,96,237,129,157,73,27,36,55,249,52,7,66,33,69,145,25,27,41,56,227,65,243,73,146,204,81,182,135,173,18,129,33,49,122,23,126,205,177,142,66,163,218,63,208,104,125,175,5,202,150,133,166,73,210,163,43,227,98,215,229,241,205,121,6,66,229,254,179,110,181,143,170,211,123,192,9,140,193,118,163,126,4,229,168,218,229,193,120,47,232,59,232,177,215,121,2,111,192,115,141,168,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("593ff365-923f-4ae6-ac7a-a20ebaa261c5"));
		}

		#endregion

	}

	#endregion

}

