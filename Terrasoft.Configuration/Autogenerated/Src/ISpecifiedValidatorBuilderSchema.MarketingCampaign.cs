namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ISpecifiedValidatorBuilderSchema

	/// <exclude/>
	public class ISpecifiedValidatorBuilderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ISpecifiedValidatorBuilderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ISpecifiedValidatorBuilderSchema(ISpecifiedValidatorBuilderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("bc9cc121-d353-4d3a-b160-b3888156283d");
			Name = "ISpecifiedValidatorBuilder";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("c92d8fca-4a0d-4385-86d2-4f5717aa816e");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,117,145,79,107,195,48,12,197,207,13,228,59,136,158,182,75,124,223,188,28,86,198,200,117,13,187,187,142,82,12,254,19,36,123,16,70,191,251,236,54,233,33,101,190,89,122,191,39,61,228,149,67,158,148,70,232,145,72,113,24,99,115,8,126,52,231,68,42,154,224,235,234,183,174,118,137,141,63,195,113,230,136,46,247,173,69,93,154,220,124,162,71,50,250,181,174,178,74,8,1,146,147,115,138,230,118,249,191,39,99,7,36,24,3,1,79,168,205,104,52,252,40,107,134,171,61,80,178,216,172,172,216,192,50,206,19,78,138,148,3,159,23,125,219,247,251,246,120,51,193,1,92,24,208,74,113,215,20,106,74,39,155,7,24,31,145,198,18,171,91,244,250,251,54,51,208,178,145,236,91,120,129,110,91,206,30,37,240,67,150,107,225,64,168,34,254,155,3,172,225,216,220,105,177,197,37,97,76,228,121,205,240,96,192,82,172,146,194,116,31,62,57,36,117,178,40,183,57,50,242,149,137,156,162,133,206,155,184,182,75,145,159,158,243,65,118,151,186,186,148,187,228,247,7,57,149,48,13,231,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("bc9cc121-d353-4d3a-b160-b3888156283d"));
		}

		#endregion

	}

	#endregion

}

