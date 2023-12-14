namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: INotificationStoreSchema

	/// <exclude/>
	public class INotificationStoreSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public INotificationStoreSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public INotificationStoreSchema(INotificationStoreSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("5ee4e1be-170c-44d3-92be-47cd9f1c5368");
			Name = "INotificationStore";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,101,80,205,106,195,48,12,62,47,144,119,208,113,187,196,15,208,144,203,24,37,151,50,214,189,128,235,202,157,33,145,131,36,15,74,233,187,215,78,151,46,108,6,131,229,239,23,145,29,81,38,235,16,62,145,217,74,244,218,188,70,242,225,148,216,106,136,84,87,151,186,122,74,18,232,4,251,179,40,142,25,31,6,116,5,148,102,139,132,28,220,166,174,50,203,24,3,173,164,113,180,124,238,126,230,158,20,217,151,0,31,25,172,115,40,2,71,171,22,162,7,253,66,160,168,193,7,55,135,193,196,241,59,28,145,165,89,236,204,202,111,74,135,33,56,8,15,203,126,183,18,239,53,50,102,214,101,238,242,175,204,252,241,129,154,152,228,55,7,40,47,160,121,240,205,95,65,203,119,69,215,154,229,85,160,254,141,210,136,108,15,3,182,162,156,151,211,193,22,117,93,231,125,137,216,229,132,231,151,77,145,229,123,173,171,107,41,88,206,13,18,97,167,12,125,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5ee4e1be-170c-44d3-92be-47cd9f1c5368"));
		}

		#endregion

	}

	#endregion

}

