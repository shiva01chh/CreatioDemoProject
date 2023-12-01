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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,80,65,106,195,48,16,60,199,224,63,44,228,110,223,155,210,139,115,13,228,16,122,95,203,107,87,197,146,204,174,84,48,166,127,175,37,219,33,105,139,47,130,157,157,157,25,141,69,67,50,160,34,184,17,51,138,107,125,81,57,219,234,46,48,122,237,108,81,161,25,80,119,86,242,108,202,179,67,16,109,187,39,50,211,41,207,230,205,145,169,155,15,160,234,81,228,5,110,227,64,205,59,246,129,46,174,161,62,81,202,178,132,87,9,198,32,143,111,235,124,38,81,172,107,18,48,145,7,173,99,80,171,39,144,245,218,143,32,234,131,12,130,65,197,14,190,162,102,177,169,149,15,114,67,168,123,173,64,197,0,127,253,15,83,202,112,207,121,101,55,16,123,77,115,216,107,186,92,246,191,67,38,32,9,129,107,119,163,21,247,243,199,84,91,44,87,127,146,242,171,210,4,29,249,19,72,124,190,119,124,47,81,87,54,51,229,250,96,44,52,232,113,169,1,252,252,203,125,219,243,76,78,158,177,144,212,202,127,230,71,178,205,210,75,154,23,244,25,76,88,150,253,0,184,208,58,232,50,2,0,0 };
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

