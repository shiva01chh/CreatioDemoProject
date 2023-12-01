namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ISpecificationTermParametersSchema

	/// <exclude/>
	public class ISpecificationTermParametersSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ISpecificationTermParametersSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ISpecificationTermParametersSchema(ISpecificationTermParametersSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("7a9ce83e-fd98-4d67-b241-16d384aff5e3");
			Name = "ISpecificationTermParameters";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b11d550e-0087-4f53-ae17-fb00d41102cf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,109,78,75,10,194,48,16,93,183,208,59,100,169,155,230,0,150,110,92,136,59,177,189,64,12,19,9,152,52,204,36,130,20,239,238,180,90,105,173,33,132,201,155,247,243,202,1,5,165,65,180,128,168,168,51,177,220,119,222,216,107,66,21,109,231,203,6,240,110,53,240,218,21,121,95,228,153,148,82,84,148,156,83,248,168,63,255,51,4,4,2,31,73,40,65,1,180,53,86,143,122,17,89,40,130,66,14,226,145,202,201,65,206,44,66,186,220,172,22,214,51,195,12,101,142,205,220,99,200,62,125,29,152,223,103,252,172,138,140,192,1,226,191,200,117,230,27,65,136,9,61,213,237,143,164,146,211,102,160,46,11,12,25,75,100,179,221,49,237,89,228,124,249,188,0,89,216,153,57,85,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7a9ce83e-fd98-4d67-b241-16d384aff5e3"));
		}

		#endregion

	}

	#endregion

}

