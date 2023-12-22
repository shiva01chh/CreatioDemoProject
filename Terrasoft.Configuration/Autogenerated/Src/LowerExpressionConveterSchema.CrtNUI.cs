namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: LowerExpressionConveterSchema

	/// <exclude/>
	public class LowerExpressionConveterSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public LowerExpressionConveterSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public LowerExpressionConveterSchema(LowerExpressionConveterSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("85ba78c6-496b-4aee-a5ba-e9335cf632be");
			Name = "LowerExpressionConveter";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("14a29563-3c13-443c-a7aa-8d0c90d831c2");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,117,79,61,11,194,80,12,156,45,244,63,132,78,10,242,192,73,212,81,221,4,7,221,196,225,181,166,245,65,251,94,73,242,252,64,253,239,166,186,56,212,112,203,229,46,119,196,219,6,185,181,5,194,30,137,44,135,82,204,50,248,210,85,145,172,184,224,211,228,145,38,131,200,206,87,176,187,179,96,179,80,174,56,108,115,14,53,10,14,179,169,153,153,9,60,97,21,192,7,129,200,8,114,118,12,69,109,153,199,224,188,158,217,211,103,255,167,197,108,194,21,105,125,107,9,153,149,171,120,65,18,164,108,116,212,174,54,230,181,43,190,121,208,103,85,39,204,123,149,46,4,52,162,251,226,149,38,138,223,121,3,229,114,162,140,255,0,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("85ba78c6-496b-4aee-a5ba-e9335cf632be"));
		}

		#endregion

	}

	#endregion

}

