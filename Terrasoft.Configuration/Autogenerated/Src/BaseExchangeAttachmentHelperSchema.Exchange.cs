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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,221,85,77,107,219,64,16,61,55,144,255,48,36,23,23,140,116,79,82,67,236,152,84,80,67,192,13,61,132,30,70,171,177,188,176,187,18,187,163,80,81,250,223,187,43,37,146,28,7,163,130,122,137,46,163,157,143,183,239,205,12,18,24,212,228,74,20,4,223,201,90,116,197,142,163,85,97,118,50,175,44,178,44,204,249,217,239,243,179,79,149,147,38,135,109,237,152,180,143,43,69,34,4,93,116,79,134,172,20,215,93,206,70,10,91,52,48,235,95,98,143,38,167,232,7,165,91,178,207,82,144,139,238,144,177,79,30,222,105,201,251,125,228,210,82,238,161,97,165,208,185,43,88,162,163,87,164,91,102,20,123,77,134,191,146,42,201,54,249,113,28,195,141,171,180,70,91,47,186,51,17,8,75,187,47,23,201,113,241,35,75,37,89,146,187,136,23,32,117,169,40,120,27,181,209,43,64,60,64,44,171,84,73,1,152,58,182,40,24,68,96,118,146,24,92,193,169,123,61,102,104,106,39,117,67,188,47,50,47,246,161,189,169,209,117,36,236,95,148,69,43,75,200,29,191,151,246,123,189,29,206,80,224,145,194,55,117,240,46,218,236,209,145,245,187,98,218,93,128,234,224,56,7,143,21,102,28,220,107,141,82,221,102,153,37,231,62,95,79,32,111,139,59,90,74,147,37,126,31,199,171,10,44,54,158,2,230,4,67,132,217,91,189,174,181,115,8,209,36,3,217,152,57,60,216,194,79,151,235,45,49,148,237,187,103,243,241,20,205,97,220,108,29,153,236,101,186,147,52,225,158,184,119,187,209,109,72,214,166,210,100,49,85,116,211,215,47,224,16,110,118,208,45,221,218,255,64,123,89,39,217,196,212,3,228,187,244,187,73,96,151,156,100,147,104,250,86,224,120,21,207,133,204,32,84,204,122,168,1,165,169,154,236,55,144,189,111,52,173,180,102,122,250,9,125,229,105,122,151,126,155,219,47,178,63,253,105,127,70,3,151,247,12,159,191,98,160,54,169,59,7,0,0 };
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

