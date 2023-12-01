namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IMailingAudienceDataSourceFactorySchema

	/// <exclude/>
	public class IMailingAudienceDataSourceFactorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IMailingAudienceDataSourceFactorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IMailingAudienceDataSourceFactorySchema(IMailingAudienceDataSourceFactorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("b546faf9-3ac8-4a7c-a169-bbd0f8b47719");
			Name = "IMailingAudienceDataSourceFactory";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("137c1838-0170-451f-b0dc-9c1d36ce6de8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,237,84,77,111,219,48,12,61,175,64,255,3,225,29,214,2,133,141,97,135,2,109,106,160,200,62,224,67,183,2,105,177,195,176,131,98,209,142,0,91,242,36,170,93,86,236,191,151,150,29,47,105,154,46,29,182,245,82,159,76,137,124,228,123,164,168,69,141,174,17,57,194,5,90,43,156,41,40,30,27,93,168,210,91,65,202,232,221,157,155,221,157,23,222,41,93,194,100,238,8,235,227,193,30,27,139,108,177,253,210,98,201,206,144,105,66,91,48,220,17,100,103,66,85,236,117,234,165,66,157,227,91,65,98,98,188,205,241,189,200,201,216,121,8,76,146,4,70,206,215,181,176,243,180,183,207,173,185,82,18,29,212,72,51,35,129,12,228,22,5,33,40,237,72,48,150,3,83,112,24,98,123,81,156,68,155,115,69,73,26,47,210,36,75,121,190,124,154,58,83,33,225,94,244,89,85,21,76,17,44,214,230,10,37,136,130,57,192,97,252,250,48,126,19,237,127,101,231,198,79,43,149,115,246,158,220,239,185,1,71,221,4,130,131,52,103,129,140,59,130,243,128,214,93,222,165,191,202,255,87,194,53,37,52,94,15,106,60,86,140,117,53,186,147,70,88,81,131,230,137,56,137,188,67,203,115,160,49,111,135,32,74,47,217,126,229,32,31,142,226,81,18,252,239,15,231,161,114,162,196,76,70,233,197,12,193,107,245,205,115,251,36,106,82,133,98,121,185,100,226,139,186,43,245,97,176,169,160,124,54,81,63,176,3,115,252,215,198,55,156,160,85,132,5,145,235,0,22,201,91,237,210,143,127,42,212,40,89,64,180,152,155,125,97,28,58,146,245,57,246,46,87,148,131,85,33,15,224,131,87,18,6,121,14,218,30,195,64,112,255,184,159,25,212,178,27,155,96,255,236,222,216,234,225,22,79,110,194,105,216,5,229,211,189,61,232,113,223,125,39,46,223,133,166,111,21,220,23,202,24,112,173,104,22,2,93,199,39,147,224,124,211,24,75,255,225,105,111,214,16,182,218,113,207,107,96,139,53,64,86,149,37,155,253,58,88,52,250,31,172,133,101,128,97,156,58,128,59,201,151,202,124,250,237,50,76,225,95,89,51,253,245,192,255,17,107,135,207,248,187,5,6,11,224,65,54,8,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b546faf9-3ac8-4a7c-a169-bbd0f8b47719"));
		}

		#endregion

	}

	#endregion

}

