namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IGeneratedWebFormProcessHandlerSchema

	/// <exclude/>
	public class IGeneratedWebFormProcessHandlerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IGeneratedWebFormProcessHandlerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IGeneratedWebFormProcessHandlerSchema(IGeneratedWebFormProcessHandlerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("fd2443d1-4e8b-456e-8121-999e79c2ef1c");
			Name = "IGeneratedWebFormProcessHandler";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("9d05c8ee-17e3-41aa-adfe-7e36f0a4c27c");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,79,61,11,131,48,16,157,21,252,15,7,238,186,151,210,165,208,143,173,67,161,115,212,23,27,48,23,185,196,130,148,254,247,70,173,224,214,219,222,241,62,89,89,248,94,213,160,59,68,148,119,58,20,71,199,218,180,131,168,96,28,103,233,59,75,147,92,208,70,64,87,14,16,29,233,59,186,158,193,136,28,52,15,84,39,39,246,38,174,134,247,23,197,77,7,201,210,40,43,203,146,246,126,176,86,201,120,248,225,72,123,153,6,158,204,234,69,218,9,245,139,218,112,75,78,83,120,130,106,193,228,78,224,96,194,72,90,156,165,46,154,79,148,94,181,40,214,128,114,147,208,15,85,103,234,141,247,223,154,201,180,239,51,215,205,193,205,50,116,130,243,47,222,23,1,135,104,76,35,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("fd2443d1-4e8b-456e-8121-999e79c2ef1c"));
		}

		#endregion

	}

	#endregion

}

