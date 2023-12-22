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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,144,65,107,195,48,12,133,207,9,228,63,232,23,36,247,109,236,82,186,209,67,203,96,131,158,221,84,78,205,98,43,72,242,74,41,251,239,115,188,182,24,10,155,64,7,153,247,189,247,112,48,30,101,50,61,194,7,50,27,33,171,237,130,130,117,67,100,163,142,66,83,159,155,186,234,186,14,158,36,122,111,248,244,124,185,223,152,190,220,30,5,70,26,92,15,100,193,155,105,114,97,128,62,138,146,135,35,238,14,68,159,96,29,142,123,105,175,54,93,225,51,197,221,152,88,23,20,217,206,45,86,139,204,190,204,200,58,217,33,195,3,172,138,51,65,115,161,187,70,249,225,21,85,64,15,120,139,22,138,220,99,123,3,202,236,74,148,231,182,219,95,237,123,150,194,25,6,212,71,248,110,234,255,83,48,168,211,19,132,244,135,127,71,44,179,112,147,116,133,127,149,54,199,148,243,3,252,227,247,129,144,1,0,0 };
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

