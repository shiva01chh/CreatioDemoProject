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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,117,79,61,11,194,80,12,156,45,244,63,132,78,10,242,192,73,212,209,186,9,14,186,137,195,107,77,235,131,246,165,36,239,249,129,250,223,77,117,173,225,150,203,93,238,136,183,45,74,103,75,132,3,50,91,161,42,152,53,249,202,213,145,109,112,228,211,228,153,38,163,40,206,215,176,127,72,192,118,165,92,113,220,21,66,13,6,28,103,115,179,48,51,120,65,78,224,41,64,20,132,112,113,2,101,99,69,166,224,188,158,217,243,119,255,167,197,108,233,134,188,185,119,140,34,202,85,188,34,7,228,108,114,210,174,46,22,141,43,127,121,48,100,85,39,44,7,149,62,4,52,162,255,226,157,38,138,126,62,160,203,253,15,247,0,0,0 };
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

