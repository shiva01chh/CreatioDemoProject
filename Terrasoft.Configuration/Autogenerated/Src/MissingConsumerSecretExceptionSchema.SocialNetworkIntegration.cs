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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,142,61,10,195,48,12,133,231,24,124,7,65,247,28,32,29,67,199,78,238,5,92,87,49,2,255,33,217,208,82,122,247,218,205,146,173,2,13,122,124,239,61,37,27,81,138,117,8,55,100,182,146,183,58,175,57,109,228,27,219,74,57,205,38,59,178,65,171,183,86,83,19,74,30,204,75,42,198,179,86,93,57,49,250,78,193,26,172,200,2,87,146,129,244,4,105,17,217,160,99,172,151,167,195,50,178,126,142,210,238,129,28,184,97,248,195,195,2,7,239,52,62,152,250,126,246,102,76,143,189,124,156,93,59,206,23,202,121,132,103,215,0,0,0 };
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

