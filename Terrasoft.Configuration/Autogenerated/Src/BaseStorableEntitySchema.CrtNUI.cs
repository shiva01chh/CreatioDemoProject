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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,109,144,77,107,131,64,16,134,207,43,248,31,6,114,73,46,122,79,106,10,13,161,244,82,2,246,86,74,217,100,39,118,64,87,217,143,4,91,242,223,187,59,106,145,182,130,200,62,251,206,187,207,170,101,131,182,147,39,132,23,52,70,218,246,236,178,93,171,207,84,121,35,29,181,58,77,190,210,68,120,75,186,130,178,183,14,155,77,154,4,178,48,88,133,109,216,213,210,218,53,60,72,139,165,107,141,60,214,184,215,142,92,207,169,60,207,225,206,250,166,145,166,223,142,235,24,5,59,102,1,57,12,87,114,31,32,189,107,43,212,24,78,70,5,164,178,169,33,159,85,188,150,104,72,214,244,25,199,223,2,232,252,177,166,19,156,162,200,191,30,34,222,64,196,119,146,62,152,182,67,227,8,131,249,129,199,167,196,111,97,6,67,209,40,244,215,72,116,134,46,65,25,30,61,41,120,39,181,97,56,104,49,123,82,192,14,162,66,7,197,54,102,160,40,120,47,219,55,93,232,190,135,37,195,129,61,227,53,126,151,171,21,172,127,10,133,157,13,195,69,214,30,153,223,248,79,139,5,106,53,92,143,215,3,157,195,27,164,201,252,249,6,130,186,29,59,251,1,0,0 };
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

