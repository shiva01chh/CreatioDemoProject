namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MissingConsumerKeyExceptionSchema

	/// <exclude/>
	public class MissingConsumerKeyExceptionSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MissingConsumerKeyExceptionSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MissingConsumerKeyExceptionSchema(MissingConsumerKeyExceptionSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("430df10a-1542-481b-a502-d52c3facc4ee");
			Name = "MissingConsumerKeyException";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("4e5fe717-963e-416c-b3c1-b2bb720a6449");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,141,61,10,195,48,12,70,103,27,124,7,65,247,28,32,29,67,167,210,41,189,128,234,42,193,224,63,44,27,18,74,239,94,171,89,58,85,160,65,31,79,223,139,24,136,51,90,130,59,149,130,156,150,58,76,41,46,110,109,5,171,75,113,152,147,117,232,141,126,25,173,26,187,184,194,188,115,165,112,54,186,39,167,66,107,167,96,242,200,60,194,205,177,32,189,129,91,160,114,165,253,178,89,202,82,244,197,115,123,120,103,193,10,253,15,134,17,126,30,149,184,85,223,247,225,164,248,60,180,114,246,76,230,3,169,206,105,73,201,0,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("430df10a-1542-481b-a502-d52c3facc4ee"));
		}

		#endregion

	}

	#endregion

}

