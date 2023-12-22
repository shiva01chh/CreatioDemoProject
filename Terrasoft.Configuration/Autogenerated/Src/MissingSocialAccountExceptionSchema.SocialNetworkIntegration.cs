namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MissingSocialAccountExceptionSchema

	/// <exclude/>
	public class MissingSocialAccountExceptionSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MissingSocialAccountExceptionSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MissingSocialAccountExceptionSchema(MissingSocialAccountExceptionSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("4f684624-c132-4775-9271-2d2847917daa");
			Name = "MissingSocialAccountException";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("4e5fe717-963e-416c-b3c1-b2bb720a6449");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,141,49,10,195,48,12,69,103,27,124,7,65,247,28,32,157,74,232,216,41,189,128,170,42,193,224,216,198,178,33,165,244,238,181,235,37,83,5,26,244,121,95,207,227,198,18,145,24,238,156,18,74,88,242,48,5,191,216,181,36,204,54,248,97,14,100,209,25,253,54,90,21,177,126,133,249,37,153,183,179,209,53,57,37,94,43,5,147,67,145,17,110,86,26,210,59,23,162,80,124,190,238,196,177,189,250,21,98,121,56,75,64,141,255,143,195,8,135,170,106,126,85,247,211,189,236,159,93,221,206,154,29,231,11,68,158,86,247,213,0,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("4f684624-c132-4775-9271-2d2847917daa"));
		}

		#endregion

	}

	#endregion

}

