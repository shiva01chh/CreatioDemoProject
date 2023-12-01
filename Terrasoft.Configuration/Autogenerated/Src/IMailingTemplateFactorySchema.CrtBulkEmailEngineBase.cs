namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IMailingTemplateFactorySchema

	/// <exclude/>
	public class IMailingTemplateFactorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IMailingTemplateFactorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IMailingTemplateFactorySchema(IMailingTemplateFactorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("097b8032-3d21-4484-aa49-cf8ba99707c8");
			Name = "IMailingTemplateFactory";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("5d774dd3-3f0d-4e5d-9409-9a3b17d3417e");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,145,193,106,195,48,12,134,207,13,228,29,68,119,217,46,245,189,235,114,41,20,114,40,148,209,23,240,28,57,53,196,114,144,157,65,25,123,247,57,182,59,182,140,193,230,139,209,47,249,215,247,99,146,22,253,40,21,194,25,153,165,119,58,108,246,142,180,233,39,150,193,56,170,171,183,186,170,171,213,29,99,31,75,104,41,32,235,248,96,11,237,81,154,193,80,127,70,59,14,50,224,65,170,224,248,154,198,133,16,176,243,147,181,146,175,77,169,79,236,94,77,135,30,44,134,139,235,60,104,199,160,24,227,30,234,193,144,15,146,148,137,125,167,33,92,48,190,71,156,251,250,105,189,92,181,22,205,230,182,69,124,89,51,78,47,131,81,209,171,64,254,206,184,202,177,62,115,29,51,211,22,78,201,34,55,151,41,146,176,159,137,35,101,1,198,191,227,254,228,205,10,99,152,152,124,243,156,239,255,58,239,196,205,96,118,92,78,20,222,182,120,222,63,60,150,224,72,93,206,158,234,247,252,203,223,196,164,197,243,1,91,68,137,90,37,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("097b8032-3d21-4484-aa49-cf8ba99707c8"));
		}

		#endregion

	}

	#endregion

}

