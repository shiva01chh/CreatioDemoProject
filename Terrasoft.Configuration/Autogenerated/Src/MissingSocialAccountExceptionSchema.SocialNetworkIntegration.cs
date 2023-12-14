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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,141,65,10,2,49,12,69,215,45,244,14,1,247,115,128,113,37,131,75,87,227,5,106,204,148,66,167,45,77,11,138,120,119,27,187,113,101,32,139,124,222,207,139,118,39,206,22,9,174,84,138,229,180,213,105,73,113,243,174,21,91,125,138,211,154,208,219,96,244,203,104,213,216,71,7,235,147,43,237,71,163,123,114,40,228,58,5,75,176,204,51,92,60,11,50,58,39,196,212,98,61,63,144,178,188,250,22,114,187,5,143,128,194,255,199,97,134,159,170,18,191,234,251,30,94,138,247,161,150,179,103,50,31,175,173,225,137,205,0,0,0 };
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

