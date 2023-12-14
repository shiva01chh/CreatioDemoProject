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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,101,144,207,106,195,48,12,135,207,13,228,29,116,220,46,241,3,44,228,176,50,70,174,91,233,93,73,149,34,176,229,34,217,133,50,250,238,179,187,118,255,234,147,237,223,247,73,66,32,24,200,14,56,19,108,72,21,45,46,169,91,71,89,120,159,21,19,71,105,155,143,182,89,101,99,217,195,251,201,18,133,146,123,79,115,13,173,123,37,33,229,249,169,109,10,229,156,131,222,114,8,168,167,225,250,126,206,236,119,164,176,68,133,9,141,224,136,158,119,151,210,160,217,83,119,243,220,47,241,144,39,207,51,176,36,210,165,14,55,110,191,172,168,215,122,5,170,115,221,181,188,124,172,149,48,221,117,2,207,150,186,111,201,253,183,122,165,148,85,108,216,254,245,172,119,183,164,162,227,139,228,64,138,147,167,126,252,65,223,10,57,192,40,156,234,205,30,30,203,74,86,231,182,57,215,205,212,243,9,192,231,22,23,107,1,0,0 };
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

