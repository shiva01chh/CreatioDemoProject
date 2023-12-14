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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,79,75,10,131,48,16,93,43,120,135,128,123,15,80,151,130,208,69,65,218,94,96,140,163,132,198,36,76,226,66,164,119,111,18,63,80,40,109,103,53,243,126,188,81,48,162,53,192,145,221,145,8,172,238,93,81,105,213,139,97,34,112,66,171,226,166,185,0,153,165,75,150,38,147,21,106,96,183,217,58,28,139,43,246,18,121,208,148,89,234,201,156,112,240,7,171,36,88,123,98,13,105,131,228,102,159,230,64,40,164,40,50,83,43,5,103,60,104,62,73,146,37,202,142,176,77,34,48,36,70,239,202,111,57,214,81,104,84,251,7,90,173,31,181,64,217,177,208,52,73,6,116,101,92,236,182,60,191,57,27,32,84,238,63,235,94,251,172,122,125,4,92,192,24,236,118,234,71,80,142,170,91,31,140,247,138,190,131,30,11,243,2,249,93,223,243,160,1,0,0 };
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

