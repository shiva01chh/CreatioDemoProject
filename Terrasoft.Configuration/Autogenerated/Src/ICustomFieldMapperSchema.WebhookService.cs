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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,144,65,107,195,48,12,133,207,9,228,63,232,23,36,247,109,236,82,186,209,67,203,96,131,158,221,84,78,205,98,43,72,242,74,41,251,239,179,189,182,4,10,155,64,7,153,247,189,247,112,48,30,101,50,61,194,7,50,27,33,171,237,130,130,117,67,100,163,142,66,83,159,155,186,234,186,14,158,36,122,111,248,244,124,185,223,152,190,220,30,5,70,26,92,15,100,193,155,105,114,97,128,62,138,146,135,35,238,14,68,159,96,29,142,123,105,175,54,221,204,103,138,187,49,177,46,40,178,205,45,86,139,194,190,100,100,157,236,144,225,1,86,179,51,65,185,208,93,163,242,240,138,42,160,7,188,69,11,69,238,177,189,1,243,236,74,148,115,219,237,175,246,189,72,225,12,3,234,35,124,55,245,255,41,24,212,233,9,66,250,195,191,35,150,69,184,73,186,153,127,149,182,196,228,249,1,93,236,44,80,136,1,0,0 };
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

