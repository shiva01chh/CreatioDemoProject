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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,82,205,106,195,48,12,62,167,208,119,16,61,109,48,146,7,88,215,203,182,142,29,122,106,97,103,213,81,18,67,98,7,217,110,41,99,239,62,217,73,186,150,82,102,140,73,140,190,31,125,178,193,142,92,143,138,96,71,204,232,108,229,243,87,107,42,93,7,70,175,173,201,63,200,144,124,82,249,69,251,181,229,110,75,124,208,138,230,179,239,249,44,11,78,155,250,10,202,148,191,27,175,189,38,247,44,5,178,139,162,128,165,11,93,135,124,90,141,255,59,70,227,42,97,115,16,79,40,209,35,120,11,20,161,167,28,38,88,113,129,235,195,190,213,10,180,241,196,85,116,252,25,237,188,9,114,103,147,228,105,131,125,79,44,165,209,218,141,110,186,88,183,88,131,111,208,11,79,169,149,244,229,224,216,144,111,136,161,19,120,108,71,56,162,41,42,193,5,165,200,185,42,180,237,41,63,115,94,154,202,246,214,182,176,29,234,32,233,102,53,249,216,122,246,51,159,221,245,177,145,114,172,105,180,226,192,42,21,88,20,203,192,209,194,104,229,142,166,243,169,104,226,248,83,133,255,100,95,153,82,203,67,206,80,177,237,160,69,73,226,174,86,186,233,145,177,3,35,111,229,101,81,141,161,47,86,241,188,166,88,22,169,242,12,188,1,15,186,139,213,48,47,176,70,102,126,108,180,106,134,23,112,73,22,83,137,49,80,121,69,123,176,186,4,25,244,195,52,124,152,12,61,193,200,58,136,60,198,25,72,22,41,14,89,191,140,144,212,140,234,2,0,0 };
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

