namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: UpperExpressionConveterSchema

	/// <exclude/>
	public class UpperExpressionConveterSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public UpperExpressionConveterSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public UpperExpressionConveterSchema(UpperExpressionConveterSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("27fcf242-4fd9-4cab-8a03-9f96704724a7");
			Name = "UpperExpressionConveter";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("14a29563-3c13-443c-a7aa-8d0c90d831c2");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,117,79,177,10,194,64,12,157,45,244,31,66,39,5,57,112,18,117,84,103,7,117,18,135,107,77,245,160,189,59,146,156,40,234,191,155,234,226,80,195,91,94,222,203,123,196,219,22,57,218,10,97,135,68,150,67,45,102,25,124,237,206,137,172,184,224,243,236,145,103,131,196,206,159,97,123,103,193,118,161,92,113,216,148,28,26,20,28,22,83,51,51,19,120,194,42,128,15,2,137,17,228,226,24,170,198,50,143,193,121,61,179,167,207,254,79,139,217,199,136,180,190,69,66,102,229,42,94,145,4,169,24,29,181,43,166,178,113,213,55,15,250,172,234,132,121,175,210,133,128,70,116,95,188,242,76,241,51,111,213,178,0,81,254,0,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("27fcf242-4fd9-4cab-8a03-9f96704724a7"));
		}

		#endregion

	}

	#endregion

}

