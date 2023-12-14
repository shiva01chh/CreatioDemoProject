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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,80,203,106,195,48,16,60,199,224,127,88,200,221,190,55,165,23,231,26,200,33,244,190,150,215,174,138,245,64,43,21,140,233,191,87,146,237,144,180,197,58,8,52,59,59,51,26,141,138,216,162,32,184,145,115,200,166,247,85,99,116,47,135,224,208,75,163,171,6,149,69,57,104,46,139,185,44,14,129,165,30,158,200,142,78,101,17,39,71,71,67,92,128,102,68,230,23,184,77,150,186,119,28,3,93,76,71,99,166,212,117,13,175,28,148,66,55,189,173,239,51,177,112,178,37,6,149,120,208,27,7,98,245,4,210,94,250,9,88,124,144,66,80,40,156,129,175,164,89,109,106,245,131,156,13,237,40,5,136,20,224,175,255,97,206,25,238,57,175,206,88,114,94,82,12,123,205,155,203,252,119,200,12,100,33,48,253,110,180,234,190,254,152,106,139,101,218,79,18,126,85,154,97,32,127,2,78,215,247,142,239,37,233,242,102,38,204,24,148,134,14,61,46,53,128,143,191,220,183,61,71,114,246,76,133,228,86,254,51,63,146,238,150,94,242,123,65,159,193,140,197,243,3,253,7,133,247,51,2,0,0 };
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

