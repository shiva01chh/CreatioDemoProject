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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,117,145,79,107,195,48,12,197,207,13,228,59,136,158,182,75,124,223,188,28,86,202,200,117,13,187,187,142,82,12,254,19,36,123,16,70,191,251,236,182,41,35,101,190,89,122,191,39,61,228,149,67,158,148,70,232,145,72,113,24,99,179,11,126,52,167,68,42,154,224,235,234,167,174,54,137,141,63,193,97,230,136,46,247,173,69,93,154,220,124,160,71,50,250,181,174,178,74,8,1,146,147,115,138,230,246,246,127,79,198,14,72,48,6,2,158,80,155,209,104,248,86,214,12,23,123,160,100,177,89,88,177,130,101,156,39,156,20,41,7,62,47,250,182,237,183,237,225,106,130,3,184,48,160,149,226,174,41,212,148,142,54,15,48,62,34,141,37,86,119,211,235,175,235,204,64,183,141,100,223,194,11,116,235,114,246,40,129,31,178,92,10,59,66,21,241,223,28,96,13,199,230,78,139,53,46,9,99,34,207,75,134,7,3,150,98,145,20,166,219,251,228,144,212,209,162,92,231,200,200,103,38,114,138,22,58,111,226,210,46,69,126,122,206,7,217,156,235,234,92,238,242,247,253,2,199,248,163,36,240,1,0,0 };
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

