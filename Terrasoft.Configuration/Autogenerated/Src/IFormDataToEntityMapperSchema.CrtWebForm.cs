namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IFormDataToEntityMapperSchema

	/// <exclude/>
	public class IFormDataToEntityMapperSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IFormDataToEntityMapperSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IFormDataToEntityMapperSchema(IFormDataToEntityMapperSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("c20ea6f3-be52-42d0-824d-0e9ad343f8f2");
			Name = "IFormDataToEntityMapper";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("30ff16fc-9eaa-40ad-9611-33924da6f041");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,82,205,106,195,48,12,62,167,208,119,16,61,109,48,146,7,88,215,203,182,142,29,122,106,97,103,215,86,18,67,98,7,217,110,9,99,239,62,217,73,186,148,82,102,140,73,140,190,31,125,178,17,45,186,78,72,132,3,18,9,103,75,159,191,90,83,234,42,144,240,218,154,252,3,13,242,39,170,47,60,110,45,181,123,164,147,150,184,92,124,47,23,89,112,218,84,87,80,194,252,221,120,237,53,186,103,46,224,93,20,5,172,93,104,91,65,253,102,252,63,144,48,174,100,54,7,241,4,37,188,0,111,1,35,180,207,97,130,21,51,92,23,142,141,150,160,141,71,42,163,227,207,104,231,141,145,7,155,36,251,157,232,58,36,46,141,214,110,116,211,197,182,17,21,248,90,120,230,81,90,114,95,14,206,53,250,26,9,90,134,199,118,152,35,154,66,5,46,72,137,206,149,161,105,250,252,194,57,55,149,29,173,109,96,63,212,65,210,205,42,244,177,245,236,103,185,184,235,99,199,229,162,194,209,138,3,43,101,32,86,84,129,162,133,209,202,29,77,231,83,209,196,241,167,10,255,201,190,18,166,150,135,156,161,36,219,66,35,56,137,187,90,233,166,19,36,90,48,252,86,94,86,229,24,250,106,19,207,107,138,117,145,42,47,192,27,240,160,187,218,12,243,2,107,120,230,231,90,203,122,120,1,115,178,152,74,140,1,213,21,237,201,106,5,60,232,135,105,248,48,25,122,130,145,117,16,121,140,51,224,44,82,28,243,245,11,8,54,179,76,243,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c20ea6f3-be52-42d0-824d-0e9ad343f8f2"));
		}

		#endregion

	}

	#endregion

}

