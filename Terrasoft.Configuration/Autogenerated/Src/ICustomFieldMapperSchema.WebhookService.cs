namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ICustomFieldMapperSchema

	/// <exclude/>
	public class ICustomFieldMapperSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ICustomFieldMapperSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ICustomFieldMapperSchema(ICustomFieldMapperSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("dec5d6ef-4d67-4ef9-831c-8d603fb196b8");
			Name = "ICustomFieldMapper";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("fe674b36-6b4e-4761-be68-f76112863a49");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,144,65,107,194,64,16,133,207,9,228,63,204,47,72,238,90,188,136,21,15,138,208,66,207,107,156,141,139,217,157,48,51,219,34,226,127,239,102,107,37,80,168,3,115,152,229,125,239,61,54,24,143,50,152,22,225,29,153,141,144,213,122,73,193,186,46,178,81,71,161,42,175,85,89,52,77,3,47,18,189,55,124,89,220,239,61,211,167,59,162,64,79,157,107,129,44,120,51,12,46,116,208,70,81,242,240,133,135,19,209,25,172,195,254,40,245,175,77,51,241,25,226,161,79,172,11,138,108,199,22,155,101,102,95,71,100,155,236,144,97,6,155,201,153,160,177,208,159,70,249,97,141,42,160,39,124,68,11,69,110,177,126,0,211,236,66,148,199,182,31,63,218,183,44,133,43,116,168,115,184,85,229,243,20,12,234,244,2,33,253,225,255,17,171,44,220,37,221,196,191,72,155,99,210,124,3,92,17,247,38,135,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("dec5d6ef-4d67-4ef9-831c-8d603fb196b8"));
		}

		#endregion

	}

	#endregion

}

