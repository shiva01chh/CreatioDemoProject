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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,142,61,10,195,48,12,133,231,24,124,7,65,247,28,32,29,67,199,78,238,5,92,87,49,2,255,97,217,208,80,122,247,90,205,210,173,2,13,122,124,239,61,37,27,145,139,117,8,55,172,213,114,222,218,188,230,180,145,239,213,54,202,105,54,217,145,13,90,189,180,154,58,83,242,96,118,110,24,207,90,13,229,84,209,15,10,214,96,153,23,184,18,11,50,18,184,71,172,6,93,197,118,121,58,44,146,245,117,148,126,15,228,192,137,225,15,15,11,252,120,39,249,96,26,251,62,154,49,61,142,114,57,135,38,243,1,169,235,9,163,207,0,0,0 };
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

