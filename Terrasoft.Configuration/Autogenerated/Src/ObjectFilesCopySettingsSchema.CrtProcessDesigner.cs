namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ObjectFilesCopySettingsSchema

	/// <exclude/>
	public class ObjectFilesCopySettingsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ObjectFilesCopySettingsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ObjectFilesCopySettingsSchema(ObjectFilesCopySettingsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("8c876db7-b521-4b78-af16-6a8f941e5884");
			Name = "ObjectFilesCopySettings";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("8b1c57bf-1ff6-4af0-890b-4cc1ace5ccaa");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,146,193,110,194,48,12,134,207,32,237,29,44,113,111,239,48,237,82,49,180,211,96,101,15,16,82,183,245,212,38,93,156,104,170,208,222,125,73,10,168,76,48,49,122,106,254,250,247,255,197,174,18,45,114,39,36,194,22,141,17,172,75,155,100,90,149,84,57,35,44,105,245,48,221,63,76,39,142,73,85,144,247,108,177,93,156,206,99,139,193,100,169,44,89,66,246,5,190,100,102,176,242,126,200,26,193,60,135,215,221,7,74,251,76,13,114,166,187,62,71,107,125,11,142,165,105,154,194,35,187,182,21,166,127,58,156,223,176,51,200,168,44,131,142,86,40,131,23,164,55,3,31,220,201,209,156,142,220,157,219,53,36,65,134,220,235,177,147,125,140,62,97,174,141,238,208,4,252,57,172,99,135,225,251,111,182,40,172,48,96,153,192,193,176,204,55,96,181,127,111,2,229,87,77,178,142,172,65,12,180,201,169,205,152,242,136,25,135,214,231,178,198,86,108,28,154,254,130,178,135,10,237,34,164,45,224,251,86,44,167,232,211,33,80,225,103,72,37,161,1,93,66,129,236,239,31,23,11,24,115,128,99,208,223,144,43,71,5,108,133,241,24,99,186,247,151,226,62,182,115,40,91,163,31,148,82,126,124,88,28,182,125,3,79,118,180,12,59,190,151,229,226,156,46,33,121,161,113,173,250,63,89,22,125,87,134,53,67,85,12,191,96,60,15,234,185,24,181,240,252,0,52,81,90,150,173,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("8c876db7-b521-4b78-af16-6a8f941e5884"));
		}

		#endregion

	}

	#endregion

}

