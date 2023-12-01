namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MissingConsumerSecretExceptionSchema

	/// <exclude/>
	public class MissingConsumerSecretExceptionSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MissingConsumerSecretExceptionSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MissingConsumerSecretExceptionSchema(MissingConsumerSecretExceptionSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("0f8b9071-26fc-4a2e-b670-8e728d131210");
			Name = "MissingConsumerSecretException";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("4e5fe717-963e-416c-b3c1-b2bb720a6449");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,142,61,10,195,48,12,133,231,24,124,7,65,247,28,32,29,67,199,78,238,5,92,87,49,2,255,97,217,208,80,122,247,202,205,210,173,2,13,122,124,239,61,37,27,145,139,117,8,55,172,213,114,222,218,188,230,180,145,239,213,54,202,105,54,217,145,13,90,189,180,154,58,83,242,96,118,110,24,207,90,137,114,170,232,133,130,53,88,230,5,174,196,3,145,4,238,17,171,65,87,177,93,158,14,203,200,250,58,74,191,7,114,224,134,225,15,15,11,252,120,167,241,193,36,251,62,154,49,61,142,242,113,138,38,243,1,78,173,129,186,206,0,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("0f8b9071-26fc-4a2e-b670-8e728d131210"));
		}

		#endregion

	}

	#endregion

}

