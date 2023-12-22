namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IValidatorBuilderSchema

	/// <exclude/>
	public class IValidatorBuilderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IValidatorBuilderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IValidatorBuilderSchema(IValidatorBuilderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("69b4bd13-570c-4f3c-b839-d638ec3973a5");
			Name = "IValidatorBuilder";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("c92d8fca-4a0d-4385-86d2-4f5717aa816e");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,101,144,193,78,195,48,12,134,207,171,212,119,240,17,46,205,3,80,245,192,132,80,175,3,237,238,118,238,100,41,113,38,59,65,154,208,222,157,100,108,48,88,78,73,254,239,179,45,131,96,32,59,224,76,240,78,170,104,113,73,221,58,202,194,251,172,152,56,74,219,124,182,205,42,27,203,30,222,142,150,40,148,220,123,154,107,104,221,43,9,41,207,79,109,83,40,231,28,244,150,67,64,61,14,151,247,115,102,191,35,133,37,42,76,104,4,31,232,121,119,46,13,154,61,117,87,207,221,136,135,60,121,158,129,37,145,46,117,184,113,251,109,69,189,212,43,80,157,235,174,229,249,99,173,132,233,174,19,120,182,212,253,72,238,191,213,43,165,172,98,195,246,175,103,189,187,38,21,29,95,36,7,82,156,60,245,227,47,186,41,228,0,163,112,170,55,123,120,44,43,89,157,218,230,84,55,115,123,190,0,180,182,71,120,115,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("69b4bd13-570c-4f3c-b839-d638ec3973a5"));
		}

		#endregion

	}

	#endregion

}

