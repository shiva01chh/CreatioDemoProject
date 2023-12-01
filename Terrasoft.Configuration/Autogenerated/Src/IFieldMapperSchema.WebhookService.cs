namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IFieldMapperSchema

	/// <exclude/>
	public class IFieldMapperSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IFieldMapperSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IFieldMapperSchema(IFieldMapperSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("9dfbf4d8-9185-4168-9736-2f2d7062756a");
			Name = "IFieldMapper";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("fe674b36-6b4e-4761-be68-f76112863a49");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,109,81,205,74,195,64,16,62,27,200,59,12,61,41,72,242,0,198,92,164,74,65,65,176,224,121,147,76,210,197,253,9,51,187,149,82,250,238,206,38,21,162,237,158,102,103,190,191,157,117,202,34,143,170,69,216,34,145,98,223,135,226,201,187,94,15,145,84,208,222,229,217,49,207,110,34,107,55,192,199,129,3,90,153,27,131,109,26,114,241,130,14,73,183,15,121,38,168,178,44,161,226,104,173,162,67,125,190,191,147,223,235,14,25,140,31,116,11,190,7,171,198,49,169,73,249,141,205,206,251,47,232,53,154,142,139,95,137,114,161,49,198,198,8,79,187,128,212,167,156,155,231,4,126,19,17,36,153,31,39,231,11,235,169,33,32,134,176,195,133,254,165,193,220,25,21,41,11,78,182,241,184,58,167,154,124,120,85,111,69,224,95,208,170,156,240,215,233,233,125,216,45,217,115,231,26,121,239,117,151,98,206,232,219,205,218,69,139,164,26,131,21,7,146,45,213,240,39,205,61,188,106,14,213,231,220,147,143,136,214,9,189,134,165,233,221,252,27,167,60,59,165,66,206,15,112,40,88,183,230,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("9dfbf4d8-9185-4168-9736-2f2d7062756a"));
		}

		#endregion

	}

	#endregion

}

