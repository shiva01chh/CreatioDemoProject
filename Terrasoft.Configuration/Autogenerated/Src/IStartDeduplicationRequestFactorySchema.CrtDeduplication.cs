namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IStartDeduplicationRequestFactorySchema

	/// <exclude/>
	public class IStartDeduplicationRequestFactorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IStartDeduplicationRequestFactorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IStartDeduplicationRequestFactorySchema(IStartDeduplicationRequestFactorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("317ae3ca-74ff-401a-9e48-5d31d65af269");
			Name = "IStartDeduplicationRequestFactory";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("4c53ad23-c903-414d-89cd-b08703861304");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,146,77,75,195,64,16,134,207,13,228,63,12,245,162,32,201,93,107,65,171,66,46,34,173,224,121,155,157,212,165,201,110,156,157,21,139,248,223,221,143,182,182,180,69,115,202,59,51,239,187,207,126,104,209,161,237,69,141,240,130,68,194,154,134,139,137,209,141,90,56,18,172,140,46,238,81,186,190,85,117,84,121,246,149,103,3,103,149,94,192,94,227,161,21,150,85,93,188,226,252,182,87,33,130,73,212,108,139,41,190,59,180,108,175,243,204,59,207,8,23,126,26,42,205,72,141,95,246,10,170,59,215,46,247,178,166,174,197,71,111,54,180,138,166,178,44,97,100,93,215,9,90,141,215,250,153,204,135,146,104,161,67,126,51,18,26,67,48,119,170,149,129,204,178,32,246,178,93,130,220,13,6,74,48,197,38,180,220,73,237,221,220,207,129,218,144,65,53,11,49,251,100,201,191,133,27,132,211,56,224,139,133,9,161,96,207,247,31,150,67,152,84,233,5,137,14,180,191,162,155,161,197,58,216,158,188,24,142,103,73,196,86,49,42,227,220,113,155,210,18,63,147,169,10,191,39,44,132,236,72,219,241,236,47,218,81,185,25,13,222,147,39,180,222,254,201,254,185,101,138,55,245,187,171,75,88,215,182,200,23,254,205,12,190,211,187,65,45,211,211,9,50,214,118,191,31,49,212,191,218,198,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("317ae3ca-74ff-401a-9e48-5d31d65af269"));
		}

		#endregion

	}

	#endregion

}

