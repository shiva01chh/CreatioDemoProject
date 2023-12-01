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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,141,65,10,2,49,12,69,215,45,244,14,1,247,115,128,113,37,131,75,87,227,5,106,204,148,66,39,45,77,11,138,120,119,91,187,113,101,32,139,124,222,207,99,187,147,36,139,4,87,202,217,74,220,202,180,68,222,188,171,217,22,31,121,90,35,122,27,140,126,25,173,170,120,118,176,62,165,208,126,52,186,37,135,76,174,81,176,4,43,50,195,197,75,71,70,231,132,24,43,151,243,3,41,245,87,223,66,170,183,224,17,176,243,255,113,152,225,167,170,186,95,181,125,15,47,241,125,168,251,217,178,54,31,181,63,236,61,204,0,0,0 };
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

