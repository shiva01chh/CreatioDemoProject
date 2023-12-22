namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: TypedValueModelSchema

	/// <exclude/>
	public class TypedValueModelSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public TypedValueModelSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public TypedValueModelSchema(TypedValueModelSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e563da35-a0e4-4fae-aeed-9e1cbe43a1ed");
			Name = "TypedValueModel";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6c038aa0-46cd-4697-bc93-5c682e364aef");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,80,65,106,195,48,16,60,199,224,63,44,228,110,223,155,210,139,115,13,228,16,122,95,203,107,87,197,146,204,174,84,48,166,127,175,37,199,193,105,139,117,16,104,118,118,102,52,22,13,201,128,138,224,70,204,40,174,245,69,229,108,171,187,192,232,181,179,69,133,102,64,221,89,201,179,41,207,14,65,180,237,158,200,76,167,60,155,39,71,166,110,94,128,170,71,145,23,184,141,3,53,239,216,7,186,184,134,250,68,41,203,18,94,37,24,131,60,190,221,223,103,18,197,186,38,1,19,121,208,58,6,117,247,4,178,94,251,17,68,125,144,65,48,168,216,193,87,212,44,86,181,114,35,55,132,186,215,10,84,12,240,215,255,48,165,12,143,156,87,118,3,177,215,52,135,189,166,205,101,254,59,100,2,146,16,184,118,55,90,241,88,223,166,90,99,185,250,147,148,191,43,77,208,145,63,129,196,235,123,199,247,18,117,101,53,83,174,15,198,66,131,30,151,26,192,207,191,220,183,61,207,228,228,25,11,73,173,252,103,126,36,219,44,189,164,247,130,62,131,9,219,156,31,61,245,9,214,59,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e563da35-a0e4-4fae-aeed-9e1cbe43a1ed"));
		}

		#endregion

	}

	#endregion

}

