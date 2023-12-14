namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BaseStorableEntitySchema

	/// <exclude/>
	public class BaseStorableEntitySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BaseStorableEntitySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BaseStorableEntitySchema(BaseStorableEntitySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("29c15305-d044-47a9-b58f-c7d81b88fdca");
			Name = "BaseStorableEntity";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,109,144,77,107,131,64,16,134,207,43,248,31,6,114,73,46,122,79,106,10,13,161,244,82,2,246,86,74,217,196,137,29,208,93,217,143,4,91,242,223,187,59,106,145,182,130,200,62,251,206,187,207,170,100,139,182,147,39,132,23,52,70,90,125,118,217,78,171,51,213,222,72,71,90,165,201,87,154,8,111,73,213,80,246,214,97,187,73,147,64,22,6,235,176,13,187,70,90,187,134,7,105,177,116,218,200,99,131,123,229,200,245,156,202,243,28,238,172,111,91,105,250,237,184,142,81,176,99,22,144,195,112,37,247,1,210,59,93,163,194,112,50,86,64,85,54,53,228,179,138,215,18,13,201,134,62,227,248,91,0,157,63,54,116,130,83,20,249,215,67,196,27,136,248,78,210,7,163,59,52,142,48,152,31,120,124,74,252,22,102,48,20,141,66,127,141,68,103,232,18,148,225,209,83,5,239,84,109,24,14,90,204,158,42,96,7,81,163,131,98,27,51,80,20,188,151,237,219,46,116,223,195,146,225,192,158,241,26,191,203,213,10,214,63,133,194,206,134,225,34,27,143,204,111,252,167,197,2,85,53,92,143,215,3,157,195,27,164,73,124,190,1,243,131,76,240,243,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("29c15305-d044-47a9-b58f-c7d81b88fdca"));
		}

		#endregion

	}

	#endregion

}

