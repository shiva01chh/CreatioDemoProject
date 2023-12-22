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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,141,61,10,195,48,12,70,103,27,124,7,65,247,28,32,29,67,167,210,41,189,128,234,42,65,224,63,44,27,26,74,239,94,187,89,50,85,160,65,31,79,223,11,232,73,18,90,130,59,229,140,18,151,50,76,49,44,188,214,140,133,99,24,230,104,25,157,209,111,163,85,21,14,43,204,155,20,242,103,163,91,114,202,180,54,10,38,135,34,35,220,88,58,210,26,164,122,202,87,218,46,47,75,169,23,253,240,84,31,142,45,216,78,255,131,97,132,195,163,234,110,213,246,179,59,41,60,119,109,63,91,118,156,47,213,191,145,144,209,0,0,0 };
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

