namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BaseExchangeAttachmentHelperSchema

	/// <exclude/>
	public class BaseExchangeAttachmentHelperSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BaseExchangeAttachmentHelperSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BaseExchangeAttachmentHelperSchema(BaseExchangeAttachmentHelperSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("9e525563-4bdb-4dfc-a6eb-a86a1fe5e500");
			Name = "BaseExchangeAttachmentHelper";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("77ff850a-3558-415d-9b34-1a36190e74f6");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,221,85,77,107,219,64,16,61,55,144,255,48,36,23,23,140,116,79,82,67,236,152,84,80,67,192,13,61,132,30,70,171,177,188,176,187,18,187,171,80,81,250,223,59,43,37,146,28,7,163,130,122,137,46,163,157,143,183,239,205,12,18,24,212,228,74,20,4,223,201,90,116,197,206,71,171,194,236,100,94,89,244,178,48,231,103,191,207,207,62,85,78,154,28,182,181,243,164,57,174,20,137,16,116,209,61,25,178,82,92,119,57,27,41,108,209,192,172,127,137,61,154,156,162,31,148,110,201,62,75,65,46,186,67,143,125,242,240,78,75,236,231,200,165,165,156,161,97,165,208,185,43,88,162,163,87,164,91,239,81,236,53,25,255,149,84,73,182,201,143,227,24,110,92,165,53,218,122,209,157,137,64,88,218,125,185,72,142,139,31,189,84,210,75,114,23,241,2,164,46,21,5,111,163,54,122,5,136,7,136,101,149,42,41,0,83,231,45,10,15,34,48,59,73,12,174,224,212,189,140,25,154,218,73,221,144,223,23,25,139,125,104,111,106,116,29,9,251,23,101,209,202,18,250,142,223,75,251,89,111,135,51,20,120,164,240,77,29,188,139,54,123,116,100,121,87,76,187,11,80,29,28,231,192,88,97,198,193,189,214,40,213,109,150,89,114,238,243,245,4,242,182,184,163,165,52,89,194,251,56,94,85,96,177,97,10,152,19,12,17,102,111,245,186,214,206,33,68,147,12,100,99,230,240,96,11,158,174,175,183,228,161,108,223,153,205,199,83,52,135,113,179,117,100,178,151,233,78,210,132,123,242,189,219,141,110,67,178,54,149,38,139,169,162,155,190,126,1,135,112,179,131,110,233,214,254,7,218,203,58,201,38,166,30,32,223,165,223,77,2,187,228,36,155,68,211,183,2,199,171,120,46,100,6,161,98,214,67,13,40,77,213,100,222,64,207,190,209,180,210,218,211,211,79,232,43,79,211,187,228,109,110,191,200,124,250,211,254,140,6,46,246,240,243,23,248,132,13,239,50,7,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("9e525563-4bdb-4dfc-a6eb-a86a1fe5e500"));
		}

		#endregion

	}

	#endregion

}

