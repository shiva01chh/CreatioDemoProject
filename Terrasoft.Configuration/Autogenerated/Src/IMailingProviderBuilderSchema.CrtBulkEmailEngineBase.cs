namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IMailingProviderBuilderSchema

	/// <exclude/>
	public class IMailingProviderBuilderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IMailingProviderBuilderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IMailingProviderBuilderSchema(IMailingProviderBuilderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e532d399-1bce-b93c-0a06-a33618381eb2");
			Name = "IMailingProviderBuilder";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b2bd3720-4060-46c2-b144-452847d3660b");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,203,75,204,77,45,46,72,76,78,85,8,73,45,42,74,44,206,79,43,209,115,206,207,75,203,76,47,45,74,44,201,204,207,227,229,170,230,229,226,229,82,0,2,229,162,212,116,160,136,130,103,94,73,106,81,26,80,143,149,130,167,111,98,102,78,102,94,122,64,81,126,89,102,74,106,17,68,43,72,3,103,65,105,82,78,102,178,66,38,76,49,134,90,167,210,204,28,32,5,84,10,180,129,147,19,93,90,1,44,175,161,105,13,148,172,133,59,33,53,47,5,226,10,144,8,88,24,25,0,0,140,244,62,102,206,0,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e532d399-1bce-b93c-0a06-a33618381eb2"));
		}

		#endregion

	}

	#endregion

}

